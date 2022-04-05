namespace TuikProject
{
    partial class UcafMatch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dG1 = new System.Windows.Forms.DataGridView();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTuikReportId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTuikReportName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtUCAF = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatchName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dG1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Image = global::TuikProject.Properties.Resources.icons8_close_16;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(637, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 64);
            this.btnClose.TabIndex = 20;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "Kapat";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::TuikProject.Properties.Resources.icons8_save_16;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(520, 11);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 64);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dG1
            // 
            this.dG1.AllowUserToAddRows = false;
            this.dG1.AllowUserToDeleteRows = false;
            this.dG1.AllowUserToResizeRows = false;
            this.dG1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dG1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDelete,
            this.colId,
            this.colName,
            this.colTuikReportId,
            this.colTuikReportName});
            this.dG1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dG1.Location = new System.Drawing.Point(0, 107);
            this.dG1.Name = "dG1";
            this.dG1.RowHeadersVisible = false;
            this.dG1.RowTemplate.Height = 25;
            this.dG1.Size = new System.Drawing.Size(803, 556);
            this.dG1.TabIndex = 19;
            this.dG1.TabStop = false;
            this.dG1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dG1_CellContentClick);
            this.dG1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dG1_CellDoubleClick);
            // 
            // colDelete
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "Sil";
            this.colDelete.DefaultCellStyle = dataGridViewCellStyle1;
            this.colDelete.HeaderText = "Sil";
            this.colDelete.Name = "colDelete";
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "#";
            this.colId.Name = "colId";
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.DataPropertyName = "Match";
            this.colName.HeaderText = "Eşleşme Adı";
            this.colName.Name = "colName";
            // 
            // colTuikReportId
            // 
            this.colTuikReportId.DataPropertyName = "UCAFId";
            this.colTuikReportId.HeaderText = "Mizan Id";
            this.colTuikReportId.Name = "colTuikReportId";
            this.colTuikReportId.Visible = false;
            // 
            // colTuikReportName
            // 
            this.colTuikReportName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTuikReportName.DataPropertyName = "UCAFName";
            this.colTuikReportName.HeaderText = "Hesap Adı";
            this.colTuikReportName.Name = "colTuikReportName";
            // 
            // txtUCAF
            // 
            this.txtUCAF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtUCAF.FormattingEnabled = true;
            this.txtUCAF.Location = new System.Drawing.Point(167, 53);
            this.txtUCAF.Name = "txtUCAF";
            this.txtUCAF.Size = new System.Drawing.Size(330, 27);
            this.txtUCAF.TabIndex = 16;
            this.txtUCAF.SelectedIndexChanged += new System.EventHandler(this.txtUCAF_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Eşleşecek Ad";
            // 
            // txtMatchName
            // 
            this.txtMatchName.Location = new System.Drawing.Point(167, 11);
            this.txtMatchName.Name = "txtMatchName";
            this.txtMatchName.Size = new System.Drawing.Size(222, 26);
            this.txtMatchName.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Eşleşecek Kod";
            // 
            // UcafMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 663);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dG1);
            this.Controls.Add(this.txtUCAF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMatchName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UcafMatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UcafMatch";
            this.Load += new System.EventHandler(this.UcafMatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dG1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnClose;
        private Button btnSave;
        private DataGridView dG1;
        private ComboBox txtUCAF;
        private Label label2;
        private TextBox txtMatchName;
        private Label label1;
        private DataGridViewButtonColumn colDelete;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colTuikReportId;
        private DataGridViewTextBoxColumn colTuikReportName;
    }
}