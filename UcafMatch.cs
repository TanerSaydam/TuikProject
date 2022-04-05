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
    public partial class UcafMatch : Form
    {
        ContextDb context = new ContextDb();
        int id = 0;
        int ucafId = 0;
        public UcafMatch()
        {
            InitializeComponent();
        }

        void Show()
        {
            var result = from match in context.UCAFMatchs
                         join ucaf in context.UCAFs on match.UCAFId equals ucaf.Id
                         select new UCAFMatchDto
                         {
                             Id = match.Id,
                             Match = match.Match,
                             UCAFId = match.UCAFId,
                             Total = match.Total,
                             UCAFName = ucaf.Name
                         };
            dG1.DataSource = result.ToList();

            btnSave.Text = "Kaydet";
            btnClose.Text = "Kapat";

            txtMatchName.Text = "";
            txtMatchName.Focus();
        }

        void GetUcafList()
        {
            txtUCAF.Items.Clear();
            var results = context.UCAFs.ToList();
            foreach (var item in results)
            {
                txtUCAF.Items.Add(item.Name);
            }
        }

        private void UcafMatch_Load(object sender, EventArgs e)
        {
            Show();
            GetUcafList();
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
                int id = Convert.ToInt16(dG1.CurrentRow.Cells[2].Value);
                string matchName = dG1.CurrentRow.Cells[4].Value.ToString();
                if (MessageBox.Show(matchName + " silmek istiyor musun?", "Sil?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var result = context.MatchProducts.Find(id);
                    context.MatchProducts.Remove(result);
                    context.SaveChanges();
                    Show();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Değiştir")
            {
                var result = context.UCAFMatchs.Find(id);
                result.Match = txtMatchName.Text;
                if (ucafId > 0)
                {
                    result.UCAFId = ucafId;
                }
                context.UCAFMatchs.Update(result);
                context.SaveChanges();
            }
            else
            {
                UCAFMatch match = new UCAFMatch
                {
                    Match = txtMatchName.Text,
                    Total = 0,
                    UCAFId = ucafId
                };
                context.UCAFMatchs.Add(match);
                context.SaveChanges();
            }
            Show();
        }

        private void dG1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt16(dG1.CurrentRow.Cells[2].Value);
            txtMatchName.Text = dG1.CurrentRow.Cells[4].Value.ToString();
            txtUCAF.Text = dG1.CurrentRow.Cells[1].Value.ToString();
            btnSave.Text = "Değiştir";
            btnClose.Text = "Vazgeç";
            ucafId = 0;
            txtMatchName.Focus();
        }

        private void txtUCAF_SelectedIndexChanged(object sender, EventArgs e)
        {
            var result = context.UCAFs.Where(p => p.Name == txtUCAF.Text).FirstOrDefault();
            ucafId = result.Id;
        }
    }
}
