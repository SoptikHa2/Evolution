namespace Evolution
{
    partial class MainMenuForm
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
            this.newSimulationButton = new System.Windows.Forms.Button();
            this.label_heading = new System.Windows.Forms.Label();
            this.loadSimulationButton = new System.Windows.Forms.Button();
            this.visualiseDataButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newSimulationButton
            // 
            this.newSimulationButton.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newSimulationButton.Location = new System.Drawing.Point(12, 130);
            this.newSimulationButton.Name = "newSimulationButton";
            this.newSimulationButton.Size = new System.Drawing.Size(260, 32);
            this.newSimulationButton.TabIndex = 0;
            this.newSimulationButton.Text = "New Simulation";
            this.newSimulationButton.UseVisualStyleBackColor = true;
            this.newSimulationButton.Click += new System.EventHandler(this.newSimulationButton_Click);
            // 
            // label_heading
            // 
            this.label_heading.AutoSize = true;
            this.label_heading.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_heading.Location = new System.Drawing.Point(81, 9);
            this.label_heading.Name = "label_heading";
            this.label_heading.Size = new System.Drawing.Size(121, 37);
            this.label_heading.TabIndex = 1;
            this.label_heading.Text = "Evolution";
            // 
            // loadSimulationButton
            // 
            this.loadSimulationButton.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loadSimulationButton.Location = new System.Drawing.Point(12, 168);
            this.loadSimulationButton.Name = "loadSimulationButton";
            this.loadSimulationButton.Size = new System.Drawing.Size(260, 32);
            this.loadSimulationButton.TabIndex = 2;
            this.loadSimulationButton.Text = "Load Simulation";
            this.loadSimulationButton.UseVisualStyleBackColor = true;
            this.loadSimulationButton.Click += new System.EventHandler(this.loadSimulationButton_Click);
            // 
            // visualiseDataButton
            // 
            this.visualiseDataButton.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.visualiseDataButton.Location = new System.Drawing.Point(12, 206);
            this.visualiseDataButton.Name = "visualiseDataButton";
            this.visualiseDataButton.Size = new System.Drawing.Size(260, 32);
            this.visualiseDataButton.TabIndex = 3;
            this.visualiseDataButton.Text = "Visualise Data";
            this.visualiseDataButton.UseVisualStyleBackColor = true;
            this.visualiseDataButton.Click += new System.EventHandler(this.visualiseDataButton_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 250);
            this.Controls.Add(this.visualiseDataButton);
            this.Controls.Add(this.loadSimulationButton);
            this.Controls.Add(this.label_heading);
            this.Controls.Add(this.newSimulationButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evolution";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newSimulationButton;
        private System.Windows.Forms.Label label_heading;
        private System.Windows.Forms.Button loadSimulationButton;
        private System.Windows.Forms.Button visualiseDataButton;
    }
}

