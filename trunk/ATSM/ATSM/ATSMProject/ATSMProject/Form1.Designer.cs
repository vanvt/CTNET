namespace ATSMProject
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colTieuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNguoiTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTheLoaiTin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTieuDe,
            this.colNoiDung,
            this.colNguoiTao,
            this.colTheLoaiTin});
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(526, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // colTieuDe
            // 
            this.colTieuDe.HeaderText = "TieuDe";
            this.colTieuDe.Name = "colTieuDe";
            // 
            // colNoiDung
            // 
            this.colNoiDung.HeaderText = "NoiDung";
            this.colNoiDung.Name = "colNoiDung";
            // 
            // colNguoiTao
            // 
            this.colNguoiTao.HeaderText = "NguoiTao";
            this.colNguoiTao.Name = "colNguoiTao";
            // 
            // colTheLoaiTin
            // 
            this.colTheLoaiTin.HeaderText = "TheLoaiTin";
            this.colTheLoaiTin.Name = "colTheLoaiTin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 262);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTieuDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNguoiTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTheLoaiTin;
    }
}

