using System;
using System.Windows.Forms;
using Travelling.Controls;

namespace Travelling
{
    public partial class MainForm : Form
    {
        public Traveler? traveler { get; set; }
        public CityGraph? map { get; set; }
        public Logger<string> logger { get; } = new Logger<string>();

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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
