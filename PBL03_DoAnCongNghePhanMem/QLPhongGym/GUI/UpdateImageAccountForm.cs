﻿using QLPhongGym.BLL;
using QLPhongGym.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongGym.GUI
{
    public partial class UpdateImageAccountForm : Form
    {
        public Admin ad { get; set; }
        static string DefaultImagePath = Application.StartupPath + @"\Resources\account_icon.png";
        public delegate void Mydel();
        public Mydel catnhatthanhcong { get; set; }
        public UpdateImageAccountForm()
        {
            InitializeComponent();
        }
        public UpdateImageAccountForm(Admin ad)
        {
            InitializeComponent();
            this.ad = ad;
            LoadAnh();
        }
        public void LoadAnh()
        {
            if (ad.Image != null)
                pb_imageacc.Image = Image.FromFile(Application.StartupPath + @"\PersonImage\" + ad.Image);
            else pb_imageacc.Image = Image.FromFile(DefaultImagePath);
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            pb_imageacc.Image = Image.FromFile(DefaultImagePath);
            pb_imageacc.Tag = null;
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            try
            {
                string PathAnh = Application.StartupPath + @"\PersonImage\";
                var codecs = ImageCodecInfo.GetImageEncoders();
                var codecFilter = "Image Files|";
                foreach (var codec in codecs)
                {
                    codecFilter += codec.FilenameExtension + ";";
                }

                using (OpenFileDialog ofd = new OpenFileDialog()
                {
                    Filter = codecFilter,
                    Multiselect = false,
                    InitialDirectory = Application.StartupPath + @"\PersonImage\"
                })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        string filename = ofd.FileName;
                        pb_imageacc.Image = Image.FromFile(filename);
                        pb_imageacc.Tag = filename.Replace(PathAnh, "");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Upload ảnh thất bại");
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string Anh = null;
            try
            {
                if (pb_imageacc.Tag != null)
                {
                    if (!string.IsNullOrEmpty(pb_imageacc.Tag.ToString()))
                        Anh = pb_imageacc.Tag.ToString();
                }
                ad.Image = Anh;
                if (UsersBLL.Instance.UpdateUser(ad))
                {
                    MessageBox.Show("Cật nhật ảnh thành công");
                    catnhatthanhcong();
                }
            }
            catch
            {
                MessageBox.Show("Cật nhật ảnh thất bại");
            }
        }
    }
}