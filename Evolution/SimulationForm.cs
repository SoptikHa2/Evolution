using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.simulation.NextTick += (o, ev) => { this.Invoke((MethodInvoker)delegate () { statusLabel.Text = $"Generation {generation} | Tick {tick++}"; }); };
            this.simulation.NextGeneration += (o, ev) => { this.Invoke((MethodInvoker)delegate () { tick = 1; statusLabel.Text = $"Generation {++generation} | Tick {tick}"; UpdateGroupBox(); }); };

            UpdateGroupBox();

            mainDrawPictureBox.Image = new Bitmap(mainDrawPictureBox.Width, mainDrawPictureBox.Height);
            drawTimer = new Timer();
            drawTimer.Interval = 1000 / FPS;
            drawTimer.Tick += (e, v) => { mainDrawPictureBox.Refresh(); };
            drawTimer.Start();
        }

        private void UpdateGroupBox()
        {
            /*animalsPanel.Controls.Clear();

            int i = 1;
            foreach (Evolution.Species s in simulation.species)
            {
                foreach (Evolution.Animal a in s.animals)
                {
                    Label l = new Label();

                    l.Text = a.name;
                    l.Width = 200;
                    l.Height = 18;
                    l.Location = new Point(10, 20 * i);

                    Evolution.Animal currAnimal = a;
                    l.Click += (o, e) => { DisplayInfoAboutAnimal(currAnimal); };

                    animalsPanel.Controls.Add(l);
                    i++;
                }
            }*/
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
    }
}
