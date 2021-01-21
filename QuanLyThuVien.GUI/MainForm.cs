using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void đọcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocGiaForm f = new DocGiaForm();
            f.Show();
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SachForm f = new SachForm();
            f.Show();
        }

        private void mượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuonSachForm f = new MuonSachForm();
            f.Show();
        }

        private void trảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraSachForm f = new TraSachForm();
            f.Show();
        }

        private void ShowLogin()
        {
            LoginForm l = new LoginForm();
            l.ShowDialog();
        }

        private void đăngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowLogin));
            thread.Start();
            this.Close();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVienForm f = new NhanVienForm();
            f.Show();
        }
    }
}
