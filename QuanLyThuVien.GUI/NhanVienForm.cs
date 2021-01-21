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
    public partial class NhanVienForm : Form
    {
        public NhanVienForm()
        {
            InitializeComponent();
        }

        QLTVbll bll = new QLTVbll();

        private void btnNVTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NhanVienForm_Load(object sender, EventArgs e)
        {
            List<NhanVien> listnhanvien = bll.GetNhanViens();
            dgvNhanVien.Rows.Clear();
            foreach (var item in listnhanvien)
            {
                int i = dgvNhanVien.Rows.Add();
                dgvNhanVien.Rows[i].Cells[0].Value = item.manhanvien;
                dgvNhanVien.Rows[i].Cells[1].Value = item.matkhau;
                dgvNhanVien.Rows[i].Cells[2].Value = item.tennhanvien;
                dgvNhanVien.Rows[i].Cells[3].Value = item.ngaysinh;
                dgvNhanVien.Rows[i].Cells[4].Value = item.diachi;
                dgvNhanVien.Rows[i].Cells[5].Value = item.sdt;
                dgvNhanVien.Rows[i].Cells[6].Value = item.cmnd;
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) ;
            else
            {
                txtNVMa.Text = dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNVMatKhau.Text = dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtNVTen.Text = dgvNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtNVngaysinh.Text = dgvNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtNVDiaChi.Text = dgvNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtNVSDT.Text = dgvNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtNVCMND.Text = dgvNhanVien.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }

        private void abc_KeyDown(object sender, KeyEventArgs e)
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

        private void btnNVKiemTra_Click(object sender, EventArgs e)
        {
            List<NhanVien> listNV = bll.GetNhanViens();
            dgvNhanVien.Rows.Clear();
            foreach (var item in listNV)
                if (item.tennhanvien.ToLower() == txtNVTen.Text.ToLower())
                {
                    int i = dgvNhanVien.Rows.Add();
                    dgvNhanVien.Rows[i].Cells[0].Value = item.manhanvien;
                    dgvNhanVien.Rows[i].Cells[1].Value = item.matkhau;
                    dgvNhanVien.Rows[i].Cells[2].Value = item.tennhanvien;
                    dgvNhanVien.Rows[i].Cells[3].Value = item.ngaysinh;
                    dgvNhanVien.Rows[i].Cells[4].Value = item.diachi;
                    dgvNhanVien.Rows[i].Cells[5].Value = item.sdt;
                    dgvNhanVien.Rows[i].Cells[6].Value = item.cmnd;
                }
        }

        private void btnNVThem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
