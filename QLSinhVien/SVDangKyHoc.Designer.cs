﻿using System.Windows.Forms;

namespace QLSinhVien
{
    partial class SVDangKyHoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SVDangKyHoc));
            this.lb = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMsv1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnThongBao = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnYeucau = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDiem = new System.Windows.Forms.Button();
            this.pnLogout = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPhantich = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.blLoad = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbChude = new System.Windows.Forms.Label();
            this.pnXemDiem = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lbSotinchi = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnLogout.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.blLoad.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnXemDiem.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.ForeColor = System.Drawing.Color.White;
            this.lb.Location = new System.Drawing.Point(12, 57);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(77, 13);
            this.lb.TabIndex = 1;
            this.lb.Text = "Mã sinh viên:";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.Color.White;
            this.lb1.Location = new System.Drawing.Point(12, 25);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(58, 13);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Sinh viên:";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.ForeColor = System.Drawing.Color.White;
            this.lbTen.Location = new System.Drawing.Point(76, 25);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(51, 13);
            this.lbTen.TabIndex = 2;
            this.lbTen.Text = "Lê Văn H";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(386, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CỔNG THÔNG TIN DÀNH CHO NGƯỜI HỌC";
            // 
            // lbMsv1
            // 
            this.lbMsv1.AutoSize = true;
            this.lbMsv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMsv1.ForeColor = System.Drawing.Color.White;
            this.lbMsv1.Location = new System.Drawing.Point(95, 57);
            this.lbMsv1.Name = "lbMsv1";
            this.lbMsv1.Size = new System.Drawing.Size(31, 13);
            this.lbMsv1.TabIndex = 3;
            this.lbMsv1.Text = "2121";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.lbMsv1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbTen);
            this.groupBox2.Controls.Add(this.lb1);
            this.groupBox2.Controls.Add(this.lb);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(998, 80);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnThongBao);
            this.panel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(3, 6);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(212, 54);
            this.panel8.TabIndex = 37;
            // 
            // btnThongBao
            // 
            this.btnThongBao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThongBao.ForeColor = System.Drawing.Color.White;
            this.btnThongBao.Image = ((System.Drawing.Image)(resources.GetObject("btnThongBao.Image")));
            this.btnThongBao.Location = new System.Drawing.Point(-159, -7);
            this.btnThongBao.Margin = new System.Windows.Forms.Padding(2);
            this.btnThongBao.Name = "btnThongBao";
            this.btnThongBao.Size = new System.Drawing.Size(376, 70);
            this.btnThongBao.TabIndex = 18;
            this.btnThongBao.Text = "                                           Thông báo và tin tức";
            this.btnThongBao.UseVisualStyleBackColor = false;
            this.btnThongBao.Click += new System.EventHandler(this.btnThongBao_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnYeucau);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 227);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(212, 54);
            this.panel3.TabIndex = 39;
            // 
            // btnYeucau
            // 
            this.btnYeucau.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnYeucau.ForeColor = System.Drawing.Color.White;
            this.btnYeucau.Image = ((System.Drawing.Image)(resources.GetObject("btnYeucau.Image")));
            this.btnYeucau.Location = new System.Drawing.Point(-164, -7);
            this.btnYeucau.Margin = new System.Windows.Forms.Padding(2);
            this.btnYeucau.Name = "btnYeucau";
            this.btnYeucau.Size = new System.Drawing.Size(388, 70);
            this.btnYeucau.TabIndex = 18;
            this.btnYeucau.Text = "                                        Đăng ký môn học";
            this.btnYeucau.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(5, 63);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(212, 54);
            this.panel4.TabIndex = 40;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(-165, -7);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(383, 70);
            this.button2.TabIndex = 18;
            this.button2.Text = "                                          Thông tin cá nhân";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDiem);
            this.panel1.Location = new System.Drawing.Point(6, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 57);
            this.panel1.TabIndex = 41;
            // 
            // btnDiem
            // 
            this.btnDiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiem.ForeColor = System.Drawing.Color.White;
            this.btnDiem.Image = ((System.Drawing.Image)(resources.GetObject("btnDiem.Image")));
            this.btnDiem.Location = new System.Drawing.Point(-171, -9);
            this.btnDiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnDiem.Name = "btnDiem";
            this.btnDiem.Size = new System.Drawing.Size(388, 70);
            this.btnDiem.TabIndex = 18;
            this.btnDiem.Text = "                                      Kết quả học tập";
            this.btnDiem.UseVisualStyleBackColor = false;
            this.btnDiem.Click += new System.EventHandler(this.btnDiem_Click);
            // 
            // pnLogout
            // 
            this.pnLogout.Controls.Add(this.btnLogout);
            this.pnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnLogout.Location = new System.Drawing.Point(3, 335);
            this.pnLogout.Name = "pnLogout";
            this.pnLogout.Size = new System.Drawing.Size(212, 54);
            this.pnLogout.TabIndex = 40;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(-220, -11);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(499, 70);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "                                 Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPhantich);
            this.panel2.Location = new System.Drawing.Point(6, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 57);
            this.panel2.TabIndex = 42;
            // 
            // btnPhantich
            // 
            this.btnPhantich.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPhantich.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhantich.ForeColor = System.Drawing.Color.White;
            this.btnPhantich.Image = ((System.Drawing.Image)(resources.GetObject("btnPhantich.Image")));
            this.btnPhantich.Location = new System.Drawing.Point(-171, -11);
            this.btnPhantich.Margin = new System.Windows.Forms.Padding(2);
            this.btnPhantich.Name = "btnPhantich";
            this.btnPhantich.Size = new System.Drawing.Size(388, 79);
            this.btnPhantich.TabIndex = 40;
            this.btnPhantich.Text = "                                      Phân tích điểm";
            this.btnPhantich.UseVisualStyleBackColor = false;
            this.btnPhantich.Click += new System.EventHandler(this.btnPhantich_Click);
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(218, 40);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(780, 417);
            this.panel6.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button1);
            this.panel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(0, 282);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(212, 54);
            this.panel7.TabIndex = 42;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(-165, -7);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(388, 70);
            this.button1.TabIndex = 18;
            this.button1.Text = "                                            Gửi yêu cầu trợ giúp";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // blLoad
            // 
            this.blLoad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.blLoad.Controls.Add(this.panel7);
            this.blLoad.Controls.Add(this.panel6);
            this.blLoad.Controls.Add(this.panel2);
            this.blLoad.Controls.Add(this.pnLogout);
            this.blLoad.Controls.Add(this.panel1);
            this.blLoad.Controls.Add(this.panel4);
            this.blLoad.Controls.Add(this.panel3);
            this.blLoad.Controls.Add(this.panel8);
            this.blLoad.Dock = System.Windows.Forms.DockStyle.Left;
            this.blLoad.Location = new System.Drawing.Point(0, 80);
            this.blLoad.Name = "blLoad";
            this.blLoad.Size = new System.Drawing.Size(220, 457);
            this.blLoad.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbChude);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(778, 34);
            this.panel5.TabIndex = 2;
            // 
            // lbChude
            // 
            this.lbChude.AutoSize = true;
            this.lbChude.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChude.Location = new System.Drawing.Point(305, 6);
            this.lbChude.Name = "lbChude";
            this.lbChude.Size = new System.Drawing.Size(163, 21);
            this.lbChude.TabIndex = 0;
            this.lbChude.Text = "ĐĂNG KÝ MÔN HỌC";
            // 
            // pnXemDiem
            // 
            this.pnXemDiem.Controls.Add(this.panel9);
            this.pnXemDiem.Controls.Add(this.listView1);
            this.pnXemDiem.Controls.Add(this.panel5);
            this.pnXemDiem.Location = new System.Drawing.Point(220, 80);
            this.pnXemDiem.Name = "pnXemDiem";
            this.pnXemDiem.Size = new System.Drawing.Size(778, 457);
            this.pnXemDiem.TabIndex = 14;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.lbSotinchi);
            this.panel9.Controls.Add(this.button3);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 425);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(778, 32);
            this.panel9.TabIndex = 3;
            // 
            // lbSotinchi
            // 
            this.lbSotinchi.AutoSize = true;
            this.lbSotinchi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSotinchi.Location = new System.Drawing.Point(3, 7);
            this.lbSotinchi.Name = "lbSotinchi";
            this.lbSotinchi.Size = new System.Drawing.Size(70, 17);
            this.lbSotinchi.TabIndex = 1;
            this.lbSotinchi.Text = "Số tín chỉ:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.Location = new System.Drawing.Point(695, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 32);
            this.button3.TabIndex = 0;
            this.button3.Text = "Đăng ký";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 34);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(778, 391);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Columns.Add("Chọn", 50);
            this.listView1.Columns.Add("Mã Môn", 100);
            this.listView1.Columns.Add("Tên Môn", 150);
            this.listView1.Columns.Add("Tín Chỉ", 50);
            this.listView1.Columns.Add("Giảng Viên", 150);
            this.listView1.Columns.Add("Lịch Học", 200);
          
            this.listView1.ItemChecked += new ItemCheckedEventHandler(this.ListView1_ItemChecked);
            // 
            // DangKyHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(998, 537);
            this.Controls.Add(this.pnXemDiem);
            this.Controls.Add(this.blLoad);
            this.Controls.Add(this.groupBox2);
            this.Name = "DangKyHoc";
            this.Text = "DangKyHoc";
            this.Load += new System.EventHandler(this.DangKyHoc_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnLogout.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.blLoad.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.pnXemDiem.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMsv1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnThongBao;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnYeucau;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDiem;
        private System.Windows.Forms.Panel pnLogout;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPhantich;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel blLoad;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbChude;
        private System.Windows.Forms.Panel pnXemDiem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lbSotinchi;
        private System.Windows.Forms.Button button3;
    }
}