using QuanLyThuVien.BLL;
using System;
using System.Threading;
using System.Windows.Forms;

namespace QuanLyThuVien.GUI
{
    public partial class MainForm : Form
    {
        private QLTVbll bll = new QLTVbll();
        private string s;

        public string S { get => s; set => s = value; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (s == "admin")
                nhânViênToolStripMenuItem.Visible = true;
            else
                nhânViênToolStripMenuItem.Visible = false;
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }
    }
}