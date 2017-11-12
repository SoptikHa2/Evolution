namespace Evolution
{
    partial class CreateSimForm
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
            this.speciesListBox = new System.Windows.Forms.ListBox();
            this.createNewSpeciesBut = new System.Windows.Forms.Button();
            this.SpeciesRemoveBut = new System.Windows.Forms.Button();
            this.SpeciesLabel = new System.Windows.Forms.Label();
            this.OKbutton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SimulationSettingsLabel = new System.Windows.Forms.Label();
            this.FoodPercentageInput = new System.Windows.Forms.NumericUpDown();
            this.MinimumFoodInput = new System.Windows.Forms.NumericUpDown();
            this.FoodMaximumInput = new System.Windows.Forms.NumericUpDown();
            this.PositionFoodLabel = new System.Windows.Forms.Label();
            this.minimumFoodLabel = new System.Windows.Forms.Label();
            this.MaximumFoodLabel = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.WidthOfMapInput = new System.Windows.Forms.NumericUpDown();
            this.heightOfMapInput = new System.Windows.Forms.NumericUpDown();
            this.AnimalsPerMapInput = new System.Windows.Forms.NumericUpDown();
            this.WidthOfMapLabel = new System.Windows.Forms.Label();
            this.HeightOfMapLabel = new System.Windows.Forms.Label();
            this.numberOfAnimalsLabel = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.RandomSeedInput = new System.Windows.Forms.TextBox();
            this.RandomSeedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FoodPercentageInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimumFoodInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodMaximumInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthOfMapInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightOfMapInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnimalsPerMapInput)).BeginInit();
            this.SuspendLayout();
            // 
            // speciesListBox
            // 
            this.speciesListBox.FormattingEnabled = true;
            this.speciesListBox.Location = new System.Drawing.Point(13, 26);
            this.speciesListBox.Name = "speciesListBox";
            this.speciesListBox.Size = new System.Drawing.Size(120, 277);
            this.speciesListBox.TabIndex = 0;
            // 
            // createNewSpeciesBut
            // 
            this.createNewSpeciesBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createNewSpeciesBut.Location = new System.Drawing.Point(12, 309);
            this.createNewSpeciesBut.Name = "createNewSpeciesBut";
            this.createNewSpeciesBut.Size = new System.Drawing.Size(29, 27);
            this.createNewSpeciesBut.TabIndex = 1;
            this.createNewSpeciesBut.Text = "+";
            this.createNewSpeciesBut.UseVisualStyleBackColor = true;
            this.createNewSpeciesBut.Click += new System.EventHandler(this.createNewSpeciesBut_Click);
            // 
            // SpeciesRemoveBut
            // 
            this.SpeciesRemoveBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SpeciesRemoveBut.Location = new System.Drawing.Point(47, 309);
            this.SpeciesRemoveBut.Name = "SpeciesRemoveBut";
            this.SpeciesRemoveBut.Size = new System.Drawing.Size(29, 27);
            this.SpeciesRemoveBut.TabIndex = 2;
            this.SpeciesRemoveBut.Text = "-";
            this.SpeciesRemoveBut.UseVisualStyleBackColor = true;
            this.SpeciesRemoveBut.Click += new System.EventHandler(this.SpeciesRemoveBut_Click);
            // 
            // SpeciesLabel
            // 
            this.SpeciesLabel.AutoSize = true;
            this.SpeciesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SpeciesLabel.Location = new System.Drawing.Point(43, 2);
            this.SpeciesLabel.Name = "SpeciesLabel";
            this.SpeciesLabel.Size = new System.Drawing.Size(62, 21);
            this.SpeciesLabel.TabIndex = 4;
            this.SpeciesLabel.Text = "Species";
            // 
            // OKbutton
            // 
            this.OKbutton.Enabled = false;
            this.OKbutton.Location = new System.Drawing.Point(167, 306);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(113, 34);
            this.OKbutton.TabIndex = 5;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(286, 306);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(113, 34);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // SimulationSettingsLabel
            // 
            this.SimulationSettingsLabel.AutoSize = true;
            this.SimulationSettingsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SimulationSettingsLabel.Location = new System.Drawing.Point(204, 2);
            this.SimulationSettingsLabel.Name = "SimulationSettingsLabel";
            this.SimulationSettingsLabel.Size = new System.Drawing.Size(145, 21);
            this.SimulationSettingsLabel.TabIndex = 7;
            this.SimulationSettingsLabel.Text = "Simulation Settings";
            // 
            // FoodPercentageInput
            // 
            this.FoodPercentageInput.Location = new System.Drawing.Point(279, 48);
            this.FoodPercentageInput.Name = "FoodPercentageInput";
            this.FoodPercentageInput.Size = new System.Drawing.Size(120, 20);
            this.FoodPercentageInput.TabIndex = 8;
            this.FoodPercentageInput.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // MinimumFoodInput
            // 
            this.MinimumFoodInput.Location = new System.Drawing.Point(279, 74);
            this.MinimumFoodInput.Name = "MinimumFoodInput";
            this.MinimumFoodInput.Size = new System.Drawing.Size(120, 20);
            this.MinimumFoodInput.TabIndex = 9;
            this.MinimumFoodInput.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // FoodMaximumInput
            // 
            this.FoodMaximumInput.Location = new System.Drawing.Point(279, 100);
            this.FoodMaximumInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FoodMaximumInput.Name = "FoodMaximumInput";
            this.FoodMaximumInput.Size = new System.Drawing.Size(120, 20);
            this.FoodMaximumInput.TabIndex = 10;
            this.FoodMaximumInput.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // PositionFoodLabel
            // 
            this.PositionFoodLabel.AutoSize = true;
            this.PositionFoodLabel.Location = new System.Drawing.Point(167, 48);
            this.PositionFoodLabel.MaximumSize = new System.Drawing.Size(100, 0);
            this.PositionFoodLabel.Name = "PositionFoodLabel";
            this.PositionFoodLabel.Size = new System.Drawing.Size(80, 26);
            this.PositionFoodLabel.TabIndex = 11;
            this.PositionFoodLabel.Text = "Chance to add food to tile (%)";
            // 
            // minimumFoodLabel
            // 
            this.minimumFoodLabel.AutoSize = true;
            this.minimumFoodLabel.Location = new System.Drawing.Point(167, 81);
            this.minimumFoodLabel.MaximumSize = new System.Drawing.Size(110, 0);
            this.minimumFoodLabel.Name = "minimumFoodLabel";
            this.minimumFoodLabel.Size = new System.Drawing.Size(103, 13);
            this.minimumFoodLabel.TabIndex = 12;
            this.minimumFoodLabel.Text = "Minimum food on tile";
            // 
            // MaximumFoodLabel
            // 
            this.MaximumFoodLabel.AutoSize = true;
            this.MaximumFoodLabel.Location = new System.Drawing.Point(167, 102);
            this.MaximumFoodLabel.MaximumSize = new System.Drawing.Size(110, 0);
            this.MaximumFoodLabel.Name = "MaximumFoodLabel";
            this.MaximumFoodLabel.Size = new System.Drawing.Size(106, 13);
            this.MaximumFoodLabel.TabIndex = 13;
            this.MaximumFoodLabel.Text = "Maximum food on tile";
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.warningLabel.ForeColor = System.Drawing.Color.Tomato;
            this.warningLabel.Location = new System.Drawing.Point(167, 283);
            this.warningLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(205, 17);
            this.warningLabel.TabIndex = 14;
            this.warningLabel.Text = "Add at least 1 species to continue";
            // 
            // WidthOfMapInput
            // 
            this.WidthOfMapInput.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.WidthOfMapInput.Location = new System.Drawing.Point(279, 144);
            this.WidthOfMapInput.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.WidthOfMapInput.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.WidthOfMapInput.Name = "WidthOfMapInput";
            this.WidthOfMapInput.Size = new System.Drawing.Size(120, 20);
            this.WidthOfMapInput.TabIndex = 15;
            this.WidthOfMapInput.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // heightOfMapInput
            // 
            this.heightOfMapInput.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.heightOfMapInput.Location = new System.Drawing.Point(279, 170);
            this.heightOfMapInput.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.heightOfMapInput.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.heightOfMapInput.Name = "heightOfMapInput";
            this.heightOfMapInput.Size = new System.Drawing.Size(120, 20);
            this.heightOfMapInput.TabIndex = 16;
            this.heightOfMapInput.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // AnimalsPerMapInput
            // 
            this.AnimalsPerMapInput.Location = new System.Drawing.Point(279, 196);
            this.AnimalsPerMapInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.AnimalsPerMapInput.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.AnimalsPerMapInput.Name = "AnimalsPerMapInput";
            this.AnimalsPerMapInput.Size = new System.Drawing.Size(120, 20);
            this.AnimalsPerMapInput.TabIndex = 17;
            this.AnimalsPerMapInput.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // WidthOfMapLabel
            // 
            this.WidthOfMapLabel.AutoSize = true;
            this.WidthOfMapLabel.Location = new System.Drawing.Point(167, 151);
            this.WidthOfMapLabel.MaximumSize = new System.Drawing.Size(110, 0);
            this.WidthOfMapLabel.Name = "WidthOfMapLabel";
            this.WidthOfMapLabel.Size = new System.Drawing.Size(70, 13);
            this.WidthOfMapLabel.TabIndex = 18;
            this.WidthOfMapLabel.Text = "Width of map";
            // 
            // HeightOfMapLabel
            // 
            this.HeightOfMapLabel.AutoSize = true;
            this.HeightOfMapLabel.Location = new System.Drawing.Point(167, 177);
            this.HeightOfMapLabel.MaximumSize = new System.Drawing.Size(110, 0);
            this.HeightOfMapLabel.Name = "HeightOfMapLabel";
            this.HeightOfMapLabel.Size = new System.Drawing.Size(73, 13);
            this.HeightOfMapLabel.TabIndex = 19;
            this.HeightOfMapLabel.Text = "Height of map";
            // 
            // numberOfAnimalsLabel
            // 
            this.numberOfAnimalsLabel.AutoSize = true;
            this.numberOfAnimalsLabel.Location = new System.Drawing.Point(167, 198);
            this.numberOfAnimalsLabel.MaximumSize = new System.Drawing.Size(110, 0);
            this.numberOfAnimalsLabel.Name = "numberOfAnimalsLabel";
            this.numberOfAnimalsLabel.Size = new System.Drawing.Size(104, 26);
            this.numberOfAnimalsLabel.TabIndex = 20;
            this.numberOfAnimalsLabel.Text = "Maximum number of animals on map";
            // 
            // EditButton
            // 
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditButton.Location = new System.Drawing.Point(82, 309);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(51, 27);
            this.EditButton.TabIndex = 21;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // RandomSeedInput
            // 
            this.RandomSeedInput.Location = new System.Drawing.Point(275, 251);
            this.RandomSeedInput.Name = "RandomSeedInput";
            this.RandomSeedInput.Size = new System.Drawing.Size(131, 20);
            this.RandomSeedInput.TabIndex = 22;
            // 
            // RandomSeedLabel
            // 
            this.RandomSeedLabel.AutoSize = true;
            this.RandomSeedLabel.Location = new System.Drawing.Point(167, 241);
            this.RandomSeedLabel.MaximumSize = new System.Drawing.Size(110, 0);
            this.RandomSeedLabel.Name = "RandomSeedLabel";
            this.RandomSeedLabel.Size = new System.Drawing.Size(102, 39);
            this.RandomSeedLabel.TabIndex = 23;
            this.RandomSeedLabel.Text = "Simulation seed (leave empty to use random seed)";
            // 
            // CreateSimForm
            // 
            this.AcceptButton = this.OKbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 352);
            this.Controls.Add(this.RandomSeedLabel);
            this.Controls.Add(this.RandomSeedInput);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.numberOfAnimalsLabel);
            this.Controls.Add(this.HeightOfMapLabel);
            this.Controls.Add(this.WidthOfMapLabel);
            this.Controls.Add(this.AnimalsPerMapInput);
            this.Controls.Add(this.heightOfMapInput);
            this.Controls.Add(this.WidthOfMapInput);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.MaximumFoodLabel);
            this.Controls.Add(this.minimumFoodLabel);
            this.Controls.Add(this.PositionFoodLabel);
            this.Controls.Add(this.FoodMaximumInput);
            this.Controls.Add(this.MinimumFoodInput);
            this.Controls.Add(this.FoodPercentageInput);
            this.Controls.Add(this.SimulationSettingsLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.SpeciesLabel);
            this.Controls.Add(this.SpeciesRemoveBut);
            this.Controls.Add(this.createNewSpeciesBut);
            this.Controls.Add(this.speciesListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateSimForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Simulation";
            ((System.ComponentModel.ISupportInitialize)(this.FoodPercentageInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimumFoodInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodMaximumInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthOfMapInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightOfMapInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnimalsPerMapInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox speciesListBox;
        private System.Windows.Forms.Button createNewSpeciesBut;
        private System.Windows.Forms.Button SpeciesRemoveBut;
        private System.Windows.Forms.Label SpeciesLabel;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label SimulationSettingsLabel;
        private System.Windows.Forms.NumericUpDown FoodPercentageInput;
        private System.Windows.Forms.NumericUpDown MinimumFoodInput;
        private System.Windows.Forms.NumericUpDown FoodMaximumInput;
        private System.Windows.Forms.Label PositionFoodLabel;
        private System.Windows.Forms.Label minimumFoodLabel;
        private System.Windows.Forms.Label MaximumFoodLabel;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.NumericUpDown WidthOfMapInput;
        private System.Windows.Forms.NumericUpDown heightOfMapInput;
        private System.Windows.Forms.NumericUpDown AnimalsPerMapInput;
        private System.Windows.Forms.Label WidthOfMapLabel;
        private System.Windows.Forms.Label HeightOfMapLabel;
        private System.Windows.Forms.Label numberOfAnimalsLabel;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.TextBox RandomSeedInput;
        private System.Windows.Forms.Label RandomSeedLabel;
    }
}