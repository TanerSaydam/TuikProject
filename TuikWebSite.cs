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
    public partial class TuikWebSite : Form
    {
        ContextDb context = new ContextDb();
        public TuikWebSite()
        {
            InitializeComponent();
        }

        void Show()
        {
            var result = context.TuikWebSite.FirstOrDefault();
            if (result != null)
            {
                txtUserId.Text = result.UserId;
                txtPassword.Text = result.Password;
                txtWebSite.Text = result.Url;
            }
        }

        private void TuikWebSite_Load(object sender, EventArgs e)
        {
            Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var result = context.TuikWebSite.FirstOrDefault();
            if (result != null)
            {
                result.UserId = txtUserId.Text;
                result.Password = txtPassword.Text;
                result.Url = txtWebSite.Text;
                context.TuikWebSite.Update(result);
                context.SaveChanges();
            }
            else
            {
                TuikWeb web = new TuikWeb()
                {
                    UserId = txtUserId.Text,
                    Password = txtPassword.Text,
                    Url = txtWebSite.Text
                };
                context.TuikWebSite.Add(web);
                context.SaveChanges();
            }

            MessageBox.Show("Güncelleme işlemi başarıyla tamamlandı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
