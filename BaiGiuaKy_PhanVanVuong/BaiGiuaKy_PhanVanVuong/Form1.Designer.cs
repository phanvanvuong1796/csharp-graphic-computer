﻿namespace BaiGiuaKy_PhanVanVuong
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReadBitmap = new System.Windows.Forms.Button();
            this.btnDrawLine = new System.Windows.Forms.Button();
            this.btnDrawCircle = new System.Windows.Forms.Button();
            this.btnChangeRGB = new System.Windows.Forms.Button();
            this.btnDrawClock = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lớp: DPT13";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sinh viên: 14151561";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên: Phan Văn Vượng";
            // 
            // btnReadBitmap
            // 
            this.btnReadBitmap.Location = new System.Drawing.Point(179, 165);
            this.btnReadBitmap.Name = "btnReadBitmap";
            this.btnReadBitmap.Size = new System.Drawing.Size(105, 31);
            this.btnReadBitmap.TabIndex = 2;
            this.btnReadBitmap.Text = "Read Bitmap file";
            this.btnReadBitmap.UseVisualStyleBackColor = true;
            this.btnReadBitmap.Click += new System.EventHandler(this.btnReadBitmap_Click);
            // 
            // btnDrawLine
            // 
            this.btnDrawLine.Location = new System.Drawing.Point(31, 222);
            this.btnDrawLine.Name = "btnDrawLine";
            this.btnDrawLine.Size = new System.Drawing.Size(105, 31);
            this.btnDrawLine.TabIndex = 3;
            this.btnDrawLine.Text = "Draw Line";
            this.btnDrawLine.UseVisualStyleBackColor = true;
            this.btnDrawLine.Click += new System.EventHandler(this.btnDrawLine_Click);
            // 
            // btnDrawCircle
            // 
            this.btnDrawCircle.Location = new System.Drawing.Point(179, 222);
            this.btnDrawCircle.Name = "btnDrawCircle";
            this.btnDrawCircle.Size = new System.Drawing.Size(105, 31);
            this.btnDrawCircle.TabIndex = 4;
            this.btnDrawCircle.Text = "Draw Circle";
            this.btnDrawCircle.UseVisualStyleBackColor = true;
            this.btnDrawCircle.Click += new System.EventHandler(this.btnDrawCircle_Click);
            // 
            // btnChangeRGB
            // 
            this.btnChangeRGB.Location = new System.Drawing.Point(31, 165);
            this.btnChangeRGB.Name = "btnChangeRGB";
            this.btnChangeRGB.Size = new System.Drawing.Size(105, 31);
            this.btnChangeRGB.TabIndex = 5;
            this.btnChangeRGB.Text = "Change RGB";
            this.btnChangeRGB.UseVisualStyleBackColor = true;
            this.btnChangeRGB.Click += new System.EventHandler(this.btnChangeRGB_Click);
            // 
            // btnDrawClock
            // 
            this.btnDrawClock.Location = new System.Drawing.Point(31, 282);
            this.btnDrawClock.Name = "btnDrawClock";
            this.btnDrawClock.Size = new System.Drawing.Size(105, 31);
            this.btnDrawClock.TabIndex = 6;
            this.btnDrawClock.Text = "Draw Clock";
            this.btnDrawClock.UseVisualStyleBackColor = true;
            this.btnDrawClock.Click += new System.EventHandler(this.btnDrawClock_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 354);
            this.Controls.Add(this.btnDrawClock);
            this.Controls.Add(this.btnChangeRGB);
            this.Controls.Add(this.btnDrawCircle);
            this.Controls.Add(this.btnDrawLine);
            this.Controls.Add(this.btnReadBitmap);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Bài giữa kỳ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReadBitmap;
        private System.Windows.Forms.Button btnDrawLine;
        private System.Windows.Forms.Button btnDrawCircle;
        private System.Windows.Forms.Button btnChangeRGB;
        private System.Windows.Forms.Button btnDrawClock;
    }
}

