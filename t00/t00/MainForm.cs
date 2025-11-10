using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace t00
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            if (panel1 != null)
            {
                int initialX = (this.Width / 2) - (panel1.Width / 2);
                panel1.Location = new Point(initialX, panel1.Location.Y);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLoadMap_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateTraveler_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtCurrentCity.Text))
            {
                MessageBox.Show("Please enter traveler name and current city.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void totalDistanceLabel_Click(object sender, EventArgs e)
        {

        }

        private void DestinationLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void btnPlanRoute_Click(object sender, EventArgs e)
        {

        }

        private void btnClearRoute_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCity_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveCity_Click(object sender, EventArgs e)
        {

        }

        private void routeLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (panel1 != null)
            {
                int newX = (this.Width / 2) - (panel1.Width / 2);

                panel1.Location = new Point(newX, panel1.Location.Y);
            }
        }

        private void routeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
