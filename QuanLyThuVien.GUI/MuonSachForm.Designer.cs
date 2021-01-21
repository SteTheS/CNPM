namespace QuanLyThuVien.GUI
{
    partial class MuonSachForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MuonSachForm));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMuonSach = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMSMaDocGia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMSTenSach = new System.Windows.Forms.TextBox();
            this.btnMSKiemTra = new System.Windows.Forms.Button();
            this.btnMSTroLai = new System.Windows.Forms.Button();
            this.btnMSMuonSach = new System.Windows.Forms.Button();
            this.txtMSMaSach = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datePickReturn = new System.Windows.Forms.DateTimePicker();
            this.datePickRent = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuonSach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(492, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 29);
            this.label1.TabIndex = 34;
            this.label1.Text = "Mượn Sách";
            // 
            // dgvMuonSach
            // 
            this.dgvMuonSach.AllowUserToAddRows = false;
            this.dgvMuonSach.AllowUserToDeleteRows = false;
            this.dgvMuonSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMuonSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuonSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvMuonSach.Location = new System.Drawing.Point(445, 90);
            this.dgvMuonSach.Name = "dgvMuonSach";
            this.dgvMuonSach.ReadOnly = true;
            this.dgvMuonSach.Size = new System.Drawing.Size(649, 335);
            this.dgvMuonSach.TabIndex = 33;
            this.dgvMuonSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMuonSach_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã sách";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên sách";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Năm xuất bản";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Thể loại";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tác giả";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Nhà xuất bản";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Số lượng";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Mã độc giả";
            // 
            // txtMSMaDocGia
            // 
            this.txtMSMaDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSMaDocGia.Location = new System.Drawing.Point(119, 153);
            this.txtMSMaDocGia.Name = "txtMSMaDocGia";
            this.txtMSMaDocGia.Size = new System.Drawing.Size(206, 22);
            this.txtMSMaDocGia.TabIndex = 29;
            this.txtMSMaDocGia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMSMaDocGia_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nhập tên Sách";
            // 
            // txtMSTenSach
            // 
            this.txtMSTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSTenSach.Location = new System.Drawing.Point(119, 29);
            this.txtMSTenSach.Name = "txtMSTenSach";
            this.txtMSTenSach.Size = new System.Drawing.Size(206, 22);
            this.txtMSTenSach.TabIndex = 30;
            // 
            // btnMSKiemTra
            // 
            this.btnMSKiemTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMSKiemTra.Location = new System.Drawing.Point(352, 27);
            this.btnMSKiemTra.Name = "btnMSKiemTra";
            this.btnMSKiemTra.Size = new System.Drawing.Size(87, 22);
            this.btnMSKiemTra.TabIndex = 26;
            this.btnMSKiemTra.Text = "Kiểm tra";
            this.btnMSKiemTra.UseVisualStyleBackColor = true;
            this.btnMSKiemTra.Click += new System.EventHandler(this.btnMSKiemTra_Click);
            // 
            // btnMSTroLai
            // 
            this.btnMSTroLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMSTroLai.Location = new System.Drawing.Point(989, 431);
            this.btnMSTroLai.Name = "btnMSTroLai";
            this.btnMSTroLai.Size = new System.Drawing.Size(92, 34);
            this.btnMSTroLai.TabIndex = 27;
            this.btnMSTroLai.Text = "Trở lại";
            this.btnMSTroLai.UseVisualStyleBackColor = true;
            this.btnMSTroLai.Click += new System.EventHandler(this.btnMSTroLai_Click);
            // 
            // btnMSMuonSach
            // 
            this.btnMSMuonSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMSMuonSach.Location = new System.Drawing.Point(141, 382);
            this.btnMSMuonSach.Name = "btnMSMuonSach";
            this.btnMSMuonSach.Size = new System.Drawing.Size(139, 34);
            this.btnMSMuonSach.TabIndex = 28;
            this.btnMSMuonSach.Text = "Mượn sách";
            this.btnMSMuonSach.UseVisualStyleBackColor = true;
            this.btnMSMuonSach.Click += new System.EventHandler(this.btnMSMuonSach_Click);
            // 
            // txtMSMaSach
            // 
            this.txtMSMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSMaSach.Location = new System.Drawing.Point(119, 111);
            this.txtMSMaSach.Name = "txtMSMaSach";
            this.txtMSMaSach.Size = new System.Drawing.Size(206, 22);
            this.txtMSMaSach.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Mã sách";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Ngày mượn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "Ngày trả";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.datePickReturn);
            this.groupBox1.Controls.Add(this.datePickRent);
            this.groupBox1.Controls.Add(this.txtMSTenSach);
            this.groupBox1.Controls.Add(this.btnMSKiemTra);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMSMaSach);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMSMaDocGia);
            this.groupBox1.Location = new System.Drawing.Point(0, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 280);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // datePickReturn
            // 
            this.datePickReturn.Location = new System.Drawing.Point(119, 230);
            this.datePickReturn.Name = "datePickReturn";
            this.datePickReturn.Size = new System.Drawing.Size(206, 20);
            this.datePickReturn.TabIndex = 34;
            // 
            // datePickRent
            // 
            this.datePickRent.Location = new System.Drawing.Point(119, 196);
            this.datePickRent.Name = "datePickRent";
            this.datePickRent.Size = new System.Drawing.Size(206, 20);
            this.datePickRent.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 95);
            this.panel1.TabIndex = 36;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // MuonSachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1093, 478);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvMuonSach);
            this.Controls.Add(this.btnMSTroLai);
            this.Controls.Add(this.btnMSMuonSach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MuonSachForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MuonSachForm";
            this.Load += new System.EventHandler(this.MuonSachForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuonSach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMuonSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMSMaDocGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMSTenSach;
        private System.Windows.Forms.Button btnMSKiemTra;
        private System.Windows.Forms.Button btnMSTroLai;
        private System.Windows.Forms.Button btnMSMuonSach;
        private System.Windows.Forms.TextBox txtMSMaSach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker datePickReturn;
        private System.Windows.Forms.DateTimePicker datePickRent;
    }
}