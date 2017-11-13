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

        private List<SpeciesSettings> species = new List<SpeciesSettings>();
        private void createNewSpeciesBut_Click(object sender, EventArgs e)
        {
            CreateSpeciesForm csf = new CreateSpeciesForm();
            DialogResult dr = csf.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (csf.edit != null)
                    species.Remove(csf.edit);
                species.Add(csf.GetSpecies());
                UpdateList();
            }
        }

        private void SpeciesRemoveBut_Click(object sender, EventArgs e)
        {
            if (speciesListBox.SelectedItem == null)
                return;
            species.Remove(speciesListBox.SelectedItem as SpeciesSettings);
            UpdateList();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (speciesListBox.SelectedItem == null)
                return;
            CreateSpeciesForm csf = new CreateSpeciesForm(speciesListBox.SelectedItem as SpeciesSettings);
            DialogResult dr = csf.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (csf.edit != null)
                    species.Remove(csf.edit);
                species.Add(csf.GetSpecies());
                UpdateList();
            }
        }

        private void UpdateList()
        {
            speciesListBox.Items.Clear();
            for (int i = 0; i < species.Count; i++)
                speciesListBox.Items.Add(species[i]);

            OKbutton.Enabled = species.Count > 0;
            warningLabel.Visible = species.Count == 0;
        }

        public Evolution.Simulation CreateSimulation()
        {
            Random rnd = RandomSeedInput.Text == "" ? new Random() : new Random(RandomSeedInput.Text.GetHashCode());
            Evolution.Simulation sim = new Evolution.Simulation(null, (int)WidthOfMapInput.Value, (int)heightOfMapInput.Value, rnd, (int)PositionFoodPercentageInput.Value, (int)MinimumFoodInput.Value, (int)MaximumFoodInput.Value);
            sim.species = species.Select(x => x.ToSpecies(sim, rnd, species.Count)).ToArray();
            return sim;
        }
    }
}
