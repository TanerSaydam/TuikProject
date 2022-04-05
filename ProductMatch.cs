using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuikProject.Models;
using TuikProject.Models.Dtos;

namespace TuikProject
{
    public partial class ProductMatch : Form
    {
        ContextDb context = new ContextDb();
        int tuikReportId = 0;
        int id = 0;
        public ProductMatch()
        {
            InitializeComponent();
        }

        void Show()
        {
            var result = from match in context.MatchProducts
                         join tuik in context.TuikReports on match.TuikReportId equals tuik.Id
                         select new MatchProductDto
                         {
                             Id = match.Id,
                             Name = match.Name,
                             TuikReportId = tuik.Id,
                             TuikReportName = tuik.Name
                         };
            dG1.DataSource = result.ToList();

            btnSave.Text = "Kaydet";
            btnClose.Text = "Kapat";

            txtMatchName.Text = "";
            txtMatchName.Focus();
            
        }

        void GetTuikProductList()
        {
            var results = context.TuikReports.ToList();
            txtTuikReport.Items.Clear();
            foreach (var item in results)
            {
                txtTuikReport.Items.Add(item.Name);  
            }
        }
        private void ProductMatch_Load(object sender, EventArgs e)
        {
            Show();
            GetTuikProductList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Değiştir")
            {
                var result = context.MatchProducts.Where(p => p.Id == id).FirstOrDefault();
                result.Name = txtMatchName.Text;
                if (tuikReportId != 0)
                {
                    result.TuikReportId = tuikReportId;
                }
                context.MatchProducts.Update(result);
                context.SaveChanges();
            }
            else
            {
                MatchProduct matchProduct = new MatchProduct()
                {
                    Name = txtMatchName.Text,
                    TuikReportId = tuikReportId
                };

                context.MatchProducts.Add(matchProduct);
                context.SaveChanges();
            }
            

            Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (btnClose.Text == "Vazgeç")
            {
                Show();
            }
            else
            {
                this.Close();
            }            
        }

        private void txtTuikReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            var result = context.TuikReports.Where(p => p.Name == txtTuikReport.Text).FirstOrDefault();
            tuikReportId = result.Id;
        }

        private void dG1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int id = Convert.ToInt16(dG1.CurrentRow.Cells[2].Value);
                string productName = dG1.CurrentRow.Cells[3].Value.ToString();
                if (MessageBox.Show(productName + " silmek istiyor musun?", "Sil?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var result = context.MatchProducts.Find(id);
                    context.MatchProducts.Remove(result);
                    context.SaveChanges();
                    Show();
                }

            }
        }

        private void dG1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt16(dG1.CurrentRow.Cells[2].Value);
            tuikReportId = 0;
            txtMatchName.Text = dG1.CurrentRow.Cells[3].Value.ToString();
            txtTuikReport.Text = dG1.CurrentRow.Cells[1].Value.ToString();
            btnSave.Text = "Değiştir";
            btnClose.Text = "Vazgeç";
            txtMatchName.Focus();
        }
    }
}
