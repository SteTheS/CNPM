using QuanLyThuVien.BLL;
using QuanLyThuVien.DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace QuanLyThuVien.GUI
{
    public partial class LoginForm : Form
    {
        private int s;
        private QLTVbll bll = new QLTVbll();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void ShowMainForm()
        {
            MainForm m = new MainForm();
            m.S = txtLoginAcc.Text;
            m.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ////txtLoginAcc.Text = "002";
            //txtLoginPass.Text = "12345";
            QuanLyThuVienbd db = new QuanLyThuVienbd();
            List<NhanVien> listNhanVien = bll.GetNhanViens();

            NhanVien nv = db.NhanViens.FirstOrDefault(a => a.manhanvien == txtLoginAcc.Text);
            try
            {
                if (txtLoginAcc.Text == "")
                    throw new Exception("Vui lòng kiểm tra lại thông tin!!");
                else
                {
                    if (txtLoginPass.Text == "")
                        txtLoginPass.Focus();
                    else if (nv != null)
                    {
                        if (nv.matkhau == txtLoginPass.Text)
                        {
                            Thread thread = new Thread(new ThreadStart(ShowMainForm));
                            thread.SetApartmentState(ApartmentState.STA);
                            thread.Start();
                            this.Close();
                            return;
                        }

                        MessageBox.Show("Bạn đã nhập sai mật khẩu!", "Thông báo!", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Bạn đã nhập sai mã nhân viên. Vui lòng nhập lại!", "Thông báo!", MessageBoxButtons.OK);
                        txtLoginAcc.Text = "";
                        txtLoginPass.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }
    }
}