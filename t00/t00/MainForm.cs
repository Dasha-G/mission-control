using System;
using System.Windows.Forms;
using Travelling.Controls;

namespace Travelling
{
    public partial class MainForm : Form
    {
        public Traveler traveler { get; set; }
        public CityGraph map { get; set; }

        private TravelerControl travelerControl;
        private RouteControl routeControl;
        private MapControl mapControl;

        public MainForm()
        {
            InitializeComponent();

            travelerControl = new TravelerControl(this);
            routeControl = new RouteControl(this);
            mapControl = new MapControl(this);

            ShowControl(travelerControl);
        }

        public void ShowControl(UserControl control)
        {
            panelContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContent.Controls.Add(control);
        }

        private void btnTraveler_Click(object sender, EventArgs e)
        {
            ShowControl(travelerControl);
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            ShowControl(mapControl);
        }

        private void btnPlanner_Click(object sender, EventArgs e)
        {
            ShowControl(routeControl);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Settings page is not ready");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


//        private void MainForm_Load(object sender, EventArgs e)
//        {

//        }

//        private void btnLoadMap_Click(object sender, EventArgs e)
//        {
//            OpenFileDialog openFileDialog = new OpenFileDialog();
//            openFileDialog.Title = "Choose a file for map";
//            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

//            if (openFileDialog.ShowDialog() == DialogResult.OK)
//            {
//                try
//                {
//                    string path = openFileDialog.FileName;

//                    map = CityGraph.LoadFromFile(path);
//                    MessageBox.Show("Map is successfully loaded", "OK",
//                        MessageBoxButtons.OK, MessageBoxIcon.Information);
//                }

//                catch (Exception ex)
//                {
//                    MessageBox.Show("Error while loading map:\n" + ex.Message,
//                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                }
//            }
//        }

//        private void btnCreateTraveler_Click(object sender, EventArgs e)
//        {
//            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtCurrentCity.Text))
//            {
//                MessageBox.Show("Please enter traveler name and current city.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return;
//            }

//            traveler = new Traveler(txtName.Text);
//            traveler.SetLocation(txtCurrentCity.Text);

//            MessageBox.Show($"Traveler '{txtName.Text}' created. Current city: {txtCurrentCity.Text}.",
//                            "Traveler Created",
//                            MessageBoxButtons.OK,
//                            MessageBoxIcon.Information);

//        }

//        private void textBox1_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
//        {

//        }

//        private void label1_Click(object sender, EventArgs e)
//        {

//        }

//        private void btnSave_Click(object sender, EventArgs e)
//        {
//            var choice = MessageBox.Show(
//            "Do you want to save to an existing file?\n\n" +
//            "Yes — select an existing file\n" +
//            "No — create a new one\n" +
//            "Cancel — abort",
//            "Save traveler",
//            MessageBoxButtons.YesNoCancel,
//            MessageBoxIcon.Question);

//            if (choice == DialogResult.Cancel)
//                return;

//            try
//            {
//                string path = null;

//                if (choice == DialogResult.Yes)
//                {
//                    using var ofd = new OpenFileDialog
//                    {
//                        Title = "Select an existing file",
//                        Filter = "Traveler (*.json)|*.json",
//                        CheckFileExists = true
//                    };

//                    if (ofd.ShowDialog() != DialogResult.OK)
//                        return;

//                    path = ofd.FileName;
//                }
//                else
//                {
//                    using var sfd = new SaveFileDialog
//                    {
//                        Title = "Create a new file",
//                        Filter = "Traveler (*.json)|*.json",
//                        FileName = "traveler.json",
//                        OverwritePrompt = false
//                    };

//                    if (sfd.ShowDialog() != DialogResult.OK)
//                        return;

//                    path = sfd.FileName;

//                    if (File.Exists(path))
//                    {
//                        var overwrite = MessageBox.Show(
//                            "This file already exists. Overwrite it?",
//                            "Confirm overwrite",
//                            MessageBoxButtons.YesNo,
//                            MessageBoxIcon.Warning);

//                        if (overwrite == DialogResult.No)
//                            return;
//                    }
//                }

//                var dir = Path.GetDirectoryName(path);
//                if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
//                    Directory.CreateDirectory(dir);

//                traveler.SaveToFile(path);

//                MessageBox.Show("Traveler saved successfully!",
//                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Error while saving:\n" + ex.Message,
//                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void totalDistanceLabel_Click(object sender, EventArgs e)
//        {

//        }

//        private void DestinationLabel_Click(object sender, EventArgs e)
//        {

//        }

//        private void btnLoad_Click(object sender, EventArgs e)
//        {
//            OpenFileDialog openFileDialog = new OpenFileDialog();
//            openFileDialog.Title = "Choose json file";
//            openFileDialog.Filter = "Traveler files (*.json)|*.json|All files (*.*)|*.*";

//            if (openFileDialog.ShowDialog() == DialogResult.OK)
//            {
//                try
//                {
//                    string path = openFileDialog.FileName;
//                    traveler = Traveler.LoadFromFile(path);
//                    MessageBox.Show("Traveler is successfully loaded", "Success",
//                        MessageBoxButtons.OK, MessageBoxIcon.Information);
//                }
//                catch (Exception ex)
//                {
//                    MessageBox.Show("Error while loading traveler:\n" + ex.Message,
//                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                }
//            }
//        }

//        private void btnPlanRoute_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                var dest = txtDestination.Text?.Trim();
//                traveler.PlanRouteTo(dest, map);

//                routeLabel.Text = traveler.GetRoute();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void btnClearRoute_Click(object sender, EventArgs e)
//        {
//            traveler.ClearRoute();
//        }

//        private void btnAddCity_Click(object sender, EventArgs e)
//        {

//        }

//        private void btnRemoveCity_Click(object sender, EventArgs e)
//        {

//        }

//        private void routeLabel_Click(object sender, EventArgs e)
//        {

//        }

//        private void panel1_Paint(object sender, PaintEventArgs e)
//        {

//        }

//        private void MainForm_Resize(object sender, EventArgs e)
//        {
//            if (panel1 != null)
//            {
//                int newX = (this.Width / 2) - (panel1.Width / 2);

//                panel1.Location = new Point(newX, panel1.Location.Y);
//            }
//        }

//        private void routeListBox_SelectedIndexChanged(object sender, EventArgs e)
//        {

//        }
//    }
