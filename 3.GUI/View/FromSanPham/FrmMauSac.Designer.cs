namespace _3.GUI.View.FromSanPham
{
    partial class FrmMauSac
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
            dtgv_Mau = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            groupBox2 = new GroupBox();
            btn_lamMoi = new Button();
            btb_CapNhat = new Button();
            btn_them = new Button();
            label2 = new Label();
            rb_KHD = new RadioButton();
            rb_HoatDong = new RadioButton();
            label3 = new Label();
            tbt_TenMau = new TextBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dtgv_Mau).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgv_Mau
            // 
            dtgv_Mau.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_Mau.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_Mau.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3, Column4 });
            dtgv_Mau.Location = new Point(-3, 28);
            dtgv_Mau.Margin = new Padding(3, 2, 3, 2);
            dtgv_Mau.Name = "dtgv_Mau";
            dtgv_Mau.RowHeadersWidth = 51;
            dtgv_Mau.RowTemplate.Height = 29;
            dtgv_Mau.Size = new Size(690, 218);
            dtgv_Mau.TabIndex = 0;
            dtgv_Mau.CellClick += dtgv_Mau_CellClick;
            // 
            // Column2
            // 
            Column2.HeaderText = "Mã màu sắc";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Tên màu sắc";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Tình trạng";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dtgv_Mau);
            groupBox3.Location = new Point(105, 236);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(688, 248);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách màu sắc";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_lamMoi);
            groupBox2.Controls.Add(btb_CapNhat);
            groupBox2.Controls.Add(btn_them);
            groupBox2.Location = new Point(500, 45);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(293, 137);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btn_lamMoi
            // 
            btn_lamMoi.Image = Properties.Resources.icons8_repeat_301;
            btn_lamMoi.ImageAlign = ContentAlignment.MiddleLeft;
            btn_lamMoi.Location = new Point(87, 76);
            btn_lamMoi.Margin = new Padding(3, 2, 3, 2);
            btn_lamMoi.Name = "btn_lamMoi";
            btn_lamMoi.Size = new Size(121, 38);
            btn_lamMoi.TabIndex = 2;
            btn_lamMoi.Text = "Làm mới";
            btn_lamMoi.UseVisualStyleBackColor = true;
            // 
            // btb_CapNhat
            // 
            btb_CapNhat.Image = Properties.Resources.icons8_edit_32;
            btb_CapNhat.ImageAlign = ContentAlignment.MiddleLeft;
            btb_CapNhat.Location = new Point(154, 26);
            btb_CapNhat.Margin = new Padding(3, 2, 3, 2);
            btb_CapNhat.Name = "btb_CapNhat";
            btb_CapNhat.Size = new Size(121, 38);
            btb_CapNhat.TabIndex = 1;
            btb_CapNhat.Text = "Cập nhật";
            btb_CapNhat.UseVisualStyleBackColor = true;
            btb_CapNhat.Click += btb_CapNhat_Click;
            // 
            // btn_them
            // 
            btn_them.Image = Properties.Resources.icons8_add_new_32;
            btn_them.ImageAlign = ContentAlignment.MiddleLeft;
            btn_them.Location = new Point(18, 27);
            btn_them.Margin = new Padding(3, 2, 3, 2);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(121, 38);
            btn_them.TabIndex = 0;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 76);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên màu sắc";
            // 
            // rb_KHD
            // 
            rb_KHD.AutoSize = true;
            rb_KHD.Location = new Point(268, 119);
            rb_KHD.Margin = new Padding(3, 2, 3, 2);
            rb_KHD.Name = "rb_KHD";
            rb_KHD.Size = new Size(74, 19);
            rb_KHD.TabIndex = 6;
            rb_KHD.TabStop = true;
            rb_KHD.Text = "Hết hàng";
            rb_KHD.UseVisualStyleBackColor = true;
            // 
            // rb_HoatDong
            // 
            rb_HoatDong.AutoSize = true;
            rb_HoatDong.Location = new Point(163, 119);
            rb_HoatDong.Margin = new Padding(3, 2, 3, 2);
            rb_HoatDong.Name = "rb_HoatDong";
            rb_HoatDong.Size = new Size(77, 19);
            rb_HoatDong.TabIndex = 5;
            rb_HoatDong.TabStop = true;
            rb_HoatDong.Text = "Còn hàng";
            rb_HoatDong.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 122);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 4;
            label3.Text = "Trạng thái";
            // 
            // tbt_TenMau
            // 
            tbt_TenMau.Location = new Point(163, 76);
            tbt_TenMau.Margin = new Padding(3, 2, 3, 2);
            tbt_TenMau.Name = "tbt_TenMau";
            tbt_TenMau.Size = new Size(185, 23);
            tbt_TenMau.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rb_KHD);
            groupBox1.Controls.Add(rb_HoatDong);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbt_TenMau);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(102, 45);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(381, 182);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin màu sắc";
            // 
            // FrmMauSac
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 509);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmMauSac";
            Text = "FrmMauSac";
            ((System.ComponentModel.ISupportInitialize)dtgv_Mau).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dtgv_Mau;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Button btn_lamMoi;
        private Button btb_CapNhat;
        private Button btn_them;
        private Label label2;
        private RadioButton rb_KHD;
        private RadioButton rb_HoatDong;
        private Label label3;
        private TextBox tbt_TenMau;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}