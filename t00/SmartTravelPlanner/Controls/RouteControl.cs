using System;
using System.Collections.Generic;
using System.Linq;
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
        private string FormatCityName(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return string.Empty;
            var tempTraveller = new Traveler("Temp");
            tempTraveller.SetLocation(input);
            return tempTraveller.GetLocation() ?? string.Empty;
        }
        private void RecalculateAndDisplayRoute()
        {
            if (main.traveler == null || main.map == null)
            {
                UpdateRouteDisplay("", 0);
                return;
            }

            string routeString = main.traveler.GetRoute();
            if (string.IsNullOrEmpty(routeString))
            {
                UpdateRouteDisplay("", 0);
                return;
            }
            List<string> routeList = new List<string>(routeString.Split(new[] { " -> " }, StringSplitOptions.None));
            int distance = main.map.GetPathDistance(routeList);
            if (distance < 0)
            {
                main.logger.Add($"Error: Could not calculate distance for route: {routeString}. Check map connections.");
                distance = 0;
            }

            UpdateRouteDisplay(routeString, distance);
        }
        public void UpdateRouteDisplay(string routeString, int distance)
        {
            if (!string.IsNullOrEmpty(routeString))
            {
                string formattedRoute = routeString.Replace(" -> ", Environment.NewLine);

                routeLabel.Text = "Planned Route:\n" + formattedRoute;

                totalDistanceLabel.Text = $"Total Distance: {distance:F0} km";
            }
            else
            {
                routeLabel.Text = "Planned Route:";
                totalDistanceLabel.Text = "Total Distance: 0 km";
            }
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
            dest = FormatCityName(dest);
            txtDestination.Text = dest;
            this.Cursor = Cursors.WaitCursor;
            try
            {
                bool success = main.traveler.PlanRouteTo(dest, main.map);

                if (success)
                {
                    RecalculateAndDisplayRoute();

                    int distance = 0;
                    string routeString = main.traveler.GetRoute();
                    if (!string.IsNullOrEmpty(routeString))
                    {
                        List<string> routeList = new List<string>(routeString.Split(new[] { " -> " }, StringSplitOptions.None));
                        distance = main.map.GetPathDistance(routeList);
                    }

                    main.logger.Add($"Traveler {main.traveler.GetName()} planned route to {dest}. Distance: {distance} km");
                }
                else
                {
                    UpdateRouteDisplay("", 0);
                    MessageBox.Show("Route not found. Destination is unreachable", "Route Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (ArgumentException ex)
            {
                UpdateRouteDisplay("", 0);
                MessageBox.Show(ex.Message, "Input Error: Current City", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                UpdateRouteDisplay("", 0);
                MessageBox.Show("Error while planning route:\n" + ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
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
                UpdateRouteDisplay("", 0);
                main.logger.Add($"Route cleared for traveler {main.traveler.GetName()}");
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCityInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            if (main.traveler == null || main.map == null)
            {
                MessageBox.Show("Please load a traveler and a map first.", "Setup Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var cityName = txtCityInput.Text?.Trim();
            if (string.IsNullOrWhiteSpace(cityName))
            {
                MessageBox.Show("Please enter a city name to add.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var cityToAdd = FormatCityName(cityName);
            List<string> currentRoute = main.traveler.GetCities();
            if (currentRoute.Contains(cityToAdd))
            {
                MessageBox.Show($"City '{cityToAdd}' is already in the route.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!main.map.CityExists(cityToAdd))
            {
                MessageBox.Show("Destination not reachable or not in map.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (currentRoute.Count == 0)
            {
                currentRoute.Add(cityToAdd);
            }
            else
            {
                string finalDestination = currentRoute.Last();
                if (currentRoute.Count > 1)
                {
                    currentRoute.RemoveAt(currentRoute.Count - 1);
                }
                currentRoute.Add(cityToAdd);
                if (currentRoute.Count > 1 && finalDestination != currentRoute.First())
                {
                    currentRoute.Add(finalDestination);
                }
            }
            main.traveler.SetCities(currentRoute);
            RecalculateAndDisplayRoute();
            main.logger.Add($"City '{cityToAdd}' inserted into traveler's route (before destination).");
            txtDestination.Clear();
        }

        private void btnRemoveCity_Click(object sender, EventArgs e)
        {
            if (main.traveler == null || main.map == null)
            {
                MessageBox.Show("Please load a traveler and a map first.", "Setup Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var cityName = txtCityInput.Text?.Trim();
            if (string.IsNullOrWhiteSpace(cityName))
            {
                MessageBox.Show("Please enter the city name to remove.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var formattedCity = FormatCityName(cityName);

            if (!main.map.CityExists(formattedCity))
            {
                MessageBox.Show("Destination not reachable or not in map.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (main.traveler.RemoveCity(formattedCity))
            {
                RecalculateAndDisplayRoute();
                main.logger.Add($"City '{formattedCity}' removed from traveler's route.");
                txtDestination.Clear();
            }
            else
            {
                MessageBox.Show($"City '{formattedCity}' is not found in the current route.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
