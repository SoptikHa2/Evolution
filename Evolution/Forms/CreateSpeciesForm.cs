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
    public partial class CreateSpeciesForm : Form
    {
        public SpeciesSettings edit = null;

        public CreateSpeciesForm()
        {
            InitializeComponent();
        }

        public CreateSpeciesForm(SpeciesSettings edit)
        {
            InitializeComponent();


            NameInput.Text = edit.name;
            selectedColor = Color.FromArgb(edit.color);
            showColorLabel.BackColor = (Color)selectedColor;
            EatEnergyNumberInput.Value = edit.eatEnergy;
            SearchFoodEnergyNumberInput.Value = edit.searchFoodEnergy;
            SearchEnemyEnergyNumberInput.Value = edit.searchEnemyEnergy;
            FightEnergyNumberInput.Value = edit.fightEnergy;
            FightSuccEnergyNumberInput.Value = edit.biteEnergy;
            KillBonusEnergyNumberInput.Value = edit.killEnergy;
            AttackStrengthNumberInput.Value = edit.attStrength;
            MaximumHealthNumberInput.Value = edit.health;
            MutationChanceNumberInput.Value = edit.mutationChance;
            BaseMoveEnergyNumberInput.Value = edit.energyPerMoveLand;
            WaterMoveEnergyNumberInput.Value = edit.energyPerMoveWater;
            MountainMoveEnergyNumberInput.Value = edit.energyPerMoveMountain;
            FoodEnergyGainInput.Value = edit.foodGainEnergy;
            AllowMovementLandCheckbox.Checked = edit.movementLand;
            AllowMovementWaterCheckbox.Checked = edit.movementWater;
            AllowMovementMountainsCheckbox.Checked = edit.movementMountain;

            this.edit = edit;
        }

        private void NameInput_TextChanged(object sender, EventArgs e)
        {
            OKbutton.Enabled = NameInput.Text != "" && selectedColor != null;
            warningLabel.Visible = NameInput.Text == "" || selectedColor == null;
        }

        public SpeciesSettings GetSpecies()
        {
            return new SpeciesSettings(NameInput.Text, (Color)selectedColor, (int)EatEnergyNumberInput.Value, (int)SearchFoodEnergyNumberInput.Value, (int)SearchEnemyEnergyNumberInput.Value,
                                (int)FightEnergyNumberInput.Value, (int)FightSuccEnergyNumberInput.Value, (int)KillBonusEnergyNumberInput.Value, (int)AttackStrengthNumberInput.Value,
                                (int)MaximumHealthNumberInput.Value, (int)MutationChanceNumberInput.Value, (int)BaseMoveEnergyNumberInput.Value, (int)WaterMoveEnergyNumberInput.Value,
                                (int)MountainMoveEnergyNumberInput.Value, (int)FoodEnergyGainInput.Value, (int)GetTerrainTypeEnergyInput.Value, AllowMovementLandCheckbox.Checked, AllowMovementWaterCheckbox.Checked, AllowMovementMountainsCheckbox.Checked);
        }

        private Color? selectedColor = Color.Black;

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = selectedColor ?? Color.Black;
            if (cd.ShowDialog() == DialogResult.OK)
            {
                selectedColor = cd.Color;
                showColorLabel.BackColor = cd.Color;
            }

            OKbutton.Enabled = NameInput.Text != "" && selectedColor != null;
            warningLabel.Visible = NameInput.Text == "" || selectedColor == null;
        }
    }

    [Serializable]
    public class SpeciesSettings
    {
        public readonly string name;
        public readonly int color;
        public readonly int eatEnergy, searchFoodEnergy, searchEnemyEnergy, fightEnergy,
                    biteEnergy, killEnergy, attStrength, health, mutationChance,
                    energyPerMoveLand, energyPerMoveWater, energyPerMoveMountain, foodGainEnergy,
                    terrainSearchEnergy;
        public readonly bool movementLand, movementWater, movementMountain;

        public SpeciesSettings(string name, Color color, int eatEnergy, int searchFoodEnergy, int searchEnemyEnergy, int fightEnergy, int biteEnergy, int killEnergy, int attStrength, int health, int mutationChance, int energyPerMoveLand, int energyPerMoveWater, int energyPerMoveMountain, int foodGainEnergy, int terrainSearchEnergy, bool movementLand, bool movementWater, bool movementMountain)
        {
            this.name = name;
            this.color = color.ToArgb();
            this.eatEnergy = eatEnergy;
            this.foodGainEnergy = foodGainEnergy;
            this.searchFoodEnergy = searchFoodEnergy;
            this.searchEnemyEnergy = searchEnemyEnergy;
            this.fightEnergy = fightEnergy;
            this.biteEnergy = biteEnergy;
            this.killEnergy = killEnergy;
            this.attStrength = attStrength;
            this.health = health;
            this.mutationChance = mutationChance;
            this.energyPerMoveLand = energyPerMoveLand;
            this.energyPerMoveWater = energyPerMoveWater;
            this.energyPerMoveMountain = energyPerMoveMountain;
            this.movementLand = movementLand;
            this.movementWater = movementWater;
            this.movementMountain = movementMountain;
            this.terrainSearchEnergy = terrainSearchEnergy;
        }

        public Evolution.Species ToSpecies(Evolution.Simulation simulation, Random rnd, int totalNumberOfSpecies)
        {
            return new Evolution.Species(name, simulation, color, totalNumberOfSpecies, rnd, attStrength, health, mutationChance, energyPerMoveLand,
                                         energyPerMoveWater, energyPerMoveMountain, eatEnergy, foodGainEnergy, searchFoodEnergy, searchEnemyEnergy, fightEnergy, biteEnergy, killEnergy,
                                         terrainSearchEnergy, movementLand, movementWater, movementMountain);
        }

        public override string ToString()
        {
            return name;
        }
    }
}
