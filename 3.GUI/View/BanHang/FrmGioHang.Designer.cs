namespace _3.GUI.View.BanHang
{
	partial class FrmGioHang
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGioHang));
			groupBox1 = new GroupBox();
			cbb_NSX = new ComboBox();
			label16 = new Label();
			cbb_size = new ComboBox();
			label15 = new Label();
			cbb_Mau = new ComboBox();
			label14 = new Label();
			label1 = new Label();
			tbt_timKiem = new TextBox();
			dtgv_sanPham = new DataGridView();
			Column16 = new DataGridViewTextBoxColumn();
			Column1 = new DataGridViewTextBoxColumn();
			Column2 = new DataGridViewTextBoxColumn();
			Column5 = new DataGridViewTextBoxColumn();
			Column6 = new DataGridViewTextBoxColumn();
			Column3 = new DataGridViewTextBoxColumn();
			Column7 = new DataGridViewTextBoxColumn();
			Column4 = new DataGridViewTextBoxColumn();
			groupBox2 = new GroupBox();
			label10 = new Label();
			btn_themKH = new Button();
			tbt_tenKh = new TextBox();
			lbl_Diem = new Label();
			label21 = new Label();
			lbl_tongTien = new Label();
			label18 = new Label();
			btn_CapNhatHD = new Button();
			btn_TaoHoaDon = new Button();
			btn_xoaGioHang = new Button();
			btn_xoaSP = new Button();
			label3 = new Label();
			tbt_SDT = new TextBox();
			label2 = new Label();
			dtgv_gioHang = new DataGridView();
			Column8 = new DataGridViewTextBoxColumn();
			Column9 = new DataGridViewTextBoxColumn();
			Column10 = new DataGridViewTextBoxColumn();
			Column11 = new DataGridViewTextBoxColumn();
			groupBox3 = new GroupBox();
			dtgv_HDcho = new DataGridView();
			Column14 = new DataGridViewTextBoxColumn();
			Column15 = new DataGridViewTextBoxColumn();
			groupBox4 = new GroupBox();
			lbl_giamGia = new Label();
			tbt_ghiChu = new TextBox();
			label13 = new Label();
			label12 = new Label();
			tbt_giamGia = new TextBox();
			lbl_Tong = new Label();
			lbl_TienThua = new Label();
			tbt_tienKhachDua = new TextBox();
			tbt_maHD = new TextBox();
			btn_thanhToan = new Button();
			label9 = new Label();
			label8 = new Label();
			label7 = new Label();
			label6 = new Label();
			label4 = new Label();
			ppdhd = new PrintPreviewDialog();
			pdhd = new System.Drawing.Printing.PrintDocument();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dtgv_sanPham).BeginInit();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dtgv_gioHang).BeginInit();
			groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dtgv_HDcho).BeginInit();
			groupBox4.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(cbb_NSX);
			groupBox1.Controls.Add(label16);
			groupBox1.Controls.Add(cbb_size);
			groupBox1.Controls.Add(label15);
			groupBox1.Controls.Add(cbb_Mau);
			groupBox1.Controls.Add(label14);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(tbt_timKiem);
			groupBox1.Controls.Add(dtgv_sanPham);
			groupBox1.Location = new Point(37, 24);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(995, 375);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Danh sách sản phẩm";
			// 
			// cbb_NSX
			// 
			cbb_NSX.FormattingEnabled = true;
			cbb_NSX.Location = new Point(429, 27);
			cbb_NSX.Name = "cbb_NSX";
			cbb_NSX.Size = new Size(103, 28);
			cbb_NSX.TabIndex = 8;
			cbb_NSX.SelectedIndexChanged += cbb_NSX_SelectedIndexChanged_1;
			// 
			// label16
			// 
			label16.AutoSize = true;
			label16.Location = new Point(379, 32);
			label16.Name = "label16";
			label16.Size = new Size(37, 20);
			label16.TabIndex = 7;
			label16.Text = "NSX";
			// 
			// cbb_size
			// 
			cbb_size.FormattingEnabled = true;
			cbb_size.Location = new Point(237, 27);
			cbb_size.Name = "cbb_size";
			cbb_size.Size = new Size(105, 28);
			cbb_size.TabIndex = 6;
			cbb_size.SelectedIndexChanged += cbb_size_SelectedIndexChanged_1;
			// 
			// label15
			// 
			label15.AutoSize = true;
			label15.Location = new Point(185, 29);
			label15.Name = "label15";
			label15.Size = new Size(36, 20);
			label15.TabIndex = 5;
			label15.Text = "Size";
			// 
			// cbb_Mau
			// 
			cbb_Mau.FormattingEnabled = true;
			cbb_Mau.Location = new Point(67, 27);
			cbb_Mau.Name = "cbb_Mau";
			cbb_Mau.Size = new Size(95, 28);
			cbb_Mau.TabIndex = 4;
			cbb_Mau.SelectedIndexChanged += cbb_Mau_SelectedIndexChanged_1;
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Location = new Point(1, 29);
			label14.Name = "label14";
			label14.Size = new Size(63, 20);
			label14.TabIndex = 3;
			label14.Text = "Màu sắc";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(670, 29);
			label1.Name = "label1";
			label1.Size = new Size(138, 20);
			label1.TabIndex = 2;
			label1.Text = "Tìm kiếm sản phẩm";
			// 
			// tbt_timKiem
			// 
			tbt_timKiem.Location = new Point(814, 25);
			tbt_timKiem.Name = "tbt_timKiem";
			tbt_timKiem.Size = new Size(163, 27);
			tbt_timKiem.TabIndex = 1;
			tbt_timKiem.TextChanged += tbt_timKiem_TextChanged_1;
			// 
			// dtgv_sanPham
			// 
			dtgv_sanPham.AllowUserToAddRows = false;
			dtgv_sanPham.AllowUserToDeleteRows = false;
			dtgv_sanPham.AllowUserToResizeColumns = false;
			dtgv_sanPham.AllowUserToResizeRows = false;
			dtgv_sanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dtgv_sanPham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dtgv_sanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dtgv_sanPham.Columns.AddRange(new DataGridViewColumn[] { Column16, Column1, Column2, Column5, Column6, Column3, Column7, Column4 });
			dtgv_sanPham.Location = new Point(1, 65);
			dtgv_sanPham.Name = "dtgv_sanPham";
			dtgv_sanPham.ReadOnly = true;
			dtgv_sanPham.RowHeadersWidth = 51;
			dtgv_sanPham.RowTemplate.Height = 29;
			dtgv_sanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dtgv_sanPham.Size = new Size(976, 309);
			dtgv_sanPham.TabIndex = 0;
			dtgv_sanPham.CellClick += dtgv_sanPham_CellClick;
			// 
			// Column16
			// 
			Column16.HeaderText = "ID";
			Column16.MinimumWidth = 6;
			Column16.Name = "Column16";
			Column16.ReadOnly = true;
			// 
			// Column1
			// 
			Column1.HeaderText = "Mã sản phẩm";
			Column1.MinimumWidth = 6;
			Column1.Name = "Column1";
			Column1.ReadOnly = true;
			// 
			// Column2
			// 
			Column2.HeaderText = "Tên sản phẩm";
			Column2.MinimumWidth = 6;
			Column2.Name = "Column2";
			Column2.ReadOnly = true;
			// 
			// Column5
			// 
			Column5.HeaderText = "Màu sắc";
			Column5.MinimumWidth = 6;
			Column5.Name = "Column5";
			Column5.ReadOnly = true;
			// 
			// Column6
			// 
			Column6.HeaderText = "Size";
			Column6.MinimumWidth = 6;
			Column6.Name = "Column6";
			Column6.ReadOnly = true;
			// 
			// Column3
			// 
			Column3.HeaderText = "Đơn giá";
			Column3.MinimumWidth = 6;
			Column3.Name = "Column3";
			Column3.ReadOnly = true;
			// 
			// Column7
			// 
			Column7.HeaderText = "Nhà sản xuất";
			Column7.MinimumWidth = 6;
			Column7.Name = "Column7";
			Column7.ReadOnly = true;
			// 
			// Column4
			// 
			Column4.HeaderText = "Số lượng tồn";
			Column4.MinimumWidth = 6;
			Column4.Name = "Column4";
			Column4.ReadOnly = true;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(label10);
			groupBox2.Controls.Add(btn_themKH);
			groupBox2.Controls.Add(tbt_tenKh);
			groupBox2.Controls.Add(lbl_Diem);
			groupBox2.Controls.Add(label21);
			groupBox2.Controls.Add(lbl_tongTien);
			groupBox2.Controls.Add(label18);
			groupBox2.Controls.Add(btn_CapNhatHD);
			groupBox2.Controls.Add(btn_TaoHoaDon);
			groupBox2.Controls.Add(btn_xoaGioHang);
			groupBox2.Controls.Add(btn_xoaSP);
			groupBox2.Controls.Add(label3);
			groupBox2.Controls.Add(tbt_SDT);
			groupBox2.Controls.Add(label2);
			groupBox2.Controls.Add(dtgv_gioHang);
			groupBox2.Location = new Point(37, 425);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(1145, 359);
			groupBox2.TabIndex = 1;
			groupBox2.TabStop = false;
			groupBox2.Text = "Giỏ hàng";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			label10.Location = new Point(1075, 232);
			label10.Name = "label10";
			label10.Size = new Size(64, 31);
			label10.TabIndex = 18;
			label10.Text = "VNĐ";
			// 
			// btn_themKH
			// 
			btn_themKH.Image = Properties.Resources.icons8_add_new_32;
			btn_themKH.ImageAlign = ContentAlignment.MiddleRight;
			btn_themKH.Location = new Point(856, 304);
			btn_themKH.Name = "btn_themKH";
			btn_themKH.RightToLeft = RightToLeft.Yes;
			btn_themKH.Size = new Size(197, 49);
			btn_themKH.TabIndex = 17;
			btn_themKH.Text = "Thêm khách hàng";
			btn_themKH.UseVisualStyleBackColor = true;
			btn_themKH.Click += btn_themKH_Click;
			// 
			// tbt_tenKh
			// 
			tbt_tenKh.Location = new Point(926, 112);
			tbt_tenKh.Name = "tbt_tenKh";
			tbt_tenKh.Size = new Size(193, 27);
			tbt_tenKh.TabIndex = 16;
			// 
			// lbl_Diem
			// 
			lbl_Diem.AutoSize = true;
			lbl_Diem.Location = new Point(926, 179);
			lbl_Diem.Name = "lbl_Diem";
			lbl_Diem.Size = new Size(17, 20);
			lbl_Diem.TabIndex = 15;
			lbl_Diem.Text = "0";
			// 
			// label21
			// 
			label21.AutoSize = true;
			label21.Location = new Point(784, 179);
			label21.Name = "label21";
			label21.Size = new Size(96, 20);
			label21.TabIndex = 14;
			label21.Text = "Điểm tích lũy";
			// 
			// lbl_tongTien
			// 
			lbl_tongTien.AutoSize = true;
			lbl_tongTien.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			lbl_tongTien.Location = new Point(926, 227);
			lbl_tongTien.Name = "lbl_tongTien";
			lbl_tongTien.Size = new Size(57, 38);
			lbl_tongTien.TabIndex = 13;
			lbl_tongTien.Text = ".....";
			// 
			// label18
			// 
			label18.AutoSize = true;
			label18.Location = new Point(784, 248);
			label18.Name = "label18";
			label18.Size = new Size(72, 20);
			label18.TabIndex = 12;
			label18.Text = "Tổng tiền";
			// 
			// btn_CapNhatHD
			// 
			btn_CapNhatHD.Image = Properties.Resources.icons8_repeat_30;
			btn_CapNhatHD.ImageAlign = ContentAlignment.MiddleRight;
			btn_CapNhatHD.Location = new Point(566, 307);
			btn_CapNhatHD.Name = "btn_CapNhatHD";
			btn_CapNhatHD.RightToLeft = RightToLeft.Yes;
			btn_CapNhatHD.Size = new Size(139, 49);
			btn_CapNhatHD.TabIndex = 10;
			btn_CapNhatHD.Text = "Cập nhật";
			btn_CapNhatHD.UseVisualStyleBackColor = true;
			btn_CapNhatHD.Click += btn_CapNhatHD_Click;
			// 
			// btn_TaoHoaDon
			// 
			btn_TaoHoaDon.Image = Properties.Resources.icons8_add_new_32;
			btn_TaoHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
			btn_TaoHoaDon.Location = new Point(379, 309);
			btn_TaoHoaDon.Name = "btn_TaoHoaDon";
			btn_TaoHoaDon.Size = new Size(150, 49);
			btn_TaoHoaDon.TabIndex = 9;
			btn_TaoHoaDon.Text = "  Tạo hóa đơn";
			btn_TaoHoaDon.UseVisualStyleBackColor = true;
			btn_TaoHoaDon.Click += btn_TaoHoaDon_Click;
			// 
			// btn_xoaGioHang
			// 
			btn_xoaGioHang.Image = Properties.Resources.icons8_trash_32;
			btn_xoaGioHang.ImageAlign = ContentAlignment.MiddleLeft;
			btn_xoaGioHang.Location = new Point(199, 309);
			btn_xoaGioHang.Name = "btn_xoaGioHang";
			btn_xoaGioHang.Size = new Size(159, 49);
			btn_xoaGioHang.TabIndex = 8;
			btn_xoaGioHang.Text = "  Xóa giỏ hàng";
			btn_xoaGioHang.UseVisualStyleBackColor = true;
			btn_xoaGioHang.Click += btn_xoaGioHang_Click;
			// 
			// btn_xoaSP
			// 
			btn_xoaSP.Image = Properties.Resources.icons8_trash_32;
			btn_xoaSP.ImageAlign = ContentAlignment.MiddleLeft;
			btn_xoaSP.Location = new Point(1, 309);
			btn_xoaSP.Name = "btn_xoaSP";
			btn_xoaSP.Size = new Size(162, 49);
			btn_xoaSP.TabIndex = 7;
			btn_xoaSP.Text = "Xóa sản phẩm";
			btn_xoaSP.UseVisualStyleBackColor = true;
			btn_xoaSP.Click += btn_xoaSP_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(784, 115);
			label3.Name = "label3";
			label3.Size = new Size(111, 20);
			label3.TabIndex = 6;
			label3.Text = "Tên khách hàng";
			// 
			// tbt_SDT
			// 
			tbt_SDT.Location = new Point(926, 51);
			tbt_SDT.Name = "tbt_SDT";
			tbt_SDT.Size = new Size(193, 27);
			tbt_SDT.TabIndex = 4;
			tbt_SDT.TextChanged += tbt_SDT_TextChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(784, 53);
			label2.Name = "label2";
			label2.Size = new Size(115, 20);
			label2.TabIndex = 3;
			label2.Text = "SĐT khách hàng";
			// 
			// dtgv_gioHang
			// 
			dtgv_gioHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dtgv_gioHang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dtgv_gioHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dtgv_gioHang.Columns.AddRange(new DataGridViewColumn[] { Column8, Column9, Column10, Column11 });
			dtgv_gioHang.Location = new Point(-5, 40);
			dtgv_gioHang.Name = "dtgv_gioHang";
			dtgv_gioHang.RowHeadersWidth = 51;
			dtgv_gioHang.RowTemplate.Height = 29;
			dtgv_gioHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dtgv_gioHang.Size = new Size(750, 243);
			dtgv_gioHang.TabIndex = 1;
			dtgv_gioHang.CellClick += dtgv_gioHang_CellClick;
			dtgv_gioHang.CellContentClick += dtgv_gioHang_CellValueChanged;
			dtgv_gioHang.CellValueChanged += dtgv_gioHang_CellValueChanged;
			// 
			// Column8
			// 
			Column8.HeaderText = "Mã sản phẩm";
			Column8.MinimumWidth = 6;
			Column8.Name = "Column8";
			// 
			// Column9
			// 
			Column9.HeaderText = "Tên sản phẩm";
			Column9.MinimumWidth = 6;
			Column9.Name = "Column9";
			// 
			// Column10
			// 
			Column10.HeaderText = "Số lượng";
			Column10.MinimumWidth = 6;
			Column10.Name = "Column10";
			// 
			// Column11
			// 
			Column11.HeaderText = "Đơn giá";
			Column11.MinimumWidth = 6;
			Column11.Name = "Column11";
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(dtgv_HDcho);
			groupBox3.Location = new Point(1187, 425);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(344, 359);
			groupBox3.TabIndex = 2;
			groupBox3.TabStop = false;
			groupBox3.Text = "Hóa đơn chờ";
			// 
			// dtgv_HDcho
			// 
			dtgv_HDcho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dtgv_HDcho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dtgv_HDcho.Columns.AddRange(new DataGridViewColumn[] { Column14, Column15 });
			dtgv_HDcho.Location = new Point(6, 27);
			dtgv_HDcho.Name = "dtgv_HDcho";
			dtgv_HDcho.RowHeadersWidth = 51;
			dtgv_HDcho.RowTemplate.Height = 29;
			dtgv_HDcho.Size = new Size(338, 331);
			dtgv_HDcho.TabIndex = 0;
			dtgv_HDcho.CellClick += dtgv_HDcho_CellClick;
			// 
			// Column14
			// 
			Column14.HeaderText = "Mã hóa đơn";
			Column14.MinimumWidth = 6;
			Column14.Name = "Column14";
			// 
			// Column15
			// 
			Column15.HeaderText = "Tên khách hàng";
			Column15.MinimumWidth = 6;
			Column15.Name = "Column15";
			// 
			// groupBox4
			// 
			groupBox4.Controls.Add(lbl_giamGia);
			groupBox4.Controls.Add(tbt_ghiChu);
			groupBox4.Controls.Add(label13);
			groupBox4.Controls.Add(label12);
			groupBox4.Controls.Add(tbt_giamGia);
			groupBox4.Controls.Add(lbl_Tong);
			groupBox4.Controls.Add(lbl_TienThua);
			groupBox4.Controls.Add(tbt_tienKhachDua);
			groupBox4.Controls.Add(tbt_maHD);
			groupBox4.Controls.Add(btn_thanhToan);
			groupBox4.Controls.Add(label9);
			groupBox4.Controls.Add(label8);
			groupBox4.Controls.Add(label7);
			groupBox4.Controls.Add(label6);
			groupBox4.Controls.Add(label4);
			groupBox4.Location = new Point(1037, 24);
			groupBox4.Name = "groupBox4";
			groupBox4.Size = new Size(494, 377);
			groupBox4.TabIndex = 3;
			groupBox4.TabStop = false;
			groupBox4.Text = "Thanh toán";
			// 
			// lbl_giamGia
			// 
			lbl_giamGia.AutoSize = true;
			lbl_giamGia.Location = new Point(373, 92);
			lbl_giamGia.Name = "lbl_giamGia";
			lbl_giamGia.Size = new Size(21, 20);
			lbl_giamGia.TabIndex = 18;
			lbl_giamGia.Text = "....";
			lbl_giamGia.Visible = false;
			// 
			// tbt_ghiChu
			// 
			tbt_ghiChu.Location = new Point(142, 215);
			tbt_ghiChu.Name = "tbt_ghiChu";
			tbt_ghiChu.Size = new Size(183, 27);
			tbt_ghiChu.TabIndex = 16;
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Location = new Point(278, 185);
			label13.Name = "label13";
			label13.Size = new Size(40, 20);
			label13.TabIndex = 15;
			label13.Text = "VNĐ";
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new Point(280, 141);
			label12.Name = "label12";
			label12.Size = new Size(40, 20);
			label12.TabIndex = 14;
			label12.Text = "VNĐ";
			// 
			// tbt_giamGia
			// 
			tbt_giamGia.Location = new Point(11, 324);
			tbt_giamGia.Name = "tbt_giamGia";
			tbt_giamGia.ReadOnly = true;
			tbt_giamGia.Size = new Size(183, 27);
			tbt_giamGia.TabIndex = 8;
			tbt_giamGia.Visible = false;
			tbt_giamGia.TextChanged += tbt_giamGia_TextChanged;
			// 
			// lbl_Tong
			// 
			lbl_Tong.AutoSize = true;
			lbl_Tong.Location = new Point(142, 185);
			lbl_Tong.Name = "lbl_Tong";
			lbl_Tong.Size = new Size(21, 20);
			lbl_Tong.TabIndex = 13;
			lbl_Tong.Text = "....";
			// 
			// lbl_TienThua
			// 
			lbl_TienThua.AutoSize = true;
			lbl_TienThua.Location = new Point(142, 141);
			lbl_TienThua.Name = "lbl_TienThua";
			lbl_TienThua.Size = new Size(21, 20);
			lbl_TienThua.TabIndex = 12;
			lbl_TienThua.Text = "....";
			// 
			// tbt_tienKhachDua
			// 
			tbt_tienKhachDua.Location = new Point(141, 92);
			tbt_tienKhachDua.Name = "tbt_tienKhachDua";
			tbt_tienKhachDua.Size = new Size(183, 27);
			tbt_tienKhachDua.TabIndex = 9;
			tbt_tienKhachDua.TextChanged += tbt_tienKhachDua_TextChanged;
			// 
			// tbt_maHD
			// 
			tbt_maHD.Location = new Point(141, 40);
			tbt_maHD.Name = "tbt_maHD";
			tbt_maHD.ReadOnly = true;
			tbt_maHD.Size = new Size(183, 27);
			tbt_maHD.TabIndex = 7;
			tbt_maHD.TextChanged += tbt_maHD_TextChanged;
			// 
			// btn_thanhToan
			// 
			btn_thanhToan.Image = Properties.Resources.icons8_get_cash_30;
			btn_thanhToan.ImageAlign = ContentAlignment.MiddleLeft;
			btn_thanhToan.Location = new Point(111, 263);
			btn_thanhToan.Name = "btn_thanhToan";
			btn_thanhToan.Size = new Size(183, 56);
			btn_thanhToan.TabIndex = 6;
			btn_thanhToan.Text = "Thanh toán";
			btn_thanhToan.UseVisualStyleBackColor = true;
			btn_thanhToan.Click += btn_thanhToan_Click;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(11, 223);
			label9.Name = "label9";
			label9.Size = new Size(58, 20);
			label9.TabIndex = 5;
			label9.Text = "Ghi chú";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(9, 185);
			label8.Name = "label8";
			label8.Size = new Size(72, 20);
			label8.TabIndex = 4;
			label8.Text = "Tổng tiền";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(9, 141);
			label7.Name = "label7";
			label7.Size = new Size(71, 20);
			label7.TabIndex = 3;
			label7.Text = "Tiền thừa";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(9, 92);
			label6.Name = "label6";
			label6.Size = new Size(109, 20);
			label6.TabIndex = 2;
			label6.Text = "Tiền khách đưa";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(9, 43);
			label4.Name = "label4";
			label4.Size = new Size(89, 20);
			label4.TabIndex = 0;
			label4.Text = "Mã hóa đơn";
			// 
			// ppdhd
			// 
			ppdhd.AutoScrollMargin = new Size(0, 0);
			ppdhd.AutoScrollMinSize = new Size(0, 0);
			ppdhd.ClientSize = new Size(400, 300);
			ppdhd.Enabled = true;
			ppdhd.Icon = (Icon)resources.GetObject("ppdhd.Icon");
			ppdhd.Name = "ppdhd";
			ppdhd.Visible = false;
			// 
			// pdhd
			// 
			pdhd.PrintPage += pdhd_PrintPage;
			// 
			// FrmGioHang
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1566, 749);
			Controls.Add(groupBox4);
			Controls.Add(groupBox3);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Name = "FrmGioHang";
			Text = "FrmGioHang";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dtgv_sanPham).EndInit();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dtgv_gioHang).EndInit();
			groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dtgv_HDcho).EndInit();
			groupBox4.ResumeLayout(false);
			groupBox4.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox1;
		private Label label1;
		private TextBox tbt_timKiem;
		private DataGridView dtgv_sanPham;
		private GroupBox groupBox2;
		private Button btn_CapNhatHD;
		private Button btn_TaoHoaDon;
		private Button btn_xoaGioHang;
		private Button btn_xoaSP;
		private Label label3;
		private TextBox tbt_SDT;
		private Label label2;
		private DataGridView dtgv_gioHang;
		private GroupBox groupBox3;
		private GroupBox groupBox4;
		private TextBox tbt_ghiChu;
		private Label label13;
		private Label label12;
		private Label lbl_Tong;
		private Label lbl_TienThua;
		private TextBox tbt_tienKhachDua;
		private TextBox tbt_giamGia;
		private TextBox tbt_maHD;
		private Button btn_thanhToan;
		private Label label9;
		private Label label8;
		private Label label7;
		private Label label6;
		private Label label4;
		private DataGridView dtgv_HDcho;
		private ComboBox cbb_NSX;
		private Label label16;
		private ComboBox cbb_size;
		private Label label15;
		private ComboBox cbb_Mau;
		private Label label14;
		private Label lbl_Diem;
		private Label label21;
		private Label lbl_tongTien;
		private Label label18;
		private DataGridViewTextBoxColumn Column16;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column5;
		private DataGridViewTextBoxColumn Column6;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column7;
		private DataGridViewTextBoxColumn Column4;
		private DataGridViewTextBoxColumn Column8;
		private DataGridViewTextBoxColumn Column9;
		private DataGridViewTextBoxColumn Column10;
		private DataGridViewTextBoxColumn Column11;
		private Label lbl_giamGia;
		private PrintPreviewDialog ppdhd;
		private System.Drawing.Printing.PrintDocument pdhd;
		private TextBox tbt_tenKh;
		private Button btn_themKH;
		private Label label10;
		private DataGridViewTextBoxColumn Column14;
		private DataGridViewTextBoxColumn Column15;
	}
}