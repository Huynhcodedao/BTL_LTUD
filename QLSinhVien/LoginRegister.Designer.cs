namespace QLSinhVien
{
    partial class LoginRegister
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginRegister));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cbluachon = new System.Windows.Forms.ComboBox();
            this.linkRegister = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThoat1 = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtComfirm = new System.Windows.Forms.TextBox();
            this.txtPassdangky = new System.Windows.Forms.TextBox();
            this.txtUsernameDangky = new System.Windows.Forms.TextBox();
            this.lb5 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.linklogin = new System.Windows.Forms.LinkLabel();
            this.lb1 = new System.Windows.Forms.Label();
            this.btnthoat2 = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnSignup = new System.Windows.Forms.Button();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbotp = new System.Windows.Forms.Label();
            this.txtOTP = new System.Windows.Forms.TextBox();
            this.btnXacnhan = new System.Windows.Forms.Button();
            this.pnload = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timerLoad = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnload.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 377);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Sáng tạo - Tiên phong - Chất lượng cao";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(168, 164);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.Cbluachon);
            this.groupBox1.Controls.Add(this.linkRegister);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnThoat1);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(536, 169);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(348, 242);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng nhập";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Cbluachon
            // 
            this.Cbluachon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbluachon.FormattingEnabled = true;
            this.Cbluachon.Items.AddRange(new object[] {
            "Người quản lý",
            "Sinh viên"});
            this.Cbluachon.Location = new System.Drawing.Point(127, 139);
            this.Cbluachon.Name = "Cbluachon";
            this.Cbluachon.Size = new System.Drawing.Size(202, 25);
            this.Cbluachon.TabIndex = 11;
            this.Cbluachon.Text = "Người quản lý";
            this.Cbluachon.SelectedIndexChanged += new System.EventHandler(this.Cbluachon_SelectedIndexChanged);
            // 
            // linkRegister
            // 
            this.linkRegister.AutoSize = true;
            this.linkRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkRegister.LinkColor = System.Drawing.Color.Black;
            this.linkRegister.Location = new System.Drawing.Point(260, 216);
            this.linkRegister.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkRegister.Name = "linkRegister";
            this.linkRegister.Size = new System.Drawing.Size(69, 18);
            this.linkRegister.TabIndex = 10;
            this.linkRegister.TabStop = true;
            this.linkRegister.Text = "Đăng ký";
            this.linkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegister_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên truy cập";
            // 
            // btnThoat1
            // 
            this.btnThoat1.BackColor = System.Drawing.Color.White;
            this.btnThoat1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat1.Location = new System.Drawing.Point(229, 178);
            this.btnThoat1.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat1.Name = "btnThoat1";
            this.btnThoat1.Size = new System.Drawing.Size(100, 26);
            this.btnThoat1.TabIndex = 7;
            this.btnThoat1.Text = "Thoát";
            this.btnThoat1.UseVisualStyleBackColor = false;
            this.btnThoat1.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(127, 98);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(202, 25);
            this.txtPassword.TabIndex = 9;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(127, 178);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(98, 26);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Tag = "";
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(127, 48);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(202, 25);
            this.txtUsername.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txtComfirm);
            this.groupBox2.Controls.Add(this.txtPassdangky);
            this.groupBox2.Controls.Add(this.txtUsernameDangky);
            this.groupBox2.Controls.Add(this.lb5);
            this.groupBox2.Controls.Add(this.lb4);
            this.groupBox2.Controls.Add(this.lb3);
            this.groupBox2.Controls.Add(this.linklogin);
            this.groupBox2.Controls.Add(this.lb1);
            this.groupBox2.Controls.Add(this.btnthoat2);
            this.groupBox2.Controls.Add(this.txtPhone);
            this.groupBox2.Controls.Add(this.btnSignup);
            this.groupBox2.Controls.Add(this.txtFullname);
            this.groupBox2.Controls.Add(this.lb2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(536, 164);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(375, 331);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đăng ký";
            this.groupBox2.Visible = false;
            // 
            // txtComfirm
            // 
            this.txtComfirm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtComfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComfirm.Location = new System.Drawing.Point(158, 219);
            this.txtComfirm.Margin = new System.Windows.Forms.Padding(2);
            this.txtComfirm.Name = "txtComfirm";
            this.txtComfirm.PasswordChar = '*';
            this.txtComfirm.Size = new System.Drawing.Size(195, 22);
            this.txtComfirm.TabIndex = 17;
            // 
            // txtPassdangky
            // 
            this.txtPassdangky.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPassdangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassdangky.Location = new System.Drawing.Point(158, 176);
            this.txtPassdangky.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassdangky.Name = "txtPassdangky";
            this.txtPassdangky.PasswordChar = '*';
            this.txtPassdangky.Size = new System.Drawing.Size(195, 22);
            this.txtPassdangky.TabIndex = 16;
            // 
            // txtUsernameDangky
            // 
            this.txtUsernameDangky.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtUsernameDangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameDangky.Location = new System.Drawing.Point(158, 131);
            this.txtUsernameDangky.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsernameDangky.Name = "txtUsernameDangky";
            this.txtUsernameDangky.Size = new System.Drawing.Size(195, 22);
            this.txtUsernameDangky.TabIndex = 15;
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb5.Location = new System.Drawing.Point(11, 225);
            this.lb5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(118, 17);
            this.lb5.TabIndex = 13;
            this.lb5.Text = "Xác nhận mật khẩu";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb4.Location = new System.Drawing.Point(11, 182);
            this.lb4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(62, 17);
            this.lb4.TabIndex = 12;
            this.lb4.Text = "Mật khẩu";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3.Location = new System.Drawing.Point(11, 137);
            this.lb3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(79, 17);
            this.lb3.TabIndex = 11;
            this.lb3.Text = "Tên truy cập";
            // 
            // linklogin
            // 
            this.linklogin.AutoSize = true;
            this.linklogin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklogin.LinkColor = System.Drawing.Color.Black;
            this.linklogin.Location = new System.Drawing.Point(265, 308);
            this.linklogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linklogin.Name = "linklogin";
            this.linklogin.Size = new System.Drawing.Size(85, 20);
            this.linklogin.TabIndex = 10;
            this.linklogin.TabStop = true;
            this.linklogin.Text = "Đăng nhập";
            this.linklogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklogin_LinkClicked);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(11, 54);
            this.lb1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(64, 17);
            this.lb1.TabIndex = 3;
            this.lb1.Text = "Họ và tên";
            // 
            // btnthoat2
            // 
            this.btnthoat2.BackColor = System.Drawing.Color.White;
            this.btnthoat2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnthoat2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnthoat2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat2.Location = new System.Drawing.Point(263, 263);
            this.btnthoat2.Margin = new System.Windows.Forms.Padding(2);
            this.btnthoat2.Name = "btnthoat2";
            this.btnthoat2.Size = new System.Drawing.Size(90, 26);
            this.btnthoat2.TabIndex = 7;
            this.btnthoat2.Text = "Thoát";
            this.btnthoat2.UseVisualStyleBackColor = false;
            this.btnthoat2.Click += new System.EventHandler(this.btnthoat2_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(158, 89);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(195, 22);
            this.txtPhone.TabIndex = 9;
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.White;
            this.btnSignup.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSignup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignup.Location = new System.Drawing.Point(158, 263);
            this.btnSignup.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(90, 26);
            this.btnSignup.TabIndex = 6;
            this.btnSignup.Tag = "";
            this.btnSignup.Text = "Đăng ký";
            this.btnSignup.UseVisualStyleBackColor = false;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // txtFullname
            // 
            this.txtFullname.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullname.Location = new System.Drawing.Point(158, 48);
            this.txtFullname.Margin = new System.Windows.Forms.Padding(2);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(195, 22);
            this.txtFullname.TabIndex = 8;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(11, 95);
            this.lb2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(85, 17);
            this.lb2.TabIndex = 2;
            this.lb2.Text = "Số điện thoại";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(303, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(393, 30);
            this.label9.TabIndex = 20;
            this.label9.Text = "CỔNG THÔNG TIN ĐÀO TẠO ĐẠI HỌC";
            // 
            // lbotp
            // 
            this.lbotp.AutoSize = true;
            this.lbotp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbotp.Location = new System.Drawing.Point(611, 194);
            this.lbotp.Name = "lbotp";
            this.lbotp.Size = new System.Drawing.Size(230, 17);
            this.lbotp.TabIndex = 21;
            this.lbotp.Text = "Nhập mã OTP để xác thực tài khoản";
            // 
            // txtOTP
            // 
            this.txtOTP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOTP.Location = new System.Drawing.Point(688, 230);
            this.txtOTP.Margin = new System.Windows.Forms.Padding(2);
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.Size = new System.Drawing.Size(108, 22);
            this.txtOTP.TabIndex = 21;
            this.txtOTP.Text = "OTP";
            this.txtOTP.TextChanged += new System.EventHandler(this.txtOTP_TextChanged);
            // 
            // btnXacnhan
            // 
            this.btnXacnhan.BackColor = System.Drawing.Color.White;
            this.btnXacnhan.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnXacnhan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXacnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacnhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXacnhan.Location = new System.Drawing.Point(697, 277);
            this.btnXacnhan.Margin = new System.Windows.Forms.Padding(2);
            this.btnXacnhan.Name = "btnXacnhan";
            this.btnXacnhan.Size = new System.Drawing.Size(90, 26);
            this.btnXacnhan.TabIndex = 18;
            this.btnXacnhan.Tag = "";
            this.btnXacnhan.Text = "Xác nhận";
            this.btnXacnhan.UseVisualStyleBackColor = false;
            this.btnXacnhan.Visible = false;
            this.btnXacnhan.Click += new System.EventHandler(this.btnXacnhan_Click);
            // 
            // pnload
            // 
            this.pnload.Controls.Add(this.pictureBox2);
            this.pnload.Controls.Add(this.label9);
            this.pnload.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnload.Location = new System.Drawing.Point(0, 0);
            this.pnload.Name = "pnload";
            this.pnload.Size = new System.Drawing.Size(1014, 110);
            this.pnload.TabIndex = 22;
            this.pnload.Paint += new System.Windows.Forms.PaintEventHandler(this.pnload_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(297, 110);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // timerLoad
            // 
            this.timerLoad.Interval = 10;
            this.timerLoad.Tick += new System.EventHandler(this.timerLoad_Tick);
            // 
            // LoginRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1014, 576);
            this.Controls.Add(this.pnload);
            this.Controls.Add(this.btnXacnhan);
            this.Controls.Add(this.lbotp);
            this.Controls.Add(this.txtOTP);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginRegister";
            this.Text = "LoginRegister";
            this.Load += new System.EventHandler(this.LoginRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnload.ResumeLayout(false);
            this.pnload.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkRegister;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThoat1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtComfirm;
        private System.Windows.Forms.TextBox txtPassdangky;
        private System.Windows.Forms.TextBox txtUsernameDangky;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.LinkLabel linklogin;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button btnthoat2;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.ComboBox Cbluachon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbotp;
        private System.Windows.Forms.TextBox txtOTP;
        private System.Windows.Forms.Button btnXacnhan;
        private System.Windows.Forms.Panel pnload;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timerLoad;
    }
}