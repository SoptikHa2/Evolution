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

        public SimulationForm(Evolution.Simulation simulation = null)
        {
            InitializeComponent();

            this.simulation = simulation ?? new Evolution.Simulation(100, 100);

            mainDrawPictureBox.Image = new Bitmap(mainDrawPictureBox.Width, mainDrawPictureBox.Height);
            drawTimer = new Timer();
            drawTimer.Interval = 1000 / FPS;
            drawTimer.Tick += (e, v) => { mainDrawPictureBox.Refresh(); };
            drawTimer.Start();
        }

        private void SimulationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Close all forms 
            Application.Exit();
        }

        private void mainDrawPictureBox_Paint(object sender, PaintEventArgs e)
        {
            simulation.DrawOnBitmap(e.Graphics, mainDrawPictureBox.Width, mainDrawPictureBox.Height);
        }
    }
}
