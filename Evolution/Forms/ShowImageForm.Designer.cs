﻿namespace Evolution
{
    partial class ShowImageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowImageForm));
            this.ShowPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowPictureBox
            // 
            this.ShowPictureBox.Location = new System.Drawing.Point(0, 0);
            this.ShowPictureBox.Name = "ShowPictureBox";
            this.ShowPictureBox.Size = new System.Drawing.Size(100, 50);
            this.ShowPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ShowPictureBox.TabIndex = 0;
            this.ShowPictureBox.TabStop = false;
            // 
            // ShowImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ShowPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowImageForm";
            this.Text = "Image Preview";
            ((System.ComponentModel.ISupportInitialize)(this.ShowPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ShowPictureBox;
    }
}