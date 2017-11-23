namespace Evolution.Forms
{
    partial class VisualiseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualiseForm));
            this.ListBoxGenerations = new System.Windows.Forms.ListBox();
            this.AnimalTreePictureBox = new System.Windows.Forms.PictureBox();
            this.speciesComboBox = new System.Windows.Forms.ComboBox();
            this.AnimalsListBox = new System.Windows.Forms.ListBox();
            this.PictureBoxPanel = new System.Windows.Forms.Panel();
            this.scaleBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.AnimalTreePictureBox)).BeginInit();
            this.PictureBoxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scaleBar)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBoxGenerations
            // 
            this.ListBoxGenerations.FormattingEnabled = true;
            this.ListBoxGenerations.Location = new System.Drawing.Point(13, 13);
            this.ListBoxGenerations.Name = "ListBoxGenerations";
            this.ListBoxGenerations.Size = new System.Drawing.Size(105, 446);
            this.ListBoxGenerations.TabIndex = 0;
            this.ListBoxGenerations.SelectedIndexChanged += new System.EventHandler(this.ListBoxGenerations_SelectedIndexChanged);
            // 
            // AnimalTreePictureBox
            // 
            this.AnimalTreePictureBox.Location = new System.Drawing.Point(0, 0);
            this.AnimalTreePictureBox.MinimumSize = new System.Drawing.Size(100, 100);
            this.AnimalTreePictureBox.Name = "AnimalTreePictureBox";
            this.AnimalTreePictureBox.Size = new System.Drawing.Size(477, 433);
            this.AnimalTreePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AnimalTreePictureBox.TabIndex = 0;
            this.AnimalTreePictureBox.TabStop = false;
            this.AnimalTreePictureBox.DoubleClick += new System.EventHandler(this.AnimalTreePictureBox_DoubleClick);
            // 
            // speciesComboBox
            // 
            this.speciesComboBox.FormattingEnabled = true;
            this.speciesComboBox.Location = new System.Drawing.Point(124, 13);
            this.speciesComboBox.Name = "speciesComboBox";
            this.speciesComboBox.Size = new System.Drawing.Size(121, 21);
            this.speciesComboBox.TabIndex = 1;
            this.speciesComboBox.SelectedIndexChanged += new System.EventHandler(this.speciesComboBox_SelectedIndexChanged);
            // 
            // AnimalsListBox
            // 
            this.AnimalsListBox.FormattingEnabled = true;
            this.AnimalsListBox.Location = new System.Drawing.Point(124, 40);
            this.AnimalsListBox.Name = "AnimalsListBox";
            this.AnimalsListBox.Size = new System.Drawing.Size(121, 420);
            this.AnimalsListBox.TabIndex = 2;
            this.AnimalsListBox.SelectedIndexChanged += new System.EventHandler(this.AnimalsListBox_SelectedIndexChanged);
            // 
            // PictureBoxPanel
            // 
            this.PictureBoxPanel.AutoScroll = true;
            this.PictureBoxPanel.Controls.Add(this.AnimalTreePictureBox);
            this.PictureBoxPanel.Location = new System.Drawing.Point(251, 3);
            this.PictureBoxPanel.Name = "PictureBoxPanel";
            this.PictureBoxPanel.Size = new System.Drawing.Size(477, 433);
            this.PictureBoxPanel.TabIndex = 3;
            // 
            // scaleBar
            // 
            this.scaleBar.Location = new System.Drawing.Point(251, 442);
            this.scaleBar.Maximum = 150;
            this.scaleBar.MaximumSize = new System.Drawing.Size(0, 30);
            this.scaleBar.Minimum = 50;
            this.scaleBar.MinimumSize = new System.Drawing.Size(480, 0);
            this.scaleBar.Name = "scaleBar";
            this.scaleBar.Size = new System.Drawing.Size(480, 30);
            this.scaleBar.SmallChange = 10;
            this.scaleBar.TabIndex = 4;
            this.scaleBar.TickFrequency = 25;
            this.scaleBar.Value = 100;
            this.scaleBar.ValueChanged += new System.EventHandler(this.scaleBar_ValueChanged);
            // 
            // VisualiseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 478);
            this.Controls.Add(this.scaleBar);
            this.Controls.Add(this.PictureBoxPanel);
            this.Controls.Add(this.AnimalsListBox);
            this.Controls.Add(this.speciesComboBox);
            this.Controls.Add(this.ListBoxGenerations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VisualiseForm";
            this.Text = "Visualisation";
            ((System.ComponentModel.ISupportInitialize)(this.AnimalTreePictureBox)).EndInit();
            this.PictureBoxPanel.ResumeLayout(false);
            this.PictureBoxPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scaleBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxGenerations;
        private System.Windows.Forms.PictureBox AnimalTreePictureBox;
        private System.Windows.Forms.ComboBox speciesComboBox;
        private System.Windows.Forms.ListBox AnimalsListBox;
        private System.Windows.Forms.Panel PictureBoxPanel;
        private System.Windows.Forms.TrackBar scaleBar;
    }
}