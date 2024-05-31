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
using System.Windows.Forms.DataVisualization.Charting;

namespace QLSinhVien
{
    public partial class QLThongKe : Form
    {
        private MySqlConnection sqlConn;
        private MySqlCommand sqlCmd;
        private DataTable sqlDt;
        private MySqlDataAdapter sqlDta;
        private DataSet DS;
        private string sqlQuery;

        private string server = "localhost";
        private string username = "root";
        private string password = "123456789";
        private string database = "student";
        public QLThongKe()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QLThongKe form1 = new QLThongKe();
            // Hiển thị form mới
            form1.Show(); this.Close();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {

            InitializeConnection();
            comboBoxLuaChon.SelectedIndexChanged += comboBoxOptions_SelectedIndexChanged;

        }
        private void InitializeConnection()
        {
            try
            {
                string connectionString = $"Server={server};Database={database};Uid={username};Pwd={password};";
                sqlConn = new MySqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể kết nối đến cơ sở dữ liệu: {ex.Message}");
            }
        }

        private void comboBoxOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Xóa dữ liệu cũ trên biểu đồ
            chart.Series.Clear();

            // Lấy lựa chọn từ ComboBox
            string selectedOption = comboBoxLuaChon.SelectedItem.ToString();
        
            // Hiển thị dữ liệu tương ứng trên biểu đồ
            switch (selectedOption)
            {
                case "Số lượng sinh viên theo từng khoa.":
                    DisplayStudentsByDepartment();
                    break;
                case "Số lượng sinh viên theo ngành học.":
                    DisplayStudentsByMajor();
                    break;
                case "Điểm trung bình học kỳ.":
                    DisplayAverageSemesterGrade();
                    break;
                case "Điểm trung bình năm học.":
                    DisplayAverageYearGrade();
                    break;
                case "Điểm GPA tích lũy.":
                    DisplayCumulativeGPA();
                    break;
                case "Số lượng sinh viên nhận học bổng.":
                 
                    break;
             
            }
        }

        private void DisplayStudentsByDepartment()
        {
            string query = "SELECT Khoa.TenKhoa, COUNT(SinhVien.MaSV) AS SoLuong " +
                           "FROM SinhVien INNER JOIN Lop ON SinhVien.MaLop = Lop.MaLop " +
                           "INNER JOIN Khoa ON Lop.MaKhoa = Khoa.MaKhoa " +
                           "GROUP BY Khoa.TenKhoa";

            DisplayChartData(query, "Số lượng sinh viên theo từng khoa");
        }

        private void DisplayStudentsByMajor()
        {
            string query = "SELECT TenLop, COUNT(MaSV) AS SoLuong " +
                           "FROM SinhVien INNER JOIN Lop ON SinhVien.MaLop = Lop.MaLop " +
                           "GROUP BY TenLop";

            DisplayChartData(query, "Số lượng sinh viên theo ngành học");
        }
        private void DisplayAverageYearGrade()
        {
            string query = @"SELECT NamHoc, SUM(DiemTong * monhoc.TinChi) / SUM(monhoc.TinChi) AS DiemTrungBinhNam
                     FROM (
                         SELECT SUBSTRING_INDEX(HocKy, '_', 1) AS NamHoc, DiemTong, monhoc.TinChi
                         FROM diem
                         INNER JOIN monhoc ON diem.MaMH = monhoc.MaMH
                     ) AS T
                     GROUP BY NamHoc";

            DisplayChartData(query, "Điểm trung bình năm học");
        }



        private void DisplayAverageSemesterGrade()
        {
            string query = "SELECT HocKy, SUM(DiemTong * monhoc.TinChi) / SUM(monhoc.TinChi) AS DiemTrungBinh " +
                           "FROM diem INNER JOIN monhoc ON diem.MaMH = monhoc.MaMH " +
                           "GROUP BY HocKy";

            DisplayChartData(query, "Điểm trung bình học kỳ");
        }
        private void DisplayCumulativeGPA()
        {
            string query = @"SELECT Khoa.TenKhoa, AVG(diem.DiemTong * monhoc.TinChi) / AVG(monhoc.TinChi) AS CumulativeGPA
                     FROM diem
                     INNER JOIN monhoc ON diem.MaMH = monhoc.MaMH
                     INNER JOIN SinhVien ON diem.MaSV = SinhVien.MaSV
                     INNER JOIN Lop ON SinhVien.MaLop = Lop.MaLop
                     INNER JOIN Khoa ON Lop.MaKhoa = Khoa.MaKhoa
                     GROUP BY Khoa.TenKhoa";

            try
            {
                sqlConn.Open();
                sqlCmd = new MySqlCommand(query, sqlConn);
                MySqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    string department = reader["TenKhoa"].ToString();
                    double cumulativeGPA = Convert.ToDouble(reader["CumulativeGPA"]);

                    // Hiển thị kết quả lên biểu đồ
                    Series series = chart.Series.Add($"GPA {department}");
                    series.Points.AddY(cumulativeGPA);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
            finally
            {
                if (sqlConn.State == ConnectionState.Open)
                {
                    sqlConn.Close();
                }
            }
        }




        private void DisplayChartData(string query, string seriesName)
        {
            try
            {
                if (chart != null && chart.IsHandleCreated) // Kiểm tra chart đã được khởi tạo và handle đã được tạo chưa
                {
                    sqlConn.Open();
                    sqlCmd = new MySqlCommand(query, sqlConn);
                    sqlDta = new MySqlDataAdapter(sqlCmd);
                    sqlDt = new DataTable();
                    sqlDta.Fill(sqlDt);

                    // Thêm dữ liệu vào biểu đồ
                    Series series = chart.Series.Add(seriesName);
                    series.ChartType = SeriesChartType.Column;

                    foreach (DataRow row in sqlDt.Rows)
                    {
                        series.Points.AddXY(row[0].ToString(), row[1]);
                    }
                }
                else
                {
                    MessageBox.Show("Biểu đồ không được khởi tạo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
            finally
            {
                if (sqlConn.State == ConnectionState.Open)
                {
                    sqlConn.Close();
                }
            }
        }

        private void comboBoxLuaChon_SelectedIndexChanged(object sender, EventArgs e)
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
    }


}
