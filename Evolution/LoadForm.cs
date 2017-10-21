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

namespace Evolution
{
    public partial class LoadForm : Form
    {
        public string SelectedPath = string.Empty;

        public LoadForm()
        {
            InitializeComponent();
        }

        private void LoadForm_Load(object sender, EventArgs e)
        {
            try
            {
                string[] directories = Directory.GetDirectories(Directory.GetCurrentDirectory() + "\\log");
                directories = directories.OrderBy(x => Directory.GetCreationTime(x)).ToArray();
                for (int i = 0; i < directories.Length; i++)
                {
                    if (Directory.Exists(directories[i] + "\\Generation 0"))
                        simulationListBox.Items.Add(directories[i].Split('\\').Last());
                }
            }
            catch (Exception ex)
            {
                simulationListBox.Items.Clear();
                simulationListBox.Items.Add("ERROR: An error occured");
                generationListBox.Items.Clear();
                generationListBox.Items.Add("ERROR: An error occured");
                if (!Directory.Exists("error"))
                    Directory.CreateDirectory("error");
                File.AppendAllText($"error\\Error_LoadForm_{DateTime.Now.ToString("dd-MM-yyyy--HH-mm-ss")}.txt", ex.ToString() + Environment.NewLine + Environment.NewLine);
            }
        }

        private void simulationListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            generationListBox.Items.Clear();
            SelectedPath = "";
            string nameOfDir = simulationListBox.SelectedItem.ToString();

            try
            {
                string[] directories = Directory.GetDirectories(Directory.GetCurrentDirectory() + "\\log\\" + nameOfDir);
                directories = directories.OrderBy(x => Directory.GetCreationTime(x)).ToArray();
                for (int i = 0; i < directories.Length; i++)
                {
                    string[] files = Directory.GetFiles(directories[i]);
                    var query = files.Select(x => Path.GetFileName(x));
                    if (query.Where(x => x.EndsWith(".map")).Count() > 0 &&
                    query.Where(x => x.EndsWith(".species")).Count() > 0)
                    {
                        generationListBox.Items.Add(directories[i].Split('\\').Last());
                    }
                }
            }
            catch (Exception ex)
            {
                generationListBox.Items.Clear();
                generationListBox.Items.Add("ERROR: An error occured");
                if (!Directory.Exists("error"))
                    Directory.CreateDirectory("error");
                File.AppendAllText($"error\\Error_LoadForm_{DateTime.Now.ToString("dd-MM-yyyy--HH-mm-ss")}.txt", ex.ToString() + Environment.NewLine + Environment.NewLine);

            }

            try
            {
                detailsPictureBox.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\log\\" + simulationListBox.SelectedItem + "\\Generation 0\\end of generation.png");
            }
            catch
            {
                detailsPictureBox.Image = Properties.Resources.preview;
            }
        }

        private void generationListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SelectedPath = Directory.GetCurrentDirectory() + "\\log\\" + simulationListBox.SelectedItem + "\\" + generationListBox.SelectedItem;
                detailsPictureBox.Image = Image.FromFile(SelectedPath + "\\end of generation.png");
            }
            catch
            {
                detailsPictureBox.Image = Properties.Resources.preview;
            }
        }
    }
}
