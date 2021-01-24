namespace QuanLyThuVien.GUI
{
    partial class DocGiaForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocGiaForm));
            this.btnDGSua = new System.Windows.Forms.Button();
            this.dgvDocGia = new System.Windows.Forms.DataGridView();
            this.maDoGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDGTen = new System.Windows.Forms.TextBox();
            this.btnDGKiemTra = new System.Windows.Forms.Button();
            this.btnDGTroLai = new System.Windows.Forms.Button();
            this.btnDGThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtPick = new System.Windows.Forms.DateTimePicker();
            this.txtDGMa = new System.Windows.Forms.TextBox();
            this.txtDGDiaChi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDGCMND = new System.Windows.Forms.TextBox();
            this.txtDGSDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDGXoa = new System.Windows.Forms.Button();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDGSua
            // 
            this.btnDGSua.BackColor = System.Drawing.SystemColors.Control;
            this.btnDGSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDGSua.Location = new System.Drawing.Point(768, 394);
            this.btnDGSua.Name = "btnDGSua";
            this.btnDGSua.Size = new System.Drawing.Size(130, 29);
            this.btnDGSua.TabIndex = 16;
            this.btnDGSua.Text = "Sửa thông tin";
            this.btnDGSua.UseVisualStyleBackColor = false;
            this.btnDGSua.Click += new System.EventHandler(this.btnDGSua_Click);
            // 
            // dgvDocGia
            // 
            this.dgvDocGia.AllowUserToAddRows = false;
            this.dgvDocGia.AllowUserToDeleteRows = false;
            this.dgvDocGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDoGia,
            this.tenDocGia,
            this.ngaySinh,
            this.diaChi,
            this.sdt,
            this.cmnd});
            this.dgvDocGia.Location = new System.Drawing.Point(3, 100);
            this.dgvDocGia.Name = "dgvDocGia";
            this.dgvDocGia.ReadOnly = true;
            this.dgvDocGia.Size = new System.Drawing.Size(592, 323);
            this.dgvDocGia.TabIndex = 15;
            this.dgvDocGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocGia_CellClick);
            // 
            // maDoGia
            // 
            this.maDoGia.HeaderText = "Mã Đọc Giả";
            this.maDoGia.Name = "maDoGia";
            this.maDoGia.ReadOnly = true;
            // 
            // tenDocGia
            // 
            this.tenDocGia.HeaderText = "Tên Đọc Giả";
            this.tenDocGia.Name = "tenDocGia";
            this.tenDocGia.ReadOnly = true;
            // 
            // ngaySinh
            // 
            this.ngaySinh.HeaderText = "Ngày Sinh";
            this.ngaySinh.Name = "ngaySinh";
            this.ngaySinh.ReadOnly = true;
            // 
            // diaChi
            // 
            this.diaChi.HeaderText = "Địa Chỉ";
            this.diaChi.Name = "diaChi";
            this.diaChi.ReadOnly = true;
            // 
            // sdt
            // 
            this.sdt.HeaderText = "SĐT";
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            // 
            // cmnd
            // 
            this.cmnd.HeaderText = "CMND";
            this.cmnd.Name = "cmnd";
            this.cmnd.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nhập tên Độc giả";
            // 
            // txtDGTen
            // 
            this.txtDGTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDGTen.Location = new System.Drawing.Point(150, 25);
            this.txtDGTen.Name = "txtDGTen";
            this.txtDGTen.Size = new System.Drawing.Size(206, 22);
            this.txtDGTen.TabIndex = 13;
            // 
            // btnDGKiemTra
            // 
            this.btnDGKiemTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDGKiemTra.Location = new System.Drawing.Point(380, 23);
            this.btnDGKiemTra.Name = "btnDGKiemTra";
            this.btnDGKiemTra.Size = new System.Drawing.Size(93, 24);
            this.btnDGKiemTra.TabIndex = 10;
            this.btnDGKiemTra.Text = "Kiểm tra";
            this.btnDGKiemTra.UseVisualStyleBackColor = true;
            this.btnDGKiemTra.Click += new System.EventHandler(this.btnDGKiemTra_Click);
            // 
            // btnDGTroLai
            // 
            this.btnDGTroLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDGTroLai.Location = new System.Drawing.Point(1005, 443);
            this.btnDGTroLai.Name = "btnDGTroLai";
            this.btnDGTroLai.Size = new System.Drawing.Size(93, 26);
            this.btnDGTroLai.TabIndex = 11;
            this.btnDGTroLai.Text = "Trở lại";
            this.btnDGTroLai.UseVisualStyleBackColor = true;
            this.btnDGTroLai.Click += new System.EventHandler(this.btnDGTroLai_Click);
            // 
            // btnDGThem
            // 
            this.btnDGThem.BackColor = System.Drawing.SystemColors.Control;
            this.btnDGThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDGThem.Location = new System.Drawing.Point(631, 394);
            this.btnDGThem.Name = "btnDGThem";
            this.btnDGThem.Size = new System.Drawing.Size(98, 29);
            this.btnDGThem.TabIndex = 12;
            this.btnDGThem.Text = "Làm thẻ";
            this.btnDGThem.UseVisualStyleBackColor = false;
            this.btnDGThem.Click += new System.EventHandler(this.btnDGThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(442, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Thông tin độc giả";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.dtPick);
            this.groupBox1.Controls.Add(this.txtDGMa);
            this.groupBox1.Controls.Add(this.txtDGDiaChi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDGTen);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnDGKiemTra);
            this.groupBox1.Controls.Add(this.txtDGCMND);
            this.groupBox1.Controls.Add(this.txtDGSDT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(595, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 277);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // dtPick
            // 
            this.dtPick.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPick.Location = new System.Drawing.Point(150, 102);
            this.dtPick.Name = "dtPick";
            this.dtPick.Size = new System.Drawing.Size(206, 20);
            this.dtPick.TabIndex = 6;
            // 
            // txtDGMa
            // 
            this.txtDGMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDGMa.Location = new System.Drawing.Point(150, 65);
            this.txtDGMa.Name = "txtDGMa";
            this.txtDGMa.ReadOnly = true;
            this.txtDGMa.Size = new System.Drawing.Size(206, 22);
            this.txtDGMa.TabIndex = 2;
            // 
            // txtDGDiaChi
            // 
            this.txtDGDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDGDiaChi.Location = new System.Drawing.Point(150, 144);
            this.txtDGDiaChi.Name = "txtDGDiaChi";
            this.txtDGDiaChi.Size = new System.Drawing.Size(206, 22);
            this.txtDGDiaChi.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "CMND";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "SĐT";
            // 
            // txtDGCMND
            // 
            this.txtDGCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDGCMND.Location = new System.Drawing.Point(150, 227);
            this.txtDGCMND.Name = "txtDGCMND";
            this.txtDGCMND.Size = new System.Drawing.Size(206, 22);
            this.txtDGCMND.TabIndex = 2;
            this.txtDGCMND.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDGCMND_KeyDown);
            // 
            // txtDGSDT
            // 
            this.txtDGSDT.AllowDrop = true;
            this.txtDGSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDGSDT.Location = new System.Drawing.Point(150, 185);
            this.txtDGSDT.Name = "txtDGSDT";
            this.txtDGSDT.Size = new System.Drawing.Size(206, 22);
            this.txtDGSDT.TabIndex = 2;
            this.txtDGSDT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDGSDT_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã đọc giả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày sinh";
            // 
            // btnDGXoa
            // 
            this.btnDGXoa.BackColor = System.Drawing.SystemColors.Control;
            this.btnDGXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDGXoa.Location = new System.Drawing.Point(932, 394);
            this.btnDGXoa.Name = "btnDGXoa";
            this.btnDGXoa.Size = new System.Drawing.Size(118, 29);
            this.btnDGXoa.TabIndex = 18;
            this.btnDGXoa.Text = "Xóa độc giả";
            this.btnDGXoa.UseVisualStyleBackColor = false;
            this.btnDGXoa.Click += new System.EventHandler(this.btnDGXoa_Click);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 102);
            this.panel1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // DocGiaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1113, 480);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDGXoa);
            this.Controls.Add(this.btnDGSua);
            this.Controls.Add(this.dgvDocGia);
            this.Controls.Add(this.btnDGTroLai);
            this.Controls.Add(this.btnDGThem);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DocGiaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DocGiaForm";
            this.Load += new System.EventHandler(this.DocGiaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDGSua;
        private System.Windows.Forms.DataGridView dgvDocGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDGTen;
        private System.Windows.Forms.Button btnDGKiemTra;
        private System.Windows.Forms.Button btnDGTroLai;
        private System.Windows.Forms.Button btnDGThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDGDiaChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDGSDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDoGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnd;
        private System.Windows.Forms.TextBox txtDGMa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDGCMND;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDGXoa;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.DateTimePicker dtPick;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}