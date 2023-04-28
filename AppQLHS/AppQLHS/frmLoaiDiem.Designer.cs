namespace GUI_QLHSApp
{
    partial class frmLoaiDiem
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            nudMaLD = new NumericUpDown();
            txtTen = new TextBox();
            txtMoTa = new TextBox();
            btnThoatLD = new Button();
            btnXoaLD = new Button();
            btnSuaLD = new Button();
            btnThemLD = new Button();
            groupBox2 = new GroupBox();
            btTimKiem = new Button();
            nudMaTK = new NumericUpDown();
            txtTenLoaiDiem = new TextBox();
            btnTim = new Button();
            rdMa = new RadioButton();
            rdTen = new RadioButton();
            groupBox1 = new GroupBox();
            txtHeSo = new TextBox();
            dgvLoaiDiem = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nudMaLD).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMaTK).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiDiem).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 36);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã Loại Điểm :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 85);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 1;
            label2.Text = "Mô Tả :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(327, 92);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 2;
            label3.Text = "Hệ Số :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(342, 36);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 3;
            label4.Text = "Tên :";
            // 
            // nudMaLD
            // 
            nudMaLD.Location = new Point(127, 33);
            nudMaLD.Margin = new Padding(3, 4, 3, 4);
            nudMaLD.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudMaLD.Name = "nudMaLD";
            nudMaLD.Size = new Size(137, 27);
            nudMaLD.TabIndex = 4;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(384, 29);
            txtTen.Margin = new Padding(3, 4, 3, 4);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(114, 27);
            txtTen.TabIndex = 5;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(127, 85);
            txtMoTa.Margin = new Padding(3, 4, 3, 4);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(177, 27);
            txtMoTa.TabIndex = 6;
            // 
            // btnThoatLD
            // 
            btnThoatLD.Location = new Point(865, 203);
            btnThoatLD.Margin = new Padding(3, 4, 3, 4);
            btnThoatLD.Name = "btnThoatLD";
            btnThoatLD.Size = new Size(107, 69);
            btnThoatLD.TabIndex = 23;
            btnThoatLD.Text = "Thoát";
            btnThoatLD.UseVisualStyleBackColor = true;
            btnThoatLD.Click += btnThoatLD_Click;
            // 
            // btnXoaLD
            // 
            btnXoaLD.Location = new Point(360, 203);
            btnXoaLD.Margin = new Padding(3, 4, 3, 4);
            btnXoaLD.Name = "btnXoaLD";
            btnXoaLD.Size = new Size(107, 69);
            btnXoaLD.TabIndex = 22;
            btnXoaLD.Text = "Xóa Loại Điểm";
            btnXoaLD.UseVisualStyleBackColor = true;
            btnXoaLD.Click += btnXoaLD_Click;
            // 
            // btnSuaLD
            // 
            btnSuaLD.Location = new Point(594, 203);
            btnSuaLD.Margin = new Padding(3, 4, 3, 4);
            btnSuaLD.Name = "btnSuaLD";
            btnSuaLD.Size = new Size(107, 69);
            btnSuaLD.TabIndex = 21;
            btnSuaLD.Text = "Sửa Loại Điểm ";
            btnSuaLD.UseVisualStyleBackColor = true;
            btnSuaLD.Click += btnSuaLD_Click;
            // 
            // btnThemLD
            // 
            btnThemLD.Location = new Point(78, 203);
            btnThemLD.Margin = new Padding(3, 4, 3, 4);
            btnThemLD.Name = "btnThemLD";
            btnThemLD.Size = new Size(107, 69);
            btnThemLD.TabIndex = 20;
            btnThemLD.Text = "Thêm Loại Điểm";
            btnThemLD.UseVisualStyleBackColor = true;
            btnThemLD.Click += btnThemLD_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btTimKiem);
            groupBox2.Controls.Add(nudMaTK);
            groupBox2.Controls.Add(txtTenLoaiDiem);
            groupBox2.Controls.Add(btnTim);
            groupBox2.Controls.Add(rdMa);
            groupBox2.Controls.Add(rdTen);
            groupBox2.Location = new Point(558, 16);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(485, 133);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm Kiếm";
            // 
            // btTimKiem
            // 
            btTimKiem.Location = new Point(211, 92);
            btTimKiem.Margin = new Padding(3, 4, 3, 4);
            btTimKiem.Name = "btTimKiem";
            btTimKiem.Size = new Size(75, 36);
            btTimKiem.TabIndex = 24;
            btTimKiem.Text = "Tìm Kiếm";
            btTimKiem.UseVisualStyleBackColor = true;
            btTimKiem.Click += btTimKiem_Click;
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
            // txtTenLoaiDiem
            // 
            txtTenLoaiDiem.Location = new Point(337, 44);
            txtTenLoaiDiem.Margin = new Padding(3, 4, 3, 4);
            txtTenLoaiDiem.Name = "txtTenLoaiDiem";
            txtTenLoaiDiem.Size = new Size(105, 27);
            txtTenLoaiDiem.TabIndex = 14;
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
            rdTen.Location = new Point(271, 49);
            rdTen.Margin = new Padding(3, 4, 3, 4);
            rdTen.Name = "rdTen";
            rdTen.Size = new Size(53, 24);
            rdTen.TabIndex = 16;
            rdTen.TabStop = true;
            rdTen.Text = "Tên";
            rdTen.UseVisualStyleBackColor = true;
            rdTen.CheckedChanged += rdTen_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtHeSo);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(nudMaLD);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtMoTa);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(537, 133);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Loại Điểm";
            // 
            // txtHeSo
            // 
            txtHeSo.Location = new Point(389, 92);
            txtHeSo.Margin = new Padding(3, 4, 3, 4);
            txtHeSo.Name = "txtHeSo";
            txtHeSo.Size = new Size(114, 27);
            txtHeSo.TabIndex = 7;
            // 
            // dgvLoaiDiem
            // 
            dgvLoaiDiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoaiDiem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiDiem.Location = new Point(14, 280);
            dgvLoaiDiem.Margin = new Padding(3, 4, 3, 4);
            dgvLoaiDiem.Name = "dgvLoaiDiem";
            dgvLoaiDiem.RowHeadersWidth = 51;
            dgvLoaiDiem.RowTemplate.Height = 25;
            dgvLoaiDiem.Size = new Size(1029, 212);
            dgvLoaiDiem.TabIndex = 26;
            dgvLoaiDiem.SelectionChanged += dgvLoaiDiem_SelectionChanged;
            // 
            // frmLoaiDiem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 497);
            Controls.Add(dgvLoaiDiem);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(btnThoatLD);
            Controls.Add(btnXoaLD);
            Controls.Add(btnSuaLD);
            Controls.Add(btnThemLD);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmLoaiDiem";
            Text = "LoaiDiem";
            Load += frmLoaiDiem_Load;
            ((System.ComponentModel.ISupportInitialize)nudMaLD).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMaTK).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiDiem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown nudMaLD;
        private TextBox txtTen;
        private TextBox txtMoTa;
        private Button btnThoatLD;
        private Button btnXoaLD;
        private Button btnSuaLD;
        private Button btnThemLD;
        private GroupBox groupBox2;
        private NumericUpDown nudMaTK;
        private TextBox txtTenLoaiDiem;
        private Button btnTim;
        private RadioButton rdMa;
        private RadioButton rdTen;
        private GroupBox groupBox1;
        private DataGridView dgvLoaiDiem;
        private Button btTimKiem;
        private TextBox txtHeSo;
    }
}