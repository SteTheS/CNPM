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
using System.Threading;

namespace QuanLyThuVien.GUI
{
    public partial class LoginForm : Form
    {
        QLTVbll bll = new QLTVbll();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ShowMainForm()
        {
            MainForm m = new MainForm();
            m.ShowDialog();
        }
        


        private void btnLogin_Click(object sender, EventArgs e)
        {
            ////txtLoginAcc.Text = "002";
            //txtLoginPass.Text = "12345";
            List<NhanVien> listNhanVien = bll.GetNhanViens();
            try
            {
                if (txtLoginAcc.Text == "")
                    throw new Exception("Vui lòng kiểm tra lại thông tin!!");
                else
                {
                    if (txtLoginPass.Text == "")
                        txtLoginPass.Focus();
                    else
                    {
                        foreach (var item in listNhanVien)
                        {
                            if (txtLoginPass.Text == item.matkhau)
                            {
                                Thread thread = new Thread(new ThreadStart(ShowMainForm));
                                thread.SetApartmentState(ApartmentState.STA);
                                thread.Start();
                                this.Close();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Bạn đã nhập sai mật khẩu!", "Thông báo!", MessageBoxButtons.OK);
                                return;
                            }
                        }
                        MessageBox.Show("Bạn đã nhập sai mã nhân viên. Vui lòng nhập lại!", "Thông báo!", MessageBoxButtons.OK);
                        txtLoginAcc.Text = "";
                        txtLoginPass.Text = "";
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
