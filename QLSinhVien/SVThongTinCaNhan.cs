using MySql.Data.MySqlClient;
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
    public partial class SVThongTinCaNhan : Form
    {
        private string fullname;
        private string masv;
        public SVThongTinCaNhan(string fullname, string masv)
        {
            InitializeComponent();
            CenterToScreen();
            this.fullname = fullname;
            this.masv = masv;
        }

        private void ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            lbTen.Text = fullname;
            lbMsv1.Text = masv;
          
                string server = "localhost";
                string username = "root";
                string password = "123456789";
                string database = "student";

                string connectionString = $"Server={server};Database={database};Uid={username};Pwd={password};";
                MySqlConnection connection = new MySqlConnection(connectionString);

                try
                {
                    connection.Open();
                    string sqlQuery = $"SELECT * FROM sinhvien WHERE MaSV = '{masv}'";
                    MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, connection);
                    MySqlDataReader sqlDd = sqlCmd.ExecuteReader();

                    if (sqlDd.Read())
                    {
                        string fullname = sqlDd["HoTen"].ToString();
                        string email = sqlDd["Email"].ToString();
                        string phone = sqlDd["SDT"].ToString();
                        string address = sqlDd["DiaChi"].ToString();
                        DateTime birthDate = (DateTime)sqlDd["NgaySinh"];
                        string classCode = sqlDd["MaLop"].ToString();

                        // Assuming you have labels named lblFullName, lblEmail, lblPhone, lblAddress, lblBirthDate, lblClassCode
                        lbTen.Text = fullname;
                    lbmsvHoSo.Text = "Mã sinh viên" + masv;
                        lbTenHoSo.Text = "Họ và tên: "+fullname;
                        lbEmail.Text = "Thư điện tử: "+email;
                        lbSDT.Text ="Số điện thoại: "+ phone;
                        lbNoiO.Text ="Nơi ở: "+ address;
                        lbNoiSinh.Text ="Nơi sinh: "+ address;
                        lbDiaChi.Text ="Địa chỉ thường trú: "+ address;
                        lbNgaySinh.Text ="Ngày sinh: "+ birthDate.ToString("yyyy-MM-dd"); // Adjust the date format as needed
                       
                    }
                    else
                    {
                        // Handle case where no data is found for the given masv
                        // Maybe display a message indicating no data found
                    }

                    sqlDd.Close();
                }
                catch (MySqlException ex)
                {
                    // Handle any exceptions
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            
        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            string fullname123 = lbTen.Text;
            string masv = lbMsv1.Text;
            SVThongBaoNguoiDung form2 = new SVThongBaoNguoiDung(fullname123, masv);
            form2.Show();
            this.Close();
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

        private void button2_Click(object sender, EventArgs e)
        {

        }
        //dăng ky mon
        private void btnYeucau_Click(object sender, EventArgs e)
        {
            string fullname123 = lbTen.Text;
            string masv = lbMsv1.Text;
            SVDangKyHoc form2 = new SVDangKyHoc(fullname123, masv);
            form2.Show(); this.Close();
        }
    }
}
