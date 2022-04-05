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
    public partial class Connection : Form
    {
        ContextDb context = new ContextDb();
        public Connection()
        {
            InitializeComponent();
        }

        void Show()
        {
            var result = context.Connections.FirstOrDefault();
            if (result != null)
            {
                txtDatabase.Text = result.Db;
                txtPassword.Text = result.Password;
                txtServer.Text = result.Server;
                txtUserId.Text = result.UserId;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var result = context.Connections.FirstOrDefault();
            if (result == null)
            {
                ConnectionClass connection = new ConnectionClass()
                {
                    Db = txtDatabase.Text,
                    Password = txtPassword.Text,
                    Server = txtServer.Text,
                    UserId = txtUserId.Text
                };
                context.Connections.Add(connection);
                context.SaveChanges();
            }
            else
            {
                result.Db = txtDatabase.Text;
                result.Password = txtPassword.Text; 
                result.Server = txtServer.Text;
                result.UserId = txtUserId.Text;
                context.Connections.Update(result);
                context.SaveChanges();
            }
            MessageBox.Show("Güncelleme işlemi başarıyla tamamlandı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);            
        }

        private void Connection_Load(object sender, EventArgs e)
        {
            Show();
        }
    }
}
