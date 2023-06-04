﻿using QLPhongGym.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLPhongGym.DTO;
using System.Data.Common;
using System.Globalization;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Reflection.Emit;
using System.Reflection;
using System.Drawing.Text;
using System.Data.Entity.ModelConfiguration.Configuration;
using QLPhongGym.DAL;
using System.Xml;
using System.Linq.Expressions;

namespace QLPhongGym.GUI
{
    public partial class XepLichHLV : Form
    {

        public delegate void AddHLVToListBox(DateTime ngaybatdau);
        public AddHLVToListBox HLVDelegate;

        /*public delegate void EditHLVToListBox(DateTime ngaybatdau);
        public EditHLVToListBox edithlv;*/

        
        public XepLichHLV()
        {
            InitializeComponent();
            //floatTimeNgayLam();
        }
       /* private void floatTimeNgayLam()
        {
            ngaylamviec.Value = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, dateTimeNgayStart.Value.Day);

        }*/
        public DateTime ngaylamviec1 { get; set; }
        public string ca { get; set; }
       
        public DateTime ngaybatdau1 { get; set; }
        public DateTime ngayketthuc1 { get; set; }

        private void XepLichHLV_Load(object sender, EventArgs e)
        {
           
          

            ngaylamviec.Value = ngaylamviec1;
            cbbCaLam.SelectedItem = ca;
            dateTimeNgayStart.Value = ngaybatdau1;
            dateTimeNgayEnd.Value = ngayketthuc1;
            string s = cbbCaLam.SelectedItem.ToString().Trim();
            int id = Convert.ToInt32(s.Substring(3, 1));
            dataGridView1.DataSource =DangKiLichLamViecBAL.getInStance.ListHLVByCaForm2(ngaylamviec.Value, id);
            // them danh sach hlv len checklist box
            var listHLV = QLHLVBLL.getInstance.GetHLVs();
            foreach (var list in listHLV)
            {
                checkedListBox1.Items.Add(list.IDUsers + " " + list.Name);
            }
                //tuanlam();*/


        }
        string luachon = "";
        private void btnXem_Click(object sender, EventArgs e)
        {
            int cnt = 0;
            //dataGridView1.DataSource = DangKiLichLamViecBAL.getInStance.CapNhatListDangKiCa(dateTimeNgayStart.Value, dateTimeNgayEnd.Value);
           

                dataGridView1.DataSource = DangKiLichLamViecBAL.getInStance.XemTheoNgay(ngaylamviec.Value);
        

                dataGridView1.DataSource = DangKiLichLamViecBAL.getInStance.XemTheoTuan(dateTimeNgayStart.Value, dateTimeNgayEnd.Value);
            
           

                dataGridView1.DataSource = DangKiLichLamViecBAL.getInStance.CapNhatListHLVAll();
            
            // sap xep theo ngay luon 
        }
        private void cbbCaLam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCaLam.SelectedIndex == -1)
            {
                MessageBox.Show("Vui long nhap");
            }
            else
            {
                if (cbbCaLam.SelectedItem.ToString() == "Ca 1")
                {
                    textTimebatdau.Text = "7h";
                    textTimeEnd.Text = "9h";
                }
                else if (cbbCaLam.SelectedItem.ToString() == "Ca 2")
                {
                    textTimebatdau.Text = "9h";
                    textTimeEnd.Text = "11h";
                }
                else if (cbbCaLam.SelectedItem.ToString() == "Ca 3")
                {
                    textTimebatdau.Text = "15h";
                    textTimeEnd.Text = "17h";
                }
                else if (cbbCaLam.SelectedItem.ToString() == "Ca 4")
                {
                    textTimebatdau.Text = "17h";
                    textTimeEnd.Text = "19h";
                }
            }
        }
        List<LichLamViecTrongTuan> tuan;
        LichLamViecTrongTuan a;
        QLPhongGymDB db = new QLPhongGymDB();

        public object Date { get; private set; }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbbCaLam.SelectedIndex != -1)
            {
                //dataGridView1.DataSource = QLHLVBLL.getInstance.getinfoLichHLV();
                //dataGridView1.Rows.Add(0, 1);
                tuan = new List<LichLamViecTrongTuan>();
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    // Kiểm tra xem phần tử này đã được chọn chưa
                    if (checkedListBox1.GetItemChecked(i))
                    {
                        // Lấy text của phần tử đã chọn
                        string itemText = checkedListBox1.Items[i].ToString();
                        a = new LichLamViecTrongTuan();
                        string[] parts = itemText.Split(' ');
                        string ma = (parts[0]);
                        string hoTen = string.Join(" ", parts.Skip(1));
                        string textca = cbbCaLam.SelectedItem.ToString().Trim();
                        a.IDHLV = Convert.ToInt32(ma);
                        int idca = -1;
                        switch (textca)
                        {
                            case "Ca 1":
                                a.IDCa = 1;
                                idca = 1;
                                break;
                            case "Ca 2":
                                a.IDCa = 2;
                                idca = 2;
                                break;
                            case "Ca 3":
                                a.IDCa = 3;
                                idca = 3;
                                break;
                            case "Ca 4":
                                a.IDCa = 4;
                                idca = 4;
                                break;
                            default:
                                MessageBox.Show("Lỗi ");
                                break;
                        }
                        /* MessageBox.Show(ma.ToString());
                         MessageBox.Show(hoTen);*/

                        a.NgayLam = ngaylamviec.Value;
                        //MessageBox.Show(a.NgayLam.ToString());
                        a.NgayBatDau = dateTimeNgayStart.Value;

                        a.NgayKetThuc = dateTimeNgayEnd.Value;
                        if (DangKiLichLamViecBAL.getInStance.AddPersonIfNotExists((int)a.IDHLV, (int)a.IDCa, (DateTime)a.NgayBatDau, (DateTime)a.NgayKetThuc, (DateTime)a.NgayLam))
                        {
                            MessageBox.Show("Thêm Thành công "+ a.IDHLV.ToString() +" "+ hoTen );
                            //dataGridView1.DataSource = DangKiLichLamViecBAL.getInStance.CapNhatListDangKiCa(dateTimeNgayStart.Value, dateTimeNgayEnd.Value);
                            dataGridView1.DataSource= DangKiLichLamViecBAL.getInStance.ListHLVByCaForm2(ngaylamviec.Value,idca);
                            
                        }
                        else
                        {
                            MessageBox.Show(a.IDHLV +" "+hoTen +" đã tồn tại");
                        }
                    }
                }
                HLVDelegate(dateTimeNgayStart.Value);

            }
            else
            {
                MessageBox.Show("Bạn Cần nhập vào Ca");
            }

            // cap nhat lai  form1 listHLV ở listbox
            FormDangKiLichHLV1 aa = new FormDangKiLichHLV1();
            aa.hienthilenlistboxHang(dateTimeNgayStart.Value);

        }

        private void dateTimeNgayStart_ValueChanged(object sender, EventArgs e)
        {
            /*  // Kiểm tra nếu labelWeek có giá trị là "Tuần 1"
              if (lbTuanLam.Text == "Tuần 1")
              {
                  // Tạo một đối tượng DateTime mới với ngày là 1 và giờ phút giây là 0
                  DateTime date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                  // Thiết lập giá trị của DateTimePicker là ngày vừa tạo
                  dateTimeNgayStart.Value = date;
                  dateTimeNgayEnd.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 8);
              }*/
            ngaylamviec.Value = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, dateTimeNgayStart.Value.Day);
        }
        private void tuanlam()
        {
           /* if (lbTuanLam.Text == "Tuần 1")
            {
                // Tạo một đối tượng DateTime mới với ngày là 1 và giờ phút giây là 0
                DateTime date = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, 1);
                // Thiết lập giá trị của DateTimePicker là ngày vừa tạo
                dateTimeNgayStart.Value = date;
                dateTimeNgayEnd.Value = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, 7);
            }
            else if (lbTuanLam.Text == "Tuần 2")
            {
                DateTime date = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, 8);
                // Thiết lập giá trị của DateTimePicker là ngày vừa tạo
                dateTimeNgayStart.Value = date;
                dateTimeNgayEnd.Value = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, 14);
                ngaylamviec.Value = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, dateTimeNgayStart.Value.Day);
            }
            else if (lbTuanLam.Text == "Tuần 3")
            {
                DateTime date = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, 15);
                // Thiết lập giá trị của DateTimePicker là ngày vừa tạo
                dateTimeNgayStart.Value = date;
                dateTimeNgayEnd.Value = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, 21);
                ngaylamviec.Value = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, dateTimeNgayStart.Value.Day);
            }
            else if (lbTuanLam.Text == "Tuần 4")
            {
                DateTime date = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, 22);
                // Thiết lập giá trị của DateTimePicker là ngày vừa tạo
                dateTimeNgayStart.Value = date;
                dateTimeNgayEnd.Value = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, 28);
            }
            else if (lbTuanLam.Text == "Tuần 5")
            {
                // tinh so ngay trong thang  
                int daysInMonth = DateTime.DaysInMonth(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month);
                DateTime date = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, 29);
                // Thiết lập giá trị của DateTimePicker là ngày vừa tạo
                dateTimeNgayStart.Value = date;
                dateTimeNgayEnd.Value = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, daysInMonth);
            }*/
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /*string Sotuan = lbTuanLam.Text.Trim();
            string[] parts = Sotuan.Split(' ');
            int weekNumber = Int32.Parse(parts[1]);
            if (weekNumber < 5)
            {
                lbTuanLam.Text = parts[0] + " " + (++weekNumber);
            }
            ngaylamviec.Value = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, dateTimeNgayStart.Value.Day);*/
        }
        private void button5_Click(object sender, EventArgs e)
        {
           /* string Sotuan = lbTuanLam.Text.Trim();
            string[] parts = Sotuan.Split(' '); // Tách chuỗi thành mảng các chuỗi con dựa trên ký tự khoảng trắng
            int weekNumber = Int32.Parse(parts[1]);
            if (weekNumber > 1)
            {
                lbTuanLam.Text = parts[0] + " " + (--weekNumber);
            }
            ngaylamviec.Value = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, dateTimeNgayStart.Value.Day);*/
        }
        private void lbTuanLam_TextChanged(object sender, EventArgs e)
        {
            tuanlam();
            ngaylamviec.Value = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, dateTimeNgayStart.Value.Day);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Hàng đầu tiên trên DataGridView đã được chọn
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                // can than loi thieu value
                //int idca = Convert.ToInt32(selectedRow.Cells[1].Value.ToString());
                int idhlv = Convert.ToInt32(selectedRow.Cells[1].Value.ToString());
                DateTime ngaylam = Convert.ToDateTime(selectedRow.Cells[3].Value.ToString());
                LichLamViecTrongTuan a = new LichLamViecTrongTuan();
                string ca = cbbCaLam.SelectedItem.ToString();
                int id = Convert.ToInt32(ca.Substring(3,1));
                a.IDCa = id;
                a.IDHLV = idhlv;
                a.NgayLam = ngaylam;
                if (DangKiLichLamViecBAL.getInStance.Xoa(a) == true)
                {
                    MessageBox.Show("Xoa thanh cong");
                }
            }
            else
            {
                MessageBox.Show("Vui long chon hang ");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // tim kiem ca theo tuan 
/*            if (cbbTimKiemCaLam.SelectedIndex != -1)
            {
                string a = cbbTimKiemCaLam.SelectedItem.ToString();
                string[] parts = a.Split(' ');
                string caNumberString = parts[parts.Length - 1];
                int caNumber = int.Parse(caNumberString);
               
                    dataGridView1.DataSource = DangKiLichLamViecBAL.getInStance.TimKiemLichLamViec(caNumber, dateTimeNgayStart.Value, dateTimeNgayEnd.Value);
             
                    dataGridView1.DataSource = DangKiLichLamViecBAL.getInStance.TimKiemLichLamViecTheoNgay(caNumber, ngaylamviec.Value);


                }
                else
                {
                    MessageBox.Show("Ban chua kick o radiobutton ");
                }*/
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormEditLichLamViec a = new FormEditLichLamViec();
            a.ngaybatdau = dateTimeNgayStart.Value;
            a.ngayketthuc = dateTimeNgayEnd.Value;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                // int IDCa = Convert.ToInt32(row.Cells[1].Value.ToString());
                int IDCa = Convert.ToInt32(cbbCaLam.SelectedItem.ToString().Substring(3, 1));
                int IDHLV = Convert.ToInt32(row.Cells[1].Value.ToString());
              
                DateTime NgayLam = Convert.ToDateTime(row.Cells[3].Value.ToString());
                a.idca = IDCa;
                a.idhlv = IDHLV;
               /* a.ngaybatdau = NgayBatDau;
                a.ngayketthuc = NgayKetThuc;*/
                a.ngaylam = NgayLam;
                a.Show();
                a.buon += new FormEditLichLamViec.mydelegate(Edit);
               
    }
            else
            {
                MessageBox.Show("Chua nhap vao hang");

            }
        }
        public void Edit(int idca, int idhlv, DateTime ngaybatdau, /*DateTime ngayketthuc,*/ DateTime ngaylam)
        {
            /*DangKiLichLamViecBAL.getInStance.UpdateOrder(idhlv,idca,ngaybatdau,ngayketthuc,ngaylam);
            */
            try {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                int IDCa = Convert.ToInt32(cbbCaLam.SelectedItem.ToString().Substring(3, 1));
                int IDHLV = Convert.ToInt32(row.Cells[1].Value.ToString());
               // DateTime NgayBatDau = Convert.ToDateTime(row.Cells[4].Value.ToString());
                /*DateTime NgayKetThuc = Convert.ToDateTime(row.Cells[5].Value.ToString());*/
                DateTime NgayLam = Convert.ToDateTime(row.Cells[3].Value.ToString());
                if (IDCa != idca || IDHLV != idhlv || ngaylam != NgayLam)
                {

                    if (DangKiLichLamViecBAL.getInStance.Capnhat1(IDCa, IDHLV, /*NgayBatDau, NgayKetThuc,*/ NgayLam, idca, idhlv, /*ngaybatdau, ngayketthuc,*/ ngaylam) == true)
                    {
                        MessageBox.Show("Cap Nhat thanh cong ");
                        
                        string[] parts = ca.Split(' ');
                        string caNumberString = parts[parts.Length - 1];

                        int caNumber = int.Parse(caNumberString);
                        dataGridView1.DataSource = DangKiLichLamViecBAL.getInStance.ListHLVByCaForm2(NgayLam, caNumber);
                        
                    }
                    else
                    {
                        MessageBox.Show("Da ton tai");
                    }
                }
                else if (IDCa == idca && IDHLV == idhlv && ngaylam == NgayLam)
                {
                    MessageBox.Show("Lịch Làm Việc đã tồn tại  ");
                }      
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã rồn tại rồi ");
            }
        }


        private void btnthangsau_Click(object sender, EventArgs e)
        {
            /*if (dateTimeNgayStart.Value.Month >= 1 && dateTimeNgayStart.Value.Month < 12)
            {
                int nam = dateTimeNgayStart.Value.Year;
                int thang = dateTimeNgayStart.Value.Month;
                int ngaybatdau = dateTimeNgayStart.Value.Day;
                int ngayketthuc = dateTimeNgayEnd.Value.Day;

                thang = ++thang;
                int daysInMonth = DateTime.DaysInMonth(nam, thang);
                if (lbTuanLam.Text == "Tuần 5")
                {
                    dateTimeNgayStart.Value = new DateTime(nam, thang, 29);
                    dateTimeNgayEnd.Value = new DateTime(nam, thang, daysInMonth);
                    ngaylamviec.Value = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, dateTimeNgayStart.Value.Day);
                }
                else
                {
                    dateTimeNgayStart.Value = new DateTime(nam, thang, ngaybatdau);
                    dateTimeNgayEnd.Value = new DateTime(nam, thang, ngayketthuc);
                    ngaylamviec.Value = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, dateTimeNgayStart.Value.Day);
                }
            }*/
        }

        private void btnthangtruoc_Click(object sender, EventArgs e)
        {
            /*if (dateTimeNgayStart.Value.Month > 1 && dateTimeNgayStart.Value.Month <= 12)
            {
                int nam = dateTimeNgayStart.Value.Year;
                int thang = dateTimeNgayStart.Value.Month;
                int ngaybatdau = dateTimeNgayStart.Value.Day;
                int ngayketthuc = dateTimeNgayEnd.Value.Day;
                thang = --thang;
                int daysInMonth = DateTime.DaysInMonth(nam, thang);
                if (lbTuanLam.Text == "Tuần 5")
                {
                    dateTimeNgayStart.Value = new DateTime(nam, thang, 29);
                    dateTimeNgayEnd.Value = new DateTime(nam, thang, daysInMonth);
                    ngaylamviec.Value = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, dateTimeNgayStart.Value.Day);
                }
                else
                {
                    dateTimeNgayStart.Value = new DateTime(nam, thang, ngaybatdau);
                    dateTimeNgayEnd.Value = new DateTime(nam, thang, ngayketthuc);
                    ngaylamviec.Value = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, dateTimeNgayStart.Value.Day);
                }
            }*/
        }

        private void btntru_Click(object sender, EventArgs e)
        {
            if (ngaylamviec.Value > dateTimeNgayStart.Value && ngaylamviec.Value <= dateTimeNgayEnd.Value)
            {
                int day = ngaylamviec.Value.Day;
                day = --day;
                ngaylamviec.Value = new DateTime(ngaylamviec.Value.Year, ngaylamviec.Value.Month, day);
            }
        }
        private void btnCong_Click(object sender, EventArgs e)
        {
            if (ngaylamviec.Value >= dateTimeNgayStart.Value && ngaylamviec.Value < dateTimeNgayEnd.Value)
            {
                int day = ngaylamviec.Value.Day;
                day = ++day;
                ngaylamviec.Value = new DateTime(ngaylamviec.Value.Year, ngaylamviec.Value.Month, day);
            }
        }

        private void lbTuanLam_Click(object sender, EventArgs e)
        {

        }
        private void btbOKI_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormDangKiLichHLV1 aa = new FormDangKiLichHLV1();
            aa.hienthilenlistboxHang(dateTimeNgayStart.Value);
            this.Dispose();
        }

        
    }
}
           
            
    


      
    
    
