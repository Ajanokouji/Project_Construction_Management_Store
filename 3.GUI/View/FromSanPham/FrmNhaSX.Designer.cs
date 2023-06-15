namespace _3.GUI.View
{
    partial class FrmNhaSX
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
            groupBox1 = new GroupBox();
            rb_KHD = new RadioButton();
            rb_HoatDong = new RadioButton();
            label3 = new Label();
            tbt_TenNSX = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            btn_lamMoi = new Button();
            btb_CapNhat = new Button();
            btn_them = new Button();
            groupBox3 = new GroupBox();
            dtgv_NSX = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_NSX).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rb_KHD);
            groupBox1.Controls.Add(rb_HoatDong);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbt_TenNSX);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(29, 29);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(381, 182);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhà sản xuất";
            // 
            // rb_KHD
            // 
            rb_KHD.AutoSize = true;
            rb_KHD.Location = new Point(232, 121);
            rb_KHD.Margin = new Padding(3, 2, 3, 2);
            rb_KHD.Name = "rb_KHD";
            rb_KHD.Size = new Size(118, 19);
            rb_KHD.TabIndex = 6;
            rb_KHD.TabStop = true;
            rb_KHD.Text = "Không hoạt động";
            rb_KHD.UseVisualStyleBackColor = true;
            // 
            // rb_HoatDong
            // 
            rb_HoatDong.AutoSize = true;
            rb_HoatDong.Location = new Point(137, 121);
            rb_HoatDong.Margin = new Padding(3, 2, 3, 2);
            rb_HoatDong.Name = "rb_HoatDong";
            rb_HoatDong.Size = new Size(82, 19);
            rb_HoatDong.TabIndex = 5;
            rb_HoatDong.TabStop = true;
            rb_HoatDong.Text = "Hoạt động";
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
            // tbt_TenNSX
            // 
            tbt_TenNSX.Location = new Point(163, 76);
            tbt_TenNSX.Margin = new Padding(3, 2, 3, 2);
            tbt_TenNSX.Name = "tbt_TenNSX";
            tbt_TenNSX.Size = new Size(185, 23);
            tbt_TenNSX.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 76);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên nhà sản xuất";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_lamMoi);
            groupBox2.Controls.Add(btb_CapNhat);
            groupBox2.Controls.Add(btn_them);
            groupBox2.Location = new Point(426, 29);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(293, 128);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btn_lamMoi
            // 
            btn_lamMoi.Image = Properties.Resources.icons8_repeat_303;
            btn_lamMoi.ImageAlign = ContentAlignment.MiddleLeft;
            btn_lamMoi.Location = new Point(85, 76);
            btn_lamMoi.Margin = new Padding(3, 2, 3, 2);
            btn_lamMoi.Name = "btn_lamMoi";
            btn_lamMoi.Size = new Size(121, 38);
            btn_lamMoi.TabIndex = 2;
            btn_lamMoi.Text = "Làm mới";
            btn_lamMoi.UseVisualStyleBackColor = true;
            btn_lamMoi.Click += btn_lamMoi_Click;
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
            // groupBox3
            // 
            groupBox3.Controls.Add(dtgv_NSX);
            groupBox3.Location = new Point(32, 220);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(688, 248);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách nhà sản xuất";
            // 
            // dtgv_NSX
            // 
            dtgv_NSX.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_NSX.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_NSX.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3, Column4 });
            dtgv_NSX.Location = new Point(-3, 28);
            dtgv_NSX.Margin = new Padding(3, 2, 3, 2);
            dtgv_NSX.Name = "dtgv_NSX";
            dtgv_NSX.RowHeadersWidth = 51;
            dtgv_NSX.RowTemplate.Height = 29;
            dtgv_NSX.Size = new Size(690, 218);
            dtgv_NSX.TabIndex = 0;
            dtgv_NSX.CellClick += dtgv_NSX_CellClick;
            // 
            // Column2
            // 
            Column2.HeaderText = "Mã NSX";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Tên NSX";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Trạng thái";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // FrmNhaSX
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 499);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmNhaSX";
            Text = "FrmNhaSX";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgv_NSX).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rb_KHD;
        private RadioButton rb_HoatDong;
        private Label label3;
        private TextBox tbt_TenNSX;
        private Label label2;
        private GroupBox groupBox2;
        private Button btn_lamMoi;
        private Button btb_CapNhat;
        private Button btn_them;
        private GroupBox groupBox3;
        private DataGridView dtgv_NSX;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}