namespace TuikProject
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.parametrelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProductMatch = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUCAFMatch = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.dG1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPeriod = new System.Windows.Forms.ComboBox();
            this.txtDate1 = new System.Windows.Forms.DateTimePicker();
            this.txtDate2 = new System.Windows.Forms.DateTimePicker();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tuikParametreleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dG1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parametrelerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1029, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // parametrelerToolStripMenuItem
            // 
            this.parametrelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnProductMatch,
            this.btnUCAFMatch,
            this.btnConnection,
            this.tuikParametreleriToolStripMenuItem});
            this.parametrelerToolStripMenuItem.Name = "parametrelerToolStripMenuItem";
            this.parametrelerToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.parametrelerToolStripMenuItem.Text = "Parametreler";
            // 
            // btnProductMatch
            // 
            this.btnProductMatch.Name = "btnProductMatch";
            this.btnProductMatch.Size = new System.Drawing.Size(180, 22);
            this.btnProductMatch.Text = "Stok Eşleştirme";
            // 
            // btnUCAFMatch
            // 
            this.btnUCAFMatch.Name = "btnUCAFMatch";
            this.btnUCAFMatch.Size = new System.Drawing.Size(180, 22);
            this.btnUCAFMatch.Text = "Mizan Eşleştirme";
            // 
            // btnConnection
            // 
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(180, 22);
            this.btnConnection.Text = "Veritabanı Bağlantısı";
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // dG1
            // 
            this.dG1.AllowUserToAddRows = false;
            this.dG1.AllowUserToDeleteRows = false;
            this.dG1.AllowUserToResizeRows = false;
            this.dG1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dG1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dG1.Location = new System.Drawing.Point(0, 127);
            this.dG1.Name = "dG1";
            this.dG1.RowHeadersVisible = false;
            this.dG1.RowTemplate.Height = 25;
            this.dG1.Size = new System.Drawing.Size(1029, 443);
            this.dG1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dönem";
            // 
            // txtPeriod
            // 
            this.txtPeriod.FormattingEnabled = true;
            this.txtPeriod.Items.AddRange(new object[] {
            "OCAK",
            "ŞUBAT",
            "MART",
            "NİSAN",
            "MAYIS",
            "HAZİRAN",
            "TEMMUZ",
            "AĞUSTOS",
            "EYLÜL",
            "EKİM",
            "KASIM",
            "ARALIK"});
            this.txtPeriod.Location = new System.Drawing.Point(88, 34);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(195, 27);
            this.txtPeriod.TabIndex = 3;
            // 
            // txtDate1
            // 
            this.txtDate1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDate1.Location = new System.Drawing.Point(29, 74);
            this.txtDate1.Name = "txtDate1";
            this.txtDate1.Size = new System.Drawing.Size(123, 26);
            this.txtDate1.TabIndex = 4;
            // 
            // txtDate2
            // 
            this.txtDate2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDate2.Location = new System.Drawing.Point(166, 74);
            this.txtDate2.Name = "txtDate2";
            this.txtDate2.Size = new System.Drawing.Size(117, 26);
            this.txtDate2.TabIndex = 5;
            // 
            // btnReport
            // 
            this.btnReport.Image = global::TuikProject.Properties.Resources.icons8_report_65;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(322, 27);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(173, 84);
            this.btnReport.TabIndex = 6;
            this.btnReport.Text = "Rapor Hazırla";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::TuikProject.Properties.Resources.icons8_door_64;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(851, 34);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 77);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Çıkış";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tuikParametreleriToolStripMenuItem
            // 
            this.tuikParametreleriToolStripMenuItem.Name = "tuikParametreleriToolStripMenuItem";
            this.tuikParametreleriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tuikParametreleriToolStripMenuItem.Text = "Tuik Parametreleri";
            this.tuikParametreleriToolStripMenuItem.Click += new System.EventHandler(this.tuikParametreleriToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 570);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.txtDate2);
            this.Controls.Add(this.txtDate1);
            this.Controls.Add(this.txtPeriod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dG1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tüik Rapor Formu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dG1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem parametrelerToolStripMenuItem;
        private ToolStripMenuItem btnProductMatch;
        private ToolStripMenuItem btnUCAFMatch;
        private ToolStripMenuItem btnConnection;
        private DataGridView dG1;
        private Label label1;
        private ComboBox txtPeriod;
        private DateTimePicker txtDate1;
        private DateTimePicker txtDate2;
        private Button btnReport;
        private Button btnClose;
        private ToolStripMenuItem tuikParametreleriToolStripMenuItem;
    }
}