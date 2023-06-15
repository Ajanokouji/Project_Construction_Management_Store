namespace _3.GUI.View.BanHang
{
	partial class FrmHoaDonn
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHoaDonn));
			groupBox1 = new GroupBox();
			btn_timk = new Button();
			textBox1 = new TextBox();
			dtgv_hoaDon = new DataGridView();
			Column1 = new DataGridViewTextBoxColumn();
			Column2 = new DataGridViewTextBoxColumn();
			Column3 = new DataGridViewTextBoxColumn();
			Column4 = new DataGridViewTextBoxColumn();
			Column5 = new DataGridViewTextBoxColumn();
			Column6 = new DataGridViewTextBoxColumn();
			Column7 = new DataGridViewTextBoxColumn();
			groupBox2 = new GroupBox();
			dtgv_CTHD = new DataGridView();
			Column12 = new DataGridViewTextBoxColumn();
			Column8 = new DataGridViewTextBoxColumn();
			Column9 = new DataGridViewTextBoxColumn();
			Column10 = new DataGridViewTextBoxColumn();
			Column11 = new DataGridViewTextBoxColumn();
			groupBox3 = new GroupBox();
			btn_xoa = new Button();
			button1 = new Button();
			groupBox4 = new GroupBox();
			tbt_ghiChu = new TextBox();
			dtp_ngay = new DateTimePicker();
			tbt_tongTien = new TextBox();
			tbt_SDT = new TextBox();
			tbt_maNV = new TextBox();
			tbt_MaHD = new TextBox();
			rb_ChuaThanhToan = new RadioButton();
			rb_daThanhToan = new RadioButton();
			label9 = new Label();
			label8 = new Label();
			label7 = new Label();
			label6 = new Label();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dtgv_hoaDon).BeginInit();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dtgv_CTHD).BeginInit();
			groupBox3.SuspendLayout();
			groupBox4.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(btn_timk);
			groupBox1.Controls.Add(textBox1);
			groupBox1.Controls.Add(dtgv_hoaDon);
			groupBox1.Location = new Point(28, 228);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(1415, 292);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Hóa đơn";
			// 
			// btn_timk
			// 
			btn_timk.BackColor = SystemColors.ActiveCaption;
			btn_timk.Image = (Image)resources.GetObject("btn_timk.Image");
			btn_timk.ImageAlign = ContentAlignment.MiddleLeft;
			btn_timk.Location = new Point(1200, 22);
			btn_timk.Margin = new Padding(3, 4, 3, 4);
			btn_timk.Name = "btn_timk";
			btn_timk.Size = new Size(97, 31);
			btn_timk.TabIndex = 18;
			btn_timk.Text = "Tìm kiếm";
			btn_timk.TextAlign = ContentAlignment.MiddleRight;
			btn_timk.UseVisualStyleBackColor = false;
			btn_timk.Click += btn_timk_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(899, 23);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(283, 27);
			textBox1.TabIndex = 2;
			textBox1.Text = "Tìm kiếm";
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// dtgv_hoaDon
			// 
			dtgv_hoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dtgv_hoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dtgv_hoaDon.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
			dtgv_hoaDon.Location = new Point(1, 56);
			dtgv_hoaDon.Name = "dtgv_hoaDon";
			dtgv_hoaDon.RowHeadersWidth = 51;
			dtgv_hoaDon.RowTemplate.Height = 29;
			dtgv_hoaDon.Size = new Size(1408, 236);
			dtgv_hoaDon.TabIndex = 0;
			dtgv_hoaDon.CellClick += dtgv_hoaDon_CellClick;
			// 
			// Column1
			// 
			Column1.HeaderText = "Mã hóa đơn";
			Column1.MinimumWidth = 6;
			Column1.Name = "Column1";
			// 
			// Column2
			// 
			Column2.HeaderText = "Mã nhân viên";
			Column2.MinimumWidth = 6;
			Column2.Name = "Column2";
			// 
			// Column3
			// 
			Column3.HeaderText = "SĐT - Khách hàng";
			Column3.MinimumWidth = 6;
			Column3.Name = "Column3";
			// 
			// Column4
			// 
			Column4.HeaderText = "Tổng tiền";
			Column4.MinimumWidth = 6;
			Column4.Name = "Column4";
			// 
			// Column5
			// 
			Column5.HeaderText = "Ngày bán";
			Column5.MinimumWidth = 6;
			Column5.Name = "Column5";
			// 
			// Column6
			// 
			Column6.HeaderText = "Ghi chú";
			Column6.MinimumWidth = 6;
			Column6.Name = "Column6";
			// 
			// Column7
			// 
			Column7.HeaderText = "Trạng thái";
			Column7.MinimumWidth = 6;
			Column7.Name = "Column7";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(dtgv_CTHD);
			groupBox2.Location = new Point(29, 631);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(1415, 192);
			groupBox2.TabIndex = 1;
			groupBox2.TabStop = false;
			groupBox2.Text = "Chi tiết hóa đơn";
			// 
			// dtgv_CTHD
			// 
			dtgv_CTHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dtgv_CTHD.Columns.AddRange(new DataGridViewColumn[] { Column12, Column8, Column9, Column10, Column11 });
			dtgv_CTHD.Location = new Point(0, 23);
			dtgv_CTHD.Name = "dtgv_CTHD";
			dtgv_CTHD.RowHeadersWidth = 51;
			dtgv_CTHD.RowTemplate.Height = 29;
			dtgv_CTHD.Size = new Size(1409, 165);
			dtgv_CTHD.TabIndex = 0;
			// 
			// Column12
			// 
			Column12.HeaderText = "Mã hóa đơn";
			Column12.MinimumWidth = 6;
			Column12.Name = "Column12";
			Column12.Width = 125;
			// 
			// Column8
			// 
			Column8.HeaderText = "Mã sản phẩm";
			Column8.MinimumWidth = 6;
			Column8.Name = "Column8";
			Column8.Width = 150;
			// 
			// Column9
			// 
			Column9.HeaderText = "Tên sản phẩm";
			Column9.MinimumWidth = 6;
			Column9.Name = "Column9";
			Column9.Width = 150;
			// 
			// Column10
			// 
			Column10.HeaderText = "Số lượng";
			Column10.MinimumWidth = 6;
			Column10.Name = "Column10";
			Column10.Width = 125;
			// 
			// Column11
			// 
			Column11.HeaderText = "Đơn giá";
			Column11.MinimumWidth = 6;
			Column11.Name = "Column11";
			Column11.Width = 125;
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(btn_xoa);
			groupBox3.Controls.Add(button1);
			groupBox3.Location = new Point(1193, 12);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(250, 210);
			groupBox3.TabIndex = 2;
			groupBox3.TabStop = false;
			groupBox3.Text = "Chức năng";
			// 
			// btn_xoa
			// 
			btn_xoa.Location = new Point(27, 106);
			btn_xoa.Name = "btn_xoa";
			btn_xoa.Size = new Size(202, 45);
			btn_xoa.TabIndex = 3;
			btn_xoa.Text = "Xóa";
			btn_xoa.UseVisualStyleBackColor = true;
			btn_xoa.Click += btn_xoa_Click;
			// 
			// button1
			// 
			button1.Location = new Point(27, 55);
			button1.Name = "button1";
			button1.Size = new Size(202, 45);
			button1.TabIndex = 0;
			button1.Text = "Cập nhật";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// groupBox4
			// 
			groupBox4.Controls.Add(tbt_ghiChu);
			groupBox4.Controls.Add(dtp_ngay);
			groupBox4.Controls.Add(tbt_tongTien);
			groupBox4.Controls.Add(tbt_SDT);
			groupBox4.Controls.Add(tbt_maNV);
			groupBox4.Controls.Add(tbt_MaHD);
			groupBox4.Controls.Add(rb_ChuaThanhToan);
			groupBox4.Controls.Add(rb_daThanhToan);
			groupBox4.Controls.Add(label9);
			groupBox4.Controls.Add(label8);
			groupBox4.Controls.Add(label7);
			groupBox4.Controls.Add(label6);
			groupBox4.Controls.Add(label5);
			groupBox4.Controls.Add(label4);
			groupBox4.Controls.Add(label3);
			groupBox4.Controls.Add(label2);
			groupBox4.Location = new Point(28, 12);
			groupBox4.Name = "groupBox4";
			groupBox4.Size = new Size(1040, 210);
			groupBox4.TabIndex = 3;
			groupBox4.TabStop = false;
			groupBox4.Text = "Danh mục hóa đơn";
			// 
			// tbt_ghiChu
			// 
			tbt_ghiChu.Enabled = false;
			tbt_ghiChu.Location = new Point(649, 121);
			tbt_ghiChu.Name = "tbt_ghiChu";
			tbt_ghiChu.Size = new Size(194, 27);
			tbt_ghiChu.TabIndex = 21;
			// 
			// dtp_ngay
			// 
			dtp_ngay.CustomFormat = "dd/MM/yyyy";
			dtp_ngay.Enabled = false;
			dtp_ngay.Format = DateTimePickerFormat.Custom;
			dtp_ngay.Location = new Point(649, 79);
			dtp_ngay.Name = "dtp_ngay";
			dtp_ngay.Size = new Size(194, 27);
			dtp_ngay.TabIndex = 20;
			// 
			// tbt_tongTien
			// 
			tbt_tongTien.Enabled = false;
			tbt_tongTien.Location = new Point(649, 33);
			tbt_tongTien.Name = "tbt_tongTien";
			tbt_tongTien.Size = new Size(194, 27);
			tbt_tongTien.TabIndex = 19;
			// 
			// tbt_SDT
			// 
			tbt_SDT.Enabled = false;
			tbt_SDT.Location = new Point(195, 127);
			tbt_SDT.Name = "tbt_SDT";
			tbt_SDT.Size = new Size(194, 27);
			tbt_SDT.TabIndex = 18;
			// 
			// tbt_maNV
			// 
			tbt_maNV.Enabled = false;
			tbt_maNV.Location = new Point(195, 80);
			tbt_maNV.Name = "tbt_maNV";
			tbt_maNV.Size = new Size(194, 27);
			tbt_maNV.TabIndex = 17;
			// 
			// tbt_MaHD
			// 
			tbt_MaHD.Enabled = false;
			tbt_MaHD.Location = new Point(195, 33);
			tbt_MaHD.Name = "tbt_MaHD";
			tbt_MaHD.Size = new Size(194, 27);
			tbt_MaHD.TabIndex = 16;
			// 
			// rb_ChuaThanhToan
			// 
			rb_ChuaThanhToan.AutoSize = true;
			rb_ChuaThanhToan.Location = new Point(803, 165);
			rb_ChuaThanhToan.Name = "rb_ChuaThanhToan";
			rb_ChuaThanhToan.Size = new Size(139, 24);
			rb_ChuaThanhToan.TabIndex = 15;
			rb_ChuaThanhToan.TabStop = true;
			rb_ChuaThanhToan.Text = "Chưa thanh toán";
			rb_ChuaThanhToan.UseVisualStyleBackColor = true;
			// 
			// rb_daThanhToan
			// 
			rb_daThanhToan.AutoSize = true;
			rb_daThanhToan.Location = new Point(663, 167);
			rb_daThanhToan.Name = "rb_daThanhToan";
			rb_daThanhToan.Size = new Size(124, 24);
			rb_daThanhToan.TabIndex = 14;
			rb_daThanhToan.TabStop = true;
			rb_daThanhToan.Text = "Đã thanh toán";
			rb_daThanhToan.UseVisualStyleBackColor = true;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(858, 40);
			label9.Name = "label9";
			label9.Size = new Size(40, 20);
			label9.TabIndex = 13;
			label9.Text = "VNĐ";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(545, 168);
			label8.Name = "label8";
			label8.Size = new Size(75, 20);
			label8.TabIndex = 6;
			label8.Text = "Trạng thái";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(547, 124);
			label7.Name = "label7";
			label7.Size = new Size(58, 20);
			label7.TabIndex = 5;
			label7.Text = "Ghi chú";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(547, 77);
			label6.Name = "label6";
			label6.Size = new Size(73, 20);
			label6.TabIndex = 4;
			label6.Text = "Ngày bán";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(547, 33);
			label5.Name = "label5";
			label5.Size = new Size(72, 20);
			label5.TabIndex = 3;
			label5.Text = "Tổng tiền";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(20, 127);
			label4.Name = "label4";
			label4.Size = new Size(125, 20);
			label4.TabIndex = 2;
			label4.Text = "SĐT - khách hàng";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(20, 80);
			label3.Name = "label3";
			label3.Size = new Size(97, 20);
			label3.TabIndex = 1;
			label3.Text = "Mã nhân viên";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(20, 36);
			label2.Name = "label2";
			label2.Size = new Size(89, 20);
			label2.TabIndex = 0;
			label2.Text = "Mã hóa đơn";
			// 
			// FrmHoaDonn
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1473, 848);
			Controls.Add(groupBox4);
			Controls.Add(groupBox3);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Name = "FrmHoaDonn";
			Text = "FrmHoaDonn";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dtgv_hoaDon).EndInit();
			groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dtgv_CTHD).EndInit();
			groupBox3.ResumeLayout(false);
			groupBox4.ResumeLayout(false);
			groupBox4.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private GroupBox groupBox3;
		private TextBox textBox1;
		private DataGridView dtgv_hoaDon;
		private DataGridView dtgv_CTHD;
		private Button button1;
		private GroupBox groupBox4;
		private Label label4;
		private Label label3;
		private Label label2;
		private RadioButton rb_ChuaThanhToan;
		private RadioButton rb_daThanhToan;
		private Label label9;
		private Label label8;
		private Label label7;
		private Label label6;
		private Label label5;
		private DataGridViewTextBoxColumn Column12;
		private DataGridViewTextBoxColumn Column8;
		private DataGridViewTextBoxColumn Column9;
		private DataGridViewTextBoxColumn Column10;
		private DataGridViewTextBoxColumn Column11;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column4;
		private DataGridViewTextBoxColumn Column5;
		private DataGridViewTextBoxColumn Column6;
		private DataGridViewTextBoxColumn Column7;
		private Button btn_timk;
		private Button btn_xoa;
		private TextBox tbt_ghiChu;
		private DateTimePicker dtp_ngay;
		private TextBox tbt_tongTien;
		private TextBox tbt_SDT;
		private TextBox tbt_maNV;
		private TextBox tbt_MaHD;
	}
}