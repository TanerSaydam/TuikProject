using Microsoft.Data.SqlClient;
using System.Data;
using TuikProject.Models;

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
            for (int i = 0; i < count; i++)
            {
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
        }

        

        private void btnReport_Click(object sender, EventArgs e)
        {
            ClearTuikReport();
            GetListProducts();
            MatchProducts();
            GetTuikReport();
            GetResult();
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
            else if (txtPeriod.Text == "ÞUBAT")
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
            else if (txtPeriod.Text == "NÝSAN")
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
            else if (txtPeriod.Text == "HAZÝRAN")
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
            else if (txtPeriod.Text == "AÐUSTOS")
            {
                DateTime date1 = Convert.ToDateTime("01.08." + DateTime.Now.Year.ToString());
                DateTime date2 = Convert.ToDateTime("01.09." + DateTime.Now.Year.ToString());
                date2 = date2.AddDays(-1);
                txtDate1.Text = date1.ToString();
                txtDate2.Text = date2.ToString();
            }
            else if (txtPeriod.Text == "EYLÜL")
            {
                DateTime date1 = Convert.ToDateTime("01.09." + DateTime.Now.Year.ToString());
                DateTime date2 = Convert.ToDateTime("01.10." + DateTime.Now.Year.ToString());
                date2 = date2.AddDays(-1);
                txtDate1.Text = date1.ToString();
                txtDate2.Text = date2.ToString();
            }
            else if (txtPeriod.Text == "EKÝM")
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
            var row = dG2.CurrentRow.Cells[0];
            if (row != null)
            {
                var results = context.TuikReportDetails.Where(t => t.TuikReportId == Convert.ToInt16(row.ToString())).ToList();
                dG3.DataSource = results;
            }
        }
    }
}