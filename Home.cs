using Microsoft.Data.SqlClient;
using System.Data;
using TuikProject.Models;
using Excel = Microsoft.Office.Interop.Excel;

namespace TuikProject
{
    public partial class Home : Form
    {
        ContextDb context = new ContextDb();
        SqlDataAdapter adapter;
        DataTable dataTable;
        public Home()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            connection.Show();
        }

        private void tuikParametreleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TuikWebSite tuikWeb = new TuikWebSite();
            tuikWeb.Show();
        }

        void ClearTuikReport()
        {
            var tuikReports = context.TuikReports.ToList();
            foreach (var item in tuikReports)
            {
                item.Count = 0;
                item.Amount = 0;
                context.TuikReports.Update(item);
                context.SaveChanges();
            }

            var tuikReportDetails = context.TuikReportDetails.ToList();
            foreach (var item in tuikReportDetails)
            {
                context.TuikReportDetails.Remove(item);
                context.SaveChanges();
            }
        }

        void GetListProducts()
        {
            var result = context.Connections.FirstOrDefault();
            SqlConnection con = new SqlConnection("server='" + result.Server + "';database='" + result.Db + "' + UserId='" + result.UserId + "' + password='" + result.Password + "'; Integrated Security=false");
            string SqlText = "SET DATEFORMAT DMY" +
                             " SELECT " +
                             " SH.SUBE_KODU,SH.STOK_KODU,ST.STOK_ADI,SUM(SH.STHAR_GCMIK) as ADET,SUM(SH.STHAR_GCMIK*SH.STHAR_NF) as TOPLAM" +
                             " FROM TBLSTHAR SH LEFT JOIN TBLSTSABIT ST ON SH.STOK_KODU=ST.STOK_KODU" +
                             " WHERE 1=1 AND SH.STHAR_FTIRSIP ='1'" +
                             //" AND SH.SUBE_KODU IN (SELECT SB.SUBE_KODU FROM TBLSUBELER SB WHERE SB.ISLETME_KODU='" & Sayfa2.Cells(6, 2) & "')" +
                             " AND SH.SUBE_KODU='" + txtCompany.Text + "'" +
                             //" AND SH.STOK_KODU LIKE '" & Sayfa3.Cells(7, 2) & " % '" +
                             " AND (SH.STHAR_TARIH BETWEEN '" + txtDate1.Text + "' AND '" + txtDate2.Text + "')" +
                             " GROUP BY SH.SUBE_KODU,SH.STOK_KODU,ST.STOK_ADI" +
                            " ORDER BY SH.STOK_KODU";

            adapter = new SqlDataAdapter(SqlText, con);
            dataTable = new DataTable();
            dataTable.Clear();
            adapter.Fill(dataTable);

            int count = dataTable.Rows.Count;

            string[] cantList = { "HIZ", "S", "D", "150", "153","9D100111111", "50SAN" };

            for (int i = 0; i < count; i++)
            {   
                string productCode = dataTable.Rows[i]["STOK_KODU"].ToString();
                foreach (var item in cantList)
                {
                    if (productCode.Contains(item))
                    {
                        goto next;
                    }
                }

                TuikReportDetail tuikReportDetail = new TuikReportDetail()
                {
                    ProductCode = dataTable.Rows[i]["STOK_KODU"].ToString(),
                    ProductName = dataTable.Rows[i]["STOK_ADI"].ToString(),
                    Quantity = Convert.ToInt16(dataTable.Rows[i]["ADET"].ToString()),
                    Amount = Convert.ToDecimal(dataTable.Rows[i]["TOPLAM"].ToString()),
                    TuikReportId = 0
                };
                context.TuikReportDetails.Add(tuikReportDetail);
                context.SaveChanges();
            next:;
            }
        }

        void MatchProducts()
        {
            var matchs = context.MatchProducts.ToList();
            foreach (var match in matchs)
            {
                var products = context.TuikReportDetails.Where(p => p.ProductName.Contains(match.Name) && p.TuikReportId == 0).ToList();
                foreach (var product in products)
                {
                    product.TuikReportId = match.TuikReportId;
                    context.TuikReportDetails.Update(product);
                    context.SaveChanges();
                }
            }
        }

        void GetTuikReport()
        {
            var results = context.TuikReports.ToList();
            foreach (var item in results)
            {
                var tuikReportDetail = context.TuikReportDetails.Where(p => p.TuikReportId == item.Id).ToList();
                int quantity = tuikReportDetail.Sum(s => s.Quantity);
                decimal amount = tuikReportDetail.Sum(s => s.Amount);
                item.Count = quantity;
                item.Amount = amount;
                context.TuikReports.Update(item);
                context.SaveChanges();
            }
        }

        void ClearUCAFs()
        {
            var ucafs = context.UCAFs.ToList();
            foreach (var ucaf in ucafs)
            {
                ucaf.Total = 0;
                context.UCAFs.Update(ucaf);
                context.SaveChanges();
            }

            var ucafMatchs = context.UCAFMatchs.ToList();
            foreach (var ucaf in ucafMatchs)
            {
                ucaf.Total = 0;
                context.UCAFMatchs.Update(ucaf);
                context.SaveChanges();
            }
        }

        void GetUcafs()
        {
            var result = context.Connections.FirstOrDefault();
            SqlConnection con = new SqlConnection("server='" + result.Server + "';database='" + result.Db + "' + UserId='" + result.UserId + "' + password='" + result.Password + "'; Integrated Security=false");

            var listUcafs = context.UCAFMatchs.ToList();
            foreach (var ucaf in listUcafs)
            {
                string SqlText = "";
                SqlText = " SET DATEFORMAT DMY";
                SqlText = SqlText + " SELECT ";
                SqlText = SqlText + " '',MF.HES_KOD,MP.HS_ADI,SUM(CASE WHEN MF.BA=1 THEN TUTAR ELSE 0 END) as BORC,SUM(CASE WHEN MF.BA=2 THEN TUTAR ELSE 0 END) as ALACAK";
                SqlText = SqlText + " FROM TBLMUHFIS MF LEFT JOIN TBLMUPLAN MP ON MF.HES_KOD=MP.HESAP_KODU ";
                SqlText = SqlText + " WHERE 1=1";
                SqlText = SqlText + " AND SB.ISLETME_KODU='" + txtCompany.Text + "'";
                SqlText = SqlText + " AND MF.HES_KOD LIKE '" + ucaf.Match + "'";
                SqlText = SqlText + " AND (MF.TARIH BETWEEN '" + txtDate1.Text + "' AND '" + txtDate2.Text + "')";
                SqlText = SqlText + " GROUP BY MF.HES_KOD,MP.HS_ADI";
                SqlText = SqlText + " ORDER BY MF.HES_KOD";
                adapter = new SqlDataAdapter(SqlText, con);
                dataTable = new DataTable();
                dataTable.Clear();
                adapter.Fill(dataTable);

                ucaf.Total = ucaf.Total + Convert.ToDecimal(dataTable.Rows[0]["ALACAK"].ToString());
                context.UCAFMatchs.Update(ucaf);
                context.SaveChanges();
            }

            listUcafs = context.UCAFMatchs.ToList();
            var ucafs = context.UCAFs.ToList();
            foreach (var ucaf in ucafs)
            {
                ucaf.Total = listUcafs.Where(p => p.UCAFId == ucaf.Id).Sum(s => s.Total);
                context.UCAFs.Update(ucaf);
                context.SaveChanges();
            }
        }

        void GetResult()
        {
            var tuikDetailResults = context.TuikReportDetails.Where(p => p.TuikReportId == 0).ToList();
            var tuikResults = context.TuikReports.ToList();
            var ucafLists = context.UCAFs.ToList();
            
            dG1.DataSource = tuikDetailResults;
            dG2.DataSource = tuikResults;
            dG3.DataSource = "";
            dG4.DataSource = ucafLists;
        }        

        void GetExcel()
        {
            Excel.Application excel = new Excel.Application();
            object Missing = Type.Missing;
            Excel.Workbook workbook = excel.Workbooks.Add(Missing);
            Excel.Worksheet worksheet = (Excel.Worksheet)excel.Sheets[1];
            Excel.Worksheet worksheet2 = (Excel.Worksheet)excel.Sheets.Add();

            worksheet.Name = "T?ik Raporu";
            worksheet2.Name = "Mizan Raporu";

            //T?ik Raporu
            worksheet.Range["A1"].ColumnWidth = 4.43;
            worksheet.Range["B1"].ColumnWidth = 19;
            worksheet.Range["C1"].ColumnWidth = 7.43;
            worksheet.Range["D1"].ColumnWidth = 11.73;

            worksheet.Range["A1"].Value = "S.No";
            worksheet.Range["B1"].Value = "?r?n Ad?";
            worksheet.Range["C1"].Value = "Adet";
            worksheet.Range["D1"].Value = "Tutar";

            worksheet.Range["A1:D1"].Font.Color = -16776961;
            worksheet.Range["A1:D1"].Font.Bold = true;
            worksheet.Range["C:D"].NumberFormat = "#,##0.00";
            
            int rowCount = worksheet.Range["A" + worksheet.Rows.Count].End[Excel.XlDirection.xlUp].Row;

            rowCount++;
            int n = 1;

            var results = context.TuikReports.ToList();
            foreach (var item in results)
            {
                worksheet.Range["A" + rowCount].Value = n;
                worksheet.Range["B" + rowCount].Value = item.Name;
                worksheet.Range["C" + rowCount].Value = item.Count;
                worksheet.Range["D" + rowCount].Value = item.Amount;
                rowCount++;
                n++;
            }

            worksheet.Range["A" + rowCount].Value = "TOPLAM";
            worksheet.Range["A" + rowCount + ":D" + rowCount].Font.Color = -16776961;
            worksheet.Range["A" + rowCount + ":D" + rowCount].Font.Bold = true;
            worksheet.Range["C" + rowCount].Value = "=Sum(C2:C" + (rowCount - 1) + ")";
            worksheet.Range["D" + rowCount].Value = "=Sum(D2:D" + (rowCount - 1) + ")";

            decimal productTotal = Convert.ToDecimal(worksheet.Range["D" + rowCount].Value);

            worksheet.Range["A1:D" + rowCount].Borders.LineStyle = 1;
            //T?ik Raporu

            //Mizan Raporu            
            worksheet2.Range["A1"].Value = "Hesap A??klamas?";
            worksheet2.Range["B1"].Value = "Tutar";

            worksheet2.Range["A1"].ColumnWidth = 34;
            worksheet2.Range["B1"].ColumnWidth = 13;

            worksheet2.Range["A1:B1"].Font.Color = -16776961;
            worksheet2.Range["A1:B1"].Font.Bold = true;

            worksheet2.Range["B:B"].NumberFormat = "#,##0.00";

            rowCount = worksheet2.Range["A" + worksheet.Rows.Count].End[Excel.XlDirection.xlUp].Row;

            rowCount++;            

            var results2 = context.UCAFs.ToList();
            foreach (var item in results2)
            {
                worksheet2.Range["A" + rowCount].Value = item.Name;
                worksheet2.Range["B" + rowCount].Value = item.Total;
                rowCount++;
            }

            worksheet2.Range["A" + rowCount + ":B" + rowCount].Font.Color = -16776961;
            worksheet2.Range["A" + rowCount + ":B" + rowCount].Font.Bold = true;
            worksheet2.Range["A" + rowCount].Value = "TOPLAM";
            worksheet2.Range["B" + rowCount].Value = "=Sum(B2:B" + (rowCount-1) + ")";
            rowCount++;

            worksheet2.Range["A" + rowCount + ":B" + rowCount].Font.Color = -16776961;
            worksheet2.Range["A" + rowCount + ":B" + rowCount].Font.Bold = true;
            worksheet2.Range["A" + rowCount].Value = "STOK SATI? TOPLAMI";
            worksheet2.Range["B" + rowCount].Value = productTotal;
            rowCount++;

            worksheet2.Range["A" + rowCount + ":B" + rowCount].Font.Color = -16776961;
            worksheet2.Range["A" + rowCount + ":B" + rowCount].Font.Bold = true;
            worksheet2.Range["A" + rowCount].Value = "FARK";
            worksheet2.Range["B" + rowCount].Value = productTotal - Convert.ToDecimal(worksheet2.Range["B" + rowCount].Value);
            //Mizan Raporu

            excel.Visible = true;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {         
            if (MessageBox.Show("Rapor haz?rlamak istiyor musun?","Rapor Haz?rla",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClearTuikReport();
                //GetListProducts();
                //MatchProducts();
                //GetTuikReport();
                ClearUCAFs();
                //GetUcafs();
                GetResult();
                GetExcel();
            }
            
        }

        void GetDate()
        {
            if (txtPeriod.Text == "OCAK")
            {
                DateTime date1 = Convert.ToDateTime("01.01." + DateTime.Now.Year.ToString());
                DateTime date2 = Convert.ToDateTime("01.02." + DateTime.Now.Year.ToString());
                date2 = date2.AddDays(-1);
                txtDate1.Text = date1.ToString();
                txtDate2.Text = date2.ToString();
            }
            else if (txtPeriod.Text == "?UBAT")
            {
                DateTime date1 = Convert.ToDateTime("01.02." + DateTime.Now.Year.ToString());
                DateTime date2 = Convert.ToDateTime("01.03." + DateTime.Now.Year.ToString());
                date2 = date2.AddDays(-1);
                txtDate1.Text = date1.ToString();
                txtDate2.Text = date2.ToString();
            }
            else if (txtPeriod.Text == "MART")
            {
                DateTime date1 = Convert.ToDateTime("01.03." + DateTime.Now.Year.ToString());
                DateTime date2 = Convert.ToDateTime("01.04." + DateTime.Now.Year.ToString());
                date2 = date2.AddDays(-1);
                txtDate1.Text = date1.ToString();
                txtDate2.Text = date2.ToString();
            }
            else if (txtPeriod.Text == "N?SAN")
            {
                DateTime date1 = Convert.ToDateTime("01.04." + DateTime.Now.Year.ToString());
                DateTime date2 = Convert.ToDateTime("01.05." + DateTime.Now.Year.ToString());
                date2 = date2.AddDays(-1);
                txtDate1.Text = date1.ToString();
                txtDate2.Text = date2.ToString();
            }
            else if (txtPeriod.Text == "MAYIS")
            {
                DateTime date1 = Convert.ToDateTime("01.05." + DateTime.Now.Year.ToString());
                DateTime date2 = Convert.ToDateTime("01.06." + DateTime.Now.Year.ToString());
                date2 = date2.AddDays(-1);
                txtDate1.Text = date1.ToString();
                txtDate2.Text = date2.ToString();
            }
            else if (txtPeriod.Text == "HAZ?RAN")
            {
                DateTime date1 = Convert.ToDateTime("01.06." + DateTime.Now.Year.ToString());
                DateTime date2 = Convert.ToDateTime("01.07." + DateTime.Now.Year.ToString());
                date2 = date2.AddDays(-1);
                txtDate1.Text = date1.ToString();
                txtDate2.Text = date2.ToString();
            }
            else if (txtPeriod.Text == "TEMMUZ")
            {
                DateTime date1 = Convert.ToDateTime("01.07." + DateTime.Now.Year.ToString());
                DateTime date2 = Convert.ToDateTime("01.08." + DateTime.Now.Year.ToString());
                date2 = date2.AddDays(-1);
                txtDate1.Text = date1.ToString();
                txtDate2.Text = date2.ToString();
            }
            else if (txtPeriod.Text == "A?USTOS")
            {
                DateTime date1 = Convert.ToDateTime("01.08." + DateTime.Now.Year.ToString());
                DateTime date2 = Convert.ToDateTime("01.09." + DateTime.Now.Year.ToString());
                date2 = date2.AddDays(-1);
                txtDate1.Text = date1.ToString();
                txtDate2.Text = date2.ToString();
            }
            else if (txtPeriod.Text == "EYL?L")
            {
                DateTime date1 = Convert.ToDateTime("01.09." + DateTime.Now.Year.ToString());
                DateTime date2 = Convert.ToDateTime("01.10." + DateTime.Now.Year.ToString());
                date2 = date2.AddDays(-1);
                txtDate1.Text = date1.ToString();
                txtDate2.Text = date2.ToString();
            }
            else if (txtPeriod.Text == "EK?M")
            {
                DateTime date1 = Convert.ToDateTime("01.10." + DateTime.Now.Year.ToString());
                DateTime date2 = Convert.ToDateTime("01.11." + DateTime.Now.Year.ToString());
                date2 = date2.AddDays(-1);
                txtDate1.Text = date1.ToString();
                txtDate2.Text = date2.ToString();
            }
            else if (txtPeriod.Text == "KASIM")
            {
                DateTime date1 = Convert.ToDateTime("01.11." + DateTime.Now.Year.ToString());
                DateTime date2 = Convert.ToDateTime("01.12." + DateTime.Now.Year.ToString());
                date2 = date2.AddDays(-1);
                txtDate1.Text = date1.ToString();
                txtDate2.Text = date2.ToString();
            }
            else if (txtPeriod.Text == "ARALIK")
            {
                DateTime date1 = Convert.ToDateTime("01.12." + DateTime.Now.Year.ToString());
                DateTime date2 = Convert.ToDateTime("01.01." + DateTime.Now.AddYears(1).Year.ToString());
                date2 = date2.AddDays(-1);
                txtDate1.Text = date1.ToString();
                txtDate2.Text = date2.ToString();
            }
        }
        private void txtPeriod_TextChanged(object sender, EventArgs e)
        {
            GetDate();
        }

        private void dG2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = Convert.ToInt16(dG2.CurrentRow.Cells["colId"].Value.ToString());
            if (rowId > 0)
            {
                var results = context.TuikReportDetails.Where(t => t.TuikReportId == rowId).ToList();
                dG3.DataSource = results;                
            }
        }

        private void btnTuikList_Click(object sender, EventArgs e)
        {
            TuikList tuikList = new TuikList();
            tuikList.Show();
        }
        
        private void Home_Load(object sender, EventArgs e)
        {
            GetResult();
        }

        private void btnProductMatch_Click(object sender, EventArgs e)
        {
            ProductMatch productMatch = new ProductMatch();
            productMatch.Show();
        }

        private void btnUCAFList_Click(object sender, EventArgs e)
        {
            UCAFList uCAFList = new UCAFList();
            uCAFList.Show();
        }

        private void btnUCAFMatch_Click(object sender, EventArgs e)
        {
            UcafMatch uCAFMatch = new UcafMatch();
            uCAFMatch.Show();
        }
    }
}