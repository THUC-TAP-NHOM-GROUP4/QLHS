﻿namespace QuanLyHocSinh
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tpQLGV = new System.Windows.Forms.TabPage();
            this.dtgDanhSachGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTimKiemDSGV = new System.Windows.Forms.Button();
            this.btnThoatDSGV = new System.Windows.Forms.Button();
            this.btnLuuDSGV = new System.Windows.Forms.Button();
            this.btnXoaDSGV = new System.Windows.Forms.Button();
            this.btnSuaDSGV = new System.Windows.Forms.Button();
            this.btnThemDSGV = new System.Windows.Forms.Button();
            this.btnXemDSGV = new System.Windows.Forms.Button();
            this.tpTrangChu = new System.Windows.Forms.TabPage();
            this.linklabelHD = new System.Windows.Forms.LinkLabel();
            this.linklabelQLGD = new System.Windows.Forms.LinkLabel();
            this.button3 = new System.Windows.Forms.Button();
            this.linklabelQLGV = new System.Windows.Forms.LinkLabel();
            this.btnGiangDay = new System.Windows.Forms.Button();
            this.linklabelQLHS = new System.Windows.Forms.LinkLabel();
            this.btnGV = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControlChinh = new System.Windows.Forms.TabControl();
            this.tpDSHS = new System.Windows.Forms.TabPage();
            this.dtgDanhSach = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTimKiemDSHS = new System.Windows.Forms.Button();
            this.btnThoatDSHS = new System.Windows.Forms.Button();
            this.btnLuuDSHS = new System.Windows.Forms.Button();
            this.btnXoaDSHS = new System.Windows.Forms.Button();
            this.btnSuaDSHS = new System.Windows.Forms.Button();
            this.btnThemDSHS = new System.Windows.Forms.Button();
            this.btnXemDSHS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tpQLGiangDay = new System.Windows.Forms.TabPage();
            this.tpQLGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachGV)).BeginInit();
            this.tpTrangChu.SuspendLayout();
            this.tabControlChinh.SuspendLayout();
            this.tpDSHS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhSach)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpQLGV
            // 
            this.tpQLGV.Controls.Add(this.dtgDanhSachGV);
            this.tpQLGV.Controls.Add(this.label2);
            this.tpQLGV.Controls.Add(this.btnTimKiemDSGV);
            this.tpQLGV.Controls.Add(this.btnThoatDSGV);
            this.tpQLGV.Controls.Add(this.btnLuuDSGV);
            this.tpQLGV.Controls.Add(this.btnXoaDSGV);
            this.tpQLGV.Controls.Add(this.btnSuaDSGV);
            this.tpQLGV.Controls.Add(this.btnThemDSGV);
            this.tpQLGV.Controls.Add(this.btnXemDSGV);
            this.tpQLGV.Location = new System.Drawing.Point(4, 22);
            this.tpQLGV.Name = "tpQLGV";
            this.tpQLGV.Size = new System.Drawing.Size(942, 502);
            this.tpQLGV.TabIndex = 2;
            this.tpQLGV.Text = "Quản lý giáo viên";
            this.tpQLGV.UseVisualStyleBackColor = true;
            // 
            // dtgDanhSachGV
            // 
            this.dtgDanhSachGV.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtgDanhSachGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDanhSachGV.Location = new System.Drawing.Point(-37, 18);
            this.dtgDanhSachGV.Name = "dtgDanhSachGV";
            this.dtgDanhSachGV.Size = new System.Drawing.Size(976, 397);
            this.dtgDanhSachGV.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(375, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 18);
            this.label2.TabIndex = 34;
            this.label2.Text = "Danh Sách Giáo Viên";
            // 
            // btnTimKiemDSGV
            // 
            this.btnTimKiemDSGV.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemDSGV.Image")));
            this.btnTimKiemDSGV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemDSGV.Location = new System.Drawing.Point(699, 435);
            this.btnTimKiemDSGV.Name = "btnTimKiemDSGV";
            this.btnTimKiemDSGV.Size = new System.Drawing.Size(80, 40);
            this.btnTimKiemDSGV.TabIndex = 42;
            this.btnTimKiemDSGV.Text = "Tìm kiếm";
            this.btnTimKiemDSGV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemDSGV.UseVisualStyleBackColor = true;
            // 
            // btnThoatDSGV
            // 
            this.btnThoatDSGV.Image = ((System.Drawing.Image)(resources.GetObject("btnThoatDSGV.Image")));
            this.btnThoatDSGV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoatDSGV.Location = new System.Drawing.Point(856, 435);
            this.btnThoatDSGV.Name = "btnThoatDSGV";
            this.btnThoatDSGV.Size = new System.Drawing.Size(80, 40);
            this.btnThoatDSGV.TabIndex = 41;
            this.btnThoatDSGV.Text = "Thoát";
            this.btnThoatDSGV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoatDSGV.UseVisualStyleBackColor = true;
            this.btnThoatDSGV.Click += new System.EventHandler(this.btnThoatDSGV_Click);
            // 
            // btnLuuDSGV
            // 
            this.btnLuuDSGV.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuDSGV.Image")));
            this.btnLuuDSGV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuDSGV.Location = new System.Drawing.Point(777, 435);
            this.btnLuuDSGV.Name = "btnLuuDSGV";
            this.btnLuuDSGV.Size = new System.Drawing.Size(80, 40);
            this.btnLuuDSGV.TabIndex = 40;
            this.btnLuuDSGV.Text = "Lưu";
            this.btnLuuDSGV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuDSGV.UseVisualStyleBackColor = true;
            // 
            // btnXoaDSGV
            // 
            this.btnXoaDSGV.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaDSGV.Image")));
            this.btnXoaDSGV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaDSGV.Location = new System.Drawing.Point(620, 435);
            this.btnXoaDSGV.Name = "btnXoaDSGV";
            this.btnXoaDSGV.Size = new System.Drawing.Size(80, 40);
            this.btnXoaDSGV.TabIndex = 39;
            this.btnXoaDSGV.Text = "Xóa";
            this.btnXoaDSGV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaDSGV.UseVisualStyleBackColor = true;
            this.btnXoaDSGV.Click += new System.EventHandler(this.btnXoaDSGV_Click);
            // 
            // btnSuaDSGV
            // 
            this.btnSuaDSGV.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaDSGV.Image")));
            this.btnSuaDSGV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaDSGV.Location = new System.Drawing.Point(541, 435);
            this.btnSuaDSGV.Name = "btnSuaDSGV";
            this.btnSuaDSGV.Size = new System.Drawing.Size(80, 40);
            this.btnSuaDSGV.TabIndex = 38;
            this.btnSuaDSGV.Text = "Sửa";
            this.btnSuaDSGV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaDSGV.UseVisualStyleBackColor = true;
            this.btnSuaDSGV.Click += new System.EventHandler(this.btnSuaDSGV_Click);
            // 
            // btnThemDSGV
            // 
            this.btnThemDSGV.Image = ((System.Drawing.Image)(resources.GetObject("btnThemDSGV.Image")));
            this.btnThemDSGV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemDSGV.Location = new System.Drawing.Point(463, 435);
            this.btnThemDSGV.Name = "btnThemDSGV";
            this.btnThemDSGV.Size = new System.Drawing.Size(80, 40);
            this.btnThemDSGV.TabIndex = 37;
            this.btnThemDSGV.Text = "Thêm";
            this.btnThemDSGV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemDSGV.UseVisualStyleBackColor = true;
            this.btnThemDSGV.Click += new System.EventHandler(this.btnThemDSGV_Click);
            // 
            // btnXemDSGV
            // 
            this.btnXemDSGV.Image = ((System.Drawing.Image)(resources.GetObject("btnXemDSGV.Image")));
            this.btnXemDSGV.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnXemDSGV.Location = new System.Drawing.Point(384, 435);
            this.btnXemDSGV.Name = "btnXemDSGV";
            this.btnXemDSGV.Size = new System.Drawing.Size(80, 40);
            this.btnXemDSGV.TabIndex = 36;
            this.btnXemDSGV.Text = "Xem ";
            this.btnXemDSGV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXemDSGV.UseVisualStyleBackColor = true;
            // 
            // tpTrangChu
            // 
            this.tpTrangChu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tpTrangChu.Controls.Add(this.linklabelHD);
            this.tpTrangChu.Controls.Add(this.linklabelQLGD);
            this.tpTrangChu.Controls.Add(this.button3);
            this.tpTrangChu.Controls.Add(this.linklabelQLGV);
            this.tpTrangChu.Controls.Add(this.btnGiangDay);
            this.tpTrangChu.Controls.Add(this.linklabelQLHS);
            this.tpTrangChu.Controls.Add(this.btnGV);
            this.tpTrangChu.Controls.Add(this.button1);
            this.tpTrangChu.Controls.Add(this.label4);
            this.tpTrangChu.Location = new System.Drawing.Point(4, 22);
            this.tpTrangChu.Name = "tpTrangChu";
            this.tpTrangChu.Padding = new System.Windows.Forms.Padding(3);
            this.tpTrangChu.Size = new System.Drawing.Size(942, 502);
            this.tpTrangChu.TabIndex = 0;
            this.tpTrangChu.Text = "Trang Chủ";
            // 
            // linklabelHD
            // 
            this.linklabelHD.AutoSize = true;
            this.linklabelHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.linklabelHD.Location = new System.Drawing.Point(523, 396);
            this.linklabelHD.Name = "linklabelHD";
            this.linklabelHD.Size = new System.Drawing.Size(76, 16);
            this.linklabelHD.TabIndex = 14;
            this.linklabelHD.TabStop = true;
            this.linklabelHD.Text = "Hướng Dẫn";
            // 
            // linklabelQLGD
            // 
            this.linklabelQLGD.AutoSize = true;
            this.linklabelQLGD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.linklabelQLGD.Location = new System.Drawing.Point(365, 396);
            this.linklabelQLGD.Name = "linklabelQLGD";
            this.linklabelQLGD.Size = new System.Drawing.Size(124, 16);
            this.linklabelQLGD.TabIndex = 13;
            this.linklabelQLGD.TabStop = true;
            this.linklabelQLGD.Text = "Quản Lý Giảng Dạy";
            this.linklabelQLGD.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklabelQLGD_LinkClicked);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(489, 265);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 125);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // linklabelQLGV
            // 
            this.linklabelQLGV.AutoSize = true;
            this.linklabelQLGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.linklabelQLGV.Location = new System.Drawing.Point(486, 216);
            this.linklabelQLGV.Name = "linklabelQLGV";
            this.linklabelQLGV.Size = new System.Drawing.Size(119, 16);
            this.linklabelQLGV.TabIndex = 12;
            this.linklabelQLGV.TabStop = true;
            this.linklabelQLGV.Text = "Quản Lý Giáo Viên";
            this.linklabelQLGV.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklabelQLGV_LinkClicked);
            // 
            // btnGiangDay
            // 
            this.btnGiangDay.Image = ((System.Drawing.Image)(resources.GetObject("btnGiangDay.Image")));
            this.btnGiangDay.Location = new System.Drawing.Point(356, 265);
            this.btnGiangDay.Name = "btnGiangDay";
            this.btnGiangDay.Size = new System.Drawing.Size(133, 125);
            this.btnGiangDay.TabIndex = 2;
            this.btnGiangDay.UseVisualStyleBackColor = true;
            this.btnGiangDay.Click += new System.EventHandler(this.btnGiangDay_Click);
            // 
            // linklabelQLHS
            // 
            this.linklabelQLHS.AutoSize = true;
            this.linklabelQLHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.linklabelQLHS.Location = new System.Drawing.Point(366, 216);
            this.linklabelQLHS.Name = "linklabelQLHS";
            this.linklabelQLHS.Size = new System.Drawing.Size(114, 16);
            this.linklabelQLHS.TabIndex = 11;
            this.linklabelQLHS.TabStop = true;
            this.linklabelQLHS.Text = "Quản Lý Học Sinh";
            this.linklabelQLHS.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklabelQLHS_LinkClicked);
            // 
            // btnGV
            // 
            this.btnGV.Image = ((System.Drawing.Image)(resources.GetObject("btnGV.Image")));
            this.btnGV.Location = new System.Drawing.Point(484, 86);
            this.btnGV.Name = "btnGV";
            this.btnGV.Size = new System.Drawing.Size(133, 127);
            this.btnGV.TabIndex = 1;
            this.btnGV.UseVisualStyleBackColor = false;
            this.btnGV.Click += new System.EventHandler(this.btnGV_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(356, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 125);
            this.button1.TabIndex = 1;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(402, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quản Lý Học Sinh,Giáo Viên";
            // 
            // tabControlChinh
            // 
            this.tabControlChinh.Controls.Add(this.tpTrangChu);
            this.tabControlChinh.Controls.Add(this.tpDSHS);
            this.tabControlChinh.Controls.Add(this.tpQLGV);
            this.tabControlChinh.Controls.Add(this.tpQLGiangDay);
            this.tabControlChinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlChinh.Location = new System.Drawing.Point(0, 0);
            this.tabControlChinh.Name = "tabControlChinh";
            this.tabControlChinh.SelectedIndex = 0;
            this.tabControlChinh.Size = new System.Drawing.Size(950, 528);
            this.tabControlChinh.TabIndex = 4;
            // 
            // tpDSHS
            // 
            this.tpDSHS.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tpDSHS.Controls.Add(this.dtgDanhSach);
            this.tpDSHS.Controls.Add(this.label3);
            this.tpDSHS.Controls.Add(this.btnTimKiemDSHS);
            this.tpDSHS.Controls.Add(this.btnThoatDSHS);
            this.tpDSHS.Controls.Add(this.btnLuuDSHS);
            this.tpDSHS.Controls.Add(this.btnXoaDSHS);
            this.tpDSHS.Controls.Add(this.btnSuaDSHS);
            this.tpDSHS.Controls.Add(this.btnThemDSHS);
            this.tpDSHS.Controls.Add(this.btnXemDSHS);
            this.tpDSHS.Location = new System.Drawing.Point(4, 22);
            this.tpDSHS.Name = "tpDSHS";
            this.tpDSHS.Padding = new System.Windows.Forms.Padding(3);
            this.tpDSHS.Size = new System.Drawing.Size(942, 502);
            this.tpDSHS.TabIndex = 1;
            this.tpDSHS.Text = "Danh sách học sinh";
            // 
            // dtgDanhSach
            // 
            this.dtgDanhSach.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtgDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDanhSach.Location = new System.Drawing.Point(2, 24);
            this.dtgDanhSach.Name = "dtgDanhSach";
            this.dtgDanhSach.Size = new System.Drawing.Size(944, 406);
            this.dtgDanhSach.TabIndex = 42;
            this.dtgDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDanhSach_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(370, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 18);
            this.label3.TabIndex = 41;
            this.label3.Text = "Danh Sách Học Sinh";
            // 
            // btnTimKiemDSHS
            // 
            this.btnTimKiemDSHS.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemDSHS.Image")));
            this.btnTimKiemDSHS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemDSHS.Location = new System.Drawing.Point(705, 456);
            this.btnTimKiemDSHS.Name = "btnTimKiemDSHS";
            this.btnTimKiemDSHS.Size = new System.Drawing.Size(80, 40);
            this.btnTimKiemDSHS.TabIndex = 50;
            this.btnTimKiemDSHS.Text = "Tìm kiếm";
            this.btnTimKiemDSHS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemDSHS.UseVisualStyleBackColor = true;
            // 
            // btnThoatDSHS
            // 
            this.btnThoatDSHS.Image = ((System.Drawing.Image)(resources.GetObject("btnThoatDSHS.Image")));
            this.btnThoatDSHS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoatDSHS.Location = new System.Drawing.Point(862, 456);
            this.btnThoatDSHS.Name = "btnThoatDSHS";
            this.btnThoatDSHS.Size = new System.Drawing.Size(80, 40);
            this.btnThoatDSHS.TabIndex = 49;
            this.btnThoatDSHS.Text = "Thoát";
            this.btnThoatDSHS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoatDSHS.UseVisualStyleBackColor = true;
            this.btnThoatDSHS.Click += new System.EventHandler(this.btnThoatDSHS_Click);
            // 
            // btnLuuDSHS
            // 
            this.btnLuuDSHS.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuDSHS.Image")));
            this.btnLuuDSHS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuDSHS.Location = new System.Drawing.Point(783, 456);
            this.btnLuuDSHS.Name = "btnLuuDSHS";
            this.btnLuuDSHS.Size = new System.Drawing.Size(80, 40);
            this.btnLuuDSHS.TabIndex = 48;
            this.btnLuuDSHS.Text = "Lưu";
            this.btnLuuDSHS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuDSHS.UseVisualStyleBackColor = true;
            // 
            // btnXoaDSHS
            // 
            this.btnXoaDSHS.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaDSHS.Image")));
            this.btnXoaDSHS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaDSHS.Location = new System.Drawing.Point(626, 456);
            this.btnXoaDSHS.Name = "btnXoaDSHS";
            this.btnXoaDSHS.Size = new System.Drawing.Size(80, 40);
            this.btnXoaDSHS.TabIndex = 47;
            this.btnXoaDSHS.Text = "Xóa";
            this.btnXoaDSHS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaDSHS.UseVisualStyleBackColor = true;
            // 
            // btnSuaDSHS
            // 
            this.btnSuaDSHS.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaDSHS.Image")));
            this.btnSuaDSHS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaDSHS.Location = new System.Drawing.Point(547, 456);
            this.btnSuaDSHS.Name = "btnSuaDSHS";
            this.btnSuaDSHS.Size = new System.Drawing.Size(80, 40);
            this.btnSuaDSHS.TabIndex = 46;
            this.btnSuaDSHS.Text = "Sửa";
            this.btnSuaDSHS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaDSHS.UseVisualStyleBackColor = true;
            this.btnSuaDSHS.Click += new System.EventHandler(this.btnSuaDSHS_Click);
            // 
            // btnThemDSHS
            // 
            this.btnThemDSHS.Image = ((System.Drawing.Image)(resources.GetObject("btnThemDSHS.Image")));
            this.btnThemDSHS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemDSHS.Location = new System.Drawing.Point(469, 456);
            this.btnThemDSHS.Name = "btnThemDSHS";
            this.btnThemDSHS.Size = new System.Drawing.Size(80, 40);
            this.btnThemDSHS.TabIndex = 45;
            this.btnThemDSHS.Text = "Thêm";
            this.btnThemDSHS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemDSHS.UseVisualStyleBackColor = true;
            // 
            // btnXemDSHS
            // 
            this.btnXemDSHS.Image = ((System.Drawing.Image)(resources.GetObject("btnXemDSHS.Image")));
            this.btnXemDSHS.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnXemDSHS.Location = new System.Drawing.Point(390, 456);
            this.btnXemDSHS.Name = "btnXemDSHS";
            this.btnXemDSHS.Size = new System.Drawing.Size(80, 40);
            this.btnXemDSHS.TabIndex = 44;
            this.btnXemDSHS.Text = "Xem";
            this.btnXemDSHS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXemDSHS.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Copyright by Nhom 4 -THUC TAP NHOM 2017";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 528);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(950, 25);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // tpQLGiangDay
            // 
            this.tpQLGiangDay.Location = new System.Drawing.Point(4, 22);
            this.tpQLGiangDay.Name = "tpQLGiangDay";
            this.tpQLGiangDay.Size = new System.Drawing.Size(942, 502);
            this.tpQLGiangDay.TabIndex = 3;
            this.tpQLGiangDay.Text = "QL Giảng dạy";
            this.tpQLGiangDay.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(950, 553);
            this.Controls.Add(this.tabControlChinh);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tpQLGV.ResumeLayout(false);
            this.tpQLGV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachGV)).EndInit();
            this.tpTrangChu.ResumeLayout(false);
            this.tpTrangChu.PerformLayout();
            this.tabControlChinh.ResumeLayout(false);
            this.tpDSHS.ResumeLayout(false);
            this.tpDSHS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhSach)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpQLGV;
        private System.Windows.Forms.TabPage tpTrangChu;
        private System.Windows.Forms.LinkLabel linklabelHD;
        private System.Windows.Forms.LinkLabel linklabelQLGD;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.LinkLabel linklabelQLGV;
        private System.Windows.Forms.Button btnGiangDay;
        private System.Windows.Forms.LinkLabel linklabelQLHS;
        private System.Windows.Forms.Button btnGV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControlChinh;
        private System.Windows.Forms.TabPage tpDSHS;
        private System.Windows.Forms.DataGridView dtgDanhSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTimKiemDSHS;
        private System.Windows.Forms.Button btnThoatDSHS;
        private System.Windows.Forms.Button btnLuuDSHS;
        private System.Windows.Forms.Button btnXoaDSHS;
        private System.Windows.Forms.Button btnSuaDSHS;
        private System.Windows.Forms.Button btnThemDSHS;
        private System.Windows.Forms.Button btnXemDSHS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dtgDanhSachGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimKiemDSGV;
        private System.Windows.Forms.Button btnThoatDSGV;
        private System.Windows.Forms.Button btnLuuDSGV;
        private System.Windows.Forms.Button btnXoaDSGV;
        private System.Windows.Forms.Button btnSuaDSGV;
        private System.Windows.Forms.Button btnThemDSGV;
        private System.Windows.Forms.Button btnXemDSGV;
        private System.Windows.Forms.TabPage tpQLGiangDay;
    }
}
