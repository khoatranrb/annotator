﻿namespace rate_image
{
    partial class Form2
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
            this.txt_label2 = new System.Windows.Forms.Label();
            this.pb_img = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_label2
            // 
            this.txt_label2.AutoSize = true;
            this.txt_label2.Location = new System.Drawing.Point(378, 13);
            this.txt_label2.Name = "txt_label2";
            this.txt_label2.Size = new System.Drawing.Size(30, 16);
            this.txt_label2.TabIndex = 0;
            this.txt_label2.Text = "Ảnh";
            // 
            // pb_img
            // 
            this.pb_img.Location = new System.Drawing.Point(48, 48);
            this.pb_img.Name = "pb_img";
            this.pb_img.Size = new System.Drawing.Size(160, 99);
            this.pb_img.TabIndex = 1;
            this.pb_img.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pb_img);
            this.Controls.Add(this.txt_label2);
            this.Name = "Form2";
            this.Text = "Ảnh";
            ((System.ComponentModel.ISupportInitialize)(this.pb_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_label2;
        private System.Windows.Forms.PictureBox pb_img;
    }
}