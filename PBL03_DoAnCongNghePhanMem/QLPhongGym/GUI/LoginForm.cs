﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLPhongGym.BLL;
using QLPhongGym.DTO;
namespace QLPhongGym.GUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public void OpenUserForm(string user)
        {
            switch (user)
            {
                case "KH":
                case "HLV":
                case "Admin":
                    break;
            }
        }
        private void pb_eye_MouseHover(object sender, EventArgs e)
        {
            txb_mk.PasswordChar = '\0';
            pb_eye.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Resources\8.ico");
        }

        private void pb_eye_MouseLeave(object sender, EventArgs e)
        {
            txb_mk.PasswordChar = '*';
            pb_eye.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Resources\7.png");
        }

        private void lb_Dangki_Click(object sender, EventArgs e)
        {
            DangKiTKForm dkf = new DangKiTKForm();
            dkf.Back += (a, b) => { (a as DangKiTKForm).Close(); this.Show(); };
            this.Hide();
            dkf.Show();
        }
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string tentk = txb_TenTk.Text, mk = txb_mk.Text, username;
            if (!TKBLL.Instance.CheckTenTKExist(tentk) || !TKBLL.Instance.CheckMKTKExist(mk))
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            username = TKBLL.Instance.GetUserName(TKBLL.Instance.GetIDQuyen(tentk));
            OpenUserForm(username);
        }

        private void lb_QuenMk_Click_1(object sender, EventArgs e)
        {
            QuenMatKhauForm qmkf = new QuenMatKhauForm();
            qmkf.Exit += (a, b) => { (a as QuenMatKhauForm).Close(); this.Show(); };

            this.Hide();
            qmkf.Show();
        }
    }
}
