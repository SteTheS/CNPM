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
    public partial class SachForm : Form
    {
        QLTVbll bll = new QLTVbll();
        public SachForm()
        {
            InitializeComponent();
        }

        private void btnSTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SachForm_Load(object sender, EventArgs e)
        {
            List<Sach> listSach = bll.GetSaches();
            dgvSach.Rows.Clear();
            foreach (var item in listSach)
            {
                int i = dgvSach.Rows.Add();
                dgvSach.Rows[i].Cells[0].Value = item.masach;
                dgvSach.Rows[i].Cells[1].Value = item.tensach;
                dgvSach.Rows[i].Cells[2].Value = item.namxuatban;
                dgvSach.Rows[i].Cells[3].Value = item.theloai;
                dgvSach.Rows[i].Cells[4].Value = item.tacgia;
                dgvSach.Rows[i].Cells[5].Value = item.nxb;
                dgvSach.Rows[i].Cells[6].Value = item.soluong;
            }

        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSMaSach.Text = dgvSach.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtSTen.Text = dgvSach.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSNamXuatBan.Text = dgvSach.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSTheLoai.Text = dgvSach.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSTacGia.Text = dgvSach.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtSNXB.Text = dgvSach.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtSSoLuong.Text = dgvSach.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btnSKiemTra_Click(object sender, EventArgs e)
        {
            List<Sach> listSach = bll.GetSaches();
            dgvSach.Rows.Clear();
            foreach(var item in listSach)
            {
                if(item.tensach == txtSTen.Text)
                {
                    int i = dgvSach.Rows.Add();
                    dgvSach.Rows[i].Cells[0].Value = item.masach;
                    dgvSach.Rows[i].Cells[1].Value = item.tensach;
                    dgvSach.Rows[i].Cells[2].Value = item.namxuatban;
                    dgvSach.Rows[i].Cells[3].Value = item.theloai;
                    dgvSach.Rows[i].Cells[4].Value = item.tacgia;
                    dgvSach.Rows[i].Cells[5].Value = item.nxb;
                    dgvSach.Rows[i].Cells[6].Value = item.soluong;
                }
            }
        }

        private int generateMPM(int mpm)
        {
            Random r = new Random();
            List<phieumuonsach> listPhieumuonSach = bll.GetPhieumuonsaches();
            foreach (var item in listPhieumuonSach)
            {
                mpm = r.Next(1000, 9999);
                if (item.maphieumuon != mpm && mpm != 0)
                    break;
            }
            return mpm;
        }

        private void btnSThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtSSoLuong.Text) <= 0)
                    MessageBox.Show("Vui lòng kiểm tra lại số lượng!!", "Thông báo!", MessageBoxButtons.OK);
                else
                {
                    if (txtSTen.Text == "" || txtSNamXuatBan.Text == "" || txtSTheLoai.Text == "" || txtSTacGia.Text == "" || txtSNXB.Text == "" || txtSSoLuong.Text == "")
                        throw new Exception("Vui lòng nhập đầy đủ thông tin sách");
                    List<Sach> listSach = bll.GetSaches();
                    Sach s = new Sach()
                    {
                        masach = generateMPM(0).ToString(),
                        tensach = txtSTen.Text,
                        namxuatban = txtSNamXuatBan.Text,
                        theloai = txtSTheLoai.Text,
                        tacgia = txtSTacGia.Text,
                        nxb = txtSNXB.Text,
                        soluong = Int32.Parse(txtSSoLuong.Text),
                    };



                    if (bll.CheckSach(s) == null)
                    {
                        bll.AddSach(s);
                        SachForm_Load(sender, e);
                        MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo!", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Sách đã có trong thư viện!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSXoa_Click(object sender, EventArgs e)
        {
            try
            {
                List<Sach> listSach = bll.GetSaches();
                if (MessageBox.Show("Bạn có thực sự muốn xóa sách này hay không?", "Thông báo!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (bll.DeleteSach(txtSMaSach.Text) == 1)
                    {
                        SachForm_Load(sender,e);
                        MessageBox.Show("Xóa sách thành công!", "Thông báo!", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy Sách cần xóa!", "Thông báo!", MessageBoxButtons.OK);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtSSoLuong.Text) <= 0)
                    MessageBox.Show("Vui lòng kiểm tra lại số lượng!!", "Thông báo!!", MessageBoxButtons.OK);
                else
                {
                    if (txtSTen.Text == "" || txtSNamXuatBan.Text == "" || txtSTheLoai.Text == "" || txtSTacGia.Text == "" || txtSNXB.Text == "" || txtSSoLuong.Text == "")
                        throw new Exception("Vui lòng nhập đầy đủ thông tin sách");
                    else
                    {
                        List<Sach> listSach = bll.GetSaches();
                        Sach s = new Sach()
                        {
                            masach = txtSMaSach.Text,
                            tensach = txtSTen.Text,
                            namxuatban = txtSNamXuatBan.Text,
                            theloai = txtSTheLoai.Text,
                            tacgia = txtSTacGia.Text,
                            nxb = txtSNXB.Text,
                            soluong = int.Parse(txtSSoLuong.Text),
                        };
                        if (bll.CheckSach(s) == null)
                        {
                            MessageBox.Show("Không tìm thấy sách cần sửa!", "Thông báo", MessageBoxButtons.OK);
                        }
                        else
                        {
                            if (MessageBox.Show("Bạn có chắc là muốn sửa sách không?", "Thông báo !", MessageBoxButtons.OKCancel) == DialogResult.OK)
                            {
                                bll.UpdateSach(s);
                                SachForm_Load(sender, e);
                                MessageBox.Show("Thay đổi thông tin sách thành công!", "Thông báo", MessageBoxButtons.OK);
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSNamXuatBan_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                case Keys.Down:
                case Keys.Left:
                case Keys.Right:
                case Keys.PageUp:
                case Keys.PageDown:
                case Keys.Delete:
                    e.SuppressKeyPress = false;
                    return;
                default:
                    break;
            }

            char currentKey = (char)e.KeyCode;
            bool ctr = e.Control || e.Alt || e.Shift;
            bool nonNumb = char.IsLetter(currentKey) || char.IsSymbol(currentKey) || char.IsWhiteSpace(currentKey) || char.IsPunctuation(currentKey);

            if (!ctr && nonNumb)
                e.SuppressKeyPress = true;

            if (e.Control && e.KeyCode == Keys.V)
            {
                string pastedText = Clipboard.GetText();
                string tempText = "";
                for (int i = 0; i < pastedText.Length; i++)
                {
                    if (char.IsDigit(pastedText[i]))
                        tempText += pastedText[i].ToString();
                }

                if (tempText != pastedText)
                {
                    e.SuppressKeyPress = true;

                    TextBox me = (TextBox)sender;
                    int start = me.SelectionStart;
                    string newTxt = me.Text;
                    newTxt = newTxt.Remove(me.SelectionStart, me.SelectionLength);
                    newTxt = newTxt.Insert(me.SelectionStart, tempText);
                    me.Text = newTxt;
                    me.SelectionStart = start + tempText.Length;
                }
                else
                    e.SuppressKeyPress = false;
            }
        }

       
    }
}
