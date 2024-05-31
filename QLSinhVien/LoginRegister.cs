using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Math.Field;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace QLSinhVien
{
 

    public partial class LoginRegister : Form
    {
        // Mã OTP ngẫu nhiên
        private string GenerateOTP()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }
        private string GenerateToken(int length = 16)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        // Gửi mã OTP qua email
        private void SendOTP(string emailAddress, string otp)
        {
            try
            {
                // Tạo link xác thực
                string verifyLink = "https://yourwebsite.com/verify?token=" + GenerateToken(); // Thay thế "yourwebsite.com" bằng địa chỉ website của bạn và hàm GenerateToken() để tạo token duy nhất

                // Tạo mã OTP
                string otp1 = GenerateOTP(); // Thay thế GenerateOTP() bằng hàm tạo mã OTP của bạn

                // Tạo email
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("huynhpro1709@gmail.com");
                mail.To.Add(emailAddress);
                mail.Subject = "Xác thực tài khoản người dùng";
                mail.Body = $"Mã OTP của bạn là: {otp}";

                SmtpServer.Port = 587;
                SmtpServer.EnableSsl = true;
                SmtpServer.Credentials = new System.Net.NetworkCredential("huynhpro1709@gmail.com", "uqqn xsio sqdp psrq");

                // Gửi email
                SmtpServer.Send(mail);
                MessageBox.Show("Mã OTP đã được gửi tới địa chỉ "+Email +".", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình gửi email: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        MySqlConnection sqlConn = new MySqlConnection();
        MySqlCommand sqlCmd = new MySqlCommand();
        DataTable sqlDt = new DataTable();
        MySqlDataAdapter sqlDta = new MySqlDataAdapter();
        MySqlDataReader sqlDd;
        DataSet DS = new DataSet();

        string sqlQuery;

        string server = "localhost";
        string username = "root";
        string password = "123456789";
        string database = "student";
        MySqlConnection sqlConn1 = new MySqlConnection();
        MySqlCommand sqlCmd1 = new MySqlCommand();
        DataTable sqlDt1 = new DataTable();
        MySqlDataAdapter sqlDta1 = new MySqlDataAdapter();
        MySqlDataReader sqlDd1;
        DataSet DS1 = new DataSet();
        public LoginRegister()
        {
            InitializeComponent();
            CenterToScreen ();
        }

        private void LoginRegister_Load(object sender, EventArgs e)
        {
            lbotp.Visible = false;
            txtOTP.Visible = false;
            pnload.Height = 0;
            timerLoad.Start ();
            
        }

   


        private void button1_Click(object sender, EventArgs e)
        {

           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to cancel", "Student Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            lbotp.Visible = false;
            txtOTP.Visible = false;
           
        }
        public string otp ;
        public string fullname;
        private void btnLogin_Click(object sender, EventArgs e)

        {
            groupBox2.Visible = false;
            groupBox1.Visible = true;
            txtOTP.Visible=false;
            lbotp.Visible=false;
            btnXacnhan.Visible=false;
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }
            string selected = Cbluachon.SelectedItem.ToString();
            //xuwr ly dang nhap
            if (selected == "Người quản lý")
            {
                
                sqlConn.ConnectionString = "server=" + server + ";" + "username=" + username + ";" + "password=" + password + ";" + "database=" + database;
                try
                {
                    sqlConn.Open();


                    // Xây dựng câu truy vấn kiểm tra tài khoản
                    string sqlQuery = "SELECT COUNT(*) FROM quanly WHERE username = @Username AND password = @Password";

                    MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                    sqlCmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                    sqlCmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                    // Thực thi câu truy vấn
                    int count = Convert.ToInt32(sqlCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        QLMenu form1 = new QLMenu();
                        // Hiển thị form mới
                        form1.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlConn.Close();
                }
            }
            else
            {

                
                sqlConn.ConnectionString = "server=" + server + ";" + "username=" + username + ";" + "password=" + password + ";" + "database=" + database;
                try
                {
                    sqlConn.Open();


                    // Xây dựng câu truy vấn kiểm tra tài khoản
                    string sqlQuery = "SELECT COUNT(*) FROM account WHERE username = @Username AND password = @Password";

                    MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                    sqlCmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                    sqlCmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                   
                    // Thực thi câu truy vấn
                    int count = Convert.ToInt32(sqlCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        sqlQuery = "SELECT Fullname FROM account WHERE username = @Username";

                        sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                        sqlCmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                        object result = sqlCmd.ExecuteScalar();
                       
                            fullname = result.ToString();
                            // guiew du lieu den form nguoidung
                            string masv = txtUsername.Text;

                        SVThongBaoNguoiDung form2 = new SVThongBaoNguoiDung(fullname, masv);
                        form2.Show();
                        this.Hide();
                    
                }
                    else
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlConn.Close();
                }
            }

        }

        private void linklogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }

        private void btnthoat2_Click(object sender, EventArgs e)
        {
           
        }
        public String Email;
        private void btnSignup_Click(object sender, EventArgs e)
        {



            // Kiểm tra xem các ô có được điền đầy đủ không
            if (string.IsNullOrEmpty(txtFullname.Text) || string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtUsernameDangky.Text) || string.IsNullOrEmpty(txtPassdangky.Text) || string.IsNullOrEmpty(txtComfirm.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            // Kiểm tra xem mật khẩu và xác nhận mật khẩu có trùng nhau không
            if (txtPassdangky.Text != txtComfirm.Text)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp.");
                return;
            }

            sqlConn.ConnectionString = "server=" + server + ";" + "username=" + username + ";" + "password=" + password + ";" + "database=" + database;
            try
            {
                
                //Kiem tra xem ten dang nhap có phai la sinh vien
                sqlConn.Open();
                string maSV = txtUsernameDangky.Text;
                string checkQuery = "SELECT COUNT(*) FROM sinhvien WHERE MaSV = @MaSV";

                MySqlCommand checkCmd = new MySqlCommand(checkQuery, sqlConn);
                checkCmd.Parameters.AddWithValue("@MaSV", maSV);
                int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                if (count == 0)
                {
                    MessageBox.Show("Tên đăng nhập phải là mã sinh viên của bạn.");
                    return;
                }
                else
                {
                    groupBox2.Visible = false;
                    groupBox1.Visible = false;
                    txtOTP.Visible = true;
                    lbotp.Visible = true;
                    btnXacnhan.Visible = true;
                    Email = txtUsernameDangky.Text + "@vnu.edu.vn";
                    otp = GenerateOTP();
                    if (!string.IsNullOrEmpty(Email))
                    {
                        SendOTP(Email, otp);
                    }
                    // Nếu các điều kiện đều đúng, thực hiện lệnh INSERT INTO
                    string sqlQuery = "INSERT INTO temp_account(Email, Fullname, Phone, Username, Password, OTP) VALUES('" + Email + "','" + txtFullname.Text + "','" + txtPhone.Text + "','" + txtUsernameDangky.Text + "','" + txtPassdangky.Text + "','" + otp + "')";

                    MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                    sqlCmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
        }
        public string email11;
        public string fullname11;
        public string phone11;
        public string username11;
        public string password11;
        private void txtOTP_TextChanged(object sender, EventArgs e)
        {
          
       
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        { 
                 string otpNhan = txtOTP.Text;
            // Thực hiện thêm dữ liệu vào bảng account từ bảng temp_account
            sqlConn.ConnectionString = "server=" + server + ";" + "username=" + username + ";" + "password=" + password + ";" + "database=" + database;
            try
            {
                sqlConn.Open();

                // Nếu các điều kiện đều đúng và OTP nhập vào trùng với OTP đã nhận được
                if (otpNhan == otp)
                {
                    groupBox2.Visible = false;
                    groupBox1.Visible = true;
                    txtOTP.Visible = false;
                    lbotp.Visible = false;
                    btnXacnhan.Visible = false;

                    // Thực hiện truy vấn để lấy dữ liệu từ bảng temp_account
                    string sqlQuery = "SELECT Email, Fullname, Phone, Username, Password FROM temp_account WHERE OTP = @OTP";

                    MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                    sqlCmd.Parameters.AddWithValue("@OTP", otp);

                    MySqlDataReader reader = sqlCmd.ExecuteReader();

                    // Kiểm tra xem có dữ liệu trả về từ temp_account không
                    if (reader.Read())
                    {
                        // Lấy dữ liệu từ cột và gán vào các biến
                        email11 = reader["Email"].ToString();
                        fullname11 = reader["Fullname"].ToString();
                        phone11 = reader["Phone"].ToString();
                        username11 = reader["Username"].ToString();
                        password11 = reader["Password"].ToString();

                        reader.Close();

                        // Thêm dữ liệu từ temp_account vào bảng account
                        string insertQuery = "INSERT INTO account(Email, Fullname, Phone, Username, Password) VALUES('" + email11 + "','" + fullname11 + "','" + phone11 + "','" + username11 + "','" + password11 + "')";

                        MySqlCommand insertCmd = new MySqlCommand(insertQuery, sqlConn);
                        insertCmd.ExecuteNonQuery();

                        // Hiển thị thông báo khi tạo tài khoản thành công
                        MessageBox.Show("Tạo tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu phù hợp với OTP đã cho.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //xóa dữ liệu trong bộ nhớ tạm
                    // Kết nối đến cơ sở dữ liệu
                    sqlConn1.ConnectionString = "server=" + server + ";" + "username=" + username + ";" + "password=" + password + ";" + "database=" + database;

                    try
                    {
                        sqlConn1.Open();

                        // Truy vấn SQL để xóa hết dữ liệu trong bảng
                        string sqlQuery1 = "TRUNCATE TABLE temp_account";

                        MySqlCommand sqlCmd1 = new MySqlCommand(sqlQuery1, sqlConn1);
                        sqlCmd1.ExecuteNonQuery();

                        Console.WriteLine("Đã xóa hết dữ liệu trong bảng temp_account.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi: " + ex.Message);
                    }
                    finally
                    {
                        sqlConn1.Close();
                    }
                }

                else
                {
                    MessageBox.Show("Không có dữ liệu phù hợp với OTP đã cho.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConn.Close();
            }

        }

        private void Cbluachon_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
        bool menuExpand = false;
        private void timerLoad_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                pnload.Height += 1;
                if (pnload.Height >= 110)
                {
                    timerLoad.Stop();
                    //menuExpand = true;
                }
            }
            else
            {
                pnload.Height -= 10;
                if (pnload.Height <= 0)
                {
                    timerLoad.Stop();
                    menuExpand = false;
                }
            }
        }

        private void pnload_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
