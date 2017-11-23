namespace Evolution.Forms
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 30D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 30D);
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 10D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 80D);
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 100D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 80D);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimulationForm));
            this.statusLabel = new System.Windows.Forms.Label();
            this.autoplayTickCheckbox = new System.Windows.Forms.CheckBox();
            this.nextTickButton = new System.Windows.Forms.Button();
            this.displayFoodCheckbox = new System.Windows.Forms.CheckBox();
            this.saveExcelDataButton = new System.Windows.Forms.Button();
            this.visualisationGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.infoSimulationButton = new System.Windows.Forms.Button();
            this.speciesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mainDrawPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.visualisationGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciesChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDrawPictureBox)).BeginInit();
            this.SuspendLayout();
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
            this.displayFoodCheckbox.Location = new System.Drawing.Point(510, 86);
            this.displayFoodCheckbox.Name = "displayFoodCheckbox";
            this.displayFoodCheckbox.Size = new System.Drawing.Size(121, 17);
            this.displayFoodCheckbox.TabIndex = 6;
            this.displayFoodCheckbox.Text = "Display food overlay";
            this.displayFoodCheckbox.UseVisualStyleBackColor = true;
            this.displayFoodCheckbox.CheckedChanged += new System.EventHandler(this.displayFoodCheckbox_CheckedChanged);
            // 
            // saveExcelDataButton
            // 
            this.saveExcelDataButton.Location = new System.Drawing.Point(506, 450);
            this.saveExcelDataButton.Name = "saveExcelDataButton";
            this.saveExcelDataButton.Size = new System.Drawing.Size(159, 38);
            this.saveExcelDataButton.TabIndex = 7;
            this.saveExcelDataButton.Text = "Save generation data in excel format into clipboard";
            this.saveExcelDataButton.UseVisualStyleBackColor = true;
            this.saveExcelDataButton.Click += new System.EventHandler(this.saveExcelDataButton_Click);
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
            this.visualisationGraph.Location = new System.Drawing.Point(506, 109);
            this.visualisationGraph.Name = "visualisationGraph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Best energy";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "Average energy";
            series2.Points.Add(dataPoint4);
            series2.Points.Add(dataPoint5);
            this.visualisationGraph.Series.Add(series1);
            this.visualisationGraph.Series.Add(series2);
            this.visualisationGraph.Size = new System.Drawing.Size(159, 147);
            this.visualisationGraph.TabIndex = 8;
            this.visualisationGraph.Text = "Evolution";
            // 
            // infoSimulationButton
            // 
            this.infoSimulationButton.Location = new System.Drawing.Point(506, 406);
            this.infoSimulationButton.Name = "infoSimulationButton";
            this.infoSimulationButton.Size = new System.Drawing.Size(159, 38);
            this.infoSimulationButton.TabIndex = 9;
            this.infoSimulationButton.Text = "Visualise gathered data";
            this.infoSimulationButton.UseVisualStyleBackColor = true;
            this.infoSimulationButton.Click += new System.EventHandler(this.infoSimulationButton_Click);
            // 
            // speciesChart
            // 
            chartArea2.AxisX.IsMarginVisible = false;
            chartArea2.AxisX.LabelStyle.Enabled = false;
            chartArea2.AxisX2.IsMarginVisible = false;
            chartArea2.AxisX2.LabelStyle.Enabled = false;
            chartArea2.AxisY.IsMarginVisible = false;
            chartArea2.AxisY.LabelStyle.Enabled = false;
            chartArea2.AxisY2.IsMarginVisible = false;
            chartArea2.AxisY2.LabelStyle.Enabled = false;
            chartArea2.Name = "ChartArea1";
            this.speciesChart.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.speciesChart.Legends.Add(legend2);
            this.speciesChart.Location = new System.Drawing.Point(506, 262);
            this.speciesChart.Name = "speciesChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea100;
            series3.Color = System.Drawing.Color.Orange;
            series3.Legend = "Legend1";
            series3.Name = "Fox";
            series3.Points.Add(dataPoint6);
            series3.Points.Add(dataPoint7);
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea100;
            series4.Color = System.Drawing.Color.Silver;
            series4.Legend = "Legend1";
            series4.Name = "Sheep";
            series4.Points.Add(dataPoint8);
            series4.Points.Add(dataPoint9);
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea100;
            series5.Legend = "Legend1";
            series5.Name = "Goat";
            series5.Points.Add(dataPoint10);
            series5.Points.Add(dataPoint11);
            this.speciesChart.Series.Add(series3);
            this.speciesChart.Series.Add(series4);
            this.speciesChart.Series.Add(series5);
            this.speciesChart.Size = new System.Drawing.Size(159, 138);
            this.speciesChart.TabIndex = 10;
            this.speciesChart.Text = "Species";
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
            // SimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 500);
            this.Controls.Add(this.speciesChart);
            this.Controls.Add(this.infoSimulationButton);
            this.Controls.Add(this.visualisationGraph);
            this.Controls.Add(this.saveExcelDataButton);
            this.Controls.Add(this.displayFoodCheckbox);
            this.Controls.Add(this.nextTickButton);
            this.Controls.Add(this.autoplayTickCheckbox);
            this.Controls.Add(this.mainDrawPictureBox);
            this.Controls.Add(this.statusLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SimulationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SimulationForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.visualisationGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciesChart)).EndInit();
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
        private System.Windows.Forms.Button saveExcelDataButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart visualisationGraph;
        private System.Windows.Forms.Button infoSimulationButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart speciesChart;
    }
}