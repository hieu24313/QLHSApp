namespace GUI_QLHSApp
{
    partial class frmHocSinh
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
            nudMaHS = new NumericUpDown();
            cbMaL = new ComboBox();
            txtGioiTinh = new TextBox();
            dtpNgaySinhHS = new DateTimePicker();
            txtTen = new TextBox();
            txtHo = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btTim = new Button();
            txtTenTK = new TextBox();
            rdTen = new RadioButton();
            nudMaTK = new NumericUpDown();
            rdMa = new RadioButton();
            btThem = new Button();
            btThoat = new Button();
            btSua = new Button();
            btXoa = new Button();
            dgvHocSinh = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMaHS).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMaTK).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHocSinh).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nudMaHS);
            groupBox1.Controls.Add(cbMaL);
            groupBox1.Controls.Add(txtGioiTinh);
            groupBox1.Controls.Add(dtpNgaySinhHS);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(txtHo);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(1, 1);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(913, 200);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin học sinh";
            // 
            // nudMaHS
            // 
            nudMaHS.Location = new Point(128, 53);
            nudMaHS.Margin = new Padding(3, 4, 3, 4);
            nudMaHS.Name = "nudMaHS";
            nudMaHS.Size = new Size(137, 27);
            nudMaHS.TabIndex = 12;
            // 
            // cbMaL
            // 
            cbMaL.FormattingEnabled = true;
            cbMaL.Location = new Point(128, 135);
            cbMaL.Margin = new Padding(3, 4, 3, 4);
            cbMaL.Name = "cbMaL";
            cbMaL.Size = new Size(138, 28);
            cbMaL.TabIndex = 11;
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.Location = new Point(727, 131);
            txtGioiTinh.Margin = new Padding(3, 4, 3, 4);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Size = new Size(164, 27);
            txtGioiTinh.TabIndex = 10;
            // 
            // dtpNgaySinhHS
            // 
            dtpNgaySinhHS.Location = new Point(375, 133);
            dtpNgaySinhHS.Margin = new Padding(3, 4, 3, 4);
            dtpNgaySinhHS.Name = "dtpNgaySinhHS";
            dtpNgaySinhHS.Size = new Size(265, 27);
            dtpNgaySinhHS.TabIndex = 9;
            dtpNgaySinhHS.Value = new DateTime(2023, 4, 17, 0, 0, 0, 0);
            // 
            // txtTen
            // 
            txtTen.Location = new Point(720, 52);
            txtTen.Margin = new Padding(3, 4, 3, 4);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(171, 27);
            txtTen.TabIndex = 8;
            // 
            // txtHo
            // 
            txtHo.Location = new Point(375, 52);
            txtHo.Margin = new Padding(3, 4, 3, 4);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(265, 27);
            txtHo.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(286, 138);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 5;
            label6.Text = "Ngày Sinh :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(286, 55);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 4;
            label5.Text = "Họ :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(646, 134);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 3;
            label4.Text = "Giới Tính :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 138);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 2;
            label3.Text = "Lớp :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(646, 55);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 55);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã Học Sinh :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btTim);
            groupBox2.Controls.Add(txtTenTK);
            groupBox2.Controls.Add(rdTen);
            groupBox2.Controls.Add(nudMaTK);
            groupBox2.Controls.Add(rdMa);
            groupBox2.Location = new Point(1, 209);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(488, 142);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm Kiếm :";
            // 
            // btTim
            // 
            btTim.Location = new Point(174, 80);
            btTim.Margin = new Padding(3, 4, 3, 4);
            btTim.Name = "btTim";
            btTim.Size = new Size(86, 31);
            btTim.TabIndex = 8;
            btTim.Text = "Tìm ";
            btTim.UseVisualStyleBackColor = true;
            btTim.Click += btTim_Click;
            // 
            // txtTenTK
            // 
            txtTenTK.Location = new Point(290, 29);
            txtTenTK.Margin = new Padding(3, 4, 3, 4);
            txtTenTK.Name = "txtTenTK";
            txtTenTK.Size = new Size(114, 27);
            txtTenTK.TabIndex = 7;
            // 
            // rdTen
            // 
            rdTen.AutoSize = true;
            rdTen.Location = new Point(229, 29);
            rdTen.Margin = new Padding(3, 4, 3, 4);
            rdTen.Name = "rdTen";
            rdTen.Size = new Size(60, 24);
            rdTen.TabIndex = 2;
            rdTen.TabStop = true;
            rdTen.Text = "Tên :";
            rdTen.UseVisualStyleBackColor = true;
            rdTen.CheckedChanged += rdTen_CheckedChanged;
            // 
            // nudMaTK
            // 
            nudMaTK.Location = new Point(74, 29);
            nudMaTK.Margin = new Padding(3, 4, 3, 4);
            nudMaTK.Name = "nudMaTK";
            nudMaTK.Size = new Size(137, 27);
            nudMaTK.TabIndex = 1;
            // 
            // rdMa
            // 
            rdMa.AutoSize = true;
            rdMa.Location = new Point(13, 29);
            rdMa.Margin = new Padding(3, 4, 3, 4);
            rdMa.Name = "rdMa";
            rdMa.Size = new Size(58, 24);
            rdMa.TabIndex = 0;
            rdMa.TabStop = true;
            rdMa.Text = "Mã :";
            rdMa.UseVisualStyleBackColor = true;
            rdMa.CheckedChanged += rdMa_CheckedChanged;
            // 
            // btThem
            // 
            btThem.Location = new Point(539, 211);
            btThem.Margin = new Padding(3, 4, 3, 4);
            btThem.Name = "btThem";
            btThem.Size = new Size(122, 69);
            btThem.TabIndex = 9;
            btThem.Text = "Thêm Học Sinh";
            btThem.UseVisualStyleBackColor = true;
            btThem.Click += btThem_Click;
            // 
            // btThoat
            // 
            btThoat.Location = new Point(698, 288);
            btThoat.Margin = new Padding(3, 4, 3, 4);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(126, 63);
            btThoat.TabIndex = 10;
            btThoat.Text = "Thoát ";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // btSua
            // 
            btSua.Location = new Point(698, 209);
            btSua.Margin = new Padding(3, 4, 3, 4);
            btSua.Name = "btSua";
            btSua.Size = new Size(126, 71);
            btSua.TabIndex = 11;
            btSua.Text = "Sửa Học Sinh";
            btSua.UseVisualStyleBackColor = true;
            btSua.Click += btSua_Click;
            // 
            // btXoa
            // 
            btXoa.Location = new Point(539, 288);
            btXoa.Margin = new Padding(3, 4, 3, 4);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(122, 63);
            btXoa.TabIndex = 12;
            btXoa.Text = "Xóa Học Sinh ";
            btXoa.UseVisualStyleBackColor = true;
            btXoa.Click += btXoa_Click;
            // 
            // dgvHocSinh
            // 
            dgvHocSinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHocSinh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHocSinh.Location = new Point(12, 387);
            dgvHocSinh.Margin = new Padding(3, 4, 3, 4);
            dgvHocSinh.Name = "dgvHocSinh";
            dgvHocSinh.RowHeadersWidth = 51;
            dgvHocSinh.RowTemplate.Height = 25;
            dgvHocSinh.Size = new Size(894, 300);
            dgvHocSinh.TabIndex = 13;
            dgvHocSinh.SelectionChanged += dgvHocSinh_SelectionChanged;
            dgvHocSinh.DoubleClick += dgvHocSinh_DoubleClick;
            // 
            // frmHocSinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 700);
            Controls.Add(dgvHocSinh);
            Controls.Add(btXoa);
            Controls.Add(btSua);
            Controls.Add(btThoat);
            Controls.Add(btThem);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmHocSinh";
            Text = "Học Sinh";
            Load += frmHocSinh_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMaHS).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMaTK).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHocSinh).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtHo;
        private TextBox txtTen;
        private DateTimePicker dtpNgaySinhHS;
        private TextBox txtGioiTinh;
        private ComboBox cbMaL;
        private GroupBox groupBox2;
        private RadioButton rdMa;
        private NumericUpDown nudMaTK;
        private Button btTim;
        private TextBox txtTenTK;
        private RadioButton rdTen;
        private Button btThem;
        private Button btThoat;
        private Button btSua;
        private Button btXoa;
        private DataGridView dgvHocSinh;
        private NumericUpDown nudMaHS;
    }
}