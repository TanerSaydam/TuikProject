namespace TuikProject
{
    partial class UCAFList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dG1 = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtUCAFName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dG1)).BeginInit();
            this.SuspendLayout();
            // 
            // dG1
            // 
            this.dG1.AllowUserToAddRows = false;
            this.dG1.AllowUserToDeleteRows = false;
            this.dG1.AllowUserToResizeRows = false;
            this.dG1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dG1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colTotal,
            this.colDelete});
            this.dG1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dG1.Location = new System.Drawing.Point(0, 91);
            this.dG1.Name = "dG1";
            this.dG1.RowHeadersVisible = false;
            this.dG1.RowTemplate.Height = 25;
            this.dG1.Size = new System.Drawing.Size(743, 731);
            this.dG1.TabIndex = 12;
            this.dG1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dG1_CellContentClick);
            this.dG1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dG1_CellDoubleClick);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::TuikProject.Properties.Resources.icons8_close_16;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(612, 29);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 33);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Kapat";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::TuikProject.Properties.Resources.icons8_save_16;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(475, 29);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 33);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtUCAFName
            // 
            this.txtUCAFName.Location = new System.Drawing.Point(94, 33);
            this.txtUCAFName.Name = "txtUCAFName";
            this.txtUCAFName.Size = new System.Drawing.Size(346, 26);
            this.txtUCAFName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hesap Adı";
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
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Hesap Adı";
            this.colName.Name = "colName";
            // 
            // colTotal
            // 
            this.colTotal.DataPropertyName = "Total";
            this.colTotal.HeaderText = "Toplam";
            this.colTotal.Name = "colTotal";
            this.colTotal.Visible = false;
            // 
            // colDelete
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.NullValue = "Sil";
            this.colDelete.DefaultCellStyle = dataGridViewCellStyle8;
            this.colDelete.HeaderText = "Sil";
            this.colDelete.Name = "colDelete";
            this.colDelete.Text = "Sil";
            // 
            // UCAFList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(743, 822);
            this.Controls.Add(this.dG1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtUCAFName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UCAFList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mizan Listesi";
            this.Load += new System.EventHandler(this.UCAFList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dG1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dG1;
        private Button btnClose;
        private Button btnSave;
        private TextBox txtUCAFName;
        private Label label1;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colTotal;
        private DataGridViewButtonColumn colDelete;
    }
}