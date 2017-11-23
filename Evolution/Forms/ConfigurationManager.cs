using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Evolution.Forms
{
    public partial class ConfigurationManager : Form
    {
        public SimulationSettings settings;
        public ConfigurationManager(SimulationSettings settings)
        {
            InitializeComponent();

            this.settings = settings;

            // Initialize configs folder
            if (!Directory.Exists("configs"))
                Directory.CreateDirectory("configs");
            // Load all saved configurations
            LoadList();
        }

        private void LoadList()
        {
            configListBox.Items.Clear();

            string[] dirs = Directory.GetDirectories("configs");
            for (int i = 0; i < dirs.Length; i++)
            {
                string dir = dirs[i];
                if (File.Exists(Path.Combine(dir, "settings.config")))
                {
                    configListBox.Items.Add(dir.Split('\\').Last());
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                TextDialog td = new TextDialog("What is name of this configuration?", "Select configuration name");
                if (td.ShowDialog() != DialogResult.OK)
                    return;
                string destination = td.Value;
                if (destination == "" || destination.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0) // Empty or invalid characters
                    return;
                if (Directory.Exists(Path.Combine("configs", destination))) // If this record already exists, ask user, if he wants to overwrite it
                {
                    DialogResult dialogResult = MessageBox.Show("There already exists some configuration with this name. Do you want to overwrite it?", "Configuration overwrite", MessageBoxButtons.YesNo);
                    if (dialogResult != DialogResult.Yes)
                        return;
                }
                else
                    Directory.CreateDirectory(Path.Combine("configs", destination));

                File.WriteAllText(Path.Combine("configs", destination, "settings.config"), Utilities.Serializer.SerializeObject(settings));
                DialogResult = DialogResult.OK;
            }
            catch { }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            try
            {
                int select = configListBox.SelectedIndex;
                if (configListBox.Items.Count <= select || configListBox.Items[select] == null)
                    return;

                string path = Path.Combine("configs", configListBox.Items[select].ToString(), "settings.config");
                settings = Utilities.Serializer.DeserializeObject(File.ReadAllText(path)) as SimulationSettings;
                DialogResult = DialogResult.OK;
            }
            catch { }
        }
    }
}
