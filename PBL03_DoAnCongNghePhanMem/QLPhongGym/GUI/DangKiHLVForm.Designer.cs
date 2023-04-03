﻿namespace QLPhongGym.GUI
{
    partial class DangKiHLVForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKiHLVForm));
            this.btn_back = new System.Windows.Forms.Button();
            this.cb_sex = new System.Windows.Forms.ComboBox();
            this.txb_address = new System.Windows.Forms.TextBox();
            this.txb_cmnd = new System.Windows.Forms.TextBox();
            this.txb_hvt = new System.Windows.Forms.TextBox();
            this.lb_cmnd = new System.Windows.Forms.Label();
            this.lb_address = new System.Windows.Forms.Label();
            this.lb_age = new System.Windows.Forms.Label();
            this.lb_hvt = new System.Windows.Forms.Label();
            this.btn_dangki = new System.Windows.Forms.Button();
            this.lb_sex = new System.Windows.Forms.Label();
            this.lb_tenhethong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_namkinhnghiem = new System.Windows.Forms.TextBox();
            this.cb_bangcap = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtp_ns = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_back.BackColor = System.Drawing.Color.Black;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.Aquamarine;
            this.btn_back.Location = new System.Drawing.Point(1444, 739);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(125, 48);
            this.btn_back.TabIndex = 31;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // cb_sex
            // 
            this.cb_sex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_sex.FormattingEnabled = true;
            this.cb_sex.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_sex.Location = new System.Drawing.Point(1346, 268);
            this.cb_sex.Name = "cb_sex";
            this.cb_sex.Size = new System.Drawing.Size(306, 33);
            this.cb_sex.TabIndex = 25;
            // 
            // txb_address
            // 
            this.txb_address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_address.Location = new System.Drawing.Point(1346, 453);
            this.txb_address.Name = "txb_address";
            this.txb_address.Size = new System.Drawing.Size(306, 30);
            this.txb_address.TabIndex = 27;
            // 
            // txb_cmnd
            // 
            this.txb_cmnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_cmnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_cmnd.Location = new System.Drawing.Point(1346, 366);
            this.txb_cmnd.Name = "txb_cmnd";
            this.txb_cmnd.Size = new System.Drawing.Size(306, 30);
            this.txb_cmnd.TabIndex = 26;
            // 
            // txb_hvt
            // 
            this.txb_hvt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_hvt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_hvt.Location = new System.Drawing.Point(1346, 86);
            this.txb_hvt.Name = "txb_hvt";
            this.txb_hvt.Size = new System.Drawing.Size(306, 30);
            this.txb_hvt.TabIndex = 23;
            // 
            // lb_cmnd
            // 
            this.lb_cmnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_cmnd.AutoSize = true;
            this.lb_cmnd.BackColor = System.Drawing.Color.Transparent;
            this.lb_cmnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cmnd.ForeColor = System.Drawing.Color.Black;
            this.lb_cmnd.Location = new System.Drawing.Point(987, 366);
            this.lb_cmnd.Name = "lb_cmnd";
            this.lb_cmnd.Size = new System.Drawing.Size(169, 29);
            this.lb_cmnd.TabIndex = 34;
            this.lb_cmnd.Text = "CMND/CCCD";
            // 
            // lb_address
            // 
            this.lb_address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_address.AutoSize = true;
            this.lb_address.BackColor = System.Drawing.Color.Transparent;
            this.lb_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_address.ForeColor = System.Drawing.Color.Black;
            this.lb_address.Location = new System.Drawing.Point(987, 453);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(93, 29);
            this.lb_address.TabIndex = 35;
            this.lb_address.Text = "Địa chỉ";
            // 
            // lb_age
            // 
            this.lb_age.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_age.AutoSize = true;
            this.lb_age.BackColor = System.Drawing.Color.Transparent;
            this.lb_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_age.ForeColor = System.Drawing.Color.Black;
            this.lb_age.Location = new System.Drawing.Point(987, 180);
            this.lb_age.Name = "lb_age";
            this.lb_age.Size = new System.Drawing.Size(135, 29);
            this.lb_age.TabIndex = 32;
            this.lb_age.Text = "Ngày sinh:";
            // 
            // lb_hvt
            // 
            this.lb_hvt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_hvt.AutoSize = true;
            this.lb_hvt.BackColor = System.Drawing.Color.Transparent;
            this.lb_hvt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hvt.ForeColor = System.Drawing.Color.Black;
            this.lb_hvt.Location = new System.Drawing.Point(987, 87);
            this.lb_hvt.Name = "lb_hvt";
            this.lb_hvt.Size = new System.Drawing.Size(122, 29);
            this.lb_hvt.TabIndex = 31;
            this.lb_hvt.Text = "Họ và tên";
            // 
            // btn_dangki
            // 
            this.btn_dangki.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_dangki.BackColor = System.Drawing.Color.Black;
            this.btn_dangki.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dangki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dangki.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangki.ForeColor = System.Drawing.Color.Aquamarine;
            this.btn_dangki.Location = new System.Drawing.Point(1132, 739);
            this.btn_dangki.Name = "btn_dangki";
            this.btn_dangki.Size = new System.Drawing.Size(125, 48);
            this.btn_dangki.TabIndex = 30;
            this.btn_dangki.Text = "Đăng kí";
            this.btn_dangki.UseVisualStyleBackColor = false;
            this.btn_dangki.Click += new System.EventHandler(this.btn_dangki_Click);
            // 
            // lb_sex
            // 
            this.lb_sex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_sex.AutoSize = true;
            this.lb_sex.BackColor = System.Drawing.Color.Transparent;
            this.lb_sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sex.ForeColor = System.Drawing.Color.Black;
            this.lb_sex.Location = new System.Drawing.Point(987, 268);
            this.lb_sex.Name = "lb_sex";
            this.lb_sex.Size = new System.Drawing.Size(110, 29);
            this.lb_sex.TabIndex = 33;
            this.lb_sex.Text = "Giới tính";
            // 
            // lb_tenhethong
            // 
            this.lb_tenhethong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_tenhethong.AutoSize = true;
            this.lb_tenhethong.BackColor = System.Drawing.Color.Transparent;
            this.lb_tenhethong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_tenhethong.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenhethong.ForeColor = System.Drawing.Color.DarkRed;
            this.lb_tenhethong.Location = new System.Drawing.Point(1093, 0);
            this.lb_tenhethong.Name = "lb_tenhethong";
            this.lb_tenhethong.Size = new System.Drawing.Size(414, 38);
            this.lb_tenhethong.TabIndex = 22;
            this.lb_tenhethong.Text = "Thông tin huấn luyện viên";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(987, 548);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 29);
            this.label1.TabIndex = 36;
            this.label1.Text = "Năm kinh nghiệm";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(987, 649);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 29);
            this.label2.TabIndex = 37;
            this.label2.Text = "Bằng cấp";
            // 
            // txb_namkinhnghiem
            // 
            this.txb_namkinhnghiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_namkinhnghiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_namkinhnghiem.Location = new System.Drawing.Point(1346, 547);
            this.txb_namkinhnghiem.Name = "txb_namkinhnghiem";
            this.txb_namkinhnghiem.Size = new System.Drawing.Size(306, 30);
            this.txb_namkinhnghiem.TabIndex = 28;
            // 
            // cb_bangcap
            // 
            this.cb_bangcap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_bangcap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_bangcap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_bangcap.FormattingEnabled = true;
            this.cb_bangcap.Items.AddRange(new object[] {
            "Xuất sắc",
            "Tốt",
            "Khá",
            "Trung Bình",
            "Yếu",
            "None"});
            this.cb_bangcap.Location = new System.Drawing.Point(1346, 641);
            this.cb_bangcap.Name = "cb_bangcap";
            this.cb_bangcap.Size = new System.Drawing.Size(306, 37);
            this.cb_bangcap.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(891, 864);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // dtp_ns
            // 
            this.dtp_ns.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_ns.CustomFormat = "dd/MM/yyyy";
            this.dtp_ns.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ns.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ns.Location = new System.Drawing.Point(1346, 185);
            this.dtp_ns.Name = "dtp_ns";
            this.dtp_ns.Size = new System.Drawing.Size(306, 34);
            this.dtp_ns.TabIndex = 39;
            // 
            // DangKiHLVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1751, 862);
            this.Controls.Add(this.dtp_ns);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_dangki);
            this.Controls.Add(this.cb_bangcap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_namkinhnghiem);
            this.Controls.Add(this.lb_tenhethong);
            this.Controls.Add(this.lb_sex);
            this.Controls.Add(this.lb_hvt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_hvt);
            this.Controls.Add(this.lb_age);
            this.Controls.Add(this.txb_address);
            this.Controls.Add(this.lb_address);
            this.Controls.Add(this.cb_sex);
            this.Controls.Add(this.txb_cmnd);
            this.Controls.Add(this.lb_cmnd);
            this.Name = "DangKiHLVForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng kí";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ComboBox cb_sex;
        private System.Windows.Forms.TextBox txb_address;
        private System.Windows.Forms.TextBox txb_cmnd;
        private System.Windows.Forms.TextBox txb_hvt;
        private System.Windows.Forms.Label lb_cmnd;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.Label lb_age;
        private System.Windows.Forms.Label lb_hvt;
        private System.Windows.Forms.Button btn_dangki;
        private System.Windows.Forms.Label lb_sex;
        private System.Windows.Forms.Label lb_tenhethong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_namkinhnghiem;
        private System.Windows.Forms.ComboBox cb_bangcap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtp_ns;
    }
}