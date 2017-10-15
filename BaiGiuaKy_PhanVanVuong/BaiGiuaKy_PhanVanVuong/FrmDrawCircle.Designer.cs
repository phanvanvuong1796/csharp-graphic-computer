namespace BaiGiuaKy_PhanVanVuong
{
    partial class FrmDrawCircle
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
            this.ptbDraw = new System.Windows.Forms.PictureBox();
            this.btnDecac = new System.Windows.Forms.Button();
            this.btnTDC = new System.Windows.Forms.Button();
            this.btnMidPoint = new System.Windows.Forms.Button();
            this.btnDrawElipse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtDecac = new System.Windows.Forms.RadioButton();
            this.rbtToaDoCuc = new System.Windows.Forms.RadioButton();
            this.rbtMidPoint = new System.Windows.Forms.RadioButton();
            this.rbtElipse = new System.Windows.Forms.RadioButton();
            this.txtBanKinh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDraw)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptbDraw
            // 
            this.ptbDraw.Location = new System.Drawing.Point(190, 12);
            this.ptbDraw.Name = "ptbDraw";
            this.ptbDraw.Size = new System.Drawing.Size(630, 459);
            this.ptbDraw.TabIndex = 0;
            this.ptbDraw.TabStop = false;
            this.ptbDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ptbDraw_MouseDown);
            this.ptbDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptbDraw_MouseMove);
            this.ptbDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ptbDraw_MouseUp);
            // 
            // btnDecac
            // 
            this.btnDecac.Location = new System.Drawing.Point(50, 239);
            this.btnDecac.Name = "btnDecac";
            this.btnDecac.Size = new System.Drawing.Size(93, 38);
            this.btnDecac.TabIndex = 2;
            this.btnDecac.Text = "Draw decac";
            this.btnDecac.UseVisualStyleBackColor = true;
            this.btnDecac.Click += new System.EventHandler(this.btnDecac_Click);
            // 
            // btnTDC
            // 
            this.btnTDC.Location = new System.Drawing.Point(50, 304);
            this.btnTDC.Name = "btnTDC";
            this.btnTDC.Size = new System.Drawing.Size(93, 42);
            this.btnTDC.TabIndex = 3;
            this.btnTDC.Text = "Draw Toa do cuc";
            this.btnTDC.UseVisualStyleBackColor = true;
            this.btnTDC.Click += new System.EventHandler(this.btnTDC_Click);
            // 
            // btnMidPoint
            // 
            this.btnMidPoint.Location = new System.Drawing.Point(50, 373);
            this.btnMidPoint.Name = "btnMidPoint";
            this.btnMidPoint.Size = new System.Drawing.Size(93, 35);
            this.btnMidPoint.TabIndex = 4;
            this.btnMidPoint.Text = "Draw mid point";
            this.btnMidPoint.UseVisualStyleBackColor = true;
            this.btnMidPoint.Click += new System.EventHandler(this.btnMidPoint_Click);
            // 
            // btnDrawElipse
            // 
            this.btnDrawElipse.Location = new System.Drawing.Point(50, 435);
            this.btnDrawElipse.Name = "btnDrawElipse";
            this.btnDrawElipse.Size = new System.Drawing.Size(93, 35);
            this.btnDrawElipse.TabIndex = 5;
            this.btnDrawElipse.Text = "Draw Elipse";
            this.btnDrawElipse.UseVisualStyleBackColor = true;
            this.btnDrawElipse.Click += new System.EventHandler(this.btnDrawElipse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBanKinh);
            this.groupBox1.Controls.Add(this.rbtElipse);
            this.groupBox1.Controls.Add(this.rbtMidPoint);
            this.groupBox1.Controls.Add(this.rbtToaDoCuc);
            this.groupBox1.Controls.Add(this.rbtDecac);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 193);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // rbtDecac
            // 
            this.rbtDecac.AutoSize = true;
            this.rbtDecac.Checked = true;
            this.rbtDecac.Location = new System.Drawing.Point(34, 88);
            this.rbtDecac.Name = "rbtDecac";
            this.rbtDecac.Size = new System.Drawing.Size(85, 17);
            this.rbtDecac.TabIndex = 0;
            this.rbtDecac.TabStop = true;
            this.rbtDecac.Text = "Draw Decac";
            this.rbtDecac.UseVisualStyleBackColor = true;
            this.rbtDecac.CheckedChanged += new System.EventHandler(this.rbtDecac_CheckedChanged);
            // 
            // rbtToaDoCuc
            // 
            this.rbtToaDoCuc.AutoSize = true;
            this.rbtToaDoCuc.Location = new System.Drawing.Point(34, 111);
            this.rbtToaDoCuc.Name = "rbtToaDoCuc";
            this.rbtToaDoCuc.Size = new System.Drawing.Size(111, 17);
            this.rbtToaDoCuc.TabIndex = 1;
            this.rbtToaDoCuc.Text = "Draw Toa Do Cuc";
            this.rbtToaDoCuc.UseVisualStyleBackColor = true;
            this.rbtToaDoCuc.CheckedChanged += new System.EventHandler(this.rbtToaDoCuc_CheckedChanged);
            // 
            // rbtMidPoint
            // 
            this.rbtMidPoint.AutoSize = true;
            this.rbtMidPoint.Location = new System.Drawing.Point(34, 134);
            this.rbtMidPoint.Name = "rbtMidPoint";
            this.rbtMidPoint.Size = new System.Drawing.Size(97, 17);
            this.rbtMidPoint.TabIndex = 2;
            this.rbtMidPoint.Text = "Draw Mid Point";
            this.rbtMidPoint.UseVisualStyleBackColor = true;
            this.rbtMidPoint.CheckedChanged += new System.EventHandler(this.rbtMidPoint_CheckedChanged);
            // 
            // rbtElipse
            // 
            this.rbtElipse.AutoSize = true;
            this.rbtElipse.Location = new System.Drawing.Point(34, 157);
            this.rbtElipse.Name = "rbtElipse";
            this.rbtElipse.Size = new System.Drawing.Size(81, 17);
            this.rbtElipse.TabIndex = 3;
            this.rbtElipse.Text = "Draw Elipse";
            this.rbtElipse.UseVisualStyleBackColor = true;
            this.rbtElipse.CheckedChanged += new System.EventHandler(this.rbtElipse_CheckedChanged);
            // 
            // txtBanKinh
            // 
            this.txtBanKinh.Location = new System.Drawing.Point(88, 36);
            this.txtBanKinh.Name = "txtBanKinh";
            this.txtBanKinh.Size = new System.Drawing.Size(65, 20);
            this.txtBanKinh.TabIndex = 4;
            this.txtBanKinh.TextChanged += new System.EventHandler(this.txtBanKinh_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bán kính";
            // 
            // FrmDrawCircle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 483);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDrawElipse);
            this.Controls.Add(this.btnMidPoint);
            this.Controls.Add(this.btnTDC);
            this.Controls.Add(this.btnDecac);
            this.Controls.Add(this.ptbDraw);
            this.Name = "FrmDrawCircle";
            this.Text = "Draw Circle";
            this.Load += new System.EventHandler(this.FrmDrawCircle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbDraw)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbDraw;
        private System.Windows.Forms.Button btnDecac;
        private System.Windows.Forms.Button btnTDC;
        private System.Windows.Forms.Button btnMidPoint;
        private System.Windows.Forms.Button btnDrawElipse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtElipse;
        private System.Windows.Forms.RadioButton rbtMidPoint;
        private System.Windows.Forms.RadioButton rbtToaDoCuc;
        private System.Windows.Forms.RadioButton rbtDecac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBanKinh;
    }
}

