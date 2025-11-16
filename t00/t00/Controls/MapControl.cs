using System;
using System.IO;
using System.Windows.Forms;
using Travelling;

namespace Travelling.Controls
{
    public partial class MapControl : UserControl
    {
        private readonly MainForm main;

        public MapControl(MainForm main)
        {
            this.main = main;
            InitializeComponent();
        }

        private void btnLoadMap_Click(object sender, EventArgs e)
        {
            using var openFileDialog = new OpenFileDialog
            {
                Title = "Choose a file for map",
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                string path = openFileDialog.FileName;

                main.map = CityGraph.LoadFromFile(path);

                MessageBox.Show("Map is successfully loaded.", "OK",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                var cities = main.map.GetAllCities();
                lstCities.Items.Clear();
                lstCities.Items.AddRange(cities.ToArray());

                lblStatus.Text = $"Map loaded from: {Path.GetFileName(path)}\nCities: {cities.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading map: Map file not found or invalid format\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MapControl_Load(object sender, EventArgs e)
        {

        }
    }
}