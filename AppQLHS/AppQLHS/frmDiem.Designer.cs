namespace GUI_QLHSApp
{
    partial class frmDiem
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
            txtDiemSo = new TextBox();
            label6 = new Label();
            txtTenHS = new TextBox();
            cbLoaiDiem = new ComboBox();
            label5 = new Label();
            cbMon = new ComboBox();
            txtMaHocSinh = new TextBox();
            label3 = new Label();
            nudMaDiem = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            btnTK = new Button();
            nudMaTK = new NumericUpDown();
            rdMa = new RadioButton();
            btSua = new Button();
            btXoa = new Button();
            btThem = new Button();
            btThoat = new Button();
            dgvDiem = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMaDiem).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMaTK).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDiem).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDiemSo);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtTenHS);
            groupBox1.Controls.Add(cbLoaiDiem);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cbMon);
            groupBox1.Controls.Add(txtMaHocSinh);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(nudMaDiem);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1022, 194);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Điểm";
            // 
            // txtDiemSo
            // 
            txtDiemSo.Location = new Point(853, 29);
            txtDiemSo.Margin = new Padding(3, 4, 3, 4);
            txtDiemSo.Name = "txtDiemSo";
            txtDiemSo.Size = new Size(131, 27);
            txtDiemSo.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(739, 37);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 12;
            label6.Text = "Điểm Số:";
            // 
            // txtTenHS
            // 
            txtTenHS.Location = new Point(430, 28);
            txtTenHS.Margin = new Padding(3, 4, 3, 4);
            txtTenHS.Name = "txtTenHS";
            txtTenHS.Size = new Size(283, 27);
            txtTenHS.TabIndex = 11;
            // 
            // cbLoaiDiem
            // 
            cbLoaiDiem.FormattingEnabled = true;
            cbLoaiDiem.Location = new Point(853, 86);
            cbLoaiDiem.Margin = new Padding(3, 4, 3, 4);
            cbLoaiDiem.Name = "cbLoaiDiem";
            cbLoaiDiem.Size = new Size(131, 28);
            cbLoaiDiem.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(738, 90);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 9;
            label5.Text = "Loại Điểm :";
            // 
            // cbMon
            // 
            cbMon.FormattingEnabled = true;
            cbMon.Location = new Point(430, 84);
            cbMon.Margin = new Padding(3, 4, 3, 4);
            cbMon.Name = "cbMon";
            cbMon.Size = new Size(166, 28);
            cbMon.TabIndex = 7;
            // 
            // txtMaHocSinh
            // 
            txtMaHocSinh.Location = new Point(149, 30);
            txtMaHocSinh.Margin = new Padding(3, 4, 3, 4);
            txtMaHocSinh.Name = "txtMaHocSinh";
            txtMaHocSinh.Size = new Size(131, 27);
            txtMaHocSinh.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(350, 95);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "Môn :";
            // 
            // nudMaDiem
            // 
            nudMaDiem.Location = new Point(149, 83);
            nudMaDiem.Margin = new Padding(3, 4, 3, 4);
            nudMaDiem.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nudMaDiem.Name = "nudMaDiem";
            nudMaDiem.Size = new Size(137, 27);
            nudMaDiem.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 86);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã Điểm :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(344, 33);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Học Sinh :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 32);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 3;
            label4.Text = "Mã Học Sinh:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnTK);
            groupBox2.Controls.Add(nudMaTK);
            groupBox2.Controls.Add(rdMa);
            groupBox2.Location = new Point(14, 229);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(439, 133);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm Kiếm";
            // 
            // btnTK
            // 
            btnTK.Location = new Point(255, 44);
            btnTK.Margin = new Padding(3, 4, 3, 4);
            btnTK.Name = "btnTK";
            btnTK.Size = new Size(96, 36);
            btnTK.TabIndex = 24;
            btnTK.Text = "Tìm Kiếm";
            btnTK.UseVisualStyleBackColor = true;
            btnTK.Click += btnTK_Click;
            // 
            // nudMaTK
            // 
            nudMaTK.Location = new Point(81, 49);
            nudMaTK.Margin = new Padding(3, 4, 3, 4);
            nudMaTK.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudMaTK.Name = "nudMaTK";
            nudMaTK.Size = new Size(123, 27);
            nudMaTK.TabIndex = 11;
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
            // 
            // btSua
            // 
            btSua.Location = new Point(705, 229);
            btSua.Margin = new Padding(3, 4, 3, 4);
            btSua.Name = "btSua";
            btSua.Size = new Size(117, 63);
            btSua.TabIndex = 28;
            btSua.Text = "Sửa Điểm ";
            btSua.UseVisualStyleBackColor = true;
            btSua.Click += btSua_Click;
            // 
            // btXoa
            // 
            btXoa.Location = new Point(539, 312);
            btXoa.Margin = new Padding(3, 4, 3, 4);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(117, 63);
            btXoa.TabIndex = 29;
            btXoa.Text = "Xóa Điểm ";
            btXoa.UseVisualStyleBackColor = true;
            btXoa.Click += btXoa_Click;
            // 
            // btThem
            // 
            btThem.Location = new Point(539, 229);
            btThem.Margin = new Padding(3, 4, 3, 4);
            btThem.Name = "btThem";
            btThem.Size = new Size(116, 63);
            btThem.TabIndex = 30;
            btThem.Text = "Thêm Điểm ";
            btThem.UseVisualStyleBackColor = true;
            btThem.Click += btThem_Click;
            // 
            // btThoat
            // 
            btThoat.Location = new Point(867, 312);
            btThoat.Margin = new Padding(3, 4, 3, 4);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(117, 63);
            btThoat.TabIndex = 31;
            btThoat.Text = "Thoát ";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // dgvDiem
            // 
            dgvDiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDiem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiem.Location = new Point(14, 383);
            dgvDiem.Margin = new Padding(3, 4, 3, 4);
            dgvDiem.Name = "dgvDiem";
            dgvDiem.RowHeadersWidth = 51;
            dgvDiem.RowTemplate.Height = 25;
            dgvDiem.Size = new Size(1022, 301);
            dgvDiem.TabIndex = 32;
            dgvDiem.SelectionChanged += dgvDiem_SelectionChanged;
            // 
            // button1
            // 
            button1.Location = new Point(867, 229);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(117, 63);
            button1.TabIndex = 33;
            button1.Text = "Xem Điểm Toàn Bộ Môn";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(705, 312);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(117, 63);
            button2.TabIndex = 34;
            button2.Text = "Làm Mới";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frmDiem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 713);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvDiem);
            Controls.Add(btThoat);
            Controls.Add(btThem);
            Controls.Add(btXoa);
            Controls.Add(btSua);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmDiem";
            Text = "Điểm";
            Load += frmDiem_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMaDiem).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMaTK).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDiem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cbLoaiDiem;
        private Label label5;
        private ComboBox cbMon;
        private TextBox txtMaHocSinh;
        private Label label3;
        private NumericUpDown nudMaDiem;
        private Label label1;
        private Label label4;
        private Label label2;
        private GroupBox groupBox2;
        private Button btnTK;
        private NumericUpDown nudMaTK;
        private RadioButton rdMa;
        private Button btSua;
        private Button btXoa;
        private Button btThem;
        private Button btThoat;
        private DataGridView dgvDiem;
        private TextBox txtTenHS;
        private TextBox txtDiemSo;
        private Label label6;
        private Button button1;
        private Button button2;
    }
}