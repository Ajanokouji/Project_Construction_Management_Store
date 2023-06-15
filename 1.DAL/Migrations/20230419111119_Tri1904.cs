using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1.DAL.Migrations
{
    public partial class Tri1904 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "chucVu",
                columns: table => new
                {
                    IDChucVu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenCV = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chucVu", x => x.IDChucVu);
                });

            migrationBuilder.CreateTable(
                name: "hangSX",
                columns: table => new
                {
                    IDHangSX = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenHangSX = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    trangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hangSX", x => x.IDHangSX);
                });

            migrationBuilder.CreateTable(
                name: "khachHang",
                columns: table => new
                {
                    SDT_KH = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenKH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    diaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    trangThai = table.Column<bool>(type: "bit", nullable: false),
                    diem = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_khachHang", x => x.SDT_KH);
                });

            migrationBuilder.CreateTable(
                name: "mauSac",
                columns: table => new
                {
                    IDMauSac = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenMau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    trangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mauSac", x => x.IDMauSac);
                });

            migrationBuilder.CreateTable(
                name: "sanPham",
                columns: table => new
                {
                    IDsanPham = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenLoaiHang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    trangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sanPham", x => x.IDsanPham);
                });

            migrationBuilder.CreateTable(
                name: "size",
                columns: table => new
                {
                    IDSize = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiZe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    trangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_size", x => x.IDSize);
                });

            migrationBuilder.CreateTable(
                name: "nhanVien",
                columns: table => new
                {
                    IDNhanVien = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDChucVu = table.Column<int>(type: "int", nullable: false),
                    TenNV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    diaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tinhTrang = table.Column<bool>(type: "bit", nullable: false),
                    matKhau = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nhanVien", x => x.IDNhanVien);
                    table.ForeignKey(
                        name: "FK_nhanVien_chucVu_IDChucVu",
                        column: x => x.IDChucVu,
                        principalTable: "chucVu",
                        principalColumn: "IDChucVu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sanPhamChiTiet",
                columns: table => new
                {
                    IDSanPhamChiTiet = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDMauSac = table.Column<int>(type: "int", nullable: true),
                    IDSize = table.Column<int>(type: "int", nullable: true),
                    IDHangSX = table.Column<int>(type: "int", nullable: false),
                    IDsanPham = table.Column<int>(type: "int", nullable: false),
                    TenSP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    maSP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gianhap = table.Column<float>(type: "real", nullable: false),
                    Giaban = table.Column<float>(type: "real", nullable: false),
                    Soluong = table.Column<int>(type: "int", nullable: false),
                    Trangthai = table.Column<bool>(type: "bit", nullable: false),
                    linkAnh = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sanPhamChiTiet", x => x.IDSanPhamChiTiet);
                    table.ForeignKey(
                        name: "FK_sanPhamChiTiet_hangSX_IDHangSX",
                        column: x => x.IDHangSX,
                        principalTable: "hangSX",
                        principalColumn: "IDHangSX",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sanPhamChiTiet_mauSac_IDMauSac",
                        column: x => x.IDMauSac,
                        principalTable: "mauSac",
                        principalColumn: "IDMauSac");
                    table.ForeignKey(
                        name: "FK_sanPhamChiTiet_sanPham_IDsanPham",
                        column: x => x.IDsanPham,
                        principalTable: "sanPham",
                        principalColumn: "IDsanPham",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sanPhamChiTiet_size_IDSize",
                        column: x => x.IDSize,
                        principalTable: "size",
                        principalColumn: "IDSize");
                });

            migrationBuilder.CreateTable(
                name: "hoaDon",
                columns: table => new
                {
                    IDHoaDon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDNhanVien = table.Column<int>(type: "int", nullable: false),
                    SDT_KH = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    tongTien = table.Column<float>(type: "real", nullable: false),
                    ngayBan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ghiChu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    trangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDon", x => x.IDHoaDon);
                    table.ForeignKey(
                        name: "FK_hoaDon_khachHang_SDT_KH",
                        column: x => x.SDT_KH,
                        principalTable: "khachHang",
                        principalColumn: "SDT_KH");
                    table.ForeignKey(
                        name: "FK_hoaDon_nhanVien_IDNhanVien",
                        column: x => x.IDNhanVien,
                        principalTable: "nhanVien",
                        principalColumn: "IDNhanVien",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hoaDonChiTiet",
                columns: table => new
                {
                    IDHoaDon = table.Column<int>(type: "int", nullable: false),
                    IDSanPham = table.Column<int>(type: "int", nullable: false),
                    Soluong = table.Column<int>(type: "int", nullable: false),
                    donGia = table.Column<float>(type: "real", nullable: false),
                    Trangthai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDonChiTiet", x => new { x.IDHoaDon, x.IDSanPham });
                    table.ForeignKey(
                        name: "FK_hoaDonChiTiet_hoaDon_IDHoaDon",
                        column: x => x.IDHoaDon,
                        principalTable: "hoaDon",
                        principalColumn: "IDHoaDon",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hoaDonChiTiet_sanPhamChiTiet_IDSanPham",
                        column: x => x.IDSanPham,
                        principalTable: "sanPhamChiTiet",
                        principalColumn: "IDSanPhamChiTiet",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "chucVu",
                columns: new[] { "IDChucVu", "tenCV" },
                values: new object[,]
                {
                    { 1, "Quản lý" },
                    { 2, "Nhân viên" }
                });

            migrationBuilder.InsertData(
                table: "hangSX",
                columns: new[] { "IDHangSX", "tenHangSX", "trangThai" },
                values: new object[,]
                {
                    { 1, "Karuizawa Shop", true },
                    { 2, "Kyotaka Shop", true },
                    { 3, "Kageyama Shop", true }
                });

            migrationBuilder.InsertData(
                table: "khachHang",
                columns: new[] { "SDT_KH", "TenKH", "diaChi", "diem", "gioiTinh", "trangThai" },
                values: new object[,]
                {
                    { "0123456789", "------", "Hà Nội", 0, true, true },
                    { "0923456567", "Nguyễn Văn Nguyên", "Hà Nội", 0, false, true },
                    { "0923456678", "Hoàng Văn Toàn", "Ninh Bình", 0, true, true }
                });

            migrationBuilder.InsertData(
                table: "mauSac",
                columns: new[] { "IDMauSac", "tenMau", "trangThai" },
                values: new object[,]
                {
                    { 1, "Xanh", true },
                    { 2, "Đỏ", true },
                    { 3, "Trắng", true },
                    { 4, "Hồng", true },
                    { 5, "Nâu", true }
                });

            migrationBuilder.InsertData(
                table: "sanPham",
                columns: new[] { "IDsanPham", "tenLoaiHang", "trangThai" },
                values: new object[,]
                {
                    { 1, "Xi măng Becamex", true },
                    { 2, "Gạch đất nung", true },
                    { 3, "Sắt", true },
                    { 4, "Thép", true },
                    { 5, "Đá xây nhà", true },
                    { 6, "Cát xây nhà", true }
                });

            migrationBuilder.InsertData(
                table: "size",
                columns: new[] { "IDSize", "SiZe", "trangThai" },
                values: new object[,]
                {
                    { 1, "S", true },
                    { 2, "M", true },
                    { 3, "L", true },
                    { 4, "XL", true },
                    { 5, "XXL", true }
                });

            migrationBuilder.InsertData(
                table: "nhanVien",
                columns: new[] { "IDNhanVien", "IDChucVu", "SDT", "TenNV", "diaChi", "email", "matKhau", "tinhTrang" },
                values: new object[,]
                {
                    { 1, 1, "0839361003", "Hoàng Ngọc Trí", "Ninh Bình", "tri232003@gmail.com", "123", true },
                    { 2, 2, "0394716335", "Phạm Đình Khải", "Hải Dương", "khaipdph27082@fpt.edu.vn", "123", true },
                    { 3, 2, "0283761554", "Nguyễn Tiến Đạt", "Hà Nội", "datntph12856@fpt.edu.vn", "123", true },
                    { 4, 2, "0582649228", "Đỗ Hoàng Huy", "Hà Nội", "huynhph39576@fpt.edu.vn", "123", true }
                });

            migrationBuilder.InsertData(
                table: "sanPhamChiTiet",
                columns: new[] { "IDSanPhamChiTiet", "Giaban", "Gianhap", "IDHangSX", "IDMauSac", "IDSize", "IDsanPham", "Soluong", "TenSP", "Trangthai", "linkAnh", "maSP" },
                values: new object[,]
                {
                    { 1, 110000f, 100000f, 1, 1, 1, 1, 1900, "Xi măng Hà Tiên", true, "", "SP01" },
                    { 2, 200000f, 125000f, 2, 2, 2, 2, 1600, "Xi măng Insee ( Holcim) Đa Dụng", true, "", "SP02" },
                    { 3, 170000f, 115000f, 3, 3, 3, 1, 1000, "Xi măng Insee ( Holcim) Xây Tô", true, "", "SP03" },
                    { 4, 150000f, 105000f, 2, 3, 1, 3, 900, "Xi măng Becamex", true, "", "SP04" },
                    { 5, 210000f, 120000f, 2, 2, 2, 2, 1400, "Xi măng Thăng Long", true, "", "SP05" },
                    { 6, 220000f, 125000f, 3, 3, 3, 3, 800, "Xi măng Cẩm Phả", true, "", "SP06" },
                    { 7, 250000f, 1600f, 1, 1, 1, 1, 600, "Xi Măng Fico", true, "", "SP07" },
                    { 8, 290000f, 200000f, 2, 2, 2, 2, 1900, "Gạch đất nung", true, "", "SP08" },
                    { 9, 199000f, 130000f, 3, 3, 3, 3, 1500, "Gạch không nung", true, "", "SP09" },
                    { 10, 170000f, 110000f, 1, 1, 1, 1, 1400, "Gạch bông", true, "", "SP10" },
                    { 11, 150000f, 100000f, 2, 2, 2, 2, 1400, "Gạch men", true, "", "SP11" },
                    { 12, 250000f, 135000f, 1, 1, 1, 1, 1400, "Gạch thông gió", true, "", "SP12" },
                    { 13, 210000f, 140000f, 2, 2, 2, 2, 1400, "Gạch kính", true, "", "SP13" },
                    { 14, 245000f, 150000f, 3, 3, 3, 3, 1200, "Gạch nhựa", true, "", "SP14" },
                    { 15, 270000f, 200000f, 1, 1, 1, 1, 1300, "Gạch cao su", true, "", "SP15" },
                    { 16, 300000f, 230000f, 2, 3, 1, 3, 1420, "Bê tông tươi", true, "", "SP16" },
                    { 17, 205000f, 130000f, 2, 2, 2, 2, 1500, "Bê tông nhựa", true, "", "SP17" },
                    { 18, 185000f, 126000f, 3, 3, 3, 3, 1400, "Bê tông Asphalt", true, "", "SP18" },
                    { 19, 276000f, 192000f, 1, 1, 1, 1, 1600, "Bê tông Polyme", true, "", "SP19" },
                    { 20, 400000f, 300000f, 2, 3, 1, 3, 1700, "Sắt thép cây", true, "", "SP20" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_hoaDon_IDNhanVien",
                table: "hoaDon",
                column: "IDNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDon_SDT_KH",
                table: "hoaDon",
                column: "SDT_KH");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonChiTiet_IDSanPham",
                table: "hoaDonChiTiet",
                column: "IDSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_nhanVien_IDChucVu",
                table: "nhanVien",
                column: "IDChucVu");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhamChiTiet_IDHangSX",
                table: "sanPhamChiTiet",
                column: "IDHangSX");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhamChiTiet_IDMauSac",
                table: "sanPhamChiTiet",
                column: "IDMauSac");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhamChiTiet_IDsanPham",
                table: "sanPhamChiTiet",
                column: "IDsanPham");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhamChiTiet_IDSize",
                table: "sanPhamChiTiet",
                column: "IDSize");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "hoaDonChiTiet");

            migrationBuilder.DropTable(
                name: "hoaDon");

            migrationBuilder.DropTable(
                name: "sanPhamChiTiet");

            migrationBuilder.DropTable(
                name: "khachHang");

            migrationBuilder.DropTable(
                name: "nhanVien");

            migrationBuilder.DropTable(
                name: "hangSX");

            migrationBuilder.DropTable(
                name: "mauSac");

            migrationBuilder.DropTable(
                name: "sanPham");

            migrationBuilder.DropTable(
                name: "size");

            migrationBuilder.DropTable(
                name: "chucVu");
        }
    }
}
