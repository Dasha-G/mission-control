using System;
using System.Windows.Forms;
using Travelling;

namespace Travelling.Controls
{
    public partial class RouteControl : UserControl
    {
        private readonly MainForm main;

        public RouteControl(MainForm main)
        {
            this.main = main;
            InitializeComponent();
        }

        private void btnPlanRoute_Click(object sender, EventArgs e)
        {
            if (main.traveler == null)
            {
                MessageBox.Show("Please create or load a traveler first",
                    "No traveler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (main.map == null)
            {
                MessageBox.Show("Please load a map first",
                    "No map", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dest = txtDestination.Text?.Trim();
            if (string.IsNullOrWhiteSpace(dest))
            {
                MessageBox.Show("Please enter a destination city",
                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                main.traveler.PlanRouteTo(dest, main.map);

                routeLabel.Text = main.traveler.GetRoute();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while planning route:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearRoute_Click(object sender, EventArgs e)
        {
            if (main.traveler == null)
            {
                MessageBox.Show("No traveler to clear route for.",
                    "No traveler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                main.traveler.ClearRoute();
                routeLabel.Text = "Planned Route:";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while clearing route:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
        }
    }
}
