using QuanLyThuVien.DAL.Database;
using QuanLyThuVien.DAL;
using QuanLyThuVien.BLL;
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
    public partial class MuonSachForm : Form
    {
        int sla = 0;
        QLTVbll bll = new QLTVbll();
        public MuonSachForm()
        {
            InitializeComponent();
        }

        private void btnMSTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MuonSachForm_Load(object sender, EventArgs e)
        {
            List<Sach> listSach = bll.GetSaches();
            dgvMuonSach.Rows.Clear();
            foreach (var item in listSach)
            {
                int i = dgvMuonSach.Rows.Add();
                dgvMuonSach.Rows[i].Cells[0].Value = item.masach;
                dgvMuonSach.Rows[i].Cells[1].Value = item.tensach;
                dgvMuonSach.Rows[i].Cells[2].Value = item.namxuatban;
                dgvMuonSach.Rows[i].Cells[3].Value = item.theloai;
                dgvMuonSach.Rows[i].Cells[4].Value = item.tacgia;
                dgvMuonSach.Rows[i].Cells[5].Value = item.nxb;
                dgvMuonSach.Rows[i].Cells[6].Value = item.soluong;
            }
        }

        private void btnMSKiemTra_Click(object sender, EventArgs e)
        {
            List<Sach> listSach = bll.GetSaches();
            dgvMuonSach.Rows.Clear();
            foreach (var item in listSach)
            {
                if (txtMSTenSach.Text == item.tensach)
                {
                    int i = dgvMuonSach.Rows.Add();
                    dgvMuonSach.Rows[i].Cells[0].Value = item.masach;
                    dgvMuonSach.Rows[i].Cells[1].Value = item.tensach;
                    dgvMuonSach.Rows[i].Cells[2].Value = item.namxuatban;
                    dgvMuonSach.Rows[i].Cells[3].Value = item.theloai;
                    dgvMuonSach.Rows[i].Cells[4].Value = item.tacgia;
                    dgvMuonSach.Rows[i].Cells[5].Value = item.nxb;
                    dgvMuonSach.Rows[i].Cells[6].Value = item.soluong;
                }
            }
        }

        private void dgvMuonSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<phieumuonsach> listPhieuMuonSach = bll.GetPhieumuonsaches();
            if (e.RowIndex < 0) ;
            else
            {
                sla = Convert.ToInt32(dgvMuonSach.Rows[e.RowIndex].Cells[6].Value.ToString());
                txtMSMaSach.Text = dgvMuonSach.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtMSTenSach.Text = dgvMuonSach.Rows[e.RowIndex].Cells[1].Value.ToString();
            }

            //cái này để tạm thế chứ giờ hết ý tưởng sửa r
        }
        private int generateMPM (int mpm)
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

        private void btnMSMuonSach_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMSMaSach.Text == "" || txtMSMaDocGia.Text == "" || txtMSTenSach.Text == "")
                    throw new Exception("Nhập thiếu thông tin, vui lòng kiểm tra lại!!");
                if (sla <= 0)
                    MessageBox.Show("Đã hết sách!!", "Thông báo!", MessageBoxButtons.OK);
                else
                {
                    Sach f = bll.GetSaches().FirstOrDefault(s => s.soluong > 0 && s.masach == txtMSMaSach.Text);
                    if (f != null)
                    {

                        List<Sach> listSach = bll.GetSaches();
                        List<phieumuonsach> listPhieuMuonSach = bll.GetPhieumuonsaches();

                        int te = Convert.ToInt32(txtMSMaDocGia.Text);
                        phieumuonsach tepm = bll.GetPhieumuonsaches().FirstOrDefault(s => s.madocgia == te);
                        if (tepm == null)
                            throw new Exception("Vui lòng kiểm tra lại mã đọc giả!!");



                        
                        phieumuonsach m = new phieumuonsach()
                        {
                            maphieumuon = generateMPM(0),
                            masach = txtMSMaSach.Text,
                            madocgia = Convert.ToInt32(txtMSMaDocGia.Text),
                            ngaymuon = datePickRent.Value.Date,
                            ngaytra = datePickReturn.Value.Date,
                         };
                         if (bll.CheckPhieuMuonSach(m) == null)
                         {
                            Sach sachSL = bll.GetSaches().FirstOrDefault(s => s.masach == txtMSMaSach.Text);

                            sachSL.soluong = sachSL.soluong - 1;
                            bll.AddPhieuMuonSach(m);
                            bll.Save();
                            MuonSachForm_Load(sender, e);
                            MessageBox.Show("Mượn sách thành công!", "Thông báo!", MessageBoxButtons.OK);
                         }
                         else
                         {
                            MessageBox.Show("Đã xảy ra lỗi, vui lòng kiểm tra lại!", "Thông báo!", MessageBoxButtons.OK);
                         }
                        
                    }
                
                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtMSMaDocGia_KeyDown(object sender, KeyEventArgs e)
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
