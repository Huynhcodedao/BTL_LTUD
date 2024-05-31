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
    public partial class QLgiangvien : Form
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
        public QLgiangvien()
        {
            InitializeComponent(); CenterToScreen();
        }
        private void Load22()
        {
            DataTable sqlDt5 = new DataTable();
           dataGridView_gv.DataSource = sqlDt5;
        }

        private void KhoaUpload()
        {
            dataGridView_gv.DataSource = null;
            dataGridView_gv.Rows.Clear();
            Load22();
            sqlConn.ConnectionString = "server=" + server + ";" + "username=" + username + ";" + "password=" + password + ";" + "database=" + database;
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "select * from giangvien";
            sqlDd = sqlCmd.ExecuteReader();
            sqlDt.Load(sqlDd);
            sqlDd.Close();
            sqlConn.Close();
            dataGridView_gv.DataSource = sqlDt;
        }

        private void giangvien_Load(object sender, EventArgs e)
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
                comboBox_tenKhoa_GV.Items.Clear();
               

                // Đọc dữ liệu từ cơ sở dữ liệu và thêm vào comboBox_tenK_k
                while (sqlReader.Read())
                {
                    comboBox_tenKhoa_GV.Items.Add(sqlReader["TenKhoa"].ToString());
      
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
            // Kết nối đến cơ sở dữ liệu
            sqlConn.ConnectionString = "server=" + server + ";username=" + username + ";password=" + password + ";database=" + database;
            try
            {
                sqlConn.Open();
                // Truy vấn SQL để lấy dữ liệu từ cơ sở dữ liệu
                string sqlQuery = "SELECT TenMon from monhoc";

                MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                MySqlDataReader sqlReader = sqlCmd.ExecuteReader();

                // Xóa các mục có sẵn trong comboBox_tenK_k
              comboBox_mhGV.Items.Clear();


                // Đọc dữ liệu từ cơ sở dữ liệu và thêm vào comboBox_tenK_k
                while (sqlReader.Read())
                {
                    comboBox_mhGV.Items.Add(sqlReader["TenMon"].ToString());

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

        private void btnThemGiangvien_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem tất cả các ô đã được điền thông tin hay không
            if (!string.IsNullOrEmpty(textBox_magv.Text) && !string.IsNullOrEmpty(textBox_hotenGV.Text) &&
                !string.IsNullOrEmpty(textBox_dcGV.Text) && !string.IsNullOrEmpty(textBox_sdtGV.Text) &&
                comboBox_tenKhoa_GV.SelectedItem != null && comboBox_mhGV.SelectedItem != null)
            {
                // Khai báo biến lưu trữ mã khoa
                string maKhoa = "";

                // Lấy tên khoa được chọn từ comboBox_tenK_k
                string tenKhoa = comboBox_tenKhoa_GV.SelectedItem.ToString();

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
                // Khai báo biến lưu trữ mã môn
                string maMon = "";

                // Lấy tên khoa được chọn từ comboBox_tenK_k
                string tenMon = comboBox_mhGV.SelectedItem.ToString();

                // Kết nối đến cơ sở dữ liệu
                sqlConn.ConnectionString = "server=" + server + ";username=" + username + ";password=" + password + ";database=" + database;
                try
                {
                    sqlConn.Open();
                    // Truy vấn SQL để lấy mã khoa từ tên monhoc
                    string sqlQuery = "SELECT MaMH FROM monhoc WHERE TenMon = @tenMon";

                    MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                    sqlCmd.Parameters.AddWithValue("@TenMon", tenMon);
                    maMon = sqlCmd.ExecuteScalar().ToString();
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

                    string sqlQuery = "INSERT INTO giangvien(MaGV, HoTen, DiaChi, NgaySinh, MaKhoa, MaMH, soDienthoai) VALUES('" + textBox_magv.Text + "','" + textBox_hotenGV.Text + "','" + textBox_dcGV.Text + "','" + dateTimePicker_nsGV.Value.ToString("yyyy-MM-dd") + "','" + maKhoa + "','" + maMon + "','" + textBox_sdtGV.Text + "')";


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
                KhoaUpload();
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin cho tất cả các ô.");
            }
            }

        private void btnCapnhatGv_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem tất cả các ô đã được điền thông tin hay không
            if (!string.IsNullOrEmpty(textBox_magv.Text) && !string.IsNullOrEmpty(textBox_hotenGV.Text) &&
                !string.IsNullOrEmpty(textBox_dcGV.Text) && !string.IsNullOrEmpty(textBox_sdtGV.Text) &&
                comboBox_tenKhoa_GV.SelectedItem != null && comboBox_mhGV.SelectedItem != null)
            {
                // Khai báo biến lưu trữ mã khoa
                string maKhoa = "";

                // Lấy tên khoa được chọn từ comboBox_tenK_k
                string tenKhoa = comboBox_tenKhoa_GV.SelectedItem.ToString();

                // Kết nối đến cơ sở dữ liệu để lấy mã khoa
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

                // Khai báo biến lưu trữ mã môn
                string maMon = "";

                // Lấy tên môn được chọn từ comboBox_mhGV
                string tenMon = comboBox_mhGV.SelectedItem.ToString();

                // Kết nối đến cơ sở dữ liệu để lấy mã môn
                sqlConn.ConnectionString = "server=" + server + ";username=" + username + ";password=" + password + ";database=" + database;
                try
                {
                    sqlConn.Open();
                    // Truy vấn SQL để lấy mã môn từ tên môn
                    string sqlQuery = "SELECT MaMH FROM monhoc WHERE TenMon = @TenMon";

                    MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                    sqlCmd.Parameters.AddWithValue("@TenMon", tenMon);
                    maMon = sqlCmd.ExecuteScalar().ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlConn.Close();
                }

                // Cập nhật thông tin của giáo viên trong cơ sở dữ liệu
                sqlConn.ConnectionString = "server=" + server + ";username=" + username + ";password=" + password + ";database=" + database;
                try
                {
                    sqlConn.Open();

                    string sqlQuery = "UPDATE giangvien SET HoTen = @HoTen, DiaChi = @DiaChi, NgaySinh = @NgaySinh, MaKhoa = @MaKhoa, MaMH = @MaMH, soDienthoai = @soDienthoai WHERE MaGV = @MaGV";

                    MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                    sqlCmd.Parameters.AddWithValue("@MaGV", textBox_magv.Text);
                    sqlCmd.Parameters.AddWithValue("@HoTen", textBox_hotenGV.Text);
                    sqlCmd.Parameters.AddWithValue("@DiaChi", textBox_dcGV.Text);
                    sqlCmd.Parameters.AddWithValue("@NgaySinh", dateTimePicker_nsGV.Value.ToString("yyyy-MM-dd"));
                    sqlCmd.Parameters.AddWithValue("@MaKhoa", maKhoa);
                    sqlCmd.Parameters.AddWithValue("@MaMH", maMon);
                    sqlCmd.Parameters.AddWithValue("@soDienthoai", textBox_sdtGV.Text);
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Đã cập nhật thông tin giáo viên.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlConn.Close();
                }
                // Sau khi cập nhật, cập nhật lại dữ liệu trên giao diện
                KhoaUpload();
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin cho tất cả các ô.");
            }

        }

        private void btnXoaGv_Click(object sender, EventArgs e)
        {

            // Kiểm tra xem mã giáo viên đã được nhập
            if (!string.IsNullOrEmpty(textBox_magv.Text))
            {
                // Kết nối đến cơ sở dữ liệu
                sqlConn.ConnectionString = "server=" + server + ";username=" + username + ";password=" + password + ";database=" + database;
                try
                {
                    sqlConn.Open();

                    // Xây dựng câu lệnh SQL để xóa dữ liệu của giáo viên có mã là textBox_magv.Text
                    string sqlQuery = "DELETE FROM giangvien WHERE MaGV = @MaGV";

                    MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                    sqlCmd.Parameters.AddWithValue("@MaGV", textBox_magv.Text);
                    sqlCmd.ExecuteNonQuery();

                    MessageBox.Show("Đã xóa thông tin giáo viên có mã " + textBox_magv.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlConn.Close();
                }

                // Sau khi xóa, cập nhật lại dữ liệu trên giao diện
                KhoaUpload();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã giáo viên để xóa.");
            }

        }

        private void btnResetGv_Click(object sender, EventArgs e)
        {
            textBox_dcGV.Text = "";
            textBox_hotenGV.Text = "";
            textBox_magv.Text = "";
            textBox_sdtGV.Text = "";
            comboBox_mhGV.Text = "";
            comboBox_tenKhoa_GV.Text = "";
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
            QLlop form1 = new QLlop();
            // Hiển thị form mới
            form1.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {

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
