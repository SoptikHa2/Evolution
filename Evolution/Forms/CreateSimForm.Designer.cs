﻿namespace Evolution.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateSimForm));
            this.speciesListBox = new System.Windows.Forms.ListBox();
            this.createNewSpeciesBut = new System.Windows.Forms.Button();
            this.SpeciesRemoveBut = new System.Windows.Forms.Button();
            this.SpeciesLabel = new System.Windows.Forms.Label();
            this.OKbutton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SimulationSettingsLabel = new System.Windows.Forms.Label();
            this.PositionFoodLandPercentageInput = new System.Windows.Forms.NumericUpDown();
            this.MinimumFoodInput = new System.Windows.Forms.NumericUpDown();
            this.MaximumFoodInput = new System.Windows.Forms.NumericUpDown();
            this.PositionFoodLandLabel = new System.Windows.Forms.Label();
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
            this.tickPerGenerationInput = new System.Windows.Forms.NumericUpDown();
            this.tickPerGenerationLabel = new System.Windows.Forms.Label();
            this.SaveLoadBut = new System.Windows.Forms.Button();
            this.PositionFoodWaterPercentageInput = new System.Windows.Forms.NumericUpDown();
            this.PositionFoodMountainPercentageInput = new System.Windows.Forms.NumericUpDown();
            this.PositionFoodMountainLabel = new System.Windows.Forms.Label();
            this.PositionFoodWaterLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PositionFoodLandPercentageInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimumFoodInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximumFoodInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthOfMapInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightOfMapInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnimalsPerMapInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickPerGenerationInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionFoodWaterPercentageInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionFoodMountainPercentageInput)).BeginInit();
            this.SuspendLayout();
            // 
            // speciesListBox
            // 
            this.speciesListBox.FormattingEnabled = true;
            this.speciesListBox.Location = new System.Drawing.Point(13, 26);
            this.speciesListBox.Name = "speciesListBox";
            this.speciesListBox.Size = new System.Drawing.Size(120, 407);
            this.speciesListBox.TabIndex = 0;
            // 
            // createNewSpeciesBut
            // 
            this.createNewSpeciesBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createNewSpeciesBut.Location = new System.Drawing.Point(12, 444);
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
            this.SpeciesRemoveBut.Location = new System.Drawing.Point(47, 444);
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
            this.OKbutton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKbutton.Enabled = false;
            this.OKbutton.Location = new System.Drawing.Point(167, 441);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(113, 34);
            this.OKbutton.TabIndex = 5;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(286, 441);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(113, 34);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // SimulationSettingsLabel
            // 
            this.SimulationSettingsLabel.AutoSize = true;
            this.SimulationSettingsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SimulationSettingsLabel.Location = new System.Drawing.Point(203, 2);
            this.SimulationSettingsLabel.Name = "SimulationSettingsLabel";
            this.SimulationSettingsLabel.Size = new System.Drawing.Size(145, 21);
            this.SimulationSettingsLabel.TabIndex = 7;
            this.SimulationSettingsLabel.Text = "Simulation Settings";
            // 
            // PositionFoodLandPercentageInput
            // 
            this.PositionFoodLandPercentageInput.Location = new System.Drawing.Point(279, 48);
            this.PositionFoodLandPercentageInput.Name = "PositionFoodLandPercentageInput";
            this.PositionFoodLandPercentageInput.Size = new System.Drawing.Size(120, 20);
            this.PositionFoodLandPercentageInput.TabIndex = 8;
            this.PositionFoodLandPercentageInput.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // MinimumFoodInput
            // 
            this.MinimumFoodInput.Location = new System.Drawing.Point(279, 137);
            this.MinimumFoodInput.Name = "MinimumFoodInput";
            this.MinimumFoodInput.Size = new System.Drawing.Size(120, 20);
            this.MinimumFoodInput.TabIndex = 9;
            this.MinimumFoodInput.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // MaximumFoodInput
            // 
            this.MaximumFoodInput.Location = new System.Drawing.Point(279, 163);
            this.MaximumFoodInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaximumFoodInput.Name = "MaximumFoodInput";
            this.MaximumFoodInput.Size = new System.Drawing.Size(120, 20);
            this.MaximumFoodInput.TabIndex = 10;
            this.MaximumFoodInput.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // PositionFoodLandLabel
            // 
            this.PositionFoodLandLabel.AutoSize = true;
            this.PositionFoodLandLabel.Location = new System.Drawing.Point(167, 48);
            this.PositionFoodLandLabel.MaximumSize = new System.Drawing.Size(100, 0);
            this.PositionFoodLandLabel.Name = "PositionFoodLandLabel";
            this.PositionFoodLandLabel.Size = new System.Drawing.Size(80, 26);
            this.PositionFoodLandLabel.TabIndex = 11;
            this.PositionFoodLandLabel.Text = "Chance to add food to tile (%)";
            // 
            // minimumFoodLabel
            // 
            this.minimumFoodLabel.AutoSize = true;
            this.minimumFoodLabel.Location = new System.Drawing.Point(167, 139);
            this.minimumFoodLabel.MaximumSize = new System.Drawing.Size(110, 0);
            this.minimumFoodLabel.Name = "minimumFoodLabel";
            this.minimumFoodLabel.Size = new System.Drawing.Size(103, 13);
            this.minimumFoodLabel.TabIndex = 12;
            this.minimumFoodLabel.Text = "Minimum food on tile";
            // 
            // MaximumFoodLabel
            // 
            this.MaximumFoodLabel.AutoSize = true;
            this.MaximumFoodLabel.Location = new System.Drawing.Point(167, 163);
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
            this.warningLabel.Location = new System.Drawing.Point(164, 374);
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
            this.WidthOfMapInput.Location = new System.Drawing.Point(279, 205);
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
            this.WidthOfMapInput.ValueChanged += new System.EventHandler(this.WidthOfMapInput_ValueChanged);
            // 
            // heightOfMapInput
            // 
            this.heightOfMapInput.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.heightOfMapInput.Location = new System.Drawing.Point(279, 231);
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
            this.heightOfMapInput.ValueChanged += new System.EventHandler(this.heightOfMapInput_ValueChanged);
            // 
            // AnimalsPerMapInput
            // 
            this.AnimalsPerMapInput.Location = new System.Drawing.Point(279, 257);
            this.AnimalsPerMapInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.AnimalsPerMapInput.Minimum = new decimal(new int[] {
            10,
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
            this.WidthOfMapLabel.Location = new System.Drawing.Point(167, 205);
            this.WidthOfMapLabel.MaximumSize = new System.Drawing.Size(110, 0);
            this.WidthOfMapLabel.Name = "WidthOfMapLabel";
            this.WidthOfMapLabel.Size = new System.Drawing.Size(70, 13);
            this.WidthOfMapLabel.TabIndex = 18;
            this.WidthOfMapLabel.Text = "Width of map";
            // 
            // HeightOfMapLabel
            // 
            this.HeightOfMapLabel.AutoSize = true;
            this.HeightOfMapLabel.Location = new System.Drawing.Point(167, 231);
            this.HeightOfMapLabel.MaximumSize = new System.Drawing.Size(110, 0);
            this.HeightOfMapLabel.Name = "HeightOfMapLabel";
            this.HeightOfMapLabel.Size = new System.Drawing.Size(73, 13);
            this.HeightOfMapLabel.TabIndex = 19;
            this.HeightOfMapLabel.Text = "Height of map";
            // 
            // numberOfAnimalsLabel
            // 
            this.numberOfAnimalsLabel.AutoSize = true;
            this.numberOfAnimalsLabel.Location = new System.Drawing.Point(167, 257);
            this.numberOfAnimalsLabel.MaximumSize = new System.Drawing.Size(110, 0);
            this.numberOfAnimalsLabel.Name = "numberOfAnimalsLabel";
            this.numberOfAnimalsLabel.Size = new System.Drawing.Size(104, 26);
            this.numberOfAnimalsLabel.TabIndex = 20;
            this.numberOfAnimalsLabel.Text = "Maximum number of animals on map";
            // 
            // EditButton
            // 
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditButton.Location = new System.Drawing.Point(82, 444);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(51, 27);
            this.EditButton.TabIndex = 21;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // RandomSeedInput
            // 
            this.RandomSeedInput.Location = new System.Drawing.Point(279, 328);
            this.RandomSeedInput.Name = "RandomSeedInput";
            this.RandomSeedInput.Size = new System.Drawing.Size(131, 20);
            this.RandomSeedInput.TabIndex = 22;
            // 
            // RandomSeedLabel
            // 
            this.RandomSeedLabel.AutoSize = true;
            this.RandomSeedLabel.Location = new System.Drawing.Point(167, 309);
            this.RandomSeedLabel.MaximumSize = new System.Drawing.Size(110, 0);
            this.RandomSeedLabel.Name = "RandomSeedLabel";
            this.RandomSeedLabel.Size = new System.Drawing.Size(102, 39);
            this.RandomSeedLabel.TabIndex = 23;
            this.RandomSeedLabel.Text = "Simulation seed (leave empty to use random seed)";
            // 
            // tickPerGenerationInput
            // 
            this.tickPerGenerationInput.Location = new System.Drawing.Point(279, 283);
            this.tickPerGenerationInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tickPerGenerationInput.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.tickPerGenerationInput.Name = "tickPerGenerationInput";
            this.tickPerGenerationInput.Size = new System.Drawing.Size(120, 20);
            this.tickPerGenerationInput.TabIndex = 24;
            this.tickPerGenerationInput.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // tickPerGenerationLabel
            // 
            this.tickPerGenerationLabel.AutoSize = true;
            this.tickPerGenerationLabel.Location = new System.Drawing.Point(167, 285);
            this.tickPerGenerationLabel.MaximumSize = new System.Drawing.Size(110, 0);
            this.tickPerGenerationLabel.Name = "tickPerGenerationLabel";
            this.tickPerGenerationLabel.Size = new System.Drawing.Size(104, 13);
            this.tickPerGenerationLabel.TabIndex = 25;
            this.tickPerGenerationLabel.Text = "Ticks per generation";
            // 
            // SaveLoadBut
            // 
            this.SaveLoadBut.Location = new System.Drawing.Point(167, 405);
            this.SaveLoadBut.Name = "SaveLoadBut";
            this.SaveLoadBut.Size = new System.Drawing.Size(232, 30);
            this.SaveLoadBut.TabIndex = 26;
            this.SaveLoadBut.Text = "Save / Load Settings";
            this.SaveLoadBut.UseVisualStyleBackColor = true;
            this.SaveLoadBut.Click += new System.EventHandler(this.SaveLoadBut_Click);
            // 
            // PositionFoodWaterPercentageInput
            // 
            this.PositionFoodWaterPercentageInput.Location = new System.Drawing.Point(279, 74);
            this.PositionFoodWaterPercentageInput.Name = "PositionFoodWaterPercentageInput";
            this.PositionFoodWaterPercentageInput.Size = new System.Drawing.Size(120, 20);
            this.PositionFoodWaterPercentageInput.TabIndex = 27;
            this.PositionFoodWaterPercentageInput.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // PositionFoodMountainPercentageInput
            // 
            this.PositionFoodMountainPercentageInput.Location = new System.Drawing.Point(279, 100);
            this.PositionFoodMountainPercentageInput.Name = "PositionFoodMountainPercentageInput";
            this.PositionFoodMountainPercentageInput.Size = new System.Drawing.Size(120, 20);
            this.PositionFoodMountainPercentageInput.TabIndex = 28;
            this.PositionFoodMountainPercentageInput.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // PositionFoodMountainLabel
            // 
            this.PositionFoodMountainLabel.AutoSize = true;
            this.PositionFoodMountainLabel.Location = new System.Drawing.Point(167, 102);
            this.PositionFoodMountainLabel.MaximumSize = new System.Drawing.Size(110, 0);
            this.PositionFoodMountainLabel.Name = "PositionFoodMountainLabel";
            this.PositionFoodMountainLabel.Size = new System.Drawing.Size(104, 26);
            this.PositionFoodMountainLabel.TabIndex = 29;
            this.PositionFoodMountainLabel.Text = "Chance to add food to mountain (%)";
            // 
            // PositionFoodWaterLabel
            // 
            this.PositionFoodWaterLabel.AutoSize = true;
            this.PositionFoodWaterLabel.Location = new System.Drawing.Point(167, 76);
            this.PositionFoodWaterLabel.MaximumSize = new System.Drawing.Size(110, 0);
            this.PositionFoodWaterLabel.Name = "PositionFoodWaterLabel";
            this.PositionFoodWaterLabel.Size = new System.Drawing.Size(104, 26);
            this.PositionFoodWaterLabel.TabIndex = 30;
            this.PositionFoodWaterLabel.Text = "Chance to add food to water (%)";
            // 
            // CreateSimForm
            // 
            this.AcceptButton = this.OKbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(418, 487);
            this.Controls.Add(this.PositionFoodWaterLabel);
            this.Controls.Add(this.PositionFoodMountainLabel);
            this.Controls.Add(this.PositionFoodMountainPercentageInput);
            this.Controls.Add(this.PositionFoodWaterPercentageInput);
            this.Controls.Add(this.SaveLoadBut);
            this.Controls.Add(this.numberOfAnimalsLabel);
            this.Controls.Add(this.tickPerGenerationLabel);
            this.Controls.Add(this.tickPerGenerationInput);
            this.Controls.Add(this.RandomSeedLabel);
            this.Controls.Add(this.RandomSeedInput);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.HeightOfMapLabel);
            this.Controls.Add(this.WidthOfMapLabel);
            this.Controls.Add(this.AnimalsPerMapInput);
            this.Controls.Add(this.heightOfMapInput);
            this.Controls.Add(this.WidthOfMapInput);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.MaximumFoodLabel);
            this.Controls.Add(this.minimumFoodLabel);
            this.Controls.Add(this.PositionFoodLandLabel);
            this.Controls.Add(this.MaximumFoodInput);
            this.Controls.Add(this.MinimumFoodInput);
            this.Controls.Add(this.PositionFoodLandPercentageInput);
            this.Controls.Add(this.SimulationSettingsLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.SpeciesLabel);
            this.Controls.Add(this.SpeciesRemoveBut);
            this.Controls.Add(this.createNewSpeciesBut);
            this.Controls.Add(this.speciesListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateSimForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Simulation";
            ((System.ComponentModel.ISupportInitialize)(this.PositionFoodLandPercentageInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimumFoodInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximumFoodInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthOfMapInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightOfMapInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnimalsPerMapInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickPerGenerationInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionFoodWaterPercentageInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionFoodMountainPercentageInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox speciesListBox;
        private System.Windows.Forms.Button createNewSpeciesBut;
        private System.Windows.Forms.Button SpeciesRemoveBut;
        private System.Windows.Forms.Label SpeciesLabel;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label SimulationSettingsLabel;
        private System.Windows.Forms.NumericUpDown PositionFoodLandPercentageInput;
        private System.Windows.Forms.NumericUpDown MinimumFoodInput;
        private System.Windows.Forms.NumericUpDown MaximumFoodInput;
        private System.Windows.Forms.Label PositionFoodLandLabel;
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
        private System.Windows.Forms.NumericUpDown tickPerGenerationInput;
        private System.Windows.Forms.Label tickPerGenerationLabel;
        private System.Windows.Forms.Button SaveLoadBut;
        private System.Windows.Forms.NumericUpDown PositionFoodWaterPercentageInput;
        private System.Windows.Forms.NumericUpDown PositionFoodMountainPercentageInput;
        private System.Windows.Forms.Label PositionFoodMountainLabel;
        private System.Windows.Forms.Label PositionFoodWaterLabel;
    }
}