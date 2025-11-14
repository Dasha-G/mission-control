using System;
using System.IO;
using System.Windows.Forms;
using Travelling;

namespace Travelling.Controls
{
    public partial class TravelerControl : UserControl
    {
        private readonly MainForm main;

        public TravelerControl(MainForm main)
        {
            this.main = main ?? throw new ArgumentNullException(nameof(main));
            InitializeComponent();
        }

        private void btnCreateTraveler_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtCurrentCity.Text))
            {
                MessageBox.Show("Please enter traveler name and current city.",
                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            main.traveler = new Traveler(txtName.Text);
            main.traveler.SetLocation(txtCurrentCity.Text);

            MessageBox.Show(
                $"Traveler '{txtName.Text}' created. Current city: {txtCurrentCity.Text}.",
                "Traveler Created",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (main == null || main.traveler == null)
            {
                MessageBox.Show("Please create or load a traveler first.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var choice = MessageBox.Show(
                "Do you want to save to an existing file?\n\n" +
                "Yes — select an existing file\n" +
                "No — create a new one\n" +
                "Cancel - exit",
                "Save traveler",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            if (choice == DialogResult.Cancel)
                return;

            try
            {
                string path;

                if (choice == DialogResult.Yes)
                {
                    using var ofd = new OpenFileDialog
                    {
                        Title = "Select an existing file",
                        Filter = "Traveler (*.json)|*.json",
                        CheckFileExists = true
                    };

                    if (ofd.ShowDialog() != DialogResult.OK)
                        return;

                    path = ofd.FileName;
                }
                else
                {
                    using var sfd = new SaveFileDialog
                    {
                        Title = "Create a new file",
                        Filter = "Traveler (*.json)|*.json",
                        FileName = "traveler.json",
                        OverwritePrompt = false
                    };

                    if (sfd.ShowDialog() != DialogResult.OK)
                        return;

                    path = sfd.FileName;

                    if (File.Exists(path))
                    {
                        var overwrite = MessageBox.Show(
                            "This file already exists. Overwrite it?",
                            "Confirm overwrite",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);

                        if (overwrite == DialogResult.No)
                            return;
                    }
                }

                var dir = Path.GetDirectoryName(path);
                if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
                    Directory.CreateDirectory(dir);

                main.traveler.SaveToFile(path);

                MessageBox.Show("Traveler saved successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving:\n" + ex,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using var openFileDialog = new OpenFileDialog
            {
                Title = "Choose traveler file",
                Filter = "Traveler files (*.json)|*.json|All files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                string path = openFileDialog.FileName;

                main.traveler = Traveler.LoadFromFile(path);

                MessageBox.Show("Traveler loaded successfully.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading traveler:\n" + ex,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateUI()
        {
            if (main.traveler == null)
                return;

            txtName.Text = main.traveler.GetName();
            txtCurrentCity.Text = main.traveler.GetLocation();
        }


        private void txtName_TextChanged(object sender, EventArgs e) { }

        private void lblTitle_Click(object sender, EventArgs e) { }
    }
}
