namespace AppQLHS
{
    partial class frmChiTietDiem
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
            dgvDiem = new DataGridView();
            label2 = new Label();
            lbHoTen = new Label();
            label3 = new Label();
            lbLop = new Label();
            cbMon = new ComboBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDiem).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(949, 57);
            label1.TabIndex = 0;
            label1.Text = "CHI TIẾT ĐIỂM CỦA HỌC SINH";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvDiem
            // 
            dgvDiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDiem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiem.Location = new Point(12, 226);
            dgvDiem.Name = "dgvDiem";
            dgvDiem.RowHeadersWidth = 51;
            dgvDiem.RowTemplate.Height = 29;
            dgvDiem.Size = new Size(925, 311);
            dgvDiem.TabIndex = 1;
            // 
            // label2
            // 
            label2.Location = new Point(66, 54);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 2;
            label2.Text = "Tên Học Sinh:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbHoTen
            // 
            lbHoTen.Location = new Point(173, 57);
            lbHoTen.Name = "lbHoTen";
            lbHoTen.Size = new Size(261, 25);
            lbHoTen.TabIndex = 3;
            lbHoTen.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Location = new Point(66, 116);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 2;
            label3.Text = "Lớp:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbLop
            // 
            lbLop.Location = new Point(173, 119);
            lbLop.Name = "lbLop";
            lbLop.Size = new Size(106, 25);
            lbLop.TabIndex = 3;
            lbLop.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbMon
            // 
            cbMon.FormattingEnabled = true;
            cbMon.Location = new Point(572, 56);
            cbMon.Name = "cbMon";
            cbMon.Size = new Size(151, 28);
            cbMon.TabIndex = 4;
            cbMon.SelectedIndexChanged += cbMon_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.Location = new Point(517, 60);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 5;
            label4.Text = "Môn:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmChiTietDiem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 549);
            Controls.Add(label4);
            Controls.Add(cbMon);
            Controls.Add(lbLop);
            Controls.Add(label3);
            Controls.Add(lbHoTen);
            Controls.Add(label2);
            Controls.Add(dgvDiem);
            Controls.Add(label1);
            MaximumSize = new Size(967, 596);
            MinimumSize = new Size(967, 596);
            Name = "frmChiTietDiem";
            Text = "frmChiTietDiem";
            Load += frmChiTietDiem_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDiem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dgvDiem;
        private Label label2;
        private Label lbHoTen;
        private Label label3;
        private Label lbLop;
        private ComboBox cbMon;
        private Label label4;
    }
}