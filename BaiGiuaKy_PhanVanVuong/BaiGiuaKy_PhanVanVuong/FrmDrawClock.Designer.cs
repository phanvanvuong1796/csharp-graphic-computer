namespace BaiGiuaKy_PhanVanVuong
{
    partial class FrmDrawClock
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
            this.components = new System.ComponentModel.Container();
            this.ptbBackground = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptbBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbBackground
            // 
            this.ptbBackground.Image = global::BaiGiuaKy_PhanVanVuong.Properties.Resources.BaseClock;
            this.ptbBackground.Location = new System.Drawing.Point(12, 12);
            this.ptbBackground.Name = "ptbBackground";
            this.ptbBackground.Size = new System.Drawing.Size(500, 500);
            this.ptbBackground.TabIndex = 0;
            this.ptbBackground.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FrmDrawClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 524);
            this.Controls.Add(this.ptbBackground);
            this.Name = "FrmDrawClock";
            this.Text = "DrawClock";
            this.Load += new System.EventHandler(this.FrmDrawClock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbBackground;
        private System.Windows.Forms.Timer timer;
    }
}