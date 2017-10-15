namespace BaiGiuaKy_PhanVanVuong
{
    partial class FrmReadBitmapFile
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listPath = new System.Windows.Forms.ListBox();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.txtHeader = new System.Windows.Forms.RichTextBox();
            this.txtInformation = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(404, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 182);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // listPath
            // 
            this.listPath.FormattingEnabled = true;
            this.listPath.Location = new System.Drawing.Point(23, 12);
            this.listPath.Name = "listPath";
            this.listPath.Size = new System.Drawing.Size(260, 108);
            this.listPath.TabIndex = 2;
            this.listPath.SelectedValueChanged += new System.EventHandler(this.listPath_SelectedValueChanged);
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(311, 52);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(75, 23);
            this.btnChooseFile.TabIndex = 3;
            this.btnChooseFile.Text = "Chọn BMP";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // txtHeader
            // 
            this.txtHeader.Location = new System.Drawing.Point(23, 262);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.ReadOnly = true;
            this.txtHeader.Size = new System.Drawing.Size(238, 159);
            this.txtHeader.TabIndex = 4;
            this.txtHeader.Text = "";
            // 
            // txtInformation
            // 
            this.txtInformation.Location = new System.Drawing.Point(347, 262);
            this.txtInformation.Name = "txtInformation";
            this.txtInformation.ReadOnly = true;
            this.txtInformation.Size = new System.Drawing.Size(238, 159);
            this.txtInformation.TabIndex = 5;
            this.txtInformation.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "File Header";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "File Information";
            // 
            // FrmReadBitmapFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 442);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInformation);
            this.Controls.Add(this.txtHeader);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.listPath);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmReadBitmapFile";
            this.Text = "Read File Bitmap";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listPath;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.RichTextBox txtHeader;
        private System.Windows.Forms.RichTextBox txtInformation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

