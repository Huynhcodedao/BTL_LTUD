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
    public partial class QLlop : Form
    {
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
        public QLlop()
        {
            InitializeComponent(); CenterToScreen();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Load22()
        {
            DataTable sqlDt5 = new DataTable();
            dataGridView_lop.DataSource = sqlDt5;
        }

        private void KhoaUpload()
        {
            dataGridView_lop.DataSource = null;
            dataGridView_lop.Rows.Clear();
            Load22();
            sqlConn.ConnectionString = "server=" + server + ";" + "username=" + username + ";" + "password=" + password + ";" + "database=" + database;
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "select * from lop";
            sqlDd = sqlCmd.ExecuteReader();
            sqlDt.Load(sqlDd);
            sqlDd.Close();
            sqlConn.Close();
            dataGridView_lop.DataSource = sqlDt;
        }

        private void lop_Load(object sender, EventArgs e)
        {
            KhoaUpload();
            // Kết nối đến cơ sở dữ liệu
            sqlConn.ConnectionString = "server=" + server + ";username=" + username + ";password=" + password + ";database=" + database;
            try
            {
                sqlConn.Open();
                // Truy vấn SQL để lấy dữ liệu từ cơ sở dữ liệu
                string sqlQuery = "SELECT TenKhoa FROM khoa";

                MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                MySqlDataReader sqlReader = sqlCmd.ExecuteReader();

                // Xóa các mục có sẵn trong comboBox_tenK_k
                comboBox_tenK_k.Items.Clear();

                // Đọc dữ liệu từ cơ sở dữ liệu và thêm vào comboBox_tenK_k
                while (sqlReader.Read())
                {
                    comboBox_tenK_k.Items.Add(sqlReader["TenKhoa"].ToString());
                }

                // Đóng kết nối
                sqlReader.Close();
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

        private void btnThemttLop_Click(object sender, EventArgs e)
        {
         
  
            // Kiểm tra xem tất cả các ô đã được điền thông tin hay không
            if (!string.IsNullOrEmpty(textBox_malop_l.Text) &&
                !string.IsNullOrEmpty(textBox_tenlop_l.Text) &&
                !string.IsNullOrEmpty(textBox_khoahoc_l.Text) &&
                comboBox_tenK_k.SelectedItem != null)
            {
                // Khai báo biến lưu trữ mã khoa
                string maKhoa = "";

                // Lấy tên khoa được chọn từ comboBox_tenK_k
                string tenKhoa = comboBox_tenK_k.SelectedItem.ToString();

                // Kết nối đến cơ sở dữ liệu
                sqlConn.ConnectionString = "server=" + server + ";username=" + username + ";password=" + password + ";database=" + database;
                try
                {
                    sqlConn.Open();
                    // Truy vấn SQL để lấy mã khoa từ tên khoa
                    string sqlQuery = "SELECT MaKhoa FROM khoa WHERE TenKhoa = @TenKhoa";

                    MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                    sqlCmd.Parameters.AddWithValue("@TenKhoa", tenKhoa);
                    maKhoa = sqlCmd.ExecuteScalar().ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlConn.Close();
                }

              

                sqlConn.ConnectionString = "server=" + server + ";" + "username=" + username + ";" + "password=" + password + ";" + "database=" + database;
                try
                {
                    sqlConn.Open();
                    string sqlQuery = "INSERT INTO lop(MaLop, MaKhoa, TenLop, KhoaHoc) VALUES('" + textBox_malop_l.Text + "','" + maKhoa + "','" + textBox_tenlop_l.Text + "','" + textBox_khoahoc_l.Text + "')";

                    MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Student Management System Update");
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
                MessageBox.Show("Vui lòng điền đầy đủ thông tin cho tất cả các ô.");
            }

            KhoaUpload();

        }

        private void btnCapnhatTTlop_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem tất cả các ô đã được điền thông tin hay không
            if (!string.IsNullOrEmpty(textBox_malop_l.Text) &&
                !string.IsNullOrEmpty(textBox_tenlop_l.Text) &&
                !string.IsNullOrEmpty(textBox_khoahoc_l.Text) &&
                comboBox_tenK_k.SelectedItem != null)
            {
                // Khai báo biến lưu trữ mã khoa
                string maKhoa = "";

                // Lấy tên khoa được chọn từ comboBox_tenK_k
                string tenKhoa = comboBox_tenK_k.SelectedItem.ToString();

                // Kết nối đến cơ sở dữ liệu để lấy mã khoa từ tên khoa
                sqlConn.ConnectionString = "server=" + server + ";username=" + username + ";password=" + password + ";database=" + database;
                try
                {
                    sqlConn.Open();
                    string sqlQuery = "SELECT MaKhoa FROM khoa WHERE TenKhoa = @TenKhoa";

                    MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                    sqlCmd.Parameters.AddWithValue("@TenKhoa", tenKhoa);
                    maKhoa = sqlCmd.ExecuteScalar()?.ToString(); // Sử dụng ?.ToString() để tránh lỗi NullReferenceException
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return; // Thoát khỏi hàm nếu có lỗi
                }
                finally
                {
                    sqlConn.Close();
                }

                // Nếu mã khoa không tồn tại, hiển thị thông báo và thoát khỏi hàm
                if (string.IsNullOrEmpty(maKhoa))
                {
                    MessageBox.Show("Không tìm thấy mã khoa cho tên khoa đã chọn.");
                    return;
                }

                // Kết nối đến cơ sở dữ liệu để thực hiện cập nhật hoặc thêm mới dữ liệu
                try
                {
                    sqlConn.Open();
                    string sqlQuery = "SELECT COUNT(*) FROM lop WHERE MaLop = @MaLop";

                    // Kiểm tra xem mã lớp đã tồn tại hay chưa
                    MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                    sqlCmd.Parameters.AddWithValue("@MaLop", textBox_malop_l.Text);
                    int count = Convert.ToInt32(sqlCmd.ExecuteScalar());

                    // Nếu mã lớp đã tồn tại, thực hiện cập nhật; ngược lại, thực hiện thêm mới
                    if (count > 0)
                    {
                        sqlQuery = "UPDATE lop SET MaKhoa = @MaKhoa, TenLop = @TenLop, KhoaHoc = @KhoaHoc WHERE MaLop = @MaLop";
                    }
                    else
                    {
                        sqlQuery = "INSERT INTO lop(MaLop, MaKhoa, TenLop, KhoaHoc) VALUES(@MaLop, @MaKhoa, @TenLop, @KhoaHoc)";
                    }

                    // Thực hiện truy vấn SQL
                    sqlCmd.CommandText = sqlQuery;
                    sqlCmd.Parameters.AddWithValue("@MaKhoa", maKhoa);
                    sqlCmd.Parameters.AddWithValue("@TenLop", textBox_tenlop_l.Text);
                    sqlCmd.Parameters.AddWithValue("@KhoaHoc", textBox_khoahoc_l.Text);
                    sqlCmd.ExecuteNonQuery();

                    MessageBox.Show("Cập nhật thông tin lớp thành công.");
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
                MessageBox.Show("Vui lòng điền đầy đủ thông tin cho tất cả các ô.");
            }

            // Sau khi cập nhật, cập nhật lại dữ liệu trên giao diện
            KhoaUpload();

        }

        private void btnXoattlop_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem tất cả các ô đã được điền thông tin hay không
            if (!string.IsNullOrEmpty(textBox_malop_l.Text))
            {
                // Kết nối đến cơ sở dữ liệu
                sqlConn.ConnectionString = "server=" + server + ";username=" + username + ";password=" + password + ";database=" + database;
                try
                {
                    sqlConn.Open();

                    // Truy vấn SQL để xóa dữ liệu lớp dựa trên mã lớp
                    string sqlQuery = "DELETE FROM lop WHERE MaLop = @MaLop";

                    MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                    sqlCmd.Parameters.AddWithValue("@MaLop", textBox_malop_l.Text);
                    int rowsAffected = sqlCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đã xóa thông tin lớp thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin lớp để xóa.");
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
                MessageBox.Show("Vui lòng nhập mã lớp cần xóa.");
            }
            dataGridView_lop.DataSource = null;
            dataGridView_lop.Rows.Clear();

            // Sau khi xóa, cập nhật lại dữ liệu trên giao diện
            KhoaUpload();

        }

        private void btnResetTTlop_Click(object sender, EventArgs e)
        {
            textBox_khoahoc_l.Text = "";
            textBox_malop_l.Text = "";
            textBox_tenlop_l.Text = "";
            comboBox_tenK_k.Text = "";
        }

        private void comboBox_tenK_k_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            QLkhoa form1 = new QLkhoa();
            // Hiển thị form mới
            form1.Show();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            QLgiangvien form1 = new QLgiangvien();
            // Hiển thị form mới
            form1.Show();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            QLmonhoc form1 = new QLmonhoc();
            // Hiển thị form mới
            form1.Show();
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            QLsinhvien form1 = new QLsinhvien();
            // Hiển thị form mới
            form1.Show();
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            QLdiem form1 = new QLdiem();
            // Hiển thị form mới
            form1.Show();
            this.Close();
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
            QLThongKe form1 = new QLThongKe();
            // Hiển thị form mới
            form1.Show(); this.Close();
        }
    }
}
