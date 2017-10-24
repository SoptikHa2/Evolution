using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Evolution
{
    public partial class SimulationForm : Form
    {
        #region Settings
        public const int FPS = 30;
        #endregion

        private Evolution.Simulation simulation;
        private Timer drawTimer;
        private int generation = 1;
        private int tick = 1;

        public SimulationForm(Evolution.Simulation simulation = null)
        {
            InitializeComponent();

            if (simulation != null)
                generation = simulation.generation;

            this.simulation = simulation ?? new Evolution.Simulation(100, 100);
            this.simulation.StartTicks();
            this.simulation.NextTick += (o, ev) => { this.Invoke((MethodInvoker)delegate () { statusLabel.Text = $"Generation {generation} | Tick {tick++}"; if (this.simulation.playTicks == 0) nextTickButton.Enabled = true; }); };
            this.simulation.NextGeneration += (o, ev) => { this.Invoke((MethodInvoker)delegate () { tick = 1; statusLabel.Text = $"Generation {++generation} | Tick {tick}"; UpdateChart(); }); };

            UpdateChart();

            mainDrawPictureBox.Image = new Bitmap(mainDrawPictureBox.Width, mainDrawPictureBox.Height);
            drawTimer = new Timer();
            drawTimer.Interval = 1000 / FPS;
            drawTimer.Tick += (e, v) => { mainDrawPictureBox.Refresh(); };
            drawTimer.Start();
        }

        private void UpdateChart(int elements = 10)
        {
            Series best = visualisationGraph.Series[0];
            Series average = visualisationGraph.Series[1];

            best.Points.Clear();
            average.Points.Clear();

            int min = Math.Max(0, Serializer.bestEnergyData.Count - elements);

            int c = 0;
            for (int i = min; i < Serializer.bestEnergyData.Count; i++)
            {
                best.Points.Add(new DataPoint(c, Serializer.bestEnergyData[i]));
                average.Points.Add(new DataPoint(c++, Serializer.averageEnergyData[i]));
            }
        }

        private void SimulationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Close all forms 
            Environment.Exit(0);
        }

        private void mainDrawPictureBox_Paint(object sender, PaintEventArgs e)
        {
            simulation.DrawOnBitmap(e.Graphics, mainDrawPictureBox.Width, mainDrawPictureBox.Height);
        }

        private void nextTickButton_Click(object sender, EventArgs e)
        {
            simulation.playTicks = 1;
            nextTickButton.Enabled = false;
        }

        private void autoplayTickCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (autoplayTickCheckbox.Checked)
            {
                simulation.playTicks = -1;
                nextTickButton.Enabled = false;
            }
            else
            {
                simulation.playTicks = 0;
                nextTickButton.Enabled = true;
            }
        }

        private void displayFoodCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            simulation.drawFoodOverlay = displayFoodCheckbox.Checked;
        }

        private void saveExcelDataButton_Click(object sender, EventArgs e)
        {
            Serializer.SaveExcelDataInClipboard();
        }
    }
}
