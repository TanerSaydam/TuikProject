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

namespace TuikProject
{
    public partial class TuikList : Form
    {
        ContextDb context = new ContextDb();
        int id = 0;
        public TuikList()
        {
            InitializeComponent();
        }

        void Show()
        {
            var result = context.TuikReports.ToList();
            dG1.DataSource = result;

            btnSave.Text = "Kaydet";
            btnClose.Text = "Kapat";

            txtProductName.Text = "";
            txtProductName.Focus();
        }

        private void TuikList_Load(object sender, EventArgs e)
        {
            Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Değiştir")
            {
                var result = context.TuikReports.Find(id);
                result.Name = txtProductName.Text;
                context.TuikReports.Update(result);
                context.SaveChanges();                
            }
            else
            {
                TuikReport report = new TuikReport()
                {
                    Name = txtProductName.Text.ToUpper(),
                    Count = 0,
                    Amount = 0
                };
                context.TuikReports.Add(report);
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

        private void dG1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int productId = Convert.ToInt16(dG1.CurrentRow.Cells[1].Value);
                string productName = dG1.CurrentRow.Cells[2].Value.ToString();
                if (MessageBox.Show(productName + " silmek istiyor musun?","Sil?",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    var result = context.TuikReports.Find(productId);
                    context.TuikReports.Remove(result);
                    context.SaveChanges();
                    Show();
                }                
            }
        }

        private void dG1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt16(dG1.CurrentRow.Cells[1].Value);
            txtProductName.Text = dG1.CurrentRow.Cells[2].Value.ToString();
            btnSave.Text = "Değiştir";
            btnClose.Text = "Vazgeç";
            txtProductName.Focus();
        }
    }
}
