using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<chucVu>().HasData(
                new chucVu() { IDChucVu = 1, tenCV = "Quản lý" },
                new chucVu() { IDChucVu = 2, tenCV = "Nhân viên" }
                );
            modelBuilder.Entity<hangSX>().HasData(
                new hangSX() { IDHangSX = 1, tenHangSX = "Karuizawa Shop", trangThai = true },
                new hangSX() { IDHangSX = 2, tenHangSX = "Kyotaka Shop", trangThai = true },
                new hangSX() { IDHangSX = 3, tenHangSX = "Kageyama Shop", trangThai = true }
                );
            modelBuilder.Entity<khachHang>().HasData(
                new khachHang() { SDT_KH = "0123456789", TenKH = "------", gioiTinh=true, diaChi="Hà Nội", trangThai=true, diem = 0 },
                new khachHang() { SDT_KH = "0923456567", TenKH = "Nguyễn Văn Nguyên", gioiTinh = false, diaChi = "Hà Nội", trangThai = true, diem = 0 },
                new khachHang() { SDT_KH = "0923456678", TenKH = "Hoàng Văn Toàn", gioiTinh = true, diaChi = "Ninh Bình", trangThai = true, diem = 0 }
                );
            modelBuilder.Entity<mauSac>().HasData(
                new mauSac() { IDMauSac = 1, tenMau = "Xanh" ,trangThai = true},
                new mauSac() { IDMauSac = 2, tenMau = "Đỏ", trangThai = true },
                new mauSac() { IDMauSac = 3, tenMau = "Trắng", trangThai = true },
                new mauSac() { IDMauSac = 4, tenMau = "Hồng", trangThai = true },
                new mauSac() { IDMauSac = 5, tenMau = "Nâu", trangThai = true }
                );
            modelBuilder.Entity<size>().HasData(
                new size() { IDSize = 1, SiZe = "S", trangThai = true },
                new size() { IDSize = 2, SiZe = "M", trangThai = true },
                new size() { IDSize = 3, SiZe = "L", trangThai = true },
                new size() { IDSize = 4, SiZe = "XL", trangThai = true },
                new size() { IDSize = 5, SiZe = "XXL", trangThai = true }
                );
            modelBuilder.Entity<sanPham1>().HasData(
              new sanPham1() { IDsanPham = 1, tenLoaiHang = "Xi măng Becamex", trangThai = true },
              new sanPham1() { IDsanPham = 2, tenLoaiHang = "Gạch đất nung", trangThai = true },
              new sanPham1() { IDsanPham = 3, tenLoaiHang = "Sắt", trangThai = true },
              new sanPham1() { IDsanPham = 4, tenLoaiHang = "Thép", trangThai = true },
              new sanPham1() { IDsanPham = 5, tenLoaiHang = "Đá xây nhà", trangThai = true },
              new sanPham1() { IDsanPham = 6, tenLoaiHang = "Cát xây nhà", trangThai = true }
             
              );
            modelBuilder.Entity<nhanVien>().HasData(
                new nhanVien() { IDNhanVien = 1, TenNV = "Hoàng Ngọc Trí", IDChucVu = 1, diaChi = "Ninh Bình",SDT="0839361003", email="tri232003@gmail.com" ,tinhTrang=true, matKhau="123" },
                 new nhanVien() { IDNhanVien = 2, TenNV = "Phạm Đình Khải", IDChucVu = 2, diaChi = "Hải Dương", SDT = "0394716335", email = "khaipdph27082@fpt.edu.vn", tinhTrang = true, matKhau = "123" },
                 new nhanVien() { IDNhanVien = 3, TenNV = "Nguyễn Tiến Đạt", IDChucVu = 2, diaChi = "Hà Nội", SDT = "0283761554", email = "datntph12856@fpt.edu.vn", tinhTrang = true, matKhau = "123" },
                 new nhanVien() { IDNhanVien = 4, TenNV = "Đỗ Hoàng Huy", IDChucVu = 2, diaChi = "Hà Nội", SDT = "0582649228", email = "huynhph39576@fpt.edu.vn", tinhTrang = true, matKhau = "123" }
                );
            modelBuilder.Entity<sanPhamChiTiet>().HasData(
                new sanPhamChiTiet() { IDSanPhamChiTiet = 1,maSP = "SP01", TenSP = "Xi măng Hà Tiên", Gianhap = 100000, Giaban = 110000, Soluong = 1900, Trangthai = true, IDHangSX = 1, IDSize = 1, IDMauSac = 1, IDsanPham = 1, linkAnh="" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 2, maSP = "SP02", TenSP = "Xi măng Insee ( Holcim) Đa Dụng", Gianhap = 125000, Giaban = 200000, Soluong = 1600, Trangthai = true, IDHangSX = 2, IDSize = 2, IDMauSac = 2, IDsanPham = 2, linkAnh = "" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 3, maSP = "SP03", TenSP = "Xi măng Insee ( Holcim) Xây Tô", Gianhap = 115000, Giaban = 170000, Soluong = 1000, Trangthai = true, IDHangSX = 3, IDSize = 3, IDMauSac = 3, IDsanPham = 1, linkAnh = "" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 4, maSP = "SP04", TenSP = "Xi măng Becamex", Gianhap = 105000, Giaban = 150000, Soluong = 900, Trangthai = true, IDHangSX = 2, IDSize = 1, IDMauSac = 3, IDsanPham = 3, linkAnh = "" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 5, maSP = "SP05", TenSP = "Xi măng Thăng Long", Gianhap = 120000, Giaban = 210000, Soluong = 1400, Trangthai = true, IDHangSX = 2, IDSize = 2, IDMauSac = 2, IDsanPham = 2, linkAnh = "" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 6, maSP = "SP06", TenSP = "Xi măng Cẩm Phả", Gianhap = 125000, Giaban = 220000, Soluong = 800, Trangthai = true, IDHangSX = 3, IDSize = 3, IDMauSac = 3, IDsanPham = 3, linkAnh = "" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 7, maSP = "SP07", TenSP = "Xi Măng Fico", Gianhap = 1600, Giaban = 250000, Soluong = 600, Trangthai = true, IDHangSX = 1, IDSize = 1, IDMauSac = 1, IDsanPham = 1, linkAnh = "" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 8, maSP = "SP08", TenSP = "Gạch đất nung", Gianhap = 200000, Giaban = 290000, Soluong = 1900, Trangthai = true, IDHangSX = 2, IDSize = 2, IDMauSac = 2, IDsanPham = 2, linkAnh = "" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 9, maSP = "SP09", TenSP = "Gạch không nung", Gianhap = 130000, Giaban = 199000, Soluong = 1500, Trangthai = true, IDHangSX = 3, IDSize = 3, IDMauSac = 3, IDsanPham = 3, linkAnh = "" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 10, maSP = "SP10", TenSP = "Gạch bông", Gianhap = 110000, Giaban = 170000, Soluong = 1400, Trangthai = true, IDHangSX = 1, IDSize = 1, IDMauSac = 1, IDsanPham = 1, linkAnh = "" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 11, maSP = "SP11", TenSP = "Gạch men", Gianhap = 100000, Giaban = 150000, Soluong = 1400, Trangthai = true, IDHangSX = 2, IDSize = 2, IDMauSac = 2, IDsanPham = 2, linkAnh = "" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 12, maSP = "SP12", TenSP = "Gạch thông gió", Gianhap = 135000, Giaban = 250000, Soluong = 1400, Trangthai = true, IDHangSX = 1, IDSize = 1, IDMauSac = 1, IDsanPham = 1, linkAnh = "" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 13, maSP = "SP13", TenSP = "Gạch kính", Gianhap = 140000, Giaban = 210000, Soluong = 1400, Trangthai = true, IDHangSX = 2, IDSize = 2, IDMauSac = 2, IDsanPham = 2, linkAnh = "" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 14, maSP = "SP14", TenSP = "Gạch nhựa", Gianhap = 150000, Giaban = 245000, Soluong = 1200, Trangthai = true, IDHangSX = 3, IDSize = 3, IDMauSac = 3, IDsanPham = 3, linkAnh = "" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 15, maSP = "SP15", TenSP = "Gạch cao su", Gianhap = 200000, Giaban = 270000, Soluong = 1300, Trangthai = true, IDHangSX = 1, IDSize = 1, IDMauSac = 1, IDsanPham = 1, linkAnh = "" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 16, maSP = "SP16", TenSP = "Bê tông tươi", Gianhap = 230000, Giaban = 300000, Soluong = 1420, Trangthai = true, IDHangSX = 2, IDSize = 1, IDMauSac = 3, IDsanPham = 3, linkAnh = "" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 17, maSP = "SP17", TenSP = "Bê tông nhựa", Gianhap = 130000, Giaban = 205000, Soluong = 1500, Trangthai = true, IDHangSX = 2, IDSize = 2, IDMauSac = 2, IDsanPham = 2, linkAnh = "" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 18, maSP = "SP18", TenSP = "Bê tông Asphalt", Gianhap = 126000, Giaban = 185000, Soluong = 1400, Trangthai = true, IDHangSX = 3, IDSize = 3, IDMauSac = 3, IDsanPham = 3, linkAnh = "" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 19, maSP = "SP19", TenSP = "Bê tông Polyme", Gianhap = 192000, Giaban = 276000, Soluong = 1600, Trangthai = true, IDHangSX = 1, IDSize = 1, IDMauSac = 1, IDsanPham = 1, linkAnh = "" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 20, maSP = "SP20", TenSP = "Sắt thép cây", Gianhap = 300000, Giaban = 400000, Soluong = 1700, Trangthai = true, IDHangSX = 2, IDSize = 1, IDMauSac = 3, IDsanPham = 3, linkAnh = "" }
                );
        }
    }
}
