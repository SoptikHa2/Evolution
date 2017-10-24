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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 10D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 25D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4D, 10D);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 4D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 8D);
            this.mainDrawPictureBox = new System.Windows.Forms.PictureBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.autoplayTickCheckbox = new System.Windows.Forms.CheckBox();
            this.nextTickButton = new System.Windows.Forms.Button();
            this.displayFoodCheckbox = new System.Windows.Forms.CheckBox();
            this.saveExcelDataButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.visualisationGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.mainDrawPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualisationGraph)).BeginInit();
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
            this.nextTickButton.Enabled = false;
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
            // saveExcelDataButton
            // 
            this.saveExcelDataButton.Location = new System.Drawing.Point(510, 173);
            this.saveExcelDataButton.Name = "saveExcelDataButton";
            this.saveExcelDataButton.Size = new System.Drawing.Size(159, 38);
            this.saveExcelDataButton.TabIndex = 7;
            this.saveExcelDataButton.Text = "Save generation data in excel format into clipboard";
            this.saveExcelDataButton.UseVisualStyleBackColor = true;
            this.saveExcelDataButton.Click += new System.EventHandler(this.saveExcelDataButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(510, 400);
            this.label2.MinimumSize = new System.Drawing.Size(159, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label2.Size = new System.Drawing.Size(159, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Click to expand detailed view";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // visualisationGraph
            // 
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX2.IsMarginVisible = false;
            chartArea1.AxisX2.LabelStyle.Enabled = false;
            chartArea1.AxisY.IsMarginVisible = false;
            chartArea1.AxisY.LabelStyle.Enabled = false;
            chartArea1.AxisY2.IsMarginVisible = false;
            chartArea1.AxisY2.LabelStyle.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.visualisationGraph.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.visualisationGraph.Legends.Add(legend1);
            this.visualisationGraph.Location = new System.Drawing.Point(510, 262);
            this.visualisationGraph.Name = "visualisationGraph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Best";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "Average";
            series2.Points.Add(dataPoint4);
            series2.Points.Add(dataPoint5);
            this.visualisationGraph.Series.Add(series1);
            this.visualisationGraph.Series.Add(series2);
            this.visualisationGraph.Size = new System.Drawing.Size(159, 147);
            this.visualisationGraph.TabIndex = 8;
            this.visualisationGraph.Text = "Evolution";
            // 
            // SimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 500);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.visualisationGraph);
            this.Controls.Add(this.saveExcelDataButton);
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
            ((System.ComponentModel.ISupportInitialize)(this.visualisationGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox mainDrawPictureBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.CheckBox autoplayTickCheckbox;
        private System.Windows.Forms.Button nextTickButton;
        private System.Windows.Forms.CheckBox displayFoodCheckbox;
        private System.Windows.Forms.Button saveExcelDataButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart visualisationGraph;
    }
}