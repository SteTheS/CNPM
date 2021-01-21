using QuanLyThuVien.BLL;
using QuanLyThuVien.DAL;
using QuanLyThuVien.DAL.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Timers;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.GUI
{
    public partial class DocGiaForm : Form
    {
        public DocGiaForm()
        {
            InitializeComponent();
        }
        
        QLTVbll bll = new QLTVbll();


        private void btnDGTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DocGiaForm_Load(object sender, EventArgs e)
        {
            List<DocGia> listDocGia = bll.GetDocGias();
            dgvDocGia.Rows.Clear();
            foreach (var item in listDocGia)
            {
                int i = dgvDocGia.Rows.Add();
                dgvDocGia.Rows[i].Cells[0].Value = item.madocgia;
                dgvDocGia.Rows[i].Cells[1].Value = item.tendocgia;
                dgvDocGia.Rows[i].Cells[2].Value = item.ngaysinh;
                dgvDocGia.Rows[i].Cells[3].Value = item.diachi;
                dgvDocGia.Rows[i].Cells[4].Value = item.sdt;
                dgvDocGia.Rows[i].Cells[5].Value = item.cmnd;
            }


        }

        private void re()
        {
            txtDGMa.Text = "";
            txtDGTen.Text = "";
            dtPick.Text = "";
            txtDGDiaChi.Text = "";
            txtDGSDT.Text = "";
            txtDGCMND.Text = "";
        }

        private void dgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) ;
            else
            {
                txtDGMa.Text = dgvDocGia.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtDGTen.Text = dgvDocGia.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtPick.Text = dgvDocGia.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDGDiaChi.Text = dgvDocGia.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDGSDT.Text = dgvDocGia.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtDGCMND.Text = dgvDocGia.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void btnDGKiemTra_Click(object sender, EventArgs e)
        {
            List<DocGia> listDocGia = bll.GetDocGias();
            dgvDocGia.Rows.Clear();
            foreach(var item in listDocGia)
            {
                if(item.tendocgia.ToLower() == txtDGTen.Text.ToLower())
                {
                    int i = dgvDocGia.Rows.Add();
                    dgvDocGia.Rows[i].Cells[0].Value = item.madocgia;
                    dgvDocGia.Rows[i].Cells[1].Value = item.tendocgia;
                    dgvDocGia.Rows[i].Cells[2].Value = item.ngaysinh;
                    dgvDocGia.Rows[i].Cells[3].Value = item.diachi;
                    dgvDocGia.Rows[i].Cells[4].Value = item.sdt;
                    dgvDocGia.Rows[i].Cells[5].Value = item.cmnd;
                }
            }
        }

        private void btnDGThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDGTen.Text == "" || dtPick.Text == "" || txtDGSDT.Text == "" || txtDGCMND.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!!");
                List<DocGia> listDocGia = bll.GetDocGias();
                DocGia dg = new DocGia()
                {
                    tendocgia = txtDGTen.Text,
                    ngaysinh = dtPick.Value.Date,
                    diachi = txtDGDiaChi.Text,
                    sdt = txtDGSDT.Text,
                    cmnd = txtDGCMND.Text
                };
                
                
                if(bll.CheckDocGia(dg) == null)
                {
                    if (txtDGSDT.TextLength != 10)
                        throw new Exception("Vui lòng kiểm tra lại số điện thoại!!");
                    else if (txtDGCMND.TextLength != 9)
                        throw new Exception("Vui lòng kiểm tra lại CMND!");
                    else
                    {
                        foreach (var item in listDocGia)
                        {
                            int i = 1;
                            if (i == item.madocgia)
                                i++;
                            else
                            {
                                dg.madocgia = i;
                                break;
                            }
                        }
                        bll.AddDocGia(dg);
                        DocGiaForm_Load(sender, e);
                        MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo!", MessageBoxButtons.OK);
                    }
                    }
                else
                {
                    MessageBox.Show("Thông tin đọc giả đã tồn tại!!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Refresh();
            re();
        }

        private void btnDGSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDGTen.Text == "" || txtDGSDT.Text == "" || txtDGCMND.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!!");
                List<DocGia> listGocGia = bll.GetDocGias();
                DocGia dg = new DocGia()
                {
                    madocgia = Convert.ToInt32(txtDGMa.Text),
                    tendocgia = txtDGTen.Text,
                    ngaysinh = dtPick.Value.Date,
                    diachi = txtDGDiaChi.Text,
                    sdt = txtDGSDT.Text,
                    cmnd = txtDGCMND.Text
                };
                
                if (bll.CheckDocGia(dg) != null)
                {
                    if (txtDGSDT.TextLength != 10)
                        throw new Exception("Vui lòng kiểm tra lại Số điện thoại!");
                    else if (txtDGCMND.TextLength != 9)
                        throw new Exception("Vui lòng kiểm tra lại CMND!");
                    else
                    {
                        bll.UpdateDocGia(dg);
                        DocGiaForm_Load(sender, e);
                        MessageBox.Show("Thay đổi thông tin thành công!", "Thông báo!", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin đọc giả!!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDGXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDGTen.Text == "" || dtPick.Text == "" || txtDGSDT.Text == "" || txtDGCMND.Text == "")
                    throw new Exception("Vui lòng kiểm tra lại!");
                List<DocGia> listDocGia = bll.GetDocGias();
                if (MessageBox.Show("Bạn có thực sự muốn xóa đọc giả này hay không?", "Thông báo!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (bll.DeleteDocGia(Convert.ToInt32(txtDGMa.Text)) == 1)
                    {
                        DocGiaForm_Load(sender, e);
                        MessageBox.Show("Xóa đọc giả thành công!", "Thông báo!", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy đọc giả cần xóa!", "Thông báo!", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            re();
        }

        private void txtDGSDT_KeyDown(object sender, KeyEventArgs e)
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

        private void txtDGCMND_KeyDown(object sender, KeyEventArgs e)
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
