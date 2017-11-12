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
    public partial class CreateSimForm : Form
    {
        public CreateSimForm()
        {
            InitializeComponent();
        }

        private void createNewSpeciesBut_Click(object sender, EventArgs e)
        {
            CreateSpeciesForm csf = new CreateSpeciesForm();
            DialogResult dr = csf.ShowDialog();
            if(dr == DialogResult.OK)
            {
                // ...
            }
        }

        private void SpeciesRemoveBut_Click(object sender, EventArgs e)
        {

        }

        private void EditButton_Click(object sender, EventArgs e)
        {

        }

        public Evolution.Simulation CreateSimulation()
        {
            return null;
        }
    }
}
