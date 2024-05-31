using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVien
{
    public partial class SVThongBaoNguoiDung : Form
    {
        private string fullname;
        private string masv;
        public SVThongBaoNguoiDung(string fullname, string masv)
        {
            InitializeComponent();
            CenterToScreen();
            this.fullname = fullname;
            this.masv = masv;
        }
        private void ThongBaoNguoiDung_Load(object sender, EventArgs e)
        {
            lbTen.Text = fullname;
            lbMsv1.Text = masv;
        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
            string fullname123 = lbTen.Text;
            string masv = lbMsv1.Text;
            SVnguoidung form2 = new SVnguoidung(fullname123, masv);
            form2.Show(); this.Close();
        }

        private void btnPhantich_Click(object sender, EventArgs e)
        {
            string fullname123 = lbTen.Text;
            string masv = lbMsv1.Text;
            SVanalysisSV form2 = new SVanalysisSV(fullname123, masv);
            form2.Show(); this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fullname123 = lbTen.Text;
            string masv = lbMsv1.Text;
            SVThongTinCaNhan form2 = new SVThongTinCaNhan(fullname123, masv);
            form2.Show(); this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to cancel", "Student Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                LoginRegister form1 = new LoginRegister();
                // Hiển thị form mới
                form1.Show();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fullname123 = lbTen.Text;
            string masv = lbMsv1.Text;
            SVDangKyHoc form2 = new SVDangKyHoc(fullname123, masv);
            form2.Show(); this.Close();
        }
    }
}
