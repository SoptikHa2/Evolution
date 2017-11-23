using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Evolution.Forms
{
    public partial class MainMenuForm : Form
    {
        private string receivedPath;
        public MainMenuForm(string path = "")
        {
            receivedPath = path;
            InitializeComponent();
        }

        private void newSimulationButton_Click(object sender, EventArgs e)
        {
            CreateSimForm csForm = new CreateSimForm();
            DialogResult dR = csForm.ShowDialog();

            if(dR == DialogResult.OK)
            {
                SimulationForm sf = new SimulationForm(csForm.CreateSimulation());
                sf.Show();
                Hide();
            }
            //SimulationForm simulation = new SimulationForm();
            //simulation.Show();
            //Hide();
        }

        private void loadSimulationButton_Click(object sender, EventArgs e)
        {
            LoadForm lf = new LoadForm();
            DialogResult dialogResult = lf.ShowDialog();

            if (dialogResult == DialogResult.OK)
                LoadFromPath(lf.SelectedPath);

            return;
        }

        private void LoadFromFileDrag(string path)
        {
            string dirPath = System.IO.Path.GetDirectoryName(path);
            System.IO.Directory.SetCurrentDirectory(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location));
            LoadFromPath(dirPath);
        }

        private void LoadFromPath(string path)
        {
            if (path == "")
                return;
            Evolution.Simulation sim = Utilities.Serializer.LoadSimulation(path);
            if (sim == null)
                MessageBox.Show("Sorry, I tried, but I was unable to load simulation. Something went wrong. Try to load different save file.", "Loading simulation failed");
            else
            {
                SimulationForm simulation = new SimulationForm(sim);
                simulation.Show();
                Hide();
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (receivedPath != "")
                LoadFromFileDrag(receivedPath);
        }

        private void visualiseDataButton_Click(object sender, EventArgs e)
        {
            LoadForm lf = new LoadForm();
            DialogResult dialogResult = lf.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                if (lf.SelectedPath == "")
                    return;
                VisualiseForm vf = new VisualiseForm(lf.SelectedPath);
                vf.ShowDialog();
            }
        }
    }
}
