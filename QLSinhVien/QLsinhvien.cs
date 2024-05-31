
using ClosedXML.Excel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLSinhVien
{
    public partial class QLsinhvien : Form
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
        public QLsinhvien()
        {
            InitializeComponent(); CenterToScreen();
        }
        private void Load22()
        {
            DataTable sqlDt5 = new DataTable();
            dataGridView_sv.DataSource = sqlDt5;
        }

        private void KhoaUpload()
        {
       
            Load22();
            sqlConn.ConnectionString = "server=" + server + ";" + "username=" + username + ";" + "password=" + password + ";" + "database=" + database;
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "select * from sinhvien";
            sqlDd = sqlCmd.ExecuteReader();
            sqlDt.Load(sqlDd);
            sqlDd.Close();
            sqlConn.Close();
            dataGridView_sv.DataSource = sqlDt;
        }

        private void sinhvien_Load(object sender, EventArgs e)
        {
            KhoaUpload();
            // Kết nối đến cơ sở dữ liệu
            sqlConn.ConnectionString = "server=" + server + ";username=" + username + ";password=" + password + ";database=" + database;
            try
            {
                sqlConn.Open();
                // Truy vấn SQL để lấy dữ liệu từ cơ sở dữ liệu
                string sqlQuery = "SELECT TenLop from lop";

                MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                MySqlDataReader sqlReader = sqlCmd.ExecuteReader();

                // Xóa các mục có sẵn trong comboBox_tenK_k
                comboBox_tenLop.Items.Clear();


                // Đọc dữ liệu từ cơ sở dữ liệu và thêm vào comboBox_tenK_k
                while (sqlReader.Read())
                {
                   comboBox_tenLop.Items.Add(sqlReader["TenLop"].ToString());

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

        private void btnResetSv_Click(object sender, EventArgs e)
        {
            textBox_dichi_sv.Clear();

            textBox_hoten_sv.Clear();

            textbox_masv.Clear();
            textBox_sdtSV.Clear();
            comboBox_tenLop.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnthemSv_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem tất cả các ô đã được điền đầy đủ thông tin hay không
            if (!string.IsNullOrEmpty(textbox_masv.Text) &&
                !string.IsNullOrEmpty(textBox_hoten_sv.Text) &&
                !string.IsNullOrEmpty(textBox_sdtSV.Text) &&
                !string.IsNullOrEmpty(textBox_dichi_sv.Text) &&
                dateTimePicker_nssv.Value != null &&
                comboBox_tenLop.SelectedItem != null)
            {
                // Khai báo biến lưu trữ mã khoa
                string maLop="";

            // Lấy tên khoa được chọn từ comboBox_tenK_k
            string tenLop = comboBox_tenLop.SelectedItem.ToString();

                // Kết nối đến cơ sở dữ liệu
                sqlConn.ConnectionString = "server=" + server + ";username=" + username + ";password=" + password + ";database=" + database;
                try
                {
                    sqlConn.Open();
                    // Truy vấn SQL để lấy mã khoa từ tên khoa
                    string sqlQuery = "SELECT MaLop FROM lop WHERE TenLop = @tenLop";

                    MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                    sqlCmd.Parameters.AddWithValue("@TenLop", tenLop);
                maLop = sqlCmd.ExecuteScalar().ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlConn.Close();
                }
               
                String s = textbox_masv.Text;
                string Email = s + "@vnu.edu.vn";

                sqlConn.ConnectionString = "server=" + server + ";" + "username=" + username + ";" + "password=" + password + ";" + "database=" + database;
                try
                {
                    sqlConn.Open();

                string sqlQuery = "INSERT INTO sinhvien(MaSV, HoTen, Email, SDT, DiaChi, NgaySinh, MaLop) VALUES('" + textbox_masv.Text + "','" + textBox_hoten_sv.Text + "','" + Email + "','" + textBox_sdtSV.Text + "','" + textBox_dichi_sv.Text + "','" + dateTimePicker_nssv.Value.ToString("yyyy-MM-dd") + "','" + maLop + "')";


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

        private void btnCapnhatSinhvien_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem tất cả các ô đã được điền đầy đủ thông tin hay không
            if (!string.IsNullOrEmpty(textbox_masv.Text) &&
                !string.IsNullOrEmpty(textBox_hoten_sv.Text) &&
                !string.IsNullOrEmpty(textBox_sdtSV.Text) &&
                !string.IsNullOrEmpty(textBox_dichi_sv.Text) &&
                dateTimePicker_nssv.Value != null &&
                comboBox_tenLop.SelectedItem != null)
            {
                // Khai báo biến lưu trữ mã lớp và mã sinh viên
                string maLop = "";
                string maSV = textbox_masv.Text;

                // Lấy tên lớp được chọn từ comboBox_tenLop
                string tenLop = comboBox_tenLop.SelectedItem.ToString();

                // Kết nối đến cơ sở dữ liệu để lấy mã lớp từ tên lớp
                sqlConn.ConnectionString = "server=" + server + ";username=" + username + ";password=" + password + ";database=" + database;
                try
                {
                    sqlConn.Open();
                    string sqlQuery = "SELECT MaLop FROM lop WHERE TenLop = @tenLop";

                    MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                    sqlCmd.Parameters.AddWithValue("@tenLop", tenLop);
                    maLop = sqlCmd.ExecuteScalar()?.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return; // Thoát khỏi phương thức nếu có lỗi xảy ra
                }
                finally
                {
                    sqlConn.Close();
                }
                    try
                    {
                        sqlConn.Open();
                        string sqlQuery = "SELECT COUNT(*) FROM sinhvien WHERE MaSV = @MaSV";

                        MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                        sqlCmd.Parameters.AddWithValue("@MaSV", maSV);
                        int count = Convert.ToInt32(sqlCmd.ExecuteScalar());

                        if (count !=0)
                        {
                            // Mã sinh viên chưa tồn tại trong cơ sở dữ liệu, tiến hành cập nhật
                            string sqlUpdateQuery = "UPDATE sinhvien SET HoTen = @HoTen, SDT = @SDT, DiaChi = @DiaChi, NgaySinh = @NgaySinh, MaLop = @MaLop WHERE MaSV = @MaSV";

                            MySqlCommand sqlUpdateCmd = new MySqlCommand(sqlUpdateQuery, sqlConn);
                            sqlUpdateCmd.Parameters.AddWithValue("@HoTen", textBox_hoten_sv.Text);
                            sqlUpdateCmd.Parameters.AddWithValue("@SDT", textBox_sdtSV.Text);
                            sqlUpdateCmd.Parameters.AddWithValue("@DiaChi", textBox_dichi_sv.Text);
                            sqlUpdateCmd.Parameters.AddWithValue("@NgaySinh", dateTimePicker_nssv.Value.ToString("yyyy-MM-dd"));
                            sqlUpdateCmd.Parameters.AddWithValue("@MaLop", maLop);
                            sqlUpdateCmd.Parameters.AddWithValue("@MaSV", maSV);

                            sqlUpdateCmd.ExecuteNonQuery();
                            MessageBox.Show("Cập nhật sinh viên thành công!");
                            KhoaUpload();
                        }
                        else
                        {
                            MessageBox.Show("Mã sinh viên không tại trong cơ sở dữ liệu.");
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
                MessageBox.Show("Vui lòng điền đầy đủ thông tin cho tất cả các ô.");
            }



        }

        private void btnXoattSinhvien_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem tất cả các ô đã được điền đầy đủ thông tin hay không
            if (!string.IsNullOrEmpty(textbox_masv.Text))
            {
                string maSV = textbox_masv.Text;

                try
                {
                    sqlConn.Open();

                    // Kiểm tra xem mã sinh viên có tồn tại trong cơ sở dữ liệu hay không
                    string checkExistQuery = "SELECT COUNT(*) FROM sinhvien WHERE MaSV = @MaSV";
                    MySqlCommand checkExistCmd = new MySqlCommand(checkExistQuery, sqlConn);
                    checkExistCmd.Parameters.AddWithValue("@MaSV", maSV);
                    int count = Convert.ToInt32(checkExistCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        // Nếu tồn tại, tiến hành xóa sinh viên
                        string deleteQuery = "DELETE FROM sinhvien WHERE MaSV = @MaSV";
                        MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, sqlConn);
                        deleteCmd.Parameters.AddWithValue("@MaSV", maSV);
                        deleteCmd.ExecuteNonQuery();

                        MessageBox.Show("Xóa sinh viên thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên có mã: " + maSV);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa sinh viên: " + ex.Message);
                }
                finally
                {
                    sqlConn.Close();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên cần xóa.");
            }

        }

        private void comboBox_tenLop_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btnImport_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        using (XLWorkbook wb = new XLWorkbook(ofd.FileName))
                        {
                            IXLWorksheet ws = wb.Worksheet(1); // Assuming data is in the first worksheet

                            bool firstRow = true;
                            foreach (IXLRow row in ws.Rows())
                            {
                                if (firstRow)
                                {
                                    // Add columns to DataTable
                                    foreach (IXLCell cell in row.Cells())
                                    {
                                        dt.Columns.Add(cell.Value.ToString());
                                    }
                                    firstRow = false;
                                }
                                else
                                {
                                    DataRow dr = dt.NewRow();
                                    int i = 0;
                                    foreach (IXLCell cell in row.Cells())
                                    {
                                        dr[i] = cell.Value.ToString();
                                        i++;
                                    }
                                    dt.Rows.Add(dr);
                                }
                            }
                        }

                        sqlConn.ConnectionString = "server=" + server + ";username=" + username + ";password=" + password + ";database=" + database;


                        sqlConn.Open();
                        foreach (DataRow row in dt.Rows)
                        {
                            string sqlQuery = @"
                            INSERT INTO sinhvien (MaSV, HoTen, Email, SDT, DiaChi, NgaySinh, MaLop)
                            VALUES (@MaSV, @HoTen, @Email, @SDT, @DiaChi, @NgaySinh, @MaLop)";

                            using (MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn))
                            {
                                sqlCmd.Parameters.AddWithValue("@MaSV", row["MaSV"]);
                                sqlCmd.Parameters.AddWithValue("@HoTen", row["HoTen"]);
                                sqlCmd.Parameters.AddWithValue("@Email", row["Email"]);
                                sqlCmd.Parameters.AddWithValue("@SDT", row["SDT"]);
                                sqlCmd.Parameters.AddWithValue("@DiaChi", row["DiaChi"]);
                                sqlCmd.Parameters.AddWithValue("@NgaySinh", DateTime.Parse(row["NgaySinh"].ToString()));
                                sqlCmd.Parameters.AddWithValue("@MaLop", row["MaLop"]);
                                sqlCmd.ExecuteNonQuery();
                            }
                        }

                        sqlConn.Close();
                        MessageBox.Show("Data has been successfully imported.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            }
        }
    }
}
