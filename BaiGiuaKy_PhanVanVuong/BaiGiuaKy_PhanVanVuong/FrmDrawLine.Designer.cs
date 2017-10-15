namespace BaiGiuaKy_PhanVanVuong
{
    partial class FrmDrawLine
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
            this.tbXa = new System.Windows.Forms.TextBox();
            this.tbYa = new System.Windows.Forms.TextBox();
            this.tbYb = new System.Windows.Forms.TextBox();
            this.tbXb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDDA = new System.Windows.Forms.Button();
            this.btnBresenham = new System.Windows.Forms.Button();
            this.btnMidPoint = new System.Windows.Forms.Button();
            this.btnLineDut = new System.Windows.Forms.Button();
            this.btnLineTrans = new System.Windows.Forms.Button();
            this.btnLineBold = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbDraw
            // 
            this.ptbDraw.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ptbDraw.Location = new System.Drawing.Point(236, 12);
            this.ptbDraw.Name = "ptbDraw";
            this.ptbDraw.Size = new System.Drawing.Size(724, 468);
            this.ptbDraw.TabIndex = 0;
            this.ptbDraw.TabStop = false;
            // 
            // tbXa
            // 
            this.tbXa.Location = new System.Drawing.Point(53, 56);
            this.tbXa.Name = "tbXa";
            this.tbXa.Size = new System.Drawing.Size(55, 20);
            this.tbXa.TabIndex = 1;
            // 
            // tbYa
            // 
            this.tbYa.Location = new System.Drawing.Point(160, 56);
            this.tbYa.Name = "tbYa";
            this.tbYa.Size = new System.Drawing.Size(55, 20);
            this.tbYa.TabIndex = 2;
            // 
            // tbYb
            // 
            this.tbYb.Location = new System.Drawing.Point(160, 134);
            this.tbYb.Name = "tbYb";
            this.tbYb.Size = new System.Drawing.Size(55, 20);
            this.tbYb.TabIndex = 4;
            // 
            // tbXb
            // 
            this.tbXb.Location = new System.Drawing.Point(53, 134);
            this.tbXb.Name = "tbXb";
            this.tbXb.Size = new System.Drawing.Size(55, 20);
            this.tbXb.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Điểm A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Điểm B";
            // 
            // btnDDA
            // 
            this.btnDDA.Location = new System.Drawing.Point(53, 187);
            this.btnDDA.Name = "btnDDA";
            this.btnDDA.Size = new System.Drawing.Size(119, 23);
            this.btnDDA.TabIndex = 11;
            this.btnDDA.Text = "Vẽ DDA đối xứng";
            this.btnDDA.UseVisualStyleBackColor = true;
            this.btnDDA.Click += new System.EventHandler(this.btnDDA_Click);
            // 
            // btnBresenham
            // 
            this.btnBresenham.Location = new System.Drawing.Point(53, 233);
            this.btnBresenham.Name = "btnBresenham";
            this.btnBresenham.Size = new System.Drawing.Size(119, 23);
            this.btnBresenham.TabIndex = 12;
            this.btnBresenham.Text = "Vẽ Bresenham";
            this.btnBresenham.UseVisualStyleBackColor = true;
            this.btnBresenham.Click += new System.EventHandler(this.btnBresenham_Click);
            // 
            // btnMidPoint
            // 
            this.btnMidPoint.Location = new System.Drawing.Point(53, 286);
            this.btnMidPoint.Name = "btnMidPoint";
            this.btnMidPoint.Size = new System.Drawing.Size(119, 23);
            this.btnMidPoint.TabIndex = 13;
            this.btnMidPoint.Text = "Vẽ MidPoint";
            this.btnMidPoint.UseVisualStyleBackColor = true;
            this.btnMidPoint.Click += new System.EventHandler(this.btnMidPoint_Click);
            // 
            // btnLineDut
            // 
            this.btnLineDut.Location = new System.Drawing.Point(53, 339);
            this.btnLineDut.Name = "btnLineDut";
            this.btnLineDut.Size = new System.Drawing.Size(119, 23);
            this.btnLineDut.TabIndex = 14;
            this.btnLineDut.Text = "Vẽ nét đứt";
            this.btnLineDut.UseVisualStyleBackColor = true;
            this.btnLineDut.Click += new System.EventHandler(this.btnLineDut_Click);
            // 
            // btnLineTrans
            // 
            this.btnLineTrans.Location = new System.Drawing.Point(53, 388);
            this.btnLineTrans.Name = "btnLineTrans";
            this.btnLineTrans.Size = new System.Drawing.Size(119, 23);
            this.btnLineTrans.TabIndex = 15;
            this.btnLineTrans.Text = "Vẽ nét mờ";
            this.btnLineTrans.UseVisualStyleBackColor = true;
            this.btnLineTrans.Click += new System.EventHandler(this.btnLineTrans_Click);
            // 
            // btnLineBold
            // 
            this.btnLineBold.Location = new System.Drawing.Point(53, 440);
            this.btnLineBold.Name = "btnLineBold";
            this.btnLineBold.Size = new System.Drawing.Size(119, 23);
            this.btnLineBold.TabIndex = 16;
            this.btnLineBold.Text = "Vẽ nét đậm";
            this.btnLineBold.UseVisualStyleBackColor = true;
            this.btnLineBold.Click += new System.EventHandler(this.btnLineBold_Click);
            // 
            // FrmDrawLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 492);
            this.Controls.Add(this.btnLineBold);
            this.Controls.Add(this.btnLineTrans);
            this.Controls.Add(this.btnLineDut);
            this.Controls.Add(this.btnMidPoint);
            this.Controls.Add(this.btnBresenham);
            this.Controls.Add(this.btnDDA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbYb);
            this.Controls.Add(this.tbXb);
            this.Controls.Add(this.tbYa);
            this.Controls.Add(this.tbXa);
            this.Controls.Add(this.ptbDraw);
            this.Name = "FrmDrawLine";
            this.Text = "Vẽ đường thẳng";
            this.Load += new System.EventHandler(this.FrmDrawLine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbDraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbDraw;
        private System.Windows.Forms.TextBox tbXa;
        private System.Windows.Forms.TextBox tbYa;
        private System.Windows.Forms.TextBox tbYb;
        private System.Windows.Forms.TextBox tbXb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDDA;
        private System.Windows.Forms.Button btnBresenham;
        private System.Windows.Forms.Button btnMidPoint;
        private System.Windows.Forms.Button btnLineDut;
        private System.Windows.Forms.Button btnLineTrans;
        private System.Windows.Forms.Button btnLineBold;
    }
}

