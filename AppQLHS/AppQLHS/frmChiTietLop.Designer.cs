namespace AppQLHS
{
    partial class frmChiTietLop
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
            dgvChiTietLop = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            lbTenLop = new Label();
            label3 = new Label();
            lbGVCN = new Label();
            label5 = new Label();
            lbNamHoc = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietLop).BeginInit();
            SuspendLayout();
            // 
            // dgvChiTietLop
            // 
            dgvChiTietLop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTietLop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietLop.Location = new Point(12, 228);
            dgvChiTietLop.Name = "dgvChiTietLop";
            dgvChiTietLop.RowHeadersWidth = 51;
            dgvChiTietLop.RowTemplate.Height = 29;
            dgvChiTietLop.Size = new Size(842, 325);
            dgvChiTietLop.TabIndex = 0;
            dgvChiTietLop.DoubleClick += dgvChiTietLop_DoubleClick;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(868, 73);
            label1.TabIndex = 1;
            label1.Text = "CHI TIẾT LỚP HỌC";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(31, 73);
            label2.Name = "label2";
            label2.Size = new Size(107, 41);
            label2.TabIndex = 2;
            label2.Text = "Tên Lớp:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbTenLop
            // 
            lbTenLop.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbTenLop.Location = new Point(118, 73);
            lbTenLop.Name = "lbTenLop";
            lbTenLop.Size = new Size(271, 41);
            lbTenLop.TabIndex = 3;
            lbTenLop.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(31, 137);
            label3.Name = "label3";
            label3.Size = new Size(81, 41);
            label3.TabIndex = 2;
            label3.Text = "GVCN:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbGVCN
            // 
            lbGVCN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbGVCN.Location = new Point(118, 137);
            lbGVCN.Name = "lbGVCN";
            lbGVCN.Size = new Size(271, 41);
            lbGVCN.TabIndex = 3;
            lbGVCN.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(395, 73);
            label5.Name = "label5";
            label5.Size = new Size(112, 41);
            label5.TabIndex = 2;
            label5.Text = "Năm Học:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbNamHoc
            // 
            lbNamHoc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbNamHoc.Location = new Point(527, 73);
            lbNamHoc.Name = "lbNamHoc";
            lbNamHoc.Size = new Size(314, 41);
            lbNamHoc.TabIndex = 3;
            lbNamHoc.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmChiTietLop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 565);
            Controls.Add(lbNamHoc);
            Controls.Add(lbGVCN);
            Controls.Add(lbTenLop);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvChiTietLop);
            Name = "frmChiTietLop";
            Text = "frmChiTietLop";
            Load += frmChiTietLop_Load;
            ((System.ComponentModel.ISupportInitialize)dgvChiTietLop).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvChiTietLop;
        private Label label1;
        private Label label2;
        private Label lbTenLop;
        private Label label3;
        private Label lbGVCN;
        private Label label5;
        private Label lbNamHoc;
    }
}