using CrystalDecisions.CrystalReports.Engine;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mysqlx.Datatypes.Scalar.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLSinhVien
{
    public partial class SVDangKyHoc : Form
    { // Khai báo các biến kết nối cơ sở dữ liệu
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
        private string masv;
        public SVDangKyHoc(string fullname123, string masv)
        {
            InitializeComponent();
            CenterToScreen();
            this.fullname = fullname123;
            this.masv = masv;
        }



        private void DangKyHoc_Load(object sender, EventArgs e)
        {
            LoadData();
            lbTen.Text = fullname;
            lbMsv1.Text= masv;
        }
        private void LoadData()
        {
            string connStr = $"Server={server}; database={database}; UID={username}; password={password}";
            sqlConn = new MySqlConnection(connStr);
            sqlConn.Open();

            sqlQuery = "SELECT monhoc.MaMH, monhoc.TenMon, monhoc.TinChi, giangvien.HoTen, giangvien.MaMH FROM monhoc " +
                       "JOIN giangvien ON monhoc.MaMH = giangvien.MaMH";
            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
            sqlDta = new MySqlDataAdapter(sqlCmd);
            DS = new DataSet();
            sqlDta.Fill(DS);
            sqlDt = DS.Tables[0];

            foreach (DataRow row in sqlDt.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(row["MaMH"].ToString());
                item.SubItems.Add(row["TenMon"].ToString());
                item.SubItems.Add(row["TinChi"].ToString());
                item.SubItems.Add(row["HoTen"].ToString());
                item.SubItems.Add(""); // Add schedule information if available
                listView1.Items.Add(item);
            }

            sqlConn.Close();
        }
        private void ListView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            int totalCredits = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Checked)
                {
                    totalCredits += int.Parse(item.SubItems[3].Text);
                }
            }
            lbSotinchi.Text = $"Tổng Số Tín Chỉ: {totalCredits}";
        }
        private void RegisterCourse(string maSV, List<string> maMHList)
        {
            string connStr = $"Server={server}; database={database}; UID={username}; password={password}";
            using (MySqlConnection sqlConn = new MySqlConnection(connStr))
            {
                sqlConn.Open();
                using (MySqlTransaction transaction = sqlConn.BeginTransaction())
                {
                    try
                    {
                        // Xóa tất cả các môn học đã đăng ký trước đó của sinh viên
                        string deleteQuery = "DELETE FROM registration WHERE MaSV = @MaSV";
                        using (MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, sqlConn, transaction))
                        {
                            deleteCmd.Parameters.AddWithValue("@MaSV", maSV);
                            deleteCmd.ExecuteNonQuery();
                        }

                        // Thêm mới các môn học được chọn vào bảng đăng ký
                        string insertQuery = "INSERT INTO registration (MaSV, MaMH) VALUES (@MaSV, @MaMH)";
                        foreach (string maMH in maMHList)
                        {
                            using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, sqlConn, transaction))
                            {
                                insertCmd.Parameters.AddWithValue("@MaSV", maSV);
                                insertCmd.Parameters.AddWithValue("@MaMH", maMH);
                                insertCmd.ExecuteNonQuery();
                            }
                        }

                        // Commit transaction
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        // Rollback transaction if an exception occurs
                        transaction.Rollback();
                        MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }







        private void btnThongBao_Click(object sender, EventArgs e)
        {
            string fullname123 = lbTen.Text;
            string masv = lbMsv1.Text;
            SVThongBaoNguoiDung form2 = new SVThongBaoNguoiDung(fullname123, masv);
            form2.Show(); this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fullname123 = lbTen.Text;
            string masv = lbMsv1.Text;
            SVThongTinCaNhan form2 = new SVThongTinCaNhan(fullname123, masv);
            form2.Show(); this.Close();
        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
            string fullname123 = lbTen.Text;
            string masv = lbMsv1.Text;
            SVnguoidung form2 = new SVnguoidung(fullname123, masv);
            form2.Show(); this.Close();
        }

        private void btnPhantich_Click(object sender, EventArgs e)
        {
            string fullname123 = lbTen.Text;
            string masv = lbMsv1.Text;
            SVanalysisSV form2 = new SVanalysisSV(fullname123, masv);
            form2.Show(); this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
    
            List<string> maMHList = new List<string>();
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Checked)
                {
                    string maMH = item.SubItems[1].Text;
                    maMHList.Add(maMH);
                }
            }

            // Gọi phương thức RegisterCourse với cả mã sinh viên và danh sách mã môn học
            RegisterCourse(masv, maMHList);

            MessageBox.Show("Đăng ký thành công!");
        }

    }
}
