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
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLSinhVien
{
    public partial class SVanalysisSV : Form
    {
        // Khai báo các biến kết nối cơ sở dữ liệu
        private MySqlConnection sqlConn;
        private MySqlCommand sqlCmd;
        private DataTable sqlDt;
        private MySqlDataAdapter sqlDta;
        private DataSet DS;
        private string sqlQuery;

        // Thông tin kết nối
        private string server = "localhost";
        private string username = "root";
        private string password = "123456789";
        private string database = "student";
        private string fullname;
        private string masv; // Mã sinh viên cần phân tích
        private Chart chart;
        public SVanalysisSV(string fullname123,string masv)
        {
            InitializeComponent();
            CenterToScreen();
            this.fullname = fullname123;
            this.masv = masv;
        }
        public SVanalysisSV()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        
        private void LoadDataAndDisplayChart()
        {
            string connString = $"server={server};user={username};database={database};password={password};";
            sqlConn = new MySqlConnection(connString);

            try
            {
                sqlConn.Open();
                string sqlQuery = @"
                SELECT d.HocKy, mh.TenMon, d.DiemTong 
                FROM diem d
                JOIN monhoc mh ON d.MaMH = mh.MaMH
                WHERE d.MaSV = @MaSV
                ORDER BY d.HocKy, mh.TenMon";

                MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                sqlCmd.Parameters.AddWithValue("@MaSV", masv);

                MySqlDataAdapter sqlDta = new MySqlDataAdapter(sqlCmd);
                DataTable sqlDt = new DataTable();
                sqlDta.Fill(sqlDt);

                // Kiểm tra dữ liệu đã truy vấn
                if (sqlDt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị.");
                    return;
                }

                DisplayChart(sqlDt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
        }

        private void DisplayChart(DataTable dataTable)
        {
            this.chart1.Series.Clear();
            Series series = new Series("Scores");
            series.ChartType = SeriesChartType.Line;
            series.XValueType = ChartValueType.String;
            series.YValueType = ChartValueType.Double;
            series.BorderWidth = 3;

            foreach (DataRow row in dataTable.Rows)
            {
                string hocKy = row["HocKy"].ToString();
                double diemTong = Convert.ToDouble(row["DiemTong"]);
                series.Points.AddXY(hocKy, diemTong);
            }

            this.chart1.Series.Add(series);

            // Cấu hình biểu đồ
            this.chart1.ChartAreas[0].AxisX.Title = "Học Kỳ";
            this.chart1.ChartAreas[0].AxisY.Title = "GPA";
            this.chart1.ChartAreas[0].RecalculateAxesScale();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            try
            {
                string connStr = $"server={server};user={username};database={database};port=3306;password={password}";
                sqlConn = new MySqlConnection(connStr);
                sqlConn.Open();

                // Truy vấn dữ liệu
                sqlQuery = "SELECT diem.MaSV, diem.MaMH, diem.DiemTong, monhoc.TenMon, monhoc.TinChi " +
                           "FROM diem INNER JOIN monhoc ON diem.MaMH = monhoc.MaMH " +
                           "WHERE diem.MaSV = @MaSV";
                sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                sqlCmd.Parameters.AddWithValue("@MaSV", masv);
                sqlDta = new MySqlDataAdapter(sqlCmd);
                sqlDt = new DataTable();
                sqlDta.Fill(sqlDt);

                // Phân tích dữ liệu
                AnalyzeData(sqlDt);

                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void AnalyzeData(DataTable dataTable)
        {
            var series = new Series("Phổ điểm sinh viên");
            series.ChartType = SeriesChartType.Column;

            // Tính toán phổ điểm
            var gradeDistribution = new Dictionary<string, int>
        {
            {"A+", 0},
            {"A", 0},
            {"B+", 0},
            {"B", 0},
            {"C+", 0},
            {"C", 0},
            {"D+", 0},
            {"D", 0},
            {"F", 0}
        };

            foreach (DataRow row in dataTable.Rows)
            {
                double diemTong = Convert.ToDouble(row["DiemTong"]);
                string grade = GetGrade(diemTong);
                gradeDistribution[grade]++;
            }

            // Thêm dữ liệu vào series
            foreach (var entry in gradeDistribution)
            {
                series.Points.AddXY(entry.Key, entry.Value);
            }

            chart1.Series.Clear();
            chart1.Series.Add(series);
        }

        private string GetGrade(double diemTong)
        {
            if (diemTong >= 4) return "A+";
            if (diemTong >= 3.7) return "A";
            if (diemTong >= 3.5) return "B+";
            if (diemTong >= 3) return "B";
            if (diemTong >= 2.5) return "C+";
            if (diemTong >= 2) return "C";
            if (diemTong >= 1.5) return "D+";
            if (diemTong >= 1) return "D";
            return "F";
        }

        private void comboBoxLuaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = comboBoxLuaChon.SelectedItem.ToString();
            if (select == "Phổ điểm tích lũy của từng kỳ")
            {
                LoadDataAndDisplayChart();
            }
            else
            {
                LoadData();
            }
        }

        private void analysisSV_Load(object sender, EventArgs e)
        {
            lbTen.Text = fullname;
            lbMsv1.Text = masv;
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

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            string fullname123 = lbTen.Text;
            string masv = lbMsv1.Text;
            SVThongBaoNguoiDung form2 = new SVThongBaoNguoiDung(fullname123, masv);
            form2.Show();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fullname123 = lbTen.Text;
            string masv = lbMsv1.Text;
            SVThongTinCaNhan form2 = new SVThongTinCaNhan(fullname123, masv);
            form2.Show();
            this.Close();

        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
            string fullname123 = lbTen.Text;
            string masv = lbMsv1.Text;
            SVnguoidung form2 = new SVnguoidung(fullname123, masv);
            form2.Show();
            this.Close();
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
