namespace GUI_QLHSApp
{
    partial class frmQuanLyLop
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1 = new GroupBox();
            txtTenLop = new TextBox();
            txtNamHoc = new TextBox();
            cbMaGiaoVien = new ComboBox();
            nudMaLop = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btTim = new Button();
            nudMaTK = new NumericUpDown();
            txtTenTK = new TextBox();
            btnTim = new Button();
            rdMa = new RadioButton();
            rdTen = new RadioButton();
            dgvQuanLyLop = new DataGridView();
            btThem = new Button();
            btXoa = new Button();
            btThoat = new Button();
            btSua = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMaLop).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMaTK).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvQuanLyLop).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTenLop);
            groupBox1.Controls.Add(txtNamHoc);
            groupBox1.Controls.Add(cbMaGiaoVien);
            groupBox1.Controls.Add(nudMaLop);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(22, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(613, 183);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Lớp ";
            // 
            // txtTenLop
            // 
            txtTenLop.Location = new Point(400, 52);
            txtTenLop.Margin = new Padding(3, 4, 3, 4);
            txtTenLop.Name = "txtTenLop";
            txtTenLop.Size = new Size(207, 27);
            txtTenLop.TabIndex = 9;
            // 
            // txtNamHoc
            // 
            txtNamHoc.Location = new Point(134, 132);
            txtNamHoc.Margin = new Padding(3, 4, 3, 4);
            txtNamHoc.Name = "txtNamHoc";
            txtNamHoc.Size = new Size(143, 27);
            txtNamHoc.TabIndex = 8;
            // 
            // cbMaGiaoVien
            // 
            cbMaGiaoVien.FormattingEnabled = true;
            cbMaGiaoVien.Location = new Point(400, 132);
            cbMaGiaoVien.Margin = new Padding(3, 4, 3, 4);
            cbMaGiaoVien.Name = "cbMaGiaoVien";
            cbMaGiaoVien.Size = new Size(207, 28);
            cbMaGiaoVien.TabIndex = 7;
            // 
            // nudMaLop
            // 
            nudMaLop.Location = new Point(134, 45);
            nudMaLop.Margin = new Padding(3, 4, 3, 4);
            nudMaLop.Name = "nudMaLop";
            nudMaLop.Size = new Size(143, 27);
            nudMaLop.TabIndex = 6;
            // 
            // label5
            // 
            label5.Location = new Point(307, 137);
            label5.Name = "label5";
            label5.Size = new Size(98, 25);
            label5.TabIndex = 5;
            label5.Text = "Giáo Viên :";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Location = new Point(45, 137);
            label4.Name = "label4";
            label4.Size = new Size(82, 25);
            label4.TabIndex = 4;
            label4.Text = "Năm Học :";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Location = new Point(307, 52);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 3;
            label3.Text = "Tên Lớp :";
            label3.TextAlign = ContentAlignment.BottomRight;
            // 
            // label1
            // 
            label1.Location = new Point(45, 45);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 1;
            label1.Text = "Mã Lớp:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btTim);
            groupBox2.Controls.Add(nudMaTK);
            groupBox2.Controls.Add(txtTenTK);
            groupBox2.Controls.Add(btnTim);
            groupBox2.Controls.Add(rdMa);
            groupBox2.Controls.Add(rdTen);
            groupBox2.Location = new Point(641, 16);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(376, 179);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm Kiếm";
            // 
            // btTim
            // 
            btTim.Location = new Point(238, 72);
            btTim.Margin = new Padding(3, 4, 3, 4);
            btTim.Name = "btTim";
            btTim.Size = new Size(114, 31);
            btTim.TabIndex = 20;
            btTim.Text = "Tìm Kiếm";
            btTim.UseVisualStyleBackColor = true;
            btTim.Click += btTim_Click;
            // 
            // nudMaTK
            // 
            nudMaTK.Location = new Point(81, 49);
            nudMaTK.Margin = new Padding(3, 4, 3, 4);
            nudMaTK.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudMaTK.Name = "nudMaTK";
            nudMaTK.Size = new Size(125, 27);
            nudMaTK.TabIndex = 11;
            // 
            // txtTenTK
            // 
            txtTenTK.Location = new Point(81, 107);
            txtTenTK.Margin = new Padding(3, 4, 3, 4);
            txtTenTK.Name = "txtTenTK";
            txtTenTK.Size = new Size(148, 27);
            txtTenTK.TabIndex = 14;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(506, 44);
            btnTim.Margin = new Padding(3, 4, 3, 4);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(77, 36);
            btnTim.TabIndex = 19;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            // 
            // rdMa
            // 
            rdMa.AutoSize = true;
            rdMa.Location = new Point(18, 49);
            rdMa.Margin = new Padding(3, 4, 3, 4);
            rdMa.Name = "rdMa";
            rdMa.Size = new Size(51, 24);
            rdMa.TabIndex = 15;
            rdMa.TabStop = true;
            rdMa.Text = "Mã";
            rdMa.UseVisualStyleBackColor = true;
            rdMa.CheckedChanged += rdMa_CheckedChanged;
            // 
            // rdTen
            // 
            rdTen.AutoSize = true;
            rdTen.Location = new Point(18, 108);
            rdTen.Margin = new Padding(3, 4, 3, 4);
            rdTen.Name = "rdTen";
            rdTen.Size = new Size(53, 24);
            rdTen.TabIndex = 16;
            rdTen.TabStop = true;
            rdTen.Text = "Tên";
            rdTen.UseVisualStyleBackColor = true;
            rdTen.CheckedChanged += rdTen_CheckedChanged;
            // 
            // dgvQuanLyLop
            // 
            dgvQuanLyLop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQuanLyLop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuanLyLop.Location = new Point(14, 296);
            dgvQuanLyLop.Margin = new Padding(3, 4, 3, 4);
            dgvQuanLyLop.Name = "dgvQuanLyLop";
            dgvQuanLyLop.RowHeadersWidth = 51;
            dgvQuanLyLop.RowTemplate.Height = 25;
            dgvQuanLyLop.Size = new Size(1002, 249);
            dgvQuanLyLop.TabIndex = 13;
            dgvQuanLyLop.SelectionChanged += dgvQuanLyLop_SelectionChanged;
            dgvQuanLyLop.DoubleClick += dgvQuanLyLop_DoubleClick;
            // 
            // btThem
            // 
            btThem.Location = new Point(77, 223);
            btThem.Margin = new Padding(3, 4, 3, 4);
            btThem.Name = "btThem";
            btThem.Size = new Size(125, 65);
            btThem.TabIndex = 14;
            btThem.Text = "Thêm Lớp";
            btThem.UseVisualStyleBackColor = true;
            btThem.Click += btThem_Click;
            // 
            // btXoa
            // 
            btXoa.Location = new Point(565, 223);
            btXoa.Margin = new Padding(3, 4, 3, 4);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(130, 65);
            btXoa.TabIndex = 15;
            btXoa.Text = "Xóa Lớp";
            btXoa.UseVisualStyleBackColor = true;
            btXoa.Click += btXoa_Click;
            // 
            // btThoat
            // 
            btThoat.Location = new Point(834, 223);
            btThoat.Margin = new Padding(3, 4, 3, 4);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(120, 65);
            btThoat.TabIndex = 16;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // btSua
            // 
            btSua.Location = new Point(329, 223);
            btSua.Margin = new Padding(3, 4, 3, 4);
            btSua.Name = "btSua";
            btSua.Size = new Size(113, 65);
            btSua.TabIndex = 17;
            btSua.Text = "Sửa Lớp";
            btSua.UseVisualStyleBackColor = true;
            btSua.Click += btSua_Click;
            // 
            // frmQuanLyLop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 561);
            Controls.Add(btSua);
            Controls.Add(btThoat);
            Controls.Add(btXoa);
            Controls.Add(btThem);
            Controls.Add(dgvQuanLyLop);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmQuanLyLop";
            Text = "Quản Lý Lớp";
            Load += frmQuanLyLop_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMaLop).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMaTK).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvQuanLyLop).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtTenLop;
        private TextBox txtNamHoc;
        private ComboBox cbMaGiaoVien;
        private NumericUpDown nudMaLop;
        private GroupBox groupBox2;
        private NumericUpDown nudMaTK;
        private TextBox txtTenTK;
        private Button btnTim;
        private RadioButton rdMa;
        private RadioButton rdTen;
        private Button btTim;
        private DataGridView dgvQuanLyLop;
        private Button btThem;
        private Button btXoa;
        private Button btThoat;
        private Button btSua;
    }
}