using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evolution.Forms
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
            Evolution.Simulation sim = new Evolution.Simulation(null, (int)WidthOfMapInput.Value, (int)heightOfMapInput.Value, rnd, (int)PositionFoodPercentageInput.Value, (int)MinimumFoodInput.Value, (int)MaximumFoodInput.Value, (int)AnimalsPerMapInput.Value, (int)tickPerGenerationInput.Value);
            sim.species = species.Select(x => x.ToSpecies(sim, rnd, species.Count)).ToArray();
            return sim;
        }



        // When width or height of map changes, set the "maximum animals input" new maximum value
        #region WidthHeightValueChanges
        private const int maximumAllowedMaxAnimalInputValue = 10000;

        private void WidthOfMapInput_ValueChanged(object sender, EventArgs e)
        {
            int wh = (int)WidthOfMapInput.Value * (int)heightOfMapInput.Value;
            AnimalsPerMapInput.Maximum = Math.Min(maximumAllowedMaxAnimalInputValue, wh);
        }

        private void heightOfMapInput_ValueChanged(object sender, EventArgs e)
        {
            int wh = (int)WidthOfMapInput.Value * (int)heightOfMapInput.Value;
            AnimalsPerMapInput.Maximum = Math.Min(maximumAllowedMaxAnimalInputValue, wh);
        }
        #endregion

        private void SaveLoadBut_Click(object sender, EventArgs e)
        {
            ConfigurationManager cm = new ConfigurationManager(CreateSimulationSettings());
            DialogResult dr = cm.ShowDialog();

            if(dr == DialogResult.OK)
            {
                LoadSimulationSettings(cm.settings);
            }
        }

        private void LoadSimulationSettings(SimulationSettings load)
        {
            WidthOfMapInput.Value = load.width;
            heightOfMapInput.Value = load.height;
            PositionFoodPercentageInput.Value = load.foodPercentage;
            MinimumFoodInput.Value = load.minFood;
            MaximumFoodInput.Value = load.maxFood;
            AnimalsPerMapInput.Value = load.animalsPerMap;
            tickPerGenerationInput.Value = load.ticksPerGeneration;
            RandomSeedInput.Text = load.randomSeed;
            species = load.species.ToList();

            UpdateList();
        }

        private SimulationSettings CreateSimulationSettings()
        {
            return new SimulationSettings((int)WidthOfMapInput.Value, (int)heightOfMapInput.Value, (int)PositionFoodPercentageInput.Value, (int)MinimumFoodInput.Value,
                (int)MaximumFoodInput.Value, (int)AnimalsPerMapInput.Value, (int)tickPerGenerationInput.Value, RandomSeedInput.Text, this.species.ToArray());
        }
    }

    [Serializable]
    public class SimulationSettings
    {
        public int width, height, foodPercentage, minFood, maxFood, animalsPerMap, ticksPerGeneration;
        public string randomSeed;
        public SpeciesSettings[] species;

        public SimulationSettings(int width, int height, int foodPercentage, int minFood, int maxFood, int animalsPerMap, int ticksPerGeneration, string randomSeed, SpeciesSettings[] species)
        {
            this.width = width;
            this.height = height;
            this.foodPercentage = foodPercentage;
            this.minFood = minFood;
            this.maxFood = maxFood;
            this.animalsPerMap = animalsPerMap;
            this.ticksPerGeneration = ticksPerGeneration;
            this.randomSeed = randomSeed;
            this.species = species;
        }
    }
}
