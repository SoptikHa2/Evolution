using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Evolution
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void newSimulationButton_Click(object sender, EventArgs e)
        {
            SimulationForm simulation = new SimulationForm();
            simulation.Show();
            Hide();
        }
    }
}
