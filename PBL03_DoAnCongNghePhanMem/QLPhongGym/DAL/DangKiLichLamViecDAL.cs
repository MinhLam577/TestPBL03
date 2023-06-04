﻿using QLPhongGym.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongGym.DAL
{
    public class DangKiLichLamViecDAL
    {
        private static DangKiLichLamViecDAL instance;
        public DangKiLichLamViecDAL()
        {

        }
        public static DangKiLichLamViecDAL getInStance
        {
            get
            {
                if (instance == null)
                    instance = new DangKiLichLamViecDAL();
                return instance;
            }
            private set
            {

            }
        }
        QLPhongGymDB db = new QLPhongGymDB();
        DataTable dt = new DataTable();

        public DataTable CreatDataTable()
        {
            dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
                {
                    new DataColumn { ColumnName = "STT", DataType = typeof(int) },
                    //new DataColumn { ColumnName = "Ca", DataType = typeof(int) },
                    new DataColumn { ColumnName = "IDMaHLV", DataType = typeof(int) },
                    new DataColumn { ColumnName = "Name", DataType = typeof(string) },
                   // new DataColumn { ColumnName = "NgayBatDau", DataType = typeof(DateTime) },
                    //new DataColumn {ColumnName = "NgayKetThuc",DataType = typeof(DateTime)},
                    new DataColumn {ColumnName = "NgayLam",DataType = typeof(DateTime)}
                });
            return dt;
        }
        // theo tuan 

        public DataTable CapNhatListHLV(DateTime ngaystart, DateTime ngayend)
        {
            dt = CreatDataTable(); int cnt = 1;
            var result = (from u in db.LichLamViecTrongTuans
                          from i in db.Users.OfType<HLV>()
                          where u.IDHLV == i.IDUsers && u.NgayBatDau == ngaystart && u.NgayBatDau <= ngayend &&
                          u.NgayKetThuc >= ngaystart && u.NgayKetThuc <= ngayend
                          orderby u.NgayLam, u.IDCa
                          select new
                          {
                              u.IDCa,
                              u.IDHLV,
                              i.Name,
                              u.NgayBatDau,
                              u.NgayKetThuc,
                              u.NgayLam
                          }).ToList();
            foreach (var u in result)
                dt.Rows.Add(
                              cnt++,
                              
                              u.IDHLV,
                              u.Name,
                              
                              u.NgayLam
                      );
            return dt;
        }
        public bool ThemCaLamViec(LichLamViecTrongTuan a)
        {
            var aa = new LichLamViecTrongTuan
            {
                IDCa = a.IDCa,
                IDHLV = a.IDHLV,
                NgayBatDau = a.NgayBatDau,
                NgayKetThuc = a.NgayKetThuc,
                NgayLam = a.NgayLam
            };
            db.LichLamViecTrongTuans.Add(aa);
            db.SaveChanges();
            return true;
        }
        // kiem tra xem doi tuong dang ki da ton tai chua
        public bool IsDifferentFromAllCaOther(LichLamViecTrongTuan a)
        {

            return db.LichLamViecTrongTuans.All(p =>
            p.IDHLV != a.IDHLV && p.IDCa != a.IDCa && p.NgayLam != a.NgayLam);

        }
        public void Exit(List<LichLamViecTrongTuan> a)
        {
            try
            {
                var list = db.LichLamViecTrongTuans.ToList();
                foreach (var newObject in a)
                {
                    // Kiểm tra xem đối tượng đã tồn tại trong cơ sở dữ liệu chưa
                    var isExist = list.Any(x =>
                        x.IDHLV == newObject.IDHLV &&
                        x.IDCa == newObject.IDCa &&
                        x.NgayLam == newObject.NgayLam
                    );

                    // Nếu đối tượng chưa tồn tại trong cơ sở dữ liệu, thêm vào
                    if (!isExist)
                    {
                        db.LichLamViecTrongTuans.Add(newObject);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");

            }
        }

        public bool AddPersonIfNotExists(int idhlv, int idca, DateTime ngaybatdau, DateTime ngayketthuc, DateTime ngaylam)
        {
            using (var context = new QLPhongGymDB())
            {
                // Kiểm tra xem đối tượng đã tồn tại trong cơ sở dữ liệu hay chưa
                var existingPerson = context.LichLamViecTrongTuans.FirstOrDefault(x => x.IDHLV == idhlv &&
                        x.IDCa == idca &&
                        x.NgayLam == ngaylam
                        );

                if (existingPerson == null)
                {
                    // Đối tượng chưa tồn tại trong cơ sở dữ liệu, thêm mới
                    var newPerson = new LichLamViecTrongTuan { IDHLV = idhlv, IDCa = idca, NgayBatDau = ngaybatdau, NgayKetThuc = ngayketthuc, NgayLam = ngaylam };
                    context.LichLamViecTrongTuans.Add(newPerson);
                    var sortedTable = context.LichLamViecTrongTuans.OrderBy(x => x.NgayLam).ThenBy(x => x.NgayBatDau >= ngaybatdau && x.NgayKetThuc <= ngayketthuc);
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    // Đối tượng đã tồn tại trong cơ sở dữ liệu, bỏ qua
                    return false;
                }
            }
        }
        public bool Xoa(LichLamViecTrongTuan a)
        {
            // tim kiem lich can chon vs 3 thuoc tinh 
            var lichhlva = db.LichLamViecTrongTuans.SingleOrDefault(x => x.IDHLV == a.IDHLV &&
                        x.IDCa == a.IDCa &&
                        x.NgayLam == a.NgayLam
                        );
            db.LichLamViecTrongTuans.Remove(lichhlva);
            db.SaveChanges();
            return true;
        }
        // tim kiem viec lam theo tuan
        public DataTable TimKiemLichLamViec(int idca, DateTime ngaybatdau, DateTime ngayketthuc)
        {
            dt = CreatDataTable();
            int cnt = 1;

            var result = (from u in db.LichLamViecTrongTuans
                          from i in db.Users.OfType<HLV>()
                          where u.IDHLV == i.IDUsers && u.IDCa == idca &&
                                u.NgayBatDau >= ngaybatdau && u.NgayKetThuc <= ngayketthuc
                          orderby u.NgayLam , u.IDCa
                          select new
                          {
                              u.IDCa,
                              u.IDHLV,
                              i.Name,
                              u.NgayBatDau,
                              u.NgayKetThuc,
                              u.NgayLam
                          }).ToList();

            foreach (var u in result)
                dt.Rows.Add(
                              cnt++,
                              u.IDCa,
                              u.IDHLV,
                              u.Name,
                              u.NgayBatDau,
                              u.NgayKetThuc,
                              u.NgayLam
                        );
            return dt;
        }
        public DataTable TimKiemLichLamViecTheoNgay(int idca, DateTime ngaylam)
        {
            dt = CreatDataTable();
            int cnt = 1;

            var result = (from u in db.LichLamViecTrongTuans
                          from i in db.Users.OfType<HLV>()
                          where u.IDHLV == i.IDUsers && u.IDCa == idca &&
                                u.NgayLam == ngaylam
                          orderby u.NgayLam,u.IDCa
                          select new
                          {
                              u.IDCa,
                              u.IDHLV,
                              i.Name,
                              u.NgayBatDau,
                              u.NgayKetThuc,
                              u.NgayLam
                          }).ToList();

            foreach (var u in result)
                dt.Rows.Add(
                              cnt++,
                              u.IDCa,
                              u.IDHLV,
                              u.Name,
                              u.NgayBatDau,
                              u.NgayKetThuc,
                              u.NgayLam
                        );
            return dt;
        }
        // tim kiem viec lam theo thang 
        // chinh sua lich lam viec 
        public bool SuaLichLamViec(LichLamViecTrongTuan a)
        {
            // tim doi tuong can chinh ssua o csdl 
            var existingLichLamViec = db.LichLamViecTrongTuans.FirstOrDefault(x => x.IDHLV == a.IDHLV &&
                x.IDCa == a.IDCa &&
                x.NgayLam == a.NgayLam
                );
            if (existingLichLamViec != null)
            {
                // Đối tượng đã tồn tại trong cơ sở dữ liệu, thực hiện chỉnh sửa
                existingLichLamViec.NgayBatDau = a.NgayBatDau;
                existingLichLamViec.NgayKetThuc = a.NgayKetThuc;
                existingLichLamViec.NgayLam = a.NgayLam;
                existingLichLamViec.IDCa = a.IDCa;
                existingLichLamViec.IDHLV = a.IDHLV;
                db.SaveChanges();
                return true;
            }
            else
            {
                // Đối tượng chưa tồn tại trong cơ sở dữ liệu, báo lỗi hoặc thêm mới nếu cần thiết
                // Nếu chỉ muốn thêm mới, hãy sử dụng phương thức Add() và SaveChanges() thay vì thông báo lỗi.
                return false;
            }
        }

        // kiem tra THONG TIN DOI TUONG cb  CAP NHAT lam tham so da trung chua ,  
        public bool UpdateOrder(int IDHLV, int IDCa, DateTime ngaybatdau, DateTime ngayketthuc, DateTime NgayLam)
        {
            // Kiểm tra xem các giá trị mới của đối tượng Order đã trùng với các giá trị của một đối tượng Order khác trong cơ sở dữ liệu hay chưa
            var exits = db.LichLamViecTrongTuans.FirstOrDefault(x => x.IDHLV == IDHLV &&
            x.IDCa == IDCa &&
            x.NgayLam == NgayLam);
            if (exits == null)
            {
                return true;
            }
            else
            {
                // Nếu đã tồn tại một đối tượng Order khác trong cơ sở dữ liệu có các giá trị tương tự với đối tượng Order cần sửa đổi, bạn có thể xử lý tùy ý, ví dụ: ném một ngoại lệ, thông báo lỗi, hoặc không cho phép sửa đổi.
                throw new Exception("Order with similar properties already exists in the database.");
                return false;
            }
        }
        public bool capnhat(int idca, int idhlv, DateTime ngaybatdau, DateTime ngayketthuc, DateTime ngaylam, int IDCA, int IDHLV, DateTime NGAYBATDAU, DateTime NGAYKETTHUC, DateTime NGAYLAM)
        {
            // Lấy đối tượng Order cần sửa đổi từ cơ sở dữ liệu
            var lich = db.LichLamViecTrongTuans.FirstOrDefault(x => x.IDHLV == idhlv &&
            x.IDCa == idca &&
            x.NgayLam == ngaylam);
            if (lich != null)
            {
                // Thực hiện các thay đổi trên đối tượng Order             
                if (UpdateOrder(IDHLV, IDCA, NGAYBATDAU, NGAYKETTHUC, NGAYLAM) == true)
                {
                    MessageBox.Show("updateOredr");
                    lich.NgayBatDau = NGAYBATDAU;
                    lich.NgayKetThuc = NGAYKETTHUC;
                    lich.NgayLam = NGAYLAM;
                    lich.IDCa = IDCA;
                    lich.IDHLV = IDHLV;
                    // Lưu các thay đổi vào cơ sở dữ liệu
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    MessageBox.Show("Loi ");
                    return false;
                }
            }
            return false;
        }
        public DataTable CapNhatListHLVAll()
        {
            dt = CreatDataTable(); int cnt = 1;
            var result = (from u in db.LichLamViecTrongTuans
                          from i in db.Users.OfType<HLV>()
                          where u.IDHLV == i.IDUsers
                          orderby u.IDCa,u.NgayLam
                          select new
                          {
                              u.IDCa,
                              u.IDHLV,
                              i.Name,
                              u.NgayBatDau,
                              u.NgayKetThuc,
                              u.NgayLam
                          }).ToList();
            foreach (var u in result)
                dt.Rows.Add(
                              cnt++,
                              /*u.IDCa,*/
                              u.IDHLV,
                              u.Name,
                              /*u.NgayBatDau,
                              u.NgayKetThuc,*/
                              u.NgayLam
                      );
            return dt;
        }
        public bool Capnhat1(int idca, int idhlv,/* DateTime ngaybatdau, DateTime ngaykeythuc,*/ DateTime ngaylam, int IDCA, int IDHLV,/* DateTime NGAYBATDAU, DateTime NGAYKETTHUC,*/ DateTime NGAYLAM)
        {

            // Lấy đối tượng Order cần sửa đổi từ cơ sở dữ liệu
            var lich = db.LichLamViecTrongTuans.FirstOrDefault(x => x.IDHLV == idhlv &&
            x.IDCa == idca &&
            x.NgayLam == ngaylam);
            lich.IDCa = IDCA;
            lich.IDHLV = IDHLV;
            /*lich.NgayBatDau = NGAYBATDAU;
            lich.NgayKetThuc = NGAYKETTHUC;*/
            lich.NgayLam = NGAYLAM;
            db.SaveChanges();
            return true;
        }
        // xem theo ngay 
        public DataTable XemTheoNgay(DateTime ngay)
        {
            dt = CreatDataTable(); int cnt = 0;
            var listtuan = (from u in db.LichLamViecTrongTuans
                            from i in db.Users.OfType<HLV>()
                            where u.NgayLam == ngay
                            orderby u.IDCa , u.NgayLam
                            select new
                            {
                                u.IDCa,
                                u.IDHLV,
                                i.Name,
                                u.NgayBatDau,
                                u.NgayKetThuc,
                                u.NgayLam
                            }).ToList();
            foreach (var u in listtuan)
                dt.Rows.Add(
                              cnt++,
                              u.IDCa,
                              u.IDHLV,
                              u.Name,
                              u.NgayBatDau,
                              u.NgayKetThuc,
                              u.NgayLam
                        );
            return dt;

        }
        public DataTable XemTheoTuan(DateTime ngaybatdau, DateTime ngayketthuc)
        {
            dt = CreatDataTable(); int cnt = 1;
            var listtuan = (from u in db.LichLamViecTrongTuans
                            from i in db.Users.OfType<HLV>()
                            where u.NgayLam >= ngaybatdau && u.NgayLam <= ngayketthuc
                            orderby u.IDCa,u.NgayLam
                            select new
                            {
                                u.IDCa,
                                u.IDHLV,
                                i.Name,
                                u.NgayBatDau,
                                u.NgayKetThuc,
                                u.NgayLam
                            }).ToList();
            foreach (var u in listtuan)
                dt.Rows.Add(
                              cnt++,
                              u.IDCa,
                              u.IDHLV,
                              u.Name,
                              u.NgayBatDau,
                              u.NgayKetThuc,
                              u.NgayLam
                        );
            return dt;

        }
        public DataTable XemTheoNgay1(DateTime ngay)
        {
            dt = CreatDataTable(); int cnt = 0;
            var listtuan = (from u in db.LichLamViecTrongTuans
                            from i in db.Users.OfType<HLV>()
                            where u.NgayLam == ngay
                            orderby u.IDCa, u.NgayLam
                            select new
                            {
                                u.IDCa,
                                u.IDHLV,
                                i.Name,
                                u.NgayBatDau,
                                u.NgayKetThuc,
                                u.NgayLam
                            }).ToList();
            foreach (var u in listtuan)
                dt.Rows.Add(
                              cnt++,
                              u.IDCa,
                              u.IDHLV,
                              u.Name,
                              u.NgayBatDau,
                              u.NgayKetThuc,
                              u.NgayLam
                        );
            return dt;

        }
        public string DisplayHLVTheoCa(string listhlv,int idca , DateTime ngaylam)
        {
            listhlv = "";
  
            var listtuan = (from u in db.LichLamViecTrongTuans
                            from i in db.Users.OfType<HLV>()
                            where u.NgayLam == ngaylam
                            && u.IDCa == idca
                            select new
                            {
                                u.IDHLV,
                                i.Name
                            }).ToList();
            // xoa 2 ki tu cuoi 
        
            for (int i = 0; i < listtuan.Count; i++)
            {
                if (i != listtuan.Count - 1)
                {
                    listhlv += "" + listtuan[i].IDHLV + " " + listtuan[i].Name + ", ";

                }
                else
                {
                    listhlv += "" + listtuan[i].IDHLV + " " + listtuan[i].Name;
                }
            }
            return listhlv;
        }
        // hiển thi tên ca theo ngay cua list hlv
        public List<String> danhsachsinhvientheongayca(DateTime ngay, int idca)
        {
            List<String> danhsachsinhvien = new List<string>();
            var result = (from u in db.LichLamViecTrongTuans
                          from i in db.Users.OfType<HLV>()
                          where u.IDHLV == i.IDUsers && u.NgayLam == ngay && u.IDCa == idca

                          select new
                          {
                              i.Name
                          }).ToList();
            foreach( var every in result)
            {
                danhsachsinhvien.Add(every.Name.ToString());

            }
            return danhsachsinhvien;
        }

        public List<String> danhsachmasinhvientheongayca(DateTime ngay, int idca, string name)
        {
            List<String> danhsachsinhvien = new List<string>();
            var result = (from u in db.LichLamViecTrongTuans
                          from i in db.Users.OfType<HLV>()
                          where u.IDHLV == i.IDUsers && u.NgayLam == ngay && u.IDCa == idca && i.Name.Contains(name)

                          select new
                          {
                              i.IDUsers
                          }).ToList();
            foreach (var every in result)
            {
                danhsachsinhvien.Add(every.IDUsers.ToString());

            }
            return danhsachsinhvien;
        }
        public DataTable ListHLVByCaForm2(DateTime ngaylam, int idca)
        {
            dt = CreatDataTable(); int cnt = 1;

            var result = (from u in db.LichLamViecTrongTuans
                          from i in db.Users.OfType<HLV>()
                          where u.IDHLV == i.IDUsers && u.NgayLam == ngaylam && u.IDCa == idca

                          select new
                          {
                             u.IDHLV,
                             i.Name,
                             u.NgayLam
                          }).ToList();
            foreach (var u in result)
                dt.Rows.Add(
                              cnt++,
                              u.IDHLV,
                              u.Name,
                              u.NgayLam
                        );
            return dt;
        }
    }
}










