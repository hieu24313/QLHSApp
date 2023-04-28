namespace QLHSApp
{
    partial class frmTrangChu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrangChu));
            menuStrip1 = new MenuStrip();
            menuItemQLHS = new ToolStripMenuItem();
            menuItemQLLOP = new ToolStripMenuItem();
            menuItemQLMON = new ToolStripMenuItem();
            menuItemGV = new ToolStripMenuItem();
            menuItemLD = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuItemQLHS, menuItemQLLOP, menuItemQLMON, menuItemGV, menuItemLD });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(853, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuItemQLHS
            // 
            menuItemQLHS.Name = "menuItemQLHS";
            menuItemQLHS.Size = new Size(138, 24);
            menuItemQLHS.Text = "Quản Lý Học Sinh";
            menuItemQLHS.Click += menuItemHS_Click;
            // 
            // menuItemQLLOP
            // 
            menuItemQLLOP.Name = "menuItemQLLOP";
            menuItemQLLOP.Size = new Size(104, 24);
            menuItemQLLOP.Text = "Quản Lý Lớp";
            menuItemQLLOP.Click += menuItemQLLOP_Click;
            // 
            // menuItemQLMON
            // 
            menuItemQLMON.Name = "menuItemQLMON";
            menuItemQLMON.Size = new Size(109, 24);
            menuItemQLMON.Text = "Quản Lý Môn";
            menuItemQLMON.Click += menuItemMon_Click;
            // 
            // menuItemGV
            // 
            menuItemGV.Name = "menuItemGV";
            menuItemGV.Size = new Size(87, 24);
            menuItemGV.Text = "Giáo Viên";
            menuItemGV.Click += menuItemGV_Click;
            // 
            // menuItemLD
            // 
            menuItemLD.Name = "menuItemLD";
            menuItemLD.Size = new Size(91, 24);
            menuItemLD.Text = "Loại Điểm";
            menuItemLD.Click += menuItemLD_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 139);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(825, 333);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(125, 68);
            label1.Name = "label1";
            label1.Size = new Size(654, 62);
            label1.TabIndex = 3;
            label1.Text = "Ứng Dụng Quản Lý Học Sinh";
            // 
            // frmTrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(853, 485);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmTrangChu";
            Text = "Quản Lý Học Sinh";
            Load += frmTrangChu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuItemQLHS;
        private ToolStripMenuItem menuItemQLLOP;
        private ToolStripMenuItem menuItemQLMON;
        private ToolStripMenuItem menuItemGV;
        private ToolStripMenuItem menuItemLD;
        private PictureBox pictureBox1;
        private Label label1;
    }
}