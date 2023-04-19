namespace GUI_QLHSApp
{
    partial class frmGiaoVien
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
            label2 = new Label();
            label3 = new Label();
            txtHoGV = new TextBox();
            txtTenGV = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtQueQuanGV = new TextBox();
            txtSODTGV = new TextBox();
            label6 = new Label();
            label7 = new Label();
            dgvGiaoVien = new DataGridView();
            btnThemGV = new Button();
            btnSuaGV = new Button();
            btnXoaGV = new Button();
            txtTimGV = new TextBox();
            rdMa = new RadioButton();
            rdTen = new RadioButton();
            groupBox1 = new GroupBox();
            nudMaGV = new NumericUpDown();
            dtpNgaySinhGV = new DateTimePicker();
            nudMa = new NumericUpDown();
            btnThoat = new Button();
            btnTim = new Button();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvGiaoVien).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMaGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMa).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Location = new Point(16, 40);
            label2.Name = "label2";
            label2.Size = new Size(120, 21);
            label2.TabIndex = 3;
            label2.Text = "Mã Giáo Viên:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Location = new Point(385, 40);
            label3.Name = "label3";
            label3.Size = new Size(54, 21);
            label3.TabIndex = 4;
            label3.Text = "Họ :";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtHoGV
            // 
            txtHoGV.Location = new Point(474, 39);
            txtHoGV.Name = "txtHoGV";
            txtHoGV.Size = new Size(259, 25);
            txtHoGV.TabIndex = 5;
            // 
            // txtTenGV
            // 
            txtTenGV.Location = new Point(834, 42);
            txtTenGV.Name = "txtTenGV";
            txtTenGV.Size = new Size(260, 25);
            txtTenGV.TabIndex = 2;
            // 
            // label4
            // 
            label4.Location = new Point(739, 42);
            label4.Name = "label4";
            label4.Size = new Size(88, 21);
            label4.TabIndex = 3;
            label4.Text = "Tên :";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Location = new Point(16, 105);
            label5.Name = "label5";
            label5.Size = new Size(120, 21);
            label5.TabIndex = 3;
            label5.Text = "Ngày Sinh :";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtQueQuanGV
            // 
            txtQueQuanGV.Location = new Point(474, 101);
            txtQueQuanGV.Name = "txtQueQuanGV";
            txtQueQuanGV.Size = new Size(260, 25);
            txtQueQuanGV.TabIndex = 7;
            // 
            // txtSODTGV
            // 
            txtSODTGV.Location = new Point(834, 104);
            txtSODTGV.Name = "txtSODTGV";
            txtSODTGV.Size = new Size(260, 25);
            txtSODTGV.TabIndex = 7;
            // 
            // label6
            // 
            label6.Location = new Point(385, 105);
            label6.Name = "label6";
            label6.Size = new Size(83, 21);
            label6.TabIndex = 8;
            label6.Text = "Quê Quán :";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Location = new Point(740, 105);
            label7.Name = "label7";
            label7.Size = new Size(88, 21);
            label7.TabIndex = 9;
            label7.Text = "Điện Thoại :";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvGiaoVien
            // 
            dgvGiaoVien.AllowUserToOrderColumns = true;
            dgvGiaoVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGiaoVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGiaoVien.Location = new Point(18, 277);
            dgvGiaoVien.Name = "dgvGiaoVien";
            dgvGiaoVien.RowHeadersWidth = 51;
            dgvGiaoVien.RowTemplate.Height = 29;
            dgvGiaoVien.Size = new Size(1113, 399);
            dgvGiaoVien.TabIndex = 10;
            dgvGiaoVien.SelectionChanged += dgvGiaoVien_SelectionChanged;
            // 
            // btnThemGV
            // 
            btnThemGV.Location = new Point(577, 207);
            btnThemGV.Name = "btnThemGV";
            btnThemGV.Size = new Size(94, 52);
            btnThemGV.TabIndex = 11;
            btnThemGV.Text = "Thêm Giáo Viên";
            btnThemGV.UseVisualStyleBackColor = true;
            btnThemGV.Click += btnThemGV_Click;
            // 
            // btnSuaGV
            // 
            btnSuaGV.Location = new Point(852, 207);
            btnSuaGV.Name = "btnSuaGV";
            btnSuaGV.Size = new Size(94, 52);
            btnSuaGV.TabIndex = 12;
            btnSuaGV.Text = "Sửa Thông Tin";
            btnSuaGV.UseVisualStyleBackColor = true;
            btnSuaGV.Click += btnSuaGV_Click;
            // 
            // btnXoaGV
            // 
            btnXoaGV.Location = new Point(710, 207);
            btnXoaGV.Name = "btnXoaGV";
            btnXoaGV.Size = new Size(94, 52);
            btnXoaGV.TabIndex = 13;
            btnXoaGV.Text = "Xóa Giáo Viên";
            btnXoaGV.UseVisualStyleBackColor = true;
            btnXoaGV.Click += btnXoaGV_Click;
            // 
            // txtTimGV
            // 
            txtTimGV.Location = new Point(295, 33);
            txtTimGV.Name = "txtTimGV";
            txtTimGV.Size = new Size(130, 25);
            txtTimGV.TabIndex = 14;
            // 
            // rdMa
            // 
            rdMa.AutoSize = true;
            rdMa.Location = new Point(16, 37);
            rdMa.Name = "rdMa";
            rdMa.Size = new Size(49, 21);
            rdMa.TabIndex = 15;
            rdMa.TabStop = true;
            rdMa.Text = "Mã";
            rdMa.UseVisualStyleBackColor = true;
            rdMa.CheckedChanged += rdMa_CheckedChanged;
            // 
            // rdTen
            // 
            rdTen.AutoSize = true;
            rdTen.Location = new Point(237, 37);
            rdTen.Name = "rdTen";
            rdTen.Size = new Size(52, 21);
            rdTen.TabIndex = 16;
            rdTen.TabStop = true;
            rdTen.Text = "Tên";
            rdTen.UseVisualStyleBackColor = true;
            rdTen.CheckedChanged += rdTen_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nudMaGV);
            groupBox1.Controls.Add(dtpNgaySinhGV);
            groupBox1.Controls.Add(txtQueQuanGV);
            groupBox1.Controls.Add(txtTenGV);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtHoGV);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtSODTGV);
            groupBox1.Location = new Point(18, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1113, 178);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Giáo Viên";
            // 
            // nudMaGV
            // 
            nudMaGV.Location = new Point(142, 36);
            nudMaGV.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudMaGV.Name = "nudMaGV";
            nudMaGV.Size = new Size(237, 25);
            nudMaGV.TabIndex = 12;
            // 
            // dtpNgaySinhGV
            // 
            dtpNgaySinhGV.Location = new Point(142, 102);
            dtpNgaySinhGV.Name = "dtpNgaySinhGV";
            dtpNgaySinhGV.Size = new Size(237, 25);
            dtpNgaySinhGV.TabIndex = 10;
            // 
            // nudMa
            // 
            nudMa.Location = new Point(71, 37);
            nudMa.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudMa.Name = "nudMa";
            nudMa.Size = new Size(150, 25);
            nudMa.TabIndex = 11;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(992, 207);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 52);
            btnThoat.TabIndex = 18;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(443, 33);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(67, 27);
            btnTim.TabIndex = 19;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(nudMa);
            groupBox2.Controls.Add(txtTimGV);
            groupBox2.Controls.Add(btnTim);
            groupBox2.Controls.Add(rdMa);
            groupBox2.Controls.Add(rdTen);
            groupBox2.Location = new Point(18, 194);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(516, 70);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm Kiếm";
            // 
            // frmGiaoVien
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 688);
            Controls.Add(groupBox2);
            Controls.Add(btnThoat);
            Controls.Add(groupBox1);
            Controls.Add(btnXoaGV);
            Controls.Add(btnSuaGV);
            Controls.Add(btnThemGV);
            Controls.Add(dgvGiaoVien);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmGiaoVien";
            Text = "Giáo Viên";
            Load += frmGiaoVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGiaoVien).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMaGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMa).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox txtHoGV;
        private TextBox txtTenGV;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private Label label5;

        public DateTimePicker DTPNgaySinhGV { get; private set; }

        private TextBox txtQueQuanGV;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox4;
        private TextBox txtSODTGV;
        private Label label6;
        private Label label7;
        private DataGridView dgvGiaoVien;
        private Button btnThemGV;
        private Button btnSuaGV;
        private Button btnXoaGV;
        private TextBox txtTimGV;
        private RadioButton rdMa;
        private RadioButton rdTen;
        private GroupBox groupBox1;
        private Button btnThoat;
        private DateTimePicker dtpNgaySinhGV;
        private Button btnTim;
        private GroupBox groupBox2;
        private NumericUpDown nudMa;
        private NumericUpDown nudMaGV;
    }
}