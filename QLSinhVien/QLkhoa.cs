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
namespace QLSinhVien
{
    /*
     * Nhóm sinh viên thực hiện: 
     * Lê Văn Huỳnh - 21021597
     * Lê Phương Duy - 21021570
     * Trần Thị Ngọc Tâm - 21021632
     */
    public partial class QLkhoa : Form
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
        public QLkhoa()
        {
            InitializeComponent(); CenterToScreen();
        }
        private void Load22()
        {
            DataTable sqlDt5 = new DataTable();
            dataGridView_khoa.DataSource = sqlDt5;
        }

        private void KhoaUpload()
        {
            Load22();
            sqlConn.ConnectionString = "server=" + server + ";" + "username=" + username + ";" + "password=" + password + ";" + "database=" + database;
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "select * from khoa";
            sqlDd = sqlCmd.ExecuteReader();
            sqlDt.Load(sqlDd);
            sqlDd.Close();
            sqlConn.Close();
            dataGridView_khoa.DataSource = sqlDt;
        }

        private void khoa_Load(object sender, EventArgs e)
        {
            KhoaUpload();
        }

        private void textBox_makhoa_k_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThmeKhoa_Click(object sender, EventArgs e)
        {

            // Kiểm tra xem các ô văn bản có được nhập liệu không
            if (!string.IsNullOrEmpty(textBox_makhoa_k.Text) && !string.IsNullOrEmpty(textBox_tenKhoa_k.Text))
            {
                sqlConn.ConnectionString = "server=" + server + ";" + "username=" + username + ";" + "password=" + password + ";" + "database=" + database;
                try
                {
                    sqlConn.Open();
                    string sqlQuery = "INSERT INTO khoa(MaKhoa, TenKhoa) VALUES('" + textBox_makhoa_k.Text + "','" + textBox_tenKhoa_k.Text + "')";

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
                MessageBox.Show("Vui lòng điền đầy đủ thông tin cho cả hai ô văn bản.");
            }



        }

        private void btnCapnhatKhoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem các ô văn bản có được nhập liệu không
            if (!string.IsNullOrEmpty(textBox_makhoa_k.Text) && !string.IsNullOrEmpty(textBox_tenKhoa_k.Text))
            {
                sqlConn.ConnectionString = "server=" + server + ";" + "username=" + username + ";" + "password=" + password + ";" + "database=" + database;
                try
                {
                    sqlConn.Open();
                    // Truy vấn SQL để kiểm tra xem mã khoa có tồn tại trong cơ sở dữ liệu không
                    string sqlCheckQuery = "SELECT COUNT(*) FROM khoa WHERE MaKhoa = '" + textBox_makhoa_k.Text + "'";

                    MySqlCommand sqlCheckCmd = new MySqlCommand(sqlCheckQuery, sqlConn);
                    int count = Convert.ToInt32(sqlCheckCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        // Nếu mã khoa tồn tại, thực hiện lệnh UPDATE
                        string sqlQuery = "UPDATE khoa SET TenKhoa = '" + textBox_tenKhoa_k.Text + "' WHERE MaKhoa = '" + textBox_makhoa_k.Text + "'";
                        MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Student Management System Update");
                    }
                    else
                    {
                        // Nếu mã khoa không tồn tại, hiển thị thông báo
                        MessageBox.Show("Mã khoa không tồn tại trong cơ sở dữ liệu.");
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

                KhoaUpload();
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin cho cả hai ô văn bản.");
            }


        }

        private void btnXoaKhoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem mã khoa có được nhập liệu không
            if (!string.IsNullOrEmpty(textBox_makhoa_k.Text))
            {
                sqlConn.ConnectionString = "server=" + server + ";" + "username=" + username + ";" + "password=" + password + ";" + "database=" + database;
                try
                {
                    sqlConn.Open();
                    string sqlCheckQuery = "SELECT COUNT(*) FROM khoa WHERE MaKhoa = '" + textBox_makhoa_k.Text + "'";

                    MySqlCommand sqlCheckCmd = new MySqlCommand(sqlCheckQuery, sqlConn);
                    int count = Convert.ToInt32(sqlCheckCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        string sqlDeleteQuery = "DELETE FROM khoa WHERE MaKhoa = '" + textBox_makhoa_k.Text + "'";
                        MySqlCommand sqlCmd = new MySqlCommand(sqlDeleteQuery, sqlConn);
                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Student Management System Update");
                    }
                    else
                    {
                        MessageBox.Show("Mã khoa không tồn tại trong cơ sở dữ liệu.");
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

                KhoaUpload();
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin mã khoa.");
            }


        }

        private void btnResetKhoa_Click(object sender, EventArgs e)
        {
            textBox_makhoa_k.Text = ""; // Đặt lại giá trị của ô mã khoa thành rỗng
            textBox_tenKhoa_k.Text = ""; // Đặt lại giá trị của ô tên khoa thành rỗng
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

        private void dataGridView_khoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
