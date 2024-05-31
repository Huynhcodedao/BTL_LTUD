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
    public partial class QLmonhoc : Form
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
        public QLmonhoc()
        {
            InitializeComponent(); CenterToScreen();
        }
        private void Load22()
        {
            DataTable sqlDt5 = new DataTable();
           dataGridView_mh.DataSource=sqlDt5;
        }

        private void KhoaUpload()
        {

            Load22();
            sqlConn.ConnectionString = "server=" + server + ";" + "username=" + username + ";" + "password=" + password + ";" + "database=" + database;
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "select * from monhoc";
            sqlDd = sqlCmd.ExecuteReader();
            sqlDt.Load(sqlDd);
            sqlDd.Close();
            sqlConn.Close();
            dataGridView_mh.DataSource = sqlDt;
        }

        private void monhoc_Load(object sender, EventArgs e)
        {
            KhoaUpload();
        }

        private void btnThemMonHoc_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem tất cả các ô đã được điền đầy đủ thông tin hay không
            if (!string.IsNullOrEmpty(textBox_tenmh_mh.Text) &&
                !string.IsNullOrEmpty(textBox_mamh_mh.Text) &&
                
                !string.IsNullOrEmpty(txtTinChi.Text))
            {
                // Kiểm tra xem mã môn học đã tồn tại trong cơ sở dữ liệu hay chưa
                bool isMaMHTonTai = false;
                string maMH = textBox_mamh_mh.Text; // Lấy mã môn học từ ô nhập liệu

                // Kết nối đến cơ sở dữ liệu để kiểm tra
                sqlConn.ConnectionString = "server=" + server + ";username=" + username + ";password=" + password + ";database=" + database;
                try
                {
                    sqlConn.Open();
                    string sqlQuery = "SELECT COUNT(*) FROM monhoc WHERE MaMH = @MaMH";
                    MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                    sqlCmd.Parameters.AddWithValue("@MaMH", maMH);
                    int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                    if (count > 0)
                    {
                        isMaMHTonTai = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi kiểm tra mã môn học: " + ex.Message);
                }
                finally
                {
                    sqlConn.Close();
                }

                // Nếu mã môn học đã tồn tại, hiển thị thông báo và không thực hiện thêm vào cơ sở dữ liệu
                if (isMaMHTonTai)
                {
                    MessageBox.Show("Mã môn học đã tồn tại trong cơ sở dữ liệu.");
                }
                else
                {
                    // Thực hiện thêm môn học vào cơ sở dữ liệu
                    sqlConn.ConnectionString = "server=" + server + ";username=" + username + ";password=" + password + ";database=" + database;
                    try
                    {
                        sqlConn.Open();
                        string sqlQuery = "INSERT INTO monhoc(MaMH, TenMon, TinChi) VALUES(@MaMH, @TenMon, @TinChi)";
                        MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                        sqlCmd.Parameters.AddWithValue("@MaMH", textBox_mamh_mh.Text);
                        sqlCmd.Parameters.AddWithValue("@TenMon", textBox_tenmh_mh.Text);
                       
                        sqlCmd.Parameters.AddWithValue("@TinChi", txtTinChi.Text);
                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm môn học thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi thêm môn học: " + ex.Message);
                    }
                    finally
                    {
                        sqlConn.Close();
                    }

                    // Gọi hàm KhoaUpload để cập nhật lại dữ liệu trên giao diện
                    KhoaUpload();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin cho tất cả các ô.");
            }


        }

        private void btnCapNhatMh_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem tất cả các ô đã được điền đầy đủ thông tin hay không
            if (!string.IsNullOrEmpty(textBox_tenmh_mh.Text) &&
                !string.IsNullOrEmpty(textBox_mamh_mh.Text)  &&
                !string.IsNullOrEmpty(txtTinChi.Text))
            {
                // Khai báo biến lưu trữ mã môn học
                string maMH = textBox_mamh_mh.Text;

                // Kết nối đến cơ sở dữ liệu để kiểm tra và cập nhật
                sqlConn.ConnectionString = "server=" + server + ";username=" + username + ";password=" + password + ";database=" + database;
                try
                {
                    sqlConn.Open();

                    // Kiểm tra xem mã môn học đã tồn tại trong cơ sở dữ liệu hay chưa
                    string sqlQueryCheck = "SELECT COUNT(*) FROM monhoc WHERE MaMH = @MaMH";
                    MySqlCommand sqlCmdCheck = new MySqlCommand(sqlQueryCheck, sqlConn);
                    sqlCmdCheck.Parameters.AddWithValue("@MaMH", maMH);
                    int count = Convert.ToInt32(sqlCmdCheck.ExecuteScalar());

                    if (count > 0)
                    {
                        // Môn học đã tồn tại, tiến hành cập nhật thông tin
                        string sqlQueryUpdate = "UPDATE monhoc SET TenMon = @TenMon, TinChi = @TinChi WHERE MaMH = @MaMH";
                        MySqlCommand sqlCmdUpdate = new MySqlCommand(sqlQueryUpdate, sqlConn);
                        sqlCmdUpdate.Parameters.AddWithValue("@TenMon", textBox_tenmh_mh.Text);
                 
                        sqlCmdUpdate.Parameters.AddWithValue("@TinChi", txtTinChi.Text);
                        sqlCmdUpdate.Parameters.AddWithValue("@MaMH", maMH);
                        sqlCmdUpdate.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật môn học thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Mã môn học không tồn tại trong cơ sở dữ liệu.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật môn học: " + ex.Message);
                }
                finally
                {
                    sqlConn.Close();
                }

                // Gọi hàm KhoaUpload để cập nhật lại dữ liệu trên giao diện
                KhoaUpload();
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin cho tất cả các ô.");
            }

        }

        private void btnXoamh_Click(object sender, EventArgs e)
        {
                // Khai báo biến lưu trữ mã môn học
                string maMH = textBox_mamh_mh.Text;

                // Kết nối đến cơ sở dữ liệu để kiểm tra và xóa bản ghi
                sqlConn.ConnectionString = "server=" + server + ";username=" + username + ";password=" + password + ";database=" + database;
                try
                {
                    sqlConn.Open();

                    // Kiểm tra xem mã môn học đã tồn tại trong cơ sở dữ liệu hay chưa
                    string sqlQueryCheck = "SELECT COUNT(*) FROM monhoc WHERE MaMH = @MaMH";
                    MySqlCommand sqlCmdCheck = new MySqlCommand(sqlQueryCheck, sqlConn);
                    sqlCmdCheck.Parameters.AddWithValue("@MaMH", maMH);
                    int count = Convert.ToInt32(sqlCmdCheck.ExecuteScalar());

                    if (count > 0)
                    {
                        // Môn học đã tồn tại, tiến hành xóa bản ghi
                        string sqlQueryDelete = "DELETE FROM monhoc WHERE MaMH = @MaMH";
                        MySqlCommand sqlCmdDelete = new MySqlCommand(sqlQueryDelete, sqlConn);
                        sqlCmdDelete.Parameters.AddWithValue("@MaMH", maMH);
                        sqlCmdDelete.ExecuteNonQuery();
                        MessageBox.Show("Xóa môn học thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Mã môn học không tồn tại trong cơ sở dữ liệu.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa môn học: " + ex.Message);
                }
                finally
                {
                    sqlConn.Close();
                }

                // Gọi hàm KhoaUpload để cập nhật lại dữ liệu trên giao diện
                KhoaUpload();

        }

        private void btnResetMonhoc_Click(object sender, EventArgs e)
        {
            textBox_mamh_mh.Text = "";
            textBox_tenmh_mh.Text = "";
            txtTinChi.Text = "";
           
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
           QLgiangvien form1 = new QLgiangvien();
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
