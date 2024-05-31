using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using ClosedXML.Excel;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QLSinhVien
{
    public partial class QLMenu : Form
    {
        MySqlConnection sqlConn = new MySqlConnection();
        MySqlCommand sqlCmd = new MySqlCommand();
        DataTable sqlDt = new DataTable();
        MySqlDataAdapter sqlDta = new MySqlDataAdapter();
        MySqlDataReader sqlDd;
        DataSet DS = new DataSet();
        MySqlConnection sqlConn1 = new MySqlConnection();
        MySqlCommand sqlCmd1 = new MySqlCommand();
        DataTable sqlDt1 = new DataTable();
        MySqlDataAdapter sqlDta1 = new MySqlDataAdapter();
        MySqlDataReader sqlDd1;
        DataSet DS1 = new DataSet();

        string sqlQuery;
        MySqlCommand sqlCmd2 = new MySqlCommand();
        DataTable sqlDt2 = new DataTable();
        MySqlDataAdapter sqlDta2 = new MySqlDataAdapter();
        MySqlDataReader sqlDd2;
        DataSet DS2 = new DataSet();
        MySqlConnection sqlConn2 = new MySqlConnection();
        string sqlQuery2;
        string server = "localhost";
        string username = "root";
        string password = "123456789";
        string database = "student";
        private string data;

        public QLMenu(string data)
        {
            InitializeComponent();
            this.data = data;
        }

        public QLMenu()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void groupBox_lop_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            QLsinhvien form1 = new QLsinhvien();
            // Hiển thị form mới
            form1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            QLkhoa form1 = new QLkhoa();
            // Hiển thị form mới
            form1.Show();
        }
        private void Load22()
        {
            DataTable sqlDt5 = new DataTable();
            dataGridView1.DataSource = sqlDt5;
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
            dataGridView1.DataSource = sqlDt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            KhoaUpload();
            sqlConn.ConnectionString = "server=" + server + ";username=" + username + ";password=" + password + ";database=" + database;
            try
            {
                sqlConn.Open();
                // Truy vấn SQL để lấy dữ liệu từ cơ sở dữ liệu
                string sqlQuery = "SELECT TenKhoa from khoa";

                MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                MySqlDataReader sqlReader = sqlCmd.ExecuteReader();

                // Xóa các mục có sẵn trong comboBox_tenK_k
                cbkhoa.Items.Clear();


                // Đọc dữ liệu từ cơ sở dữ liệu và thêm vào comboBox_tenK_k
                while (sqlReader.Read())
                {
                    cbkhoa.Items.Add(sqlReader["TenKhoa"].ToString());

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

            //theem học kì vào combobox
            sqlConn.ConnectionString = "server=" + server + ";username=" + username + ";password=" + password + ";database=" + database;
            try
            {
                sqlConn.Open();
                // Truy vấn SQL để lấy dữ liệu từ cơ sở dữ liệu
                string sqlQuery = "SELECT HocKy from diem";

                MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                MySqlDataReader sqlReader = sqlCmd.ExecuteReader();

                // Xóa các mục có sẵn trong comboBox_tenK_k
                cbHocKy.Items.Clear();


                // Đọc dữ liệu từ cơ sở dữ liệu và thêm vào comboBox_tenK_k
                while (sqlReader.Read())
                {
                    cbHocKy.Items.Add(sqlReader["HocKy"].ToString());

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
      

        private void button3_Click(object sender, EventArgs e)
        {
            QLgiangvien form1 = new QLgiangvien();
            // Hiển thị form mới
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QLlop form1 = new QLlop();
            // Hiển thị form mới
            form1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            QLmonhoc form1 = new QLmonhoc();
            // Hiển thị form mới
            form1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            QLdiem form1 = new QLdiem();
            // Hiển thị form mới
            form1.Show();
        }

        private void timKiemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void thoongsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chucNangToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            QLsinhvien form1 = new QLsinhvien();
            // Hiển thị form mới
            form1.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            QLkhoa form1 = new QLkhoa();
            // Hiển thị form mới
            form1.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            QLgiangvien form1 = new QLgiangvien();
            // Hiển thị form mới
            form1.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            QLlop form1 = new QLlop();
            // Hiển thị form mới
            form1.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            QLmonhoc form1 = new QLmonhoc();
            // Hiển thị form mới
            form1.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            QLdiem form1 = new QLdiem();
            // Hiển thị form mới
            form1.Show();
        }
        bool menuExpand = false;
        private void timerLoadMenu_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 60)
                {
                    timerLoadMenu.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 250)
                {
                    timerLoadMenu.Stop();
                    menuExpand = false;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timerLoadMenu.Start();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            QLlop form1 = new QLlop();
            // Hiển thị form mới
            form1.Show(); this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            QLgiangvien form1 = new QLgiangvien();
            // Hiển thị form mới
            form1.Show(); this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            QLmonhoc form1 = new QLmonhoc();
            // Hiển thị form mới
            form1.Show(); this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            QLsinhvien form1 = new QLsinhvien();
            // Hiển thị form mới
            form1.Show(); this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            QLdiem form1 = new QLdiem();
            // Hiển thị form mới
            form1.Show(); this.Close();
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

        private void button1_Click_2(object sender, EventArgs e)
        {
            QLThongKe form1 = new QLThongKe();
            // Hiển thị form mới
            form1.Show(); this.Close();
        }

        private void cbkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string makhoa = "";
            string tenkhoa = cbkhoa.SelectedItem.ToString(); ;


            sqlConn1.ConnectionString = "server=" + server + ";username=" + username + ";password=" + password + ";database=" + database;
            try
            {
                sqlConn1.Open();
                // Truy vấn SQL để lấy dữ liệu từ cơ sở dữ liệu
                string sqlQuery1 = "SELECT MaKhoa from khoa where TenKhoa = @TenKhoa";

                MySqlCommand sqlCmd1 = new MySqlCommand(sqlQuery1, sqlConn1);
                sqlCmd1.Parameters.AddWithValue("@TenKhoa", tenkhoa);
                makhoa = sqlCmd1.ExecuteScalar()?.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn1.Close();
            }




            //upload ten lop vào combobox
            sqlConn1.ConnectionString = "server=" + server + ";username=" + username + ";password=" + password + ";database=" + database;
            try
            {
                sqlConn1.Open();
                // Truy vấn SQL để lấy dữ liệu từ cơ sở dữ liệu
                string sqlQuery = "SELECT TenLop from lop where MaKhoa= '" + makhoa + "'";

                MySqlCommand sqlCmd1 = new MySqlCommand(sqlQuery, sqlConn1);
                MySqlDataReader sqlReader1 = sqlCmd1.ExecuteReader();

                // Xóa các mục có sẵn trong comboBox_tenK_k
                cbLop.Items.Clear();


                // Đọc dữ liệu từ cơ sở dữ liệu và thêm vào comboBox_tenK_k
                while (sqlReader1.Read())
                {
                    cbLop.Items.Add(sqlReader1["TenLop"].ToString());

                }

                // Đóng kết nối
                sqlReader1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn1.Close();
            }


            string connectionString = "Server=localhost;Database=student;Uid=root;Pwd=123456789;";


            try
            {
                sqlConn.Open();

                // Updated query to include the 'khoa' table and filter by the department name
                string query = @"
            SELECT sv.MaSV, sv.HoTen, sv.Email, sv.SDT, sv.DiaChi, sv.NgaySinh, sv.MaLop, 
                   k.TenKhoa,
                   SUM(dm.DiemTong * m.TinChi) / SUM(m.TinChi) AS GPA 
            FROM sinhvien AS sv 
            INNER JOIN lop AS l ON sv.MaLop = l.MaLop
            INNER JOIN khoa AS k ON l.MaKhoa = k.MaKhoa
            INNER JOIN diem AS dm ON sv.MaSV = dm.MaSV 
            INNER JOIN monhoc AS m ON dm.MaMH = m.MaMH 
            WHERE k.TenKhoa = @TenKhoa
            GROUP BY sv.MaSV, sv.HoTen, sv.Email, sv.SDT, sv.DiaChi, sv.NgaySinh, sv.MaLop, k.TenKhoa";

                MySqlCommand sqlCmd = new MySqlCommand(query, sqlConn);
                sqlCmd.Parameters.AddWithValue("@TenKhoa", cbkhoa.SelectedItem.ToString());

                MySqlDataAdapter sqlDta = new MySqlDataAdapter(sqlCmd);
                DataTable dataTable = new DataTable();
                sqlDta.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }

        }

        private void txtYeucau_TextChanged(object sender, EventArgs e)
        {
            string s = cbLuaChon.SelectedItem.ToString();
            if (s == "Tìm kiếm theo mã sinh viên") {
                string connectionString = "Server=localhost;Database=student;Uid=root;Pwd=123456789;";
                MySqlConnection sqlConn = new MySqlConnection(connectionString);

                try
                {
                    sqlConn.Open();

                    string query = "SELECT sv.MaSV, sv.HoTen, sv.SDT, sv.DiaChi, sv.NgaySinh, sv.MaLop, " +
                               "SUM(dm.DiemTong * m.TinChi) / SUM(m.TinChi) AS GPA " +
                               "FROM sinhvien AS sv " +
                               "INNER JOIN diem AS dm ON sv.MaSV = dm.MaSV " +
                               "INNER JOIN monhoc AS m ON dm.MaMH = m.MaMH " +
                               "WHERE sv.MaSV = @MaSV " +
                               "GROUP BY sv.MaSV, sv.HoTen, sv.SDT, sv.DiaChi, sv.NgaySinh, sv.MaLop";
                    MySqlCommand sqlCmd = new MySqlCommand(query, sqlConn);
                    sqlCmd.Parameters.AddWithValue("@MaSV", txtYeucau.Text);

                    MySqlDataAdapter sqlDta = new MySqlDataAdapter(sqlCmd);
                    DataTable dataTable = new DataTable();
                    sqlDta.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    sqlConn.Close();
                }
            }
            else if (s == "Tìm kiếm theo tên sinh viên")
            {
                string connectionString = "Server=localhost;Database=student;Uid=root;Pwd=123456789;";
                MySqlConnection sqlConn = new MySqlConnection(connectionString);

                try
                {
                    sqlConn.Open();

                    string query = "SELECT sv.MaSV, sv.HoTen, sv.SDT, sv.DiaChi, sv.NgaySinh, sv.MaLop, " +
                                "SUM(dm.DiemTong * m.TinChi) / SUM(m.TinChi) AS GPA " +
                                "FROM sinhvien AS sv " +
                                "INNER JOIN diem AS dm ON sv.MaSV = dm.MaSV " +
                                "INNER JOIN monhoc AS m ON dm.MaMH = m.MaMH " +
                                "WHERE sv.HoTen = @HoTen " +
                                "GROUP BY sv.MaSV, sv.HoTen, sv.SDT, sv.DiaChi, sv.NgaySinh, sv.MaLop";
                    MySqlCommand sqlCmd = new MySqlCommand(query, sqlConn);
                    sqlCmd.Parameters.AddWithValue("@HoTen", txtYeucau.Text);

                    MySqlDataAdapter sqlDta = new MySqlDataAdapter(sqlCmd);
                    DataTable dataTable = new DataTable();
                    sqlDta.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    sqlConn.Close();
                }
            }
        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {

            sqlConn.ConnectionString = "server=" + server + ";username=" + username + ";password=" + password + ";database=" + database;
            try
            {
                sqlConn.Open();

                // Updated query to include the 'khoa' table and filter by the department name
                string query = @"
            SELECT sv.MaSV, sv.HoTen, sv.Email, sv.SDT, sv.DiaChi, sv.NgaySinh, sv.MaLop, 
                   k.TenKhoa,
                   SUM(dm.DiemTong * m.TinChi) / SUM(m.TinChi) AS GPA 
            FROM sinhvien AS sv 
            INNER JOIN lop AS l ON sv.MaLop = l.MaLop
            INNER JOIN khoa AS k ON l.MaKhoa = k.MaKhoa
            INNER JOIN diem AS dm ON sv.MaSV = dm.MaSV 
            INNER JOIN monhoc AS m ON dm.MaMH = m.MaMH 
            WHERE l.TenLop = @TenLop
            GROUP BY sv.MaSV, sv.HoTen, sv.Email, sv.SDT, sv.DiaChi, sv.NgaySinh, sv.MaLop, k.TenKhoa
                ORDER BY 
                sv.MaSV;";

                MySqlCommand sqlCmd = new MySqlCommand(query, sqlConn);
                sqlCmd.Parameters.AddWithValue("@TenLop", cbLop.SelectedItem.ToString());

                MySqlDataAdapter sqlDta = new MySqlDataAdapter(sqlCmd);
                DataTable dataTable = new DataTable();
                sqlDta.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            
            if (cbHocKy.SelectedItem != null)
            {string s = cbHocKy.SelectedItem.ToString();
                if (cbLuaChon.SelectedItem == "Tìm kiếm theo học bổng")
                {


            


                    if (cbkhoa.SelectedItem == null & cbLop.SelectedItem == null)
                    {
                        sqlConn.ConnectionString = "server=" + server + ";username=" + username + ";password=" + password + ";database=" + database;
                        try
                        {
                            sqlConn.Open();

                            string sqlQuery = @"
                        SELECT sv.MaSV, sv.HoTen, sv.Email, sv.SDT, sv.DiaChi, sv.NgaySinh, sv.MaLop, 
                               SUM(d.DiemTong * mh.TinChi) / SUM(mh.TinChi) AS GPA
                        FROM sinhvien sv
                        JOIN diem d ON sv.MaSV = d.MaSV
                        JOIN monhoc mh ON d.MaMH = mh.MaMH
                        WHERE d.HocKy = @HocKy
                        GROUP BY sv.MaSV
                        HAVING GPA > 3.2
                        ORDER BY 
                        sv.HoTen;";

                            using (MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn))
                            {
                                // Assuming the semester (HocKy) is passed as a parameter
                                sqlCmd.Parameters.AddWithValue("@HocKy", s); // Example semester value

                                using (MySqlDataAdapter sqlDta = new MySqlDataAdapter(sqlCmd))
                                {
                                    DataTable sqlDt = new DataTable();
                                    sqlDta.Fill(sqlDt);

                                    // Bind the DataTable to the DataGridView
                                    dataGridView1.DataSource = sqlDt;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message);
                        }
                    }
                    else if (cbLop.SelectedItem == null & cbkhoa.SelectedItem != null)
                    {
                        LoadData();
                    }
                    else
                    {
                        LoadData2();
                    }

                }
                else if (cbLuaChon.SelectedItem == "Tìm kiếm theo sinh viên bị cảnh báo học vụ")
                {
                    if (cbkhoa.SelectedItem == null & cbLop.SelectedItem == null)
                    {
                        sqlConn.ConnectionString = "server=" + server + ";username=" + username + ";password=" + password + ";database=" + database;
                        try
                        {
                            sqlConn.Open();

                            string sqlQuery = @"
                        SELECT sv.MaSV, sv.HoTen, sv.Email, sv.SDT, sv.DiaChi, sv.NgaySinh, sv.MaLop, 
                               SUM(d.DiemTong * mh.TinChi) / SUM(mh.TinChi) AS GPA
                        FROM sinhvien sv
                        JOIN diem d ON sv.MaSV = d.MaSV
                        JOIN monhoc mh ON d.MaMH = mh.MaMH
                        WHERE d.HocKy = @HocKy
                        GROUP BY sv.MaSV
                        HAVING GPA < 2
                        ORDER BY 
                            sv.HoTen;";

                            using (MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn))
                            {
                                // Assuming the semester (HocKy) is passed as a parameter
                                sqlCmd.Parameters.AddWithValue("@HocKy", s); // Example semester value

                                using (MySqlDataAdapter sqlDta = new MySqlDataAdapter(sqlCmd))
                                {
                                    DataTable sqlDt = new DataTable();
                                    sqlDta.Fill(sqlDt);

                                    // Bind the DataTable to the DataGridView
                                    dataGridView1.DataSource = sqlDt;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message);
                        }
                    }
                    else if (cbLop.SelectedItem == null & cbkhoa.SelectedItem != null)
                    {
                        LoadDataHocVu();
                    }
                    else
                    {
                        LoadDataHocVu2();
                    }
                }
            }
        }
        private string connectionString = "Server=localhost;Database=student;User ID=root;Password=123456789;";
        private void LoadData()
        {
            string pecifiedHocKy = "";
            string pecifiedMaKhoa = "";
            pecifiedHocKy = cbHocKy.SelectedItem.ToString();
            pecifiedMaKhoa = cbkhoa.SelectedItem.ToString();

            using (MySqlConnection sqlConn = new MySqlConnection(connectionString))
            {
                try
                {
                    sqlConn.Open();

                    string sqlQuery = @"
                       SELECT 
                            sv.MaSV, 
                            sv.HoTen, 
                            sv.Email, 
                            sv.SDT, 
                            sv.DiaChi, 
                            sv.NgaySinh, 
                            l.TenLop, 
                            k.TenKhoa,
                            SUM(d.DiemTong * mh.TinChi) / SUM(mh.TinChi) AS GPA
                        FROM 
                            sinhvien sv
                        JOIN 
                            lop l ON sv.MaLop = l.MaLop
                        JOIN 
                            khoa k ON l.MaKhoa = k.MaKhoa
                        JOIN 
                            diem d ON sv.MaSV = d.MaSV
                        JOIN 
                            monhoc mh ON d.MaMH = mh.MaMH
                        WHERE 
                            d.HocKy = @specifiedHocKy AND 
                            k.TenKhoa =  @specifiedMaKhoa
                        GROUP BY 
                            sv.MaSV, sv.HoTen, sv.Email, sv.SDT, sv.DiaChi, sv.NgaySinh, l.TenLop, k.TenKhoa
                        HAVING 
                            GPA > 3.2
                        ORDER BY 
                         sv.HoTen;";

                    using (MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn))
                    {
                        sqlCmd.Parameters.AddWithValue("@specifiedHocKy", pecifiedHocKy);
                        sqlCmd.Parameters.AddWithValue("@specifiedMaKhoa", pecifiedMaKhoa);

                        MySqlDataAdapter sqlDta = new MySqlDataAdapter(sqlCmd);
                        DataTable sqlDt = new DataTable();
                        sqlDta.Fill(sqlDt);

                        dataGridView1.DataSource = sqlDt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
        private void LoadData2()
        {
            string pecifiedHocKy = "";
            string pecifiedMaKhoa = "";
            pecifiedHocKy = cbHocKy.SelectedItem.ToString();
            pecifiedMaKhoa = cbkhoa.SelectedItem.ToString();
            string tenlop = cbLop.SelectedItem.ToString();
            using (MySqlConnection sqlConn = new MySqlConnection(connectionString))
            {
                try
                {
                    sqlConn.Open();

                    string sqlQuery = @"
                       SELECT 
                            sv.MaSV, 
                            sv.HoTen, 
                            sv.Email, 
                            sv.SDT, 
                            sv.DiaChi, 
                            sv.NgaySinh, 
                            l.TenLop, 
                            k.TenKhoa,
                            SUM(d.DiemTong * mh.TinChi) / SUM(mh.TinChi) AS GPA
                        FROM 
                            sinhvien sv
                        JOIN 
                            lop l ON sv.MaLop = l.MaLop
                        JOIN 
                            khoa k ON l.MaKhoa = k.MaKhoa
                        JOIN 
                            diem d ON sv.MaSV = d.MaSV
                        JOIN 
                            monhoc mh ON d.MaMH = mh.MaMH
                        WHERE 
                            d.HocKy = @specifiedHocKy AND 
                            k.TenKhoa =  @specifiedMaKhoa AND
                            l.TenLop = @tenlop
                        GROUP BY 
                            sv.MaSV, sv.HoTen, sv.Email, sv.SDT, sv.DiaChi, sv.NgaySinh, l.TenLop, k.TenKhoa
                        HAVING 
                            GPA > 3.2
                        ORDER BY 
                            sv.HoTen;";

                    using (MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn))
                    {
                        sqlCmd.Parameters.AddWithValue("@specifiedHocKy", pecifiedHocKy);
                        sqlCmd.Parameters.AddWithValue("@specifiedMaKhoa", pecifiedMaKhoa);
                        sqlCmd.Parameters.AddWithValue("@tenlop", tenlop);

                        MySqlDataAdapter sqlDta = new MySqlDataAdapter(sqlCmd);
                        DataTable sqlDt = new DataTable();
                        sqlDta.Fill(sqlDt);

                        dataGridView1.DataSource = sqlDt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }


        private void LoadDataHocVu()
        {
            string pecifiedHocKy = "";
            string pecifiedMaKhoa = "";
            pecifiedHocKy = cbHocKy.SelectedItem.ToString();
            pecifiedMaKhoa = cbkhoa.SelectedItem.ToString();

            using (MySqlConnection sqlConn = new MySqlConnection(connectionString))
            {
                try
                {
                    sqlConn.Open();

                    string sqlQuery = @"
                       SELECT 
                            sv.MaSV, 
                            sv.HoTen, 
                            sv.Email, 
                            sv.SDT, 
                            sv.DiaChi, 
                            sv.NgaySinh, 
                            l.TenLop, 
                            k.TenKhoa,
                            SUM(d.DiemTong * mh.TinChi) / SUM(mh.TinChi) AS GPA
                        FROM 
                            sinhvien sv
                        JOIN 
                            lop l ON sv.MaLop = l.MaLop
                        JOIN 
                            khoa k ON l.MaKhoa = k.MaKhoa
                        JOIN 
                            diem d ON sv.MaSV = d.MaSV
                        JOIN 
                            monhoc mh ON d.MaMH = mh.MaMH
                        WHERE 
                            d.HocKy = @specifiedHocKy AND 
                            k.TenKhoa =  @specifiedMaKhoa
                        GROUP BY 
                            sv.MaSV, sv.HoTen, sv.Email, sv.SDT, sv.DiaChi, sv.NgaySinh, l.TenLop, k.TenKhoa
                        HAVING 
                            GPA < 2
                        ORDER BY 
                         sv.HoTen;";

                    using (MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn))
                    {
                        sqlCmd.Parameters.AddWithValue("@specifiedHocKy", pecifiedHocKy);
                        sqlCmd.Parameters.AddWithValue("@specifiedMaKhoa", pecifiedMaKhoa);

                        MySqlDataAdapter sqlDta = new MySqlDataAdapter(sqlCmd);
                        DataTable sqlDt = new DataTable();
                        sqlDta.Fill(sqlDt);

                        dataGridView1.DataSource = sqlDt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
        private void LoadDataHocVu2()
        {
            string pecifiedHocKy = "";
            string pecifiedMaKhoa = "";
            pecifiedHocKy = cbHocKy.SelectedItem.ToString();
            pecifiedMaKhoa = cbkhoa.SelectedItem.ToString();
            string tenlop = cbLop.SelectedItem.ToString();
            using (MySqlConnection sqlConn = new MySqlConnection(connectionString))
            {
                try
                {
                    sqlConn.Open();

                    string sqlQuery = @"
                       SELECT 
                            sv.MaSV, 
                            sv.HoTen, 
                            sv.Email, 
                            sv.SDT, 
                            sv.DiaChi, 
                            sv.NgaySinh, 
                            l.TenLop, 
                            k.TenKhoa,
                            SUM(d.DiemTong * mh.TinChi) / SUM(mh.TinChi) AS GPA
                        FROM 
                            sinhvien sv
                        JOIN 
                            lop l ON sv.MaLop = l.MaLop
                        JOIN 
                            khoa k ON l.MaKhoa = k.MaKhoa
                        JOIN 
                            diem d ON sv.MaSV = d.MaSV
                        JOIN 
                            monhoc mh ON d.MaMH = mh.MaMH
                        WHERE 
                            d.HocKy = @specifiedHocKy AND 
                            k.TenKhoa =  @specifiedMaKhoa AND
                            l.TenLop = @tenlop
                        GROUP BY 
                            sv.MaSV, sv.HoTen, sv.Email, sv.SDT, sv.DiaChi, sv.NgaySinh, l.TenLop, k.TenKhoa
                        HAVING 
                                GPA < 2 
                        ORDER BY 
                            sv.HoTen;";

                    using (MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn))
                    {
                        sqlCmd.Parameters.AddWithValue("@specifiedHocKy", pecifiedHocKy);
                        sqlCmd.Parameters.AddWithValue("@specifiedMaKhoa", pecifiedMaKhoa);
                        sqlCmd.Parameters.AddWithValue("@tenlop", tenlop);

                        MySqlDataAdapter sqlDta = new MySqlDataAdapter(sqlCmd);
                        DataTable sqlDt = new DataTable();
                        sqlDta.Fill(sqlDt);

                        dataGridView1.DataSource = sqlDt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            using (XLWorkbook wb = new XLWorkbook())
                            {
                                DataTable dt = new DataTable();

                                // Add DataGridView columns to DataTable
                                foreach (DataGridViewColumn column in dataGridView1.Columns)
                                {
                                    dt.Columns.Add(column.HeaderText, typeof(string));
                                }

                                // Add DataGridView rows to DataTable
                                foreach (DataGridViewRow row in dataGridView1.Rows)
                                {
                                    DataRow dr = dt.NewRow();
                                    foreach (DataGridViewCell cell in row.Cells)
                                    {
                                        dr[cell.ColumnIndex] = cell.Value?.ToString();
                                    }
                                    dt.Rows.Add(dr);
                                }

                                // Add DataTable as a worksheet
                                wb.Worksheets.Add(dt, "Students");
                                wb.SaveAs(sfd.FileName);

                                MessageBox.Show("Data has been successfully exported.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No data available to export.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    
}
