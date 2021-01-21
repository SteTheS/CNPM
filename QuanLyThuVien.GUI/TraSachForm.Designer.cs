namespace QuanLyThuVien.GUI
{
    partial class TraSachForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraSachForm));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTraSach = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTSMaDocGia = new System.Windows.Forms.TextBox();
            this.btnTSKiemTra = new System.Windows.Forms.Button();
            this.btnTSTroLai = new System.Windows.Forms.Button();
            this.btnTSTraSach = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.maphiemuondgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masachdgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madocgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaymuondgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaytradgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraSach)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(465, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 41;
            this.label1.Text = "Trả Sách";
            // 
            // dgvTraSach
            // 
            this.dgvTraSach.AllowUserToAddRows = false;
            this.dgvTraSach.AllowUserToDeleteRows = false;
            this.dgvTraSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTraSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTraSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphiemuondgv,
            this.masachdgv,
            this.madocgia,
            this.ngaymuondgv,
            this.ngaytradgv});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTraSach.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTraSach.Location = new System.Drawing.Point(455, 89);
            this.dgvTraSach.Name = "dgvTraSach";
            this.dgvTraSach.ReadOnly = true;
            this.dgvTraSach.Size = new System.Drawing.Size(628, 320);
            this.dgvTraSach.TabIndex = 40;
            this.dgvTraSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTraSach_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Nhập mã độc giả";
            // 
            // txtTSMaDocGia
            // 
            this.txtTSMaDocGia.Location = new System.Drawing.Point(118, 100);
            this.txtTSMaDocGia.Name = "txtTSMaDocGia";
            this.txtTSMaDocGia.Size = new System.Drawing.Size(222, 20);
            this.txtTSMaDocGia.TabIndex = 38;
            // 
            // btnTSKiemTra
            // 
            this.btnTSKiemTra.Location = new System.Drawing.Point(355, 98);
            this.btnTSKiemTra.Name = "btnTSKiemTra";
            this.btnTSKiemTra.Size = new System.Drawing.Size(75, 23);
            this.btnTSKiemTra.TabIndex = 35;
            this.btnTSKiemTra.Text = "Kiểm tra";
            this.btnTSKiemTra.UseVisualStyleBackColor = true;
            this.btnTSKiemTra.Click += new System.EventHandler(this.btnTSKiemTra_Click);
            // 
            // btnTSTroLai
            // 
            this.btnTSTroLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTSTroLai.Location = new System.Drawing.Point(990, 415);
            this.btnTSTroLai.Name = "btnTSTroLai";
            this.btnTSTroLai.Size = new System.Drawing.Size(83, 23);
            this.btnTSTroLai.TabIndex = 36;
            this.btnTSTroLai.Text = "Trở lại";
            this.btnTSTroLai.UseVisualStyleBackColor = true;
            this.btnTSTroLai.Click += new System.EventHandler(this.btnTSTroLai_Click);
            // 
            // btnTSTraSach
            // 
            this.btnTSTraSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTSTraSach.Location = new System.Drawing.Point(178, 376);
            this.btnTSTraSach.Name = "btnTSTraSach";
            this.btnTSTraSach.Size = new System.Drawing.Size(95, 33);
            this.btnTSTraSach.TabIndex = 37;
            this.btnTSTraSach.Text = "Trả sách";
            this.btnTSTraSach.UseVisualStyleBackColor = true;
            this.btnTSTraSach.Click += new System.EventHandler(this.btnTSTraSach_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 84);
            this.panel1.TabIndex = 42;
            // 
            // maphiemuondgv
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maphiemuondgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.maphiemuondgv.HeaderText = "Mã phiếu mượn";
            this.maphiemuondgv.Name = "maphiemuondgv";
            this.maphiemuondgv.ReadOnly = true;
            // 
            // masachdgv
            // 
            this.masachdgv.HeaderText = "Mã sách";
            this.masachdgv.Name = "masachdgv";
            this.masachdgv.ReadOnly = true;
            // 
            // madocgia
            // 
            this.madocgia.HeaderText = "Mã đọc giả";
            this.madocgia.Name = "madocgia";
            this.madocgia.ReadOnly = true;
            // 
            // ngaymuondgv
            // 
            this.ngaymuondgv.HeaderText = "Ngày mượn";
            this.ngaymuondgv.Name = "ngaymuondgv";
            this.ngaymuondgv.ReadOnly = true;
            // 
            // ngaytradgv
            // 
            this.ngaytradgv.HeaderText = "Ngày trả";
            this.ngaytradgv.Name = "ngaytradgv";
            this.ngaytradgv.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // TraSachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1085, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvTraSach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTSMaDocGia);
            this.Controls.Add(this.btnTSKiemTra);
            this.Controls.Add(this.btnTSTroLai);
            this.Controls.Add(this.btnTSTraSach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TraSachForm";
            this.Text = "TraSachForm";
            this.Load += new System.EventHandler(this.TraSachForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraSach)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTraSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTSMaDocGia;
        private System.Windows.Forms.Button btnTSKiemTra;
        private System.Windows.Forms.Button btnTSTroLai;
        private System.Windows.Forms.Button btnTSTraSach;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphiemuondgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn masachdgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn madocgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaymuondgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaytradgv;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}