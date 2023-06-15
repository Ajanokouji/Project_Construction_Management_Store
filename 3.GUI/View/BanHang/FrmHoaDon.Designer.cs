namespace _3.GUI.View.BanHang
{
	partial class FrmHoaDon
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHoaDon));
			groupBox1 = new GroupBox();
			btn_timk = new Button();
			dtg_hoadon = new DataGridView();
			Column1 = new DataGridViewTextBoxColumn();
			Column2 = new DataGridViewTextBoxColumn();
			Column3 = new DataGridViewTextBoxColumn();
			Column4 = new DataGridViewTextBoxColumn();
			Column5 = new DataGridViewTextBoxColumn();
			Column6 = new DataGridViewTextBoxColumn();
			Column7 = new DataGridViewTextBoxColumn();
			tbt_timk = new TextBox();
			label1 = new Label();
			groupBox2 = new GroupBox();
			dtg_hoadonchitiet = new DataGridView();
			Column8 = new DataGridViewTextBoxColumn();
			Column9 = new DataGridViewTextBoxColumn();
			Column13 = new DataGridViewTextBoxColumn();
			Column10 = new DataGridViewTextBoxColumn();
			Column11 = new DataGridViewTextBoxColumn();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dtg_hoadon).BeginInit();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dtg_hoadonchitiet).BeginInit();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(btn_timk);
			groupBox1.Controls.Add(dtg_hoadon);
			groupBox1.Controls.Add(tbt_timk);
			groupBox1.Controls.Add(label1);
			groupBox1.Dock = DockStyle.Top;
			groupBox1.Location = new Point(0, 0);
			groupBox1.Margin = new Padding(3, 4, 3, 4);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(3, 4, 3, 4);
			groupBox1.Size = new Size(1144, 287);
			groupBox1.TabIndex = 2;
			groupBox1.TabStop = false;
			groupBox1.Text = "Hóa đơn";
			// 
			// btn_timk
			// 
			btn_timk.BackColor = SystemColors.ActiveCaption;
			btn_timk.Image = (Image)resources.GetObject("btn_timk.Image");
			btn_timk.ImageAlign = ContentAlignment.MiddleLeft;
			btn_timk.Location = new Point(413, 33);
			btn_timk.Margin = new Padding(3, 4, 3, 4);
			btn_timk.Name = "btn_timk";
			btn_timk.Size = new Size(97, 31);
			btn_timk.TabIndex = 17;
			btn_timk.Text = "Tìm kiếm";
			btn_timk.TextAlign = ContentAlignment.MiddleRight;
			btn_timk.UseVisualStyleBackColor = false;
			btn_timk.Click += btn_timk_Click;
			// 
			// dtg_hoadon
			// 
			dtg_hoadon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dtg_hoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dtg_hoadon.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
			dtg_hoadon.Dock = DockStyle.Bottom;
			dtg_hoadon.Location = new Point(3, 95);
			dtg_hoadon.Name = "dtg_hoadon";
			dtg_hoadon.RowHeadersWidth = 51;
			dtg_hoadon.RowTemplate.Height = 29;
			dtg_hoadon.Size = new Size(1138, 188);
			dtg_hoadon.TabIndex = 16;
			dtg_hoadon.CellClick += dtg_hoadon_CellClick;
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
			Column3.HeaderText = "Số điện thoại khách hàng";
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
			// tbt_timk
			// 
			tbt_timk.Location = new Point(154, 35);
			tbt_timk.Margin = new Padding(3, 4, 3, 4);
			tbt_timk.Name = "tbt_timk";
			tbt_timk.Size = new Size(217, 27);
			tbt_timk.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(14, 41);
			label1.Name = "label1";
			label1.Size = new Size(135, 20);
			label1.TabIndex = 0;
			label1.Text = "Tìm kiếm hóa đơn";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(dtg_hoadonchitiet);
			groupBox2.Dock = DockStyle.Fill;
			groupBox2.Location = new Point(0, 287);
			groupBox2.Margin = new Padding(3, 4, 3, 4);
			groupBox2.Name = "groupBox2";
			groupBox2.Padding = new Padding(3, 4, 3, 4);
			groupBox2.Size = new Size(1144, 439);
			groupBox2.TabIndex = 3;
			groupBox2.TabStop = false;
			groupBox2.Text = "Hóa đơn chi tiết";
			// 
			// dtg_hoadonchitiet
			// 
			dtg_hoadonchitiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dtg_hoadonchitiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dtg_hoadonchitiet.Columns.AddRange(new DataGridViewColumn[] { Column8, Column9, Column13, Column10, Column11 });
			dtg_hoadonchitiet.Dock = DockStyle.Bottom;
			dtg_hoadonchitiet.Location = new Point(3, 22);
			dtg_hoadonchitiet.Name = "dtg_hoadonchitiet";
			dtg_hoadonchitiet.RowHeadersWidth = 51;
			dtg_hoadonchitiet.RowTemplate.Height = 29;
			dtg_hoadonchitiet.Size = new Size(1138, 413);
			dtg_hoadonchitiet.TabIndex = 1;
			// 
			// Column8
			// 
			Column8.HeaderText = "Mã hóa đơn";
			Column8.MinimumWidth = 6;
			Column8.Name = "Column8";
			// 
			// Column9
			// 
			Column9.HeaderText = "Mã sản phẩm";
			Column9.MinimumWidth = 6;
			Column9.Name = "Column9";
			// 
			// Column13
			// 
			Column13.HeaderText = "Tên Sản Phẩm";
			Column13.MinimumWidth = 6;
			Column13.Name = "Column13";
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
			// FrmHoaDon
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1144, 726);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Name = "FrmHoaDon";
			Text = "FrmHoaDon";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dtg_hoadon).EndInit();
			groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dtg_hoadonchitiet).EndInit();
			ResumeLayout(false);
		}

		#endregion
		private GroupBox groupBox1;
		private TextBox tbt_timk;
		private Label label1;
		private DataGridView dtg_hoadon;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column4;
		private DataGridViewTextBoxColumn Column5;
		private DataGridViewTextBoxColumn Column6;
		private DataGridViewTextBoxColumn Column7;
		private Button btn_timk;
		private GroupBox groupBox2;
		private DataGridView dtg_hoadonchitiet;
		private DataGridViewTextBoxColumn Column8;
		private DataGridViewTextBoxColumn Column9;
		private DataGridViewTextBoxColumn Column13;
		private DataGridViewTextBoxColumn Column10;
		private DataGridViewTextBoxColumn Column11;
	}
}