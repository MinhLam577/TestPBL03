﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLPhongGym.BLL;
using QLPhongGym.DTO;
namespace QLPhongGym.GUI
{
    public partial class DangKiHLVForm : Form
    {
        public TK tk { get;set; }
        public DangKiHLVForm()
        {
            InitializeComponent();
        }
        public DangKiHLVForm(TK tk)
        {
            InitializeComponent();
            this.tk = tk;
        }
        private void btn_dangki_Click(object sender, EventArgs e)
        {
            string hoten = txb_hvt.Text;
            string tuoi = txb_age.Text;
            string cccd = txb_cmnd.Text;
            string diachi = txb_address.Text;
            string nkn = txb_namkinhnghiem.Text;
            string BangCap = cb_bangcap.Text;
            bool gen = false;
            if (hoten == "" || tuoi == "" || cccd == "" || diachi == "" || nkn == "" || BangCap == "" || cb_sex.Text == "")
            {
                MessageBox.Show("Mời nhập vào thông tin còn thiếu");
                return;
            }
            if (!UsersBLL.Instance.CheckAge(tuoi))
            {
                MessageBox.Show("Tuổi không hợp lệ");
                return;
            }
            if (!UsersBLL.Instance.CheckCmnd(cccd))
            {
                MessageBox.Show("Căn cước nhân dân không hợp lệ");
                return;
            }
            if (!UsersBLL.Instance.CheckHoTen(hoten))
            {
                MessageBox.Show("Họ tên không hợp lệ");
                return;
            }
            if (!UsersBLL.Instance.CheckDiaChi(diachi))
            {
                MessageBox.Show("Địa chỉ không hợp lệ");
                return;
            }
            if (!UsersBLL.Instance.CheckNamKinhNghiem(nkn))
            {
                MessageBox.Show("Năm kinh nghiệm không hợp lệ");
                return;
            }
            if(cb_sex.Text == "Nam") gen = true;
            
            HLV hlv = new HLV { 
                Name = hoten, Age = Convert.ToInt32(tuoi), CCCD = cccd, Address = diachi, BangCap = BangCap,
                NamKinhNghiem = Convert.ToInt32(nkn), Sex = gen
            };
            if (UsersBLL.Instance.AddUser(hlv))
            {
                tk.IDUser = UsersBLL.Instance.GetUserID(cccd);
                if (TKBLL.Instance.AddTK(this.tk))
                {
                    MessageBox.Show("Đăng kí thành công");
                }
            }
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}