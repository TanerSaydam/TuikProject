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
    public partial class UCAFList : Form
    {
        ContextDb context = new ContextDb();
        int id = 0;
        public UCAFList()
        {
            InitializeComponent();
        }

        void Show()
        {
            var result = context.UCAFs.ToList();
            dG1.DataSource = result;

            btnSave.Text = "Kaydet";
            btnClose.Text = "Kapat";

            txtUCAFName.Text = "";
            txtUCAFName.Focus();
        }

        private void UCAFList_Load(object sender, EventArgs e)
        {
            Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Değiştir")
            {
                var result = context.UCAFs.Where(p => p.Id == id).FirstOrDefault();
                result.Name = txtUCAFName.Text;

                context.UCAFs.Update(result);
                context.SaveChanges();
            }
            else
            {
                UCAF ucaf = new UCAF()
                {
                    Name = txtUCAFName.Text,
                    Total = 0
                };

                context.UCAFs.Add(ucaf);
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

        private void dG1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt16(dG1.CurrentRow.Cells[1].Value);
            txtUCAFName.Text = dG1.CurrentRow.Cells[2].Value.ToString();
            btnSave.Text = "Değiştir";
            btnClose.Text = "Vazgeç";
            txtUCAFName.Focus();
        }

        private void dG1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int ucafId = Convert.ToInt16(dG1.CurrentRow.Cells[1].Value);
                string ucafName = dG1.CurrentRow.Cells[2].Value.ToString();
                if (MessageBox.Show(ucafName + " silmek istiyor musun?", "Sil?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var result = context.UCAFs.Find(ucafId);
                    context.UCAFs.Remove(result);
                    context.SaveChanges();
                    Show();
                }
            }
        }
    }
}
