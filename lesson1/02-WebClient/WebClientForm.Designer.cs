namespace _02_WebClient
{
    partial class WebClientForm
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
            this.btnDownloadImage = new System.Windows.Forms.Button();
            this.btnDownloadBigImage = new System.Windows.Forms.Button();
            this.ImageContainer = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDownloadingTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImageContainer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDownloadImage
            // 
            this.btnDownloadImage.Location = new System.Drawing.Point(12, 12);
            this.btnDownloadImage.Name = "btnDownloadImage";
            this.btnDownloadImage.Size = new System.Drawing.Size(126, 23);
            this.btnDownloadImage.TabIndex = 0;
            this.btnDownloadImage.Text = "Download image";
            this.btnDownloadImage.UseVisualStyleBackColor = true;
            this.btnDownloadImage.Click += new System.EventHandler(this.btnLoadIamge_Click);
            // 
            // btnDownloadBigImage
            // 
            this.btnDownloadBigImage.Location = new System.Drawing.Point(155, 12);
            this.btnDownloadBigImage.Name = "btnDownloadBigImage";
            this.btnDownloadBigImage.Size = new System.Drawing.Size(128, 23);
            this.btnDownloadBigImage.TabIndex = 1;
            this.btnDownloadBigImage.Text = "Download big image";
            this.btnDownloadBigImage.UseVisualStyleBackColor = true;
            this.btnDownloadBigImage.Click += new System.EventHandler(this.btnDownloadBigImage_Click);
            // 
            // ImageContainer
            // 
            this.ImageContainer.Location = new System.Drawing.Point(12, 70);
            this.ImageContainer.Name = "ImageContainer";
            this.ImageContainer.Size = new System.Drawing.Size(271, 249);
            this.ImageContainer.TabIndex = 2;
            this.ImageContainer.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Downloading time:";
            // 
            // lblDownloadingTime
            // 
            this.lblDownloadingTime.AutoSize = true;
            this.lblDownloadingTime.Location = new System.Drawing.Point(112, 54);
            this.lblDownloadingTime.Name = "lblDownloadingTime";
            this.lblDownloadingTime.Size = new System.Drawing.Size(0, 13);
            this.lblDownloadingTime.TabIndex = 4;
            // 
            // WebClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 332);
            this.Controls.Add(this.lblDownloadingTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImageContainer);
            this.Controls.Add(this.btnDownloadBigImage);
            this.Controls.Add(this.btnDownloadImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "WebClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Web client";
            ((System.ComponentModel.ISupportInitialize)(this.ImageContainer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDownloadImage;
        private System.Windows.Forms.Button btnDownloadBigImage;
        private System.Windows.Forms.PictureBox ImageContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDownloadingTime;
    }
}