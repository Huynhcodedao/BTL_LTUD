using ClosedXML.Excel;
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
    public partial class QLdiem : Form
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
        public QLdiem()
        {
            InitializeComponent(); CenterToScreen();
        }
        private void Load22()
        {
            DataTable sqlDt5 = new DataTable();
            dataGridView_diem.DataSource = sqlDt5;
        }

        private void KhoaUpload()
        {
            Load22();
            sqlConn.ConnectionString = "server=" + server + ";" + "username=" + username + ";" + "password=" + password + ";" + "database=" + database;
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "select * from diem";
            sqlDd = sqlCmd.ExecuteReader();
            sqlDt.Load(sqlDd);
            sqlDd.Close();
            sqlConn.Close();
            dataGridView_diem.DataSource = sqlDt;
        }

        private void diem_Load(object sender, EventArgs e)
        {
            KhoaUpload();
              sqlConn.ConnectionString = "server=" + server + ";username=" + username + ";password=" + password + ";database=" + database;
            try
            {
                sqlConn.Open();
                // Truy vấn SQL để lấy dữ liệu từ cơ sở dữ liệu
                string sqlQuery = "SELECT MaSV from sinhvien";

                MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                MySqlDataReader sqlReader = sqlCmd.ExecuteReader();

                // Xóa các mục có sẵn trong comboBox_tenK_k
                comboBox_masv_d.Items.Clear();


                // Đọc dữ liệu từ cơ sở dữ liệu và thêm vào comboBox_tenK_k
                while (sqlReader.Read())
                {
                    comboBox_masv_d.Items.Add(sqlReader["MaSV"].ToString());

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

            sqlConn.ConnectionString = "server=" + server + ";username=" + username + ";password=" + password + ";database=" + database;
            try
            {
                sqlConn.Open();
                // Truy vấn SQL để lấy dữ liệu từ cơ sở dữ liệu
                string sqlQuery = "SELECT MaMH from monhoc";

                MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                MySqlDataReader sqlReader = sqlCmd.ExecuteReader();

                // Xóa các mục có sẵn trong comboBox_tenK_k
               comboBox_mamh_d.Items.Clear();


                // Đọc dữ liệu từ cơ sở dữ liệu và thêm vào comboBox_tenK_k
                while (sqlReader.Read())
                {
                    comboBox_mamh_d.Items.Add(sqlReader["MaMH"].ToString());

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_masv_d_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn một mã sinh viên từ ComboBox chưa
            if (comboBox_masv_d.SelectedItem != null)
            {
                // Lấy mã sinh viên đã chọn từ ComboBox
                string maSV = comboBox_masv_d.SelectedItem.ToString();

                // Thực hiện truy vấn SQL để lấy tên sinh viên tương ứng với mã sinh viên đã chọn
                sqlConn.ConnectionString = "server=" + server + ";username=" + username + ";password=" + password + ";database=" + database;
                try
                {
                    sqlConn.Open();
                    string sqlQuery = "SELECT HoTen FROM sinhvien WHERE MaSV = @MaSV";

                    MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                    sqlCmd.Parameters.AddWithValue("@MaSV", maSV);
                    string tenSV = sqlCmd.ExecuteScalar()?.ToString();

                    // Hiển thị tên sinh viên trong TextBox hoặc Label
                    txtTenSv.Text = tenSV;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lấy tên sinh viên: " + ex.Message);
                }
                finally
                {
                    sqlConn.Close();
                }
            }
        }

        private void comboBox_mamh_d_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn một mã sinh viên từ ComboBox chưa
            if (comboBox_mamh_d.SelectedItem != null)
            {
                // Lấy mã sinh viên đã chọn từ ComboBox
                string maMH = comboBox_mamh_d.SelectedItem.ToString();

                // Thực hiện truy vấn SQL để lấy tên sinh viên tương ứng với mã sinh viên đã chọn
                sqlConn.ConnectionString = "server=" + server + ";username=" + username + ";password=" + password + ";database=" + database;
                try
                {
                    sqlConn.Open();
                    string sqlQuery = "SELECT TenMon from monhoc WHERE MaMH = @MaMH";

                    MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                    sqlCmd.Parameters.AddWithValue("@MaMH", maMH);
                    string tenMH = sqlCmd.ExecuteScalar()?.ToString();

                    // Hiển thị tên sinh viên trong TextBox hoặc Label
                    txtTenMon.Text = tenMH;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lấy tên sinh viên: " + ex.Message);
                }
                finally
                {
                    sqlConn.Close();
                }
            }
        }

        private void btnThemMonHoc_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem tất cả các ô đã được điền đầy đủ thông tin hay không
            if (!string.IsNullOrEmpty(textBox_diemGK.Text) &&
                !string.IsNullOrEmpty(textBox_diemCK.Text) &&
                comboBox_masv_d.SelectedItem != null &&
                comboBox_mamh_d.SelectedItem != null)
            {
                // Tiến hành tính điểm tổng và xác định điểm chữ dựa trên điểm tổng
                float a = float.Parse(textBox_diemGK.Text);
                float b = float.Parse(textBox_diemCK.Text);
                double c = a * 0.4 + b * 0.6;
                double d;

                // Xác định điểm chữ dựa trên điểm tổng
                if (c >= 9)
                {
                    d = 4;
                }
                else if (c >= 8.5)
                {
                    d = 3.7;
                }
                else if (c >= 8)
                {
                    d = 3.5;
                }
                else if (c >= 7)
                {
                    d = 3;
                }
                else if (c >= 6.5)
                {
                    d = 2.5;
                }
                else if (c >= 6)
                {
                    d = 2;
                }
                else if (c >= 5)
                {
                    d = 1.5;
                }
                else if (c >= 4)
                {
                    d = 1;
                }
                else
                {
                    d = 0;
                }

                // Tạo biến để lưu trữ kết quả kiểm tra
                bool studentHasScoreForCourse = false;

                // Kiểm tra xem sinh viên đã có điểm cho môn học đó chưa
                sqlConn.ConnectionString = "server=" + server + ";" + "username=" + username + ";" + "password=" + password + ";" + "database=" + database;
                try
                {
                    sqlConn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM diem WHERE MaSV = @MaSV AND MaMH = @MaMH";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, sqlConn);
                    checkCmd.Parameters.AddWithValue("@MaSV", comboBox_masv_d.SelectedItem.ToString());
                    checkCmd.Parameters.AddWithValue("@MaMH", comboBox_mamh_d.SelectedItem.ToString());
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        studentHasScoreForCourse = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi kiểm tra điểm của sinh viên: " + ex.Message);
                }
                finally
                {
                    sqlConn.Close();
                }

                // Nếu sinh viên đã có điểm cho môn đó, hiển thị thông báo và không thêm điểm mới
                if (studentHasScoreForCourse)
                {
                    MessageBox.Show("Sinh viên đã có điểm cho môn này. Không thể thêm điểm mới.");
                }
                else
                {
                    sqlConn.ConnectionString = "server=" + server + ";" + "username=" + username + ";" + "password=" + password + ";" + "database=" + database;

                    try
                    {
                        // Open the database connection
                        sqlConn.Open();

                        // SQL query to insert a new record into the 'diem' table
                        string sqlQuery = "INSERT INTO diem (MaSV, MaMH, DiemGiuaki, DiemCuoiki, DiemTong, HocKy) VALUES (@MaSV, @MaMH, @DiemGK, @DiemCK, @DiemTong, @HocKy)";

                        // Create a new MySqlCommand object
                        MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn);

                        // Add parameters to the MySqlCommand object
                        sqlCmd.Parameters.AddWithValue("@MaSV", comboBox_masv_d.SelectedItem.ToString());
                        sqlCmd.Parameters.AddWithValue("@MaMH", comboBox_mamh_d.SelectedItem.ToString());
                        sqlCmd.Parameters.AddWithValue("@DiemGK", textBox_diemGK.Text);
                        sqlCmd.Parameters.AddWithValue("@DiemCK", textBox_diemCK.Text);
                        sqlCmd.Parameters.AddWithValue("@DiemTong", d); // Assuming 'd' is defined and is of correct type
                        sqlCmd.Parameters.AddWithValue("@HocKy", txtHocKy.Text); // Corrected parameter name

                        // Execute the SQL query
                        sqlCmd.ExecuteNonQuery();

                        // Show a success message
                        MessageBox.Show("Đã thêm điểm mới thành công!");
                    }
                    catch (Exception ex)
                    {
                        // Show an error message if something goes wrong
                        MessageBox.Show("Lỗi khi thêm điểm mới: " + ex.Message);
                    }
                    finally
                    {
                        // Close the database connection
                        sqlConn.Close();
                    }
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
            if (!string.IsNullOrEmpty(textBox_diemGK.Text) &&
                !string.IsNullOrEmpty(textBox_diemCK.Text) &&
                comboBox_masv_d.SelectedItem != null &&
                comboBox_mamh_d.SelectedItem != null)
            {
                // Tiến hành tính điểm tổng và xác định điểm chữ dựa trên điểm tổng
                float a, b;
                if (float.TryParse(textBox_diemGK.Text, out a) && float.TryParse(textBox_diemCK.Text, out b))
                {
                    double c = a * 0.4 + b * 0.6;
                    double d;
                    if (c >= 9)
                    {
                        d = 4;
                    }
                    else if (c >= 8.5)
                    {
                        d = 3.7;
                    }
                    else if (c >= 8)
                    {
                        d = 3.5;
                    }
                    else if (c >= 7)
                    {
                        d = 3;
                    }
                    else if (c >= 6.5)
                    {
                        d = 2.5;
                    }
                    else if (c >= 6)
                    {
                        d = 2;
                    }
                    else if (c >= 5)
                    {
                        d = 1.5;
                    }
                    else if (c >= 4)
                    {
                        d = 1;
                    }
                    else
                    {
                        d = 0;
                    }

                    // Tạo biến để lưu trữ kết quả kiểm tra
                    bool studentHasScoreForCourse = false;

                    // Kiểm tra xem sinh viên đã có điểm cho môn học đó chưa
                    sqlConn.ConnectionString = "server=" + server + ";" + "username=" + username + ";" + "password=" + password + ";" + "database=" + database;
                    try
                    {
                        sqlConn.Open();

                        string checkQuery = "SELECT COUNT(*) FROM diem WHERE MaSV = @MaSV AND MaMH = @MaMH";
                        MySqlCommand checkCmd = new MySqlCommand(checkQuery, sqlConn);
                        checkCmd.Parameters.AddWithValue("@MaSV", comboBox_masv_d.SelectedItem.ToString());
                        checkCmd.Parameters.AddWithValue("@MaMH", comboBox_mamh_d.SelectedItem.ToString());
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            studentHasScoreForCourse = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi kiểm tra điểm của sinh viên: " + ex.Message);
                    }
                    finally
                    {
                        sqlConn.Close();
                    }

                    // Nếu sinh viên đã có điểm cho môn đó, tiến hành cập nhật điểm mới
                    if (studentHasScoreForCourse)
                    {
                        sqlConn.ConnectionString = "server=" + server + ";" + "username=" + username + ";" + "password=" + password + ";" + "database=" + database;
                        try
                        {
                            sqlConn.Open();

                            string updateQuery = "UPDATE diem SET DiemGiuaki = @DiemGiuaki, DiemCuoiki = @DiemCuoiki, DiemTong = @DiemTong, HocKy = @HocKy WHERE MaSV = @MaSV AND MaMH = @MaMH";
                            MySqlCommand updateCmd = new MySqlCommand(updateQuery, sqlConn);
                            updateCmd.Parameters.AddWithValue("@DiemGiuaki", a);
                            updateCmd.Parameters.AddWithValue("@DiemCuoiki", b);
                            updateCmd.Parameters.AddWithValue("@DiemTong", d);
                            updateCmd.Parameters.AddWithValue("@HocKy", txtHocKy.Text);
                            updateCmd.Parameters.AddWithValue("@MaSV", comboBox_masv_d.SelectedItem.ToString());
                            updateCmd.Parameters.AddWithValue("@MaMH", comboBox_mamh_d.SelectedItem.ToString());
                            updateCmd.ExecuteNonQuery();

                            MessageBox.Show("Cập nhật điểm thành công!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi cập nhật điểm: " + ex.Message);
                        }
                        finally
                        {
                            sqlConn.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sinh viên chưa có điểm cho môn này. Không thể cập nhật.");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập điểm số hợp lệ (kiểu số thực)!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin cho tất cả các ô.");
            }

            KhoaUpload();
        }

        private void btnXoamh_Click(object sender, EventArgs e)
        {
            // Xác định dữ liệu cần xóa (ví dụ: xóa điểm của một sinh viên cho một môn học cụ thể)
            string maSV = comboBox_masv_d.Text; // Mã sinh viên cần xóa điểm
            string maMH = comboBox_mamh_d.Text; // Mã môn học cần xóa điểm

            // Thực hiện truy vấn xóa dữ liệu
            sqlConn.ConnectionString = "server=" + server + ";username=" + username + ";password=" + password + ";database=" + database;
            try
            {
                sqlConn.Open();

                string deleteQuery = "DELETE FROM diem WHERE MaSV = @MaSV AND MaMH = @MaMH";
                MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, sqlConn);
                deleteCmd.Parameters.AddWithValue("@MaSV", maSV);
                deleteCmd.Parameters.AddWithValue("@MaMH", maMH);
                int rowsAffected = deleteCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Đã xóa điểm thành công!");
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu nào được xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
            KhoaUpload();

        }

        private void btnResetMonhoc_Click(object sender, EventArgs e)
        {
            comboBox_mamh_d.Text = "";
            comboBox_masv_d.Text = "";
            textBox_diemCK.Text = "";
            textBox_diemGK.Text = "";
            txtHocKy.Text = "";
            txtTenMon.Text = "";
            txtTenSv.Text = "";
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

        private void button11_Click(object sender, EventArgs e)
        {
            QLsinhvien form1 = new QLsinhvien();
            // Hiển thị form mới
            form1.Show();
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
           
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
                            INSERT INTO diem (MaSV, MaMH, DiemGiuaki, DiemCuoiki, DiemTong, HocKy)
                            VALUES (@MaSV, @MaMH, @DiemGiuaki, @DiemCuoiki, @DiemTong, @HocKy)";

                                using (MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn))
                                {
                                    sqlCmd.Parameters.AddWithValue("@MaSV", row["MaSV"]);
                                    sqlCmd.Parameters.AddWithValue("@MaMH", row["MaMH"]);
                                    sqlCmd.Parameters.AddWithValue("@DiemGiuaki", Convert.ToDouble(row["DiemGiuaki"]));
                                    sqlCmd.Parameters.AddWithValue("@DiemCuoiki", Convert.ToDouble(row["DiemCuoiki"]));
                                    sqlCmd.Parameters.AddWithValue("@DiemTong", Convert.ToDouble(row["DiemTong"]));
                                    sqlCmd.Parameters.AddWithValue("@HocKy", row["HocKy"]);
                                    sqlCmd.ExecuteNonQuery();
                                }
                            }
                        

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
