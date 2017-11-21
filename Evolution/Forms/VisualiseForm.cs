using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evolution
{
    public partial class VisualiseForm : Form
    {
        private readonly string path;
        private Evolution.Species[] species;
        private Image image;

        public VisualiseForm(string path)
        {
            InitializeComponent();
            LoadedGeneration = int.Parse(path.Split('\\').Last().Replace("Generation ", ""));
            this.path = Directory.GetParent(path).FullName;
            LoadSimulationGeneration(LoadedGeneration);

            // Add generations into generation listbox
            string[] dirs = Directory.GetDirectories(this.path);
            dirs = dirs.OrderBy(x => int.Parse(x.Split(' ')[1])).ToArray();
            for (int i = 0; i < dirs.Length; i++)
            {
                if (Directory.GetFiles(dirs[i], "*.species").Length > 0)
                    ListBoxGenerations.Items.Add(Path.GetFileName(dirs[i]));
            }
        }

        private int LoadedGeneration = 0;
        private void LoadSimulationGeneration(int generation)
        {
            string pth = Path.Combine(path, "Generation " + generation);
            if (Directory.Exists(pth))
            {
                try
                {
                    string file = Directory.GetFiles(pth, "*.species")[0];
                    species = Serializer.DeserializeObject(File.ReadAllText(file)) as Evolution.Species[];
                    // Add species into combobox
                    speciesComboBox.Items.Clear();
                    speciesComboBox.Items.AddRange(species);
                    speciesComboBox.SelectedIndex = 0;
                    ShowTreeOf();
                }
                catch { MessageBox.Show("An error appeared when I was loading files.", "Visualisation failed"); }
            }
        }

        private void ShowTreeOf(Evolution.Animal animal = null)
        {
            if (species.Length == 0 || species[0].animals.Length == 0)
                return;

            if (animal == null)
                animal = species[0].animals[0];

            Image i = GraphViz.GetGraph(animal.GetNodes(animal.startNode).ToArray());
            this.image = i;
            AnimalTreePictureBox.Image = ScaleImage(image, (int)(image.Width * (scaleBar.Value / 100d)), (int)(image.Height * (scaleBar.Value / 100d)));
        }

        /// <summary>
        /// When Generation number is changed -> update everything
        /// </summary>
        private void ListBoxGenerations_SelectedIndexChanged(object sender, EventArgs e)
        {
            int newGeneration = int.Parse(ListBoxGenerations.SelectedItem.ToString().Replace("Generation ", ""));
            LoadedGeneration = newGeneration;
            LoadSimulationGeneration(newGeneration);
        }

        private static Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);

            using (var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);

            return newImage;
        }

        private void scaleBar_ValueChanged(object sender, EventArgs e)
        {
            AnimalTreePictureBox.Image = ScaleImage(image, (int)(image.Width * (scaleBar.Value / 100d)), (int)(image.Height * (scaleBar.Value / 100d)));
        }

        private void AnimalTreePictureBox_DoubleClick(object sender, EventArgs e)
        {
            ShowImageForm si = new ShowImageForm(AnimalTreePictureBox.Image);
            si.ShowDialog();
        }

        private void speciesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AnimalsListBox.Items.Clear();
            if (species.Length > speciesComboBox.SelectedIndex)
            {
                AnimalsListBox.Items.Clear();
                AnimalsListBox.Items.AddRange(species[speciesComboBox.SelectedIndex].animals);
                if (AnimalsListBox.Items.Count != 0)
                    AnimalsListBox.SelectedIndex = 0;
            }
        }

        private void AnimalsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Evolution.Species selectedSpecies = species[speciesComboBox.SelectedIndex];

            if (selectedSpecies.animals.Length > AnimalsListBox.SelectedIndex)
            {
                ShowTreeOf(selectedSpecies.animals[AnimalsListBox.SelectedIndex]);
            }
        }
    }
}
