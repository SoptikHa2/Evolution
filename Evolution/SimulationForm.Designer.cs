namespace Evolution
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
            this.animals = new System.Windows.Forms.GroupBox();
            this.animalInfo = new System.Windows.Forms.Label();
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
            // animals
            // 
            this.animals.Location = new System.Drawing.Point(507, 33);
            this.animals.Name = "animals";
            this.animals.Size = new System.Drawing.Size(169, 374);
            this.animals.TabIndex = 4;
            this.animals.TabStop = false;
            this.animals.Text = "Animals";
            // 
            // animalInfo
            // 
            this.animalInfo.AutoSize = true;
            this.animalInfo.Location = new System.Drawing.Point(507, 414);
            this.animalInfo.MaximumSize = new System.Drawing.Size(161, 81);
            this.animalInfo.MinimumSize = new System.Drawing.Size(160, 80);
            this.animalInfo.Name = "animalInfo";
            this.animalInfo.Size = new System.Drawing.Size(160, 80);
            this.animalInfo.TabIndex = 5;
            this.animalInfo.Click += new System.EventHandler(this.animalInfo_Click);
            // 
            // SimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 500);
            this.Controls.Add(this.animalInfo);
            this.Controls.Add(this.animals);
            this.Controls.Add(this.mainDrawPictureBox);
            this.Controls.Add(this.statusLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SimulationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimulationForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SimulationForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.mainDrawPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox mainDrawPictureBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.GroupBox animals;
        private System.Windows.Forms.Label animalInfo;
    }
}