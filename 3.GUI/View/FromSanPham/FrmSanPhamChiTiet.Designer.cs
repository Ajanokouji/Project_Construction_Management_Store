namespace _3.GUI.View.FromSanPham
{
	partial class FrmSanPhamChiTiet
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
			groupBox3 = new GroupBox();
			dtgv_sanPham = new DataGridView();
			Column10 = new DataGridViewTextBoxColumn();
			Column1 = new DataGridViewTextBoxColumn();
			Column2 = new DataGridViewTextBoxColumn();
			Column3 = new DataGridViewTextBoxColumn();
			Column4 = new DataGridViewTextBoxColumn();
			Column5 = new DataGridViewTextBoxColumn();
			Column8 = new DataGridViewTextBoxColumn();
			Column11 = new DataGridViewTextBoxColumn();
			Column9 = new DataGridViewTextBoxColumn();
			groupBox1 = new GroupBox();
			cbb_loaiHang = new ComboBox();
			label7 = new Label();
			groupBox2 = new GroupBox();
			btn_xuat = new Button();
			btn_capNhat = new Button();
			btn_them = new Button();
			tbt_maSP = new TextBox();
			label1 = new Label();
			cb_NSX = new ComboBox();
			label10 = new Label();
			rb_het = new RadioButton();
			rb_con = new RadioButton();
			tbt_soLuong = new TextBox();
			tbt_giaBan = new TextBox();
			tbt_giaNhap = new TextBox();
			tbt_ten = new TextBox();
			label6 = new Label();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			ptb_linkAnh = new PictureBox();
			groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dtgv_sanPham).BeginInit();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)ptb_linkAnh).BeginInit();
			SuspendLayout();
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(dtgv_sanPham);
			groupBox3.Location = new Point(27, 379);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(1321, 323);
			groupBox3.TabIndex = 5;
			groupBox3.TabStop = false;
			groupBox3.Text = "Danh sách sản phẩm";
			// 
			// dtgv_sanPham
			// 
			dtgv_sanPham.AllowUserToDeleteRows = false;
			dtgv_sanPham.AllowUserToResizeColumns = false;
			dtgv_sanPham.AllowUserToResizeRows = false;
			dtgv_sanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dtgv_sanPham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dtgv_sanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dtgv_sanPham.Columns.AddRange(new DataGridViewColumn[] { Column10, Column1, Column2, Column3, Column4, Column5, Column8, Column11, Column9 });
			dtgv_sanPham.Location = new Point(0, 51);
			dtgv_sanPham.Name = "dtgv_sanPham";
			dtgv_sanPham.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
			dtgv_sanPham.RowHeadersWidth = 51;
			dtgv_sanPham.RowTemplate.Height = 29;
			dtgv_sanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dtgv_sanPham.Size = new Size(1321, 267);
			dtgv_sanPham.TabIndex = 0;
			dtgv_sanPham.CellClick += dtgv_sanPham_CellClick_1;
			// 
			// Column10
			// 
			Column10.HeaderText = "ID";
			Column10.MinimumWidth = 6;
			Column10.Name = "Column10";
			// 
			// Column1
			// 
			Column1.HeaderText = "Mã sản phẩm";
			Column1.MinimumWidth = 6;
			Column1.Name = "Column1";
			// 
			// Column2
			// 
			Column2.HeaderText = "Tên sản phẩm";
			Column2.MinimumWidth = 6;
			Column2.Name = "Column2";
			// 
			// Column3
			// 
			Column3.HeaderText = "Giá nhập";
			Column3.MinimumWidth = 6;
			Column3.Name = "Column3";
			// 
			// Column4
			// 
			Column4.HeaderText = "Giá bán";
			Column4.MinimumWidth = 6;
			Column4.Name = "Column4";
			// 
			// Column5
			// 
			Column5.HeaderText = "Số lượng";
			Column5.MinimumWidth = 6;
			Column5.Name = "Column5";
			// 
			// Column8
			// 
			Column8.HeaderText = "Nhà sản xuất";
			Column8.MinimumWidth = 6;
			Column8.Name = "Column8";
			// 
			// Column11
			// 
			Column11.HeaderText = "Loại hàng";
			Column11.MinimumWidth = 6;
			Column11.Name = "Column11";
			// 
			// Column9
			// 
			Column9.HeaderText = "Trạng thái";
			Column9.MinimumWidth = 6;
			Column9.Name = "Column9";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(cbb_loaiHang);
			groupBox1.Controls.Add(label7);
			groupBox1.Controls.Add(groupBox2);
			groupBox1.Controls.Add(tbt_maSP);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(cb_NSX);
			groupBox1.Controls.Add(label10);
			groupBox1.Controls.Add(rb_het);
			groupBox1.Controls.Add(rb_con);
			groupBox1.Controls.Add(tbt_soLuong);
			groupBox1.Controls.Add(tbt_giaBan);
			groupBox1.Controls.Add(tbt_giaNhap);
			groupBox1.Controls.Add(tbt_ten);
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Location = new Point(21, 37);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(994, 335);
			groupBox1.TabIndex = 3;
			groupBox1.TabStop = false;
			groupBox1.Text = "Thông tin sản phẩm";
			// 
			// cbb_loaiHang
			// 
			cbb_loaiHang.FormattingEnabled = true;
			cbb_loaiHang.Location = new Point(538, 148);
			cbb_loaiHang.Name = "cbb_loaiHang";
			cbb_loaiHang.Size = new Size(197, 28);
			cbb_loaiHang.TabIndex = 26;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(377, 150);
			label7.Name = "label7";
			label7.Size = new Size(74, 20);
			label7.TabIndex = 25;
			label7.Text = "Loại hàng";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(btn_xuat);
			groupBox2.Controls.Add(btn_capNhat);
			groupBox2.Controls.Add(btn_them);
			groupBox2.Location = new Point(774, 0);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(213, 336);
			groupBox2.TabIndex = 4;
			groupBox2.TabStop = false;
			groupBox2.Text = "Chức năng";
			// 
			// btn_xuat
			// 
			btn_xuat.Image = Properties.Resources.icons8_microsoft_excel_481;
			btn_xuat.ImageAlign = ContentAlignment.MiddleLeft;
			btn_xuat.Location = new Point(9, 179);
			btn_xuat.Name = "btn_xuat";
			btn_xuat.Size = new Size(198, 49);
			btn_xuat.TabIndex = 4;
			btn_xuat.Text = "Xuất Excel";
			btn_xuat.UseVisualStyleBackColor = true;
			btn_xuat.Click += btn_xuat_Click_1;
			// 
			// btn_capNhat
			// 
			btn_capNhat.Image = Properties.Resources.icons8_edit_32;
			btn_capNhat.ImageAlign = ContentAlignment.MiddleLeft;
			btn_capNhat.Location = new Point(9, 113);
			btn_capNhat.Name = "btn_capNhat";
			btn_capNhat.Size = new Size(198, 53);
			btn_capNhat.TabIndex = 1;
			btn_capNhat.Text = "Cập nhật";
			btn_capNhat.UseVisualStyleBackColor = true;
			btn_capNhat.Click += btn_capNhat_Click_1;
			// 
			// btn_them
			// 
			btn_them.Image = Properties.Resources.icons8_add_new_32;
			btn_them.ImageAlign = ContentAlignment.MiddleLeft;
			btn_them.Location = new Point(9, 43);
			btn_them.Name = "btn_them";
			btn_them.Size = new Size(198, 53);
			btn_them.TabIndex = 0;
			btn_them.Text = "Thêm";
			btn_them.UseVisualStyleBackColor = true;
			btn_them.Click += btn_them_Click_1;
			// 
			// tbt_maSP
			// 
			tbt_maSP.Location = new Point(146, 41);
			tbt_maSP.Name = "tbt_maSP";
			tbt_maSP.Size = new Size(197, 27);
			tbt_maSP.TabIndex = 24;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(16, 44);
			label1.Name = "label1";
			label1.Size = new Size(98, 20);
			label1.TabIndex = 23;
			label1.Text = "Mã sản phẩm";
			// 
			// cb_NSX
			// 
			cb_NSX.FormattingEnabled = true;
			cb_NSX.Location = new Point(538, 92);
			cb_NSX.Name = "cb_NSX";
			cb_NSX.Size = new Size(197, 28);
			cb_NSX.TabIndex = 20;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(377, 94);
			label10.Name = "label10";
			label10.Size = new Size(94, 20);
			label10.TabIndex = 16;
			label10.Text = "Nhà sản xuất";
			// 
			// rb_het
			// 
			rb_het.AutoSize = true;
			rb_het.Location = new Point(644, 204);
			rb_het.Name = "rb_het";
			rb_het.Size = new Size(91, 24);
			rb_het.TabIndex = 12;
			rb_het.TabStop = true;
			rb_het.Text = "Hết hàng";
			rb_het.UseVisualStyleBackColor = true;
			// 
			// rb_con
			// 
			rb_con.AutoSize = true;
			rb_con.Location = new Point(538, 204);
			rb_con.Name = "rb_con";
			rb_con.Size = new Size(93, 24);
			rb_con.TabIndex = 11;
			rb_con.TabStop = true;
			rb_con.Text = "Còn hàng";
			rb_con.UseVisualStyleBackColor = true;
			// 
			// tbt_soLuong
			// 
			tbt_soLuong.Location = new Point(538, 41);
			tbt_soLuong.Name = "tbt_soLuong";
			tbt_soLuong.Size = new Size(197, 27);
			tbt_soLuong.TabIndex = 10;
			// 
			// tbt_giaBan
			// 
			tbt_giaBan.Location = new Point(146, 196);
			tbt_giaBan.Name = "tbt_giaBan";
			tbt_giaBan.Size = new Size(197, 27);
			tbt_giaBan.TabIndex = 9;
			// 
			// tbt_giaNhap
			// 
			tbt_giaNhap.Location = new Point(146, 147);
			tbt_giaNhap.Name = "tbt_giaNhap";
			tbt_giaNhap.Size = new Size(197, 27);
			tbt_giaNhap.TabIndex = 8;
			// 
			// tbt_ten
			// 
			tbt_ten.Location = new Point(146, 93);
			tbt_ten.Name = "tbt_ten";
			tbt_ten.Size = new Size(197, 27);
			tbt_ten.TabIndex = 7;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(377, 208);
			label6.Name = "label6";
			label6.Size = new Size(75, 20);
			label6.TabIndex = 5;
			label6.Text = "Trạng thái";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(377, 41);
			label5.Name = "label5";
			label5.Size = new Size(140, 20);
			label5.TabIndex = 4;
			label5.Text = "Số lượng trong kho:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(16, 199);
			label4.Name = "label4";
			label4.Size = new Size(60, 20);
			label4.TabIndex = 3;
			label4.Text = "Giá bán";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(16, 149);
			label3.Name = "label3";
			label3.Size = new Size(68, 20);
			label3.TabIndex = 2;
			label3.Text = "Giá nhập";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(16, 96);
			label2.Name = "label2";
			label2.Size = new Size(100, 20);
			label2.TabIndex = 1;
			label2.Text = "Tên sản phẩm";
			// 
			// ptb_linkAnh
			// 
			ptb_linkAnh.BackColor = SystemColors.ActiveCaption;
			ptb_linkAnh.BackgroundImageLayout = ImageLayout.Zoom;
			ptb_linkAnh.Image = Properties.Resources.quy_trinh_giam_sat_thi_cong_xay_dung_can_luu_y_nhung_dieu_naoa;
			ptb_linkAnh.Location = new Point(1021, 37);
			ptb_linkAnh.Name = "ptb_linkAnh";
			ptb_linkAnh.Size = new Size(335, 335);
			ptb_linkAnh.SizeMode = PictureBoxSizeMode.StretchImage;
			ptb_linkAnh.TabIndex = 21;
			ptb_linkAnh.TabStop = false;
			ptb_linkAnh.Click += ptb_linkAnh_Click_1;
			// 
			// FrmSanPhamChiTiet
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1368, 736);
			Controls.Add(groupBox3);
			Controls.Add(groupBox1);
			Controls.Add(ptb_linkAnh);
			Name = "FrmSanPhamChiTiet";
			Text = "FrmSanPhamChiTiet";
			groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dtgv_sanPham).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)ptb_linkAnh).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox3;
		private DataGridView dtgv_sanPham;
		private GroupBox groupBox1;
		private ComboBox cbb_loaiHang;
		private Label label7;
		private TextBox tbt_maSP;
		private Label label1;
		private PictureBox ptb_linkAnh;
		private ComboBox cb_NSX;
		private Label label10;
		private RadioButton rb_het;
		private RadioButton rb_con;
		private TextBox tbt_soLuong;
		private TextBox tbt_giaBan;
		private TextBox tbt_giaNhap;
		private TextBox tbt_ten;
		private Label label6;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private GroupBox groupBox2;
		private Button btn_xuat;
		private Button btn_capNhat;
		private Button btn_them;
		private DataGridViewTextBoxColumn Column10;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column4;
		private DataGridViewTextBoxColumn Column5;
		private DataGridViewTextBoxColumn Column8;
		private DataGridViewTextBoxColumn Column11;
		private DataGridViewTextBoxColumn Column9;
	}
}