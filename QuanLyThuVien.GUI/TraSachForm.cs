using QuanLyThuVien.BLL;
using QuanLyThuVien.DAL;
using QuanLyThuVien.DAL.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.GUI
{
    public partial class TraSachForm : Form
    {
        public TraSachForm()
        {
            InitializeComponent();
        }
        string MaSach;
        phieumuonsach PMS = new phieumuonsach();
        QLTVbll bll = new QLTVbll();

        private void btnTSTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TraSachForm_Load(object sender, EventArgs e)
        {
            List<phieumuonsach> pms = bll.GetPhieumuonsaches();
            dgvTraSach.Rows.Clear();
            foreach(var item in pms)
            {
                int i = dgvTraSach.Rows.Add();
                dgvTraSach.Rows[i].Cells[0].Value = item.maphieumuon;
                dgvTraSach.Rows[i].Cells[1].Value = item.masach;
                dgvTraSach.Rows[i].Cells[2].Value = item.madocgia;
                dgvTraSach.Rows[i].Cells[3].Value = item.ngaymuon;
                dgvTraSach.Rows[i].Cells[4].Value = item.ngaytra;
            }
        }

        private void dgvTraSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) ;
            else
            {
                txtTSMaDocGia.Text = dgvTraSach.Rows[e.RowIndex].Cells[2].Value.ToString();
                MaSach = dgvTraSach.Rows[e.RowIndex].Cells[1].Value.ToString();
                PMS.maphieumuon = Convert.ToInt32(dgvTraSach.Rows[e.RowIndex].Cells[0].Value);
                PMS.masach = dgvTraSach.Rows[e.RowIndex].Cells[1].Value.ToString();
                PMS.madocgia = Convert.ToInt32(dgvTraSach.Rows[e.RowIndex].Cells[2].Value);
                PMS.ngaymuon = Convert.ToDateTime(dgvTraSach.Rows[e.RowIndex].Cells[3].Value);
                PMS.ngaytra = Convert.ToDateTime(dgvTraSach.Rows[e.RowIndex].Cells[4].Value);

            }
        }

        private void btnTSTraSach_Click(object sender, EventArgs e)
        {
            try
            {
                List<phieumuonsach> pms = bll.GetPhieumuonsaches();
                List<Sach> listSach = bll.GetSaches();
                if (MessageBox.Show("Xác nhận trả sách??", "Thông báo!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    phieumuonsach mps = bll.GetPhieumuonsaches().FirstOrDefault(s => s.maphieumuon == PMS.maphieumuon);
                    if (mps != null)
                        if (bll.DeletePhieuMuonSach(PMS.maphieumuon) == 1)
                        {
                            Sach TraSach = bll.GetSaches().FirstOrDefault(s => s.masach == PMS.masach);
                            TraSach.soluong = TraSach.soluong + 1;
                            bll.Save();
                            TraSachForm_Load(sender, e);
                            MessageBox.Show("Đã trả sách!", "Thông báo!", MessageBoxButtons.OK);
                        }
                    else
                    {
                        MessageBox.Show("Không tìm thấy Thông tin!", "Thông báo!", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTSKiemTra_Click(object sender, EventArgs e)
        {
            List<phieumuonsach> dg = bll.GetPhieumuonsaches();
            dgvTraSach.Rows.Clear();
            foreach(var item in dg)
            {
                if(item.madocgia == Convert.ToInt32(txtTSMaDocGia.Text))
                {
                    int i = dgvTraSach.Rows.Add();
                    dgvTraSach.Rows[i].Cells[0].Value = item.maphieumuon;
                    dgvTraSach.Rows[i].Cells[1].Value = item.masach;
                    dgvTraSach.Rows[i].Cells[2].Value = item.madocgia;
                    dgvTraSach.Rows[i].Cells[3].Value = item.ngaymuon;
                    dgvTraSach.Rows[i].Cells[4].Value = item.ngaytra;
                }
            }
        }
    }
}
