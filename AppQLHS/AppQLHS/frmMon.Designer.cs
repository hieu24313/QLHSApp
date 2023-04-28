namespace GUI_QLHSApp
{
    partial class frmMon
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
            txtTenMon = new TextBox();
            nudMaMon = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            rdTen = new RadioButton();
            rdMa = new RadioButton();
            btTim = new Button();
            txtTenMonTK = new TextBox();
            nudMaMonTK = new NumericUpDown();
            btThemMon = new Button();
            btSuaMon = new Button();
            btXoaMon = new Button();
            btThoat = new Button();
            dgvMon = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMaMon).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMaMonTK).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMon).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTenMon);
            groupBox1.Controls.Add(nudMaMon);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(397, 133);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Môn ";
            // 
            // txtTenMon
            // 
            txtTenMon.Location = new Point(128, 83);
            txtTenMon.Margin = new Padding(3, 4, 3, 4);
            txtTenMon.Name = "txtTenMon";
            txtTenMon.Size = new Size(137, 27);
            txtTenMon.TabIndex = 3;
            // 
            // nudMaMon
            // 
            nudMaMon.Location = new Point(128, 29);
            nudMaMon.Margin = new Padding(3, 4, 3, 4);
            nudMaMon.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudMaMon.Name = "nudMaMon";
            nudMaMon.Size = new Size(137, 27);
            nudMaMon.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 93);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên Môn :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 40);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã Môn :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdTen);
            groupBox2.Controls.Add(rdMa);
            groupBox2.Controls.Add(btTim);
            groupBox2.Controls.Add(txtTenMonTK);
            groupBox2.Controls.Add(nudMaMonTK);
            groupBox2.Location = new Point(456, 16);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(397, 133);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm Kiếm ";
            // 
            // rdTen
            // 
            rdTen.AutoSize = true;
            rdTen.Location = new Point(21, 83);
            rdTen.Name = "rdTen";
            rdTen.Size = new Size(87, 24);
            rdTen.TabIndex = 6;
            rdTen.TabStop = true;
            rdTen.Text = "Tên môn";
            rdTen.UseVisualStyleBackColor = true;
            rdTen.CheckedChanged += rdTen_CheckedChanged;
            // 
            // rdMa
            // 
            rdMa.AutoSize = true;
            rdMa.Location = new Point(21, 32);
            rdMa.Name = "rdMa";
            rdMa.Size = new Size(85, 24);
            rdMa.TabIndex = 5;
            rdMa.TabStop = true;
            rdMa.Text = "Mã môn";
            rdMa.UseVisualStyleBackColor = true;
            rdMa.CheckedChanged += rdMa_CheckedChanged;
            // 
            // btTim
            // 
            btTim.Location = new Point(304, 53);
            btTim.Margin = new Padding(3, 4, 3, 4);
            btTim.Name = "btTim";
            btTim.Size = new Size(86, 31);
            btTim.TabIndex = 4;
            btTim.Text = "Tìm ";
            btTim.UseVisualStyleBackColor = true;
            btTim.Click += btTim_Click;
            // 
            // txtTenMonTK
            // 
            txtTenMonTK.Location = new Point(128, 83);
            txtTenMonTK.Margin = new Padding(3, 4, 3, 4);
            txtTenMonTK.Name = "txtTenMonTK";
            txtTenMonTK.Size = new Size(137, 27);
            txtTenMonTK.TabIndex = 3;
            // 
            // nudMaMonTK
            // 
            nudMaMonTK.Location = new Point(128, 29);
            nudMaMonTK.Margin = new Padding(3, 4, 3, 4);
            nudMaMonTK.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudMaMonTK.Name = "nudMaMonTK";
            nudMaMonTK.Size = new Size(137, 27);
            nudMaMonTK.TabIndex = 2;
            // 
            // btThemMon
            // 
            btThemMon.Location = new Point(105, 168);
            btThemMon.Margin = new Padding(3, 4, 3, 4);
            btThemMon.Name = "btThemMon";
            btThemMon.Size = new Size(95, 50);
            btThemMon.TabIndex = 5;
            btThemMon.Text = "Thêm Môn ";
            btThemMon.UseVisualStyleBackColor = true;
            btThemMon.Click += btThemMon_Click;
            // 
            // btSuaMon
            // 
            btSuaMon.Location = new Point(269, 168);
            btSuaMon.Margin = new Padding(3, 4, 3, 4);
            btSuaMon.Name = "btSuaMon";
            btSuaMon.Size = new Size(103, 50);
            btSuaMon.TabIndex = 6;
            btSuaMon.Text = "Sửa Môn";
            btSuaMon.UseVisualStyleBackColor = true;
            btSuaMon.Click += btSuaMon_Click;
            // 
            // btXoaMon
            // 
            btXoaMon.Location = new Point(497, 168);
            btXoaMon.Margin = new Padding(3, 4, 3, 4);
            btXoaMon.Name = "btXoaMon";
            btXoaMon.Size = new Size(101, 50);
            btXoaMon.TabIndex = 7;
            btXoaMon.Text = "Xóa Môn";
            btXoaMon.UseVisualStyleBackColor = true;
            btXoaMon.Click += btXoaMon_Click;
            // 
            // btThoat
            // 
            btThoat.Location = new Point(693, 168);
            btThoat.Margin = new Padding(3, 4, 3, 4);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(107, 50);
            btThoat.TabIndex = 8;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // dgvMon
            // 
            dgvMon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMon.Location = new Point(14, 247);
            dgvMon.Margin = new Padding(3, 4, 3, 4);
            dgvMon.Name = "dgvMon";
            dgvMon.RowHeadersWidth = 51;
            dgvMon.RowTemplate.Height = 25;
            dgvMon.Size = new Size(887, 280);
            dgvMon.TabIndex = 9;
            dgvMon.SelectionChanged += dgvMon_SelectionChanged;
            // 
            // frmMon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(dgvMon);
            Controls.Add(btThoat);
            Controls.Add(btXoaMon);
            Controls.Add(btSuaMon);
            Controls.Add(btThemMon);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMon";
            Text = "Mon";
            Load += frmMon_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMaMon).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMaMonTK).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown nudMaMon;
        private Label label2;
        private Label label1;
        private TextBox txtTenMon;
        private GroupBox groupBox2;
        private Button btTim;
        private TextBox txtTenMonTK;
        private NumericUpDown nudMaMonTK;
        private Button btThemMon;
        private Button btSuaMon;
        private Button btXoaMon;
        private Button btThoat;
        private DataGridView dgvMon;
        private RadioButton rdTen;
        private RadioButton rdMa;
    }
}