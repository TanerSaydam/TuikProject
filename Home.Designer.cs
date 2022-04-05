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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.parametrelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTuikList = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProductMatch = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUCAFList = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUCAFMatch = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.tuikParametreleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPeriod = new System.Windows.Forms.ComboBox();
            this.txtDate1 = new System.Windows.Forms.DateTimePicker();
            this.txtDate2 = new System.Windows.Forms.DateTimePicker();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.dG2 = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dG3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTuikReportId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dG1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dG4 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dG2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dG3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dG1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dG4)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parametrelerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1311, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // parametrelerToolStripMenuItem
            // 
            this.parametrelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTuikList,
            this.btnProductMatch,
            this.btnUCAFList,
            this.btnUCAFMatch,
            this.btnConnection,
            this.tuikParametreleriToolStripMenuItem});
            this.parametrelerToolStripMenuItem.Name = "parametrelerToolStripMenuItem";
            this.parametrelerToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.parametrelerToolStripMenuItem.Text = "Parametreler";
            // 
            // btnTuikList
            // 
            this.btnTuikList.Name = "btnTuikList";
            this.btnTuikList.Size = new System.Drawing.Size(180, 22);
            this.btnTuikList.Text = "Tüik Listesi";
            this.btnTuikList.Click += new System.EventHandler(this.btnTuikList_Click);
            // 
            // btnProductMatch
            // 
            this.btnProductMatch.Name = "btnProductMatch";
            this.btnProductMatch.Size = new System.Drawing.Size(180, 22);
            this.btnProductMatch.Text = "Stok Eşleştirme";
            this.btnProductMatch.Click += new System.EventHandler(this.btnProductMatch_Click);
            // 
            // btnUCAFList
            // 
            this.btnUCAFList.Name = "btnUCAFList";
            this.btnUCAFList.Size = new System.Drawing.Size(180, 22);
            this.btnUCAFList.Text = "Mizan Listesi";
            this.btnUCAFList.Click += new System.EventHandler(this.btnUCAFList_Click);
            // 
            // btnUCAFMatch
            // 
            this.btnUCAFMatch.Name = "btnUCAFMatch";
            this.btnUCAFMatch.Size = new System.Drawing.Size(180, 22);
            this.btnUCAFMatch.Text = "Mizan Eşleştirme";
            this.btnUCAFMatch.Click += new System.EventHandler(this.btnUCAFMatch_Click);
            // 
            // btnConnection
            // 
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(180, 22);
            this.btnConnection.Text = "Veritabanı Bağlantısı";
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // tuikParametreleriToolStripMenuItem
            // 
            this.tuikParametreleriToolStripMenuItem.Name = "tuikParametreleriToolStripMenuItem";
            this.tuikParametreleriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tuikParametreleriToolStripMenuItem.Text = "Tuik Parametreleri";
            this.tuikParametreleriToolStripMenuItem.Click += new System.EventHandler(this.tuikParametreleriToolStripMenuItem_Click);
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
            this.txtPeriod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.txtPeriod.Size = new System.Drawing.Size(107, 27);
            this.txtPeriod.TabIndex = 0;
            this.txtPeriod.TextChanged += new System.EventHandler(this.txtPeriod_TextChanged);
            // 
            // txtDate1
            // 
            this.txtDate1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDate1.Location = new System.Drawing.Point(29, 74);
            this.txtDate1.Name = "txtDate1";
            this.txtDate1.Size = new System.Drawing.Size(134, 26);
            this.txtDate1.TabIndex = 4;
            // 
            // txtDate2
            // 
            this.txtDate2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDate2.Location = new System.Drawing.Point(179, 74);
            this.txtDate2.Name = "txtDate2";
            this.txtDate2.Size = new System.Drawing.Size(134, 26);
            this.txtDate2.TabIndex = 5;
            // 
            // btnReport
            // 
            this.btnReport.Image = global::TuikProject.Properties.Resources.icons8_report_65;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(357, 27);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(173, 84);
            this.btnReport.TabIndex = 6;
            this.btnReport.Text = "Rapor Hazırla";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::TuikProject.Properties.Resources.icons8_door_64;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1143, 34);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 77);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Çıkış";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "İşletme";
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(259, 35);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(54, 26);
            this.txtCompany.TabIndex = 9;
            this.txtCompany.TabStop = false;
            this.txtCompany.Text = "1";
            this.txtCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dG2
            // 
            this.dG2.AllowUserToAddRows = false;
            this.dG2.AllowUserToDeleteRows = false;
            this.dG2.AllowUserToResizeRows = false;
            this.dG2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dG2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dG2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colCount,
            this.colAmount});
            this.dG2.Location = new System.Drawing.Point(415, 166);
            this.dG2.Name = "dG2";
            this.dG2.RowHeadersVisible = false;
            this.dG2.RowTemplate.Height = 25;
            this.dG2.Size = new System.Drawing.Size(409, 568);
            this.dG2.TabIndex = 10;
            this.dG2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dG2_CellClick);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "#";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Ürün Adı";
            this.colName.Name = "colName";
            // 
            // colCount
            // 
            this.colCount.DataPropertyName = "Count";
            this.colCount.HeaderText = "Adet";
            this.colCount.Name = "colCount";
            // 
            // colAmount
            // 
            this.colAmount.DataPropertyName = "Amount";
            dataGridViewCellStyle1.Format = "n2";
            this.colAmount.DefaultCellStyle = dataGridViewCellStyle1;
            this.colAmount.HeaderText = "Tutar";
            this.colAmount.Name = "colAmount";
            // 
            // dG3
            // 
            this.dG3.AllowUserToAddRows = false;
            this.dG3.AllowUserToDeleteRows = false;
            this.dG3.AllowUserToResizeRows = false;
            this.dG3.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dG3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dG3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.colProductCode,
            this.colProductName,
            this.colQuantity,
            this.dataGridViewTextBoxColumn2,
            this.colTuikReportId});
            this.dG3.Location = new System.Drawing.Point(830, 166);
            this.dG3.Name = "dG3";
            this.dG3.RowHeadersVisible = false;
            this.dG3.RowTemplate.Height = 25;
            this.dG3.Size = new System.Drawing.Size(481, 568);
            this.dG3.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // colProductCode
            // 
            this.colProductCode.DataPropertyName = "ProductCode";
            this.colProductCode.HeaderText = "Ürün Kodu";
            this.colProductCode.Name = "colProductCode";
            // 
            // colProductName
            // 
            this.colProductName.DataPropertyName = "ProductName";
            this.colProductName.HeaderText = "Ürün Adı";
            this.colProductName.Name = "colProductName";
            // 
            // colQuantity
            // 
            this.colQuantity.DataPropertyName = "Quantity";
            this.colQuantity.HeaderText = "Adet";
            this.colQuantity.Name = "colQuantity";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Amount";
            dataGridViewCellStyle2.Format = "n2";
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn2.HeaderText = "Tutar";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // colTuikReportId
            // 
            this.colTuikReportId.DataPropertyName = "TuikReportId";
            this.colTuikReportId.HeaderText = "Tük Rapor Id";
            this.colTuikReportId.Name = "colTuikReportId";
            this.colTuikReportId.Visible = false;
            // 
            // dG1
            // 
            this.dG1.AllowUserToAddRows = false;
            this.dG1.AllowUserToDeleteRows = false;
            this.dG1.AllowUserToResizeRows = false;
            this.dG1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dG1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dG1.Location = new System.Drawing.Point(0, 166);
            this.dG1.Name = "dG1";
            this.dG1.RowHeadersVisible = false;
            this.dG1.RowTemplate.Height = 25;
            this.dG1.Size = new System.Drawing.Size(409, 568);
            this.dG1.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn3.HeaderText = "#";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ProductCode";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ürün Kodu";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ürün Adı";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn6.HeaderText = "Adet";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Amount";
            dataGridViewCellStyle3.Format = "n2";
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn7.HeaderText = "Tutar";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TuikReportId";
            this.dataGridViewTextBoxColumn8.HeaderText = "Tük Rapor Id";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dG4
            // 
            this.dG4.AllowUserToAddRows = false;
            this.dG4.AllowUserToDeleteRows = false;
            this.dG4.AllowUserToResizeRows = false;
            this.dG4.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dG4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dG4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn14});
            this.dG4.Location = new System.Drawing.Point(613, 12);
            this.dG4.Name = "dG4";
            this.dG4.RowHeadersVisible = false;
            this.dG4.RowTemplate.Height = 25;
            this.dG4.Size = new System.Drawing.Size(434, 148);
            this.dG4.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn9.HeaderText = "#";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn10.HeaderText = "Hesap Adı";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Total";
            dataGridViewCellStyle4.Format = "n2";
            this.dataGridViewTextBoxColumn14.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn14.HeaderText = "Toplam";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 734);
            this.Controls.Add(this.dG4);
            this.Controls.Add(this.dG1);
            this.Controls.Add(this.dG3);
            this.Controls.Add(this.dG2);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.txtDate2);
            this.Controls.Add(this.txtDate1);
            this.Controls.Add(this.txtPeriod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tüik Rapor Formu";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dG2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dG3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dG1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dG4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem parametrelerToolStripMenuItem;
        private ToolStripMenuItem btnProductMatch;
        private ToolStripMenuItem btnUCAFMatch;
        private ToolStripMenuItem btnConnection;
        private Label label1;
        private ComboBox txtPeriod;
        private DateTimePicker txtDate1;
        private DateTimePicker txtDate2;
        private Button btnReport;
        private Button btnClose;
        private ToolStripMenuItem tuikParametreleriToolStripMenuItem;
        private Label label2;
        private TextBox txtCompany;
        private DataGridView dG2;
        private DataGridView dG3;
        private ToolStripMenuItem btnUCAFList;
        private ToolStripMenuItem btnTuikList;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colCount;
        private DataGridViewTextBoxColumn colAmount;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn colProductCode;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn colTuikReportId;
        private DataGridView dG1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridView dG4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    }
}