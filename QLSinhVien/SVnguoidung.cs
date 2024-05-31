using Microsoft.Office.Interop.Excel;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.IO;
using MySqlX.XDevAPI.Common;



namespace QLSinhVien
{
    public partial class SVnguoidung : Form
    {
       
        MySqlCommand sqlCmd = new MySqlCommand();

        MySqlDataAdapter sqlDta = new MySqlDataAdapter();
        MySqlDataReader sqlDd;
        DataSet DS = new DataSet();

        string sqlQuery;

        string server = "localhost";
        string username = "root";
        string password = "123456789";
        string database = "student"; 
        private string fullname;
        private string masv ;
        public SVnguoidung(string fullname, string masv)
        {
            InitializeComponent();
            CenterToScreen();
            this.fullname = fullname;
            this.masv = masv;
        }
     


        private void nguoidung_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadData2();
            lbTen.Text = fullname;
            lbMsv1.Text = masv;
        }

        private void btnPhantich_Click(object sender, EventArgs e)
        {
           string fullname123 = lbTen.Text;
           string masv = lbMsv1.Text;
            SVanalysisSV form2 = new SVanalysisSV(fullname123, masv);
            form2.Show();
            this.Close();
        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
            LoadData();
            LoadData2();
        }
        bool sidebarExpand = true;
        private void timeLoad_Tick(object sender, EventArgs e)
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
        private void LoadData2()
        {
            string connectionString = $"Server={server};Database={database};Uid={username};Pwd={password};";

            try
            {
                using (MySqlConnection sqlConn = new MySqlConnection(connectionString))
                {
                    sqlConn.Open();

                    // Tính tổng số tín chỉ
                    string queryTinChi = @"SELECT SUM(TinChi) AS TongTinChi FROM monhoc
                                    WHERE MaMH IN (SELECT DISTINCT MaMH FROM diem WHERE MaSV = @MaSV)";
                    MySqlCommand cmdTinChi = new MySqlCommand(queryTinChi, sqlConn);
                    cmdTinChi.Parameters.AddWithValue("@MaSV", masv);
                    object tongTinChi = cmdTinChi.ExecuteScalar();
                    lbTinChi.Text = "Tín chỉ tích lũy: " + tongTinChi.ToString();

                    // Lấy lớp quản lý
                    string queryLop = @"SELECT TenLop FROM lop WHERE MaLop = 
                                (SELECT MaLop FROM sinhvien WHERE MaSV = @MaSV)";
                    MySqlCommand cmdLop = new MySqlCommand(queryLop, sqlConn);
                    cmdLop.Parameters.AddWithValue("@MaSV", masv);
                    object tenLop = cmdLop.ExecuteScalar();
                    lbLop.Text = "Lớp quản lý: " + tenLop.ToString();
                    // Tính GPA
                    string queryGPA = @"SELECT SUM(DiemTong * TinChi) / SUM(TinChi) AS GPA FROM diem d
                                JOIN monhoc m ON d.MaMH = m.MaMH
                                WHERE MaSV = @MaSV";
                    MySqlCommand cmdGPA = new MySqlCommand(queryGPA, sqlConn);
                    cmdGPA.Parameters.AddWithValue("@MaSV", masv);
                    object gpa = cmdGPA.ExecuteScalar();
                    lbGPA.Text = "Điểm trung bình tích lũy hệ 4: " + gpa.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadData()
        {
            string connectionString = $"Server={server};Database={database};Uid={username};Pwd={password};";
            string sqlQuery = @"SELECT mh.MaMH, mh.TenMon, mh.TinChi, d.DiemGiuaki, d.DiemCuoiki, d.DiemTong, d.HocKy 
                            FROM diem d
                            JOIN monhoc mh ON d.MaMH = mh.MaMH
                            WHERE d.MaSV = @MaSV";

            using (MySqlConnection sqlConn = new MySqlConnection(connectionString))
            {
                try
                {
                    sqlConn.Open();
                    MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                    sqlCmd.Parameters.AddWithValue("@MaSV", masv);

                    MySqlDataReader sqlDd = sqlCmd.ExecuteReader();
                    listView1.Items.Clear();

                    while (sqlDd.Read())
                    {
                        ListViewItem item = new ListViewItem(sqlDd["MaMH"].ToString());
                        item.SubItems.Add(sqlDd["TenMon"].ToString());
                        item.SubItems.Add(sqlDd["TinChi"].ToString());
                        item.SubItems.Add(sqlDd["DiemGiuaki"].ToString());
                        item.SubItems.Add(sqlDd["DiemCuoiki"].ToString());
                        item.SubItems.Add(sqlDd["DiemTong"].ToString());
                        item.SubItems.Add(sqlDd["HocKy"].ToString());

                        listView1.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {

        }

        private void btnThongBao_Click_1(object sender, EventArgs e)
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

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnYeucau_Click(object sender, EventArgs e)
        {
            string fullname123 = lbTen.Text;
            string masv = lbMsv1.Text;
            SVDangKyHoc form2 = new SVDangKyHoc(fullname123, masv);
            form2.Show(); this.Close();
        }
    }
}
