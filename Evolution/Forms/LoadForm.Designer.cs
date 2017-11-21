namespace Evolution
{
    partial class LoadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadForm));
            this.simulationListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.generationListBox = new System.Windows.Forms.ListBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.detailsPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.detailsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // simulationListBox
            // 
            this.simulationListBox.FormattingEnabled = true;
            this.simulationListBox.Location = new System.Drawing.Point(17, 37);
            this.simulationListBox.Name = "simulationListBox";
            this.simulationListBox.Size = new System.Drawing.Size(146, 290);
            this.simulationListBox.TabIndex = 0;
            this.simulationListBox.SelectedIndexChanged += new System.EventHandler(this.simulationListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Simulation";
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.okButton.Location = new System.Drawing.Point(17, 332);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(146, 35);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // generationListBox
            // 
            this.generationListBox.FormattingEnabled = true;
            this.generationListBox.Location = new System.Drawing.Point(201, 37);
            this.generationListBox.Name = "generationListBox";
            this.generationListBox.Size = new System.Drawing.Size(146, 290);
            this.generationListBox.TabIndex = 3;
            this.generationListBox.SelectedIndexChanged += new System.EventHandler(this.generationListBox_SelectedIndexChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cancelButton.Location = new System.Drawing.Point(201, 333);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(146, 35);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(196, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Generation";
            // 
            // detailsPictureBox
            // 
            this.detailsPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.detailsPictureBox.ErrorImage = global::Evolution.Properties.Resources.preview;
            this.detailsPictureBox.Image = global::Evolution.Properties.Resources.preview;
            this.detailsPictureBox.InitialImage = global::Evolution.Properties.Resources.preview;
            this.detailsPictureBox.Location = new System.Drawing.Point(359, 13);
            this.detailsPictureBox.Name = "detailsPictureBox";
            this.detailsPictureBox.Size = new System.Drawing.Size(350, 350);
            this.detailsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.detailsPictureBox.TabIndex = 6;
            this.detailsPictureBox.TabStop = false;
            // 
            // LoadForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(723, 379);
            this.Controls.Add(this.detailsPictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.generationListBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.simulationListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Load Simulation";
            this.Load += new System.EventHandler(this.LoadForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detailsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox simulationListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ListBox generationListBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox detailsPictureBox;
    }
}