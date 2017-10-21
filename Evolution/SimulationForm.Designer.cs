﻿namespace Evolution
{
    partial class SimulationForm
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
            this.mainDrawPictureBox = new System.Windows.Forms.PictureBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.autoplayTickCheckbox = new System.Windows.Forms.CheckBox();
            this.nextTickButton = new System.Windows.Forms.Button();
            this.displayFoodCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainDrawPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainDrawPictureBox
            // 
            this.mainDrawPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.mainDrawPictureBox.Location = new System.Drawing.Point(0, 0);
            this.mainDrawPictureBox.Name = "mainDrawPictureBox";
            this.mainDrawPictureBox.Size = new System.Drawing.Size(500, 500);
            this.mainDrawPictureBox.TabIndex = 1;
            this.mainDrawPictureBox.TabStop = false;
            this.mainDrawPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.mainDrawPictureBox_Paint);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statusLabel.Location = new System.Drawing.Point(506, 9);
            this.statusLabel.MinimumSize = new System.Drawing.Size(170, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(170, 21);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "Generation 42";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // autoplayTickCheckbox
            // 
            this.autoplayTickCheckbox.AutoSize = true;
            this.autoplayTickCheckbox.Checked = true;
            this.autoplayTickCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoplayTickCheckbox.Location = new System.Drawing.Point(510, 33);
            this.autoplayTickCheckbox.Name = "autoplayTickCheckbox";
            this.autoplayTickCheckbox.Size = new System.Drawing.Size(117, 17);
            this.autoplayTickCheckbox.TabIndex = 4;
            this.autoplayTickCheckbox.Text = "Simulation autoplay";
            this.autoplayTickCheckbox.UseVisualStyleBackColor = true;
            this.autoplayTickCheckbox.CheckedChanged += new System.EventHandler(this.autoplayTickCheckbox_CheckedChanged);
            // 
            // nextTickButton
            // 
            this.nextTickButton.Location = new System.Drawing.Point(510, 57);
            this.nextTickButton.Name = "nextTickButton";
            this.nextTickButton.Size = new System.Drawing.Size(159, 23);
            this.nextTickButton.TabIndex = 5;
            this.nextTickButton.Text = "Start 1 tick";
            this.nextTickButton.UseVisualStyleBackColor = true;
            this.nextTickButton.Click += new System.EventHandler(this.nextTickButton_Click);
            // 
            // displayFoodCheckbox
            // 
            this.displayFoodCheckbox.AutoSize = true;
            this.displayFoodCheckbox.Location = new System.Drawing.Point(510, 125);
            this.displayFoodCheckbox.Name = "displayFoodCheckbox";
            this.displayFoodCheckbox.Size = new System.Drawing.Size(121, 17);
            this.displayFoodCheckbox.TabIndex = 6;
            this.displayFoodCheckbox.Text = "Display food overlay";
            this.displayFoodCheckbox.UseVisualStyleBackColor = true;
            this.displayFoodCheckbox.CheckedChanged += new System.EventHandler(this.displayFoodCheckbox_CheckedChanged);
            // 
            // SimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 500);
            this.Controls.Add(this.displayFoodCheckbox);
            this.Controls.Add(this.nextTickButton);
            this.Controls.Add(this.autoplayTickCheckbox);
            this.Controls.Add(this.mainDrawPictureBox);
            this.Controls.Add(this.statusLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SimulationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SimulationForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.mainDrawPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox mainDrawPictureBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.CheckBox autoplayTickCheckbox;
        private System.Windows.Forms.Button nextTickButton;
        private System.Windows.Forms.CheckBox displayFoodCheckbox;
    }
}