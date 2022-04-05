namespace TuikProject
{
    public partial class Home : Form
    {
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
    }
}