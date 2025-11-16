using System.Drawing;
using System.Windows.Forms;

namespace Travelling
{
    partial class MainForm
    {
        private Panel panelMenu;
        private Panel panelContent;
        private Button btnTraveler;
        private Button btnMap;
        private Button btnPlanner;
        private Button btnExit;

        private void InitializeComponent()
        {
            panelMenu = new Panel();
            btnPlanner = new Button();
            btnMap = new Button();
            btnExit = new Button();
            btnTraveler = new Button();
            panelContent = new Panel();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(24, 31, 53);
            panelMenu.Controls.Add(btnPlanner);
            panelMenu.Controls.Add(btnMap);
            panelMenu.Controls.Add(btnExit);
            panelMenu.Controls.Add(btnTraveler);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 4, 3, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(229, 800);
            panelMenu.TabIndex = 1;
            // 
            // btnPlanner
            // 
            btnPlanner.Dock = DockStyle.Top;
            btnPlanner.FlatAppearance.BorderSize = 0;
            btnPlanner.FlatStyle = FlatStyle.Flat;
            btnPlanner.Font = new Font("Segoe UI", 11F);
            btnPlanner.ForeColor = Color.White;
            btnPlanner.Location = new Point(0, 152);
            btnPlanner.Margin = new Padding(3, 4, 3, 4);
            btnPlanner.Name = "btnPlanner";
            btnPlanner.Size = new Size(229, 72);
            btnPlanner.TabIndex = 2;
            btnPlanner.Text = "Route Planner";
            btnPlanner.Click += btnPlanner_Click;
            // 
            // btnMap
            // 
            btnMap.Dock = DockStyle.Top;
            btnMap.FlatAppearance.BorderSize = 0;
            btnMap.FlatStyle = FlatStyle.Flat;
            btnMap.Font = new Font("Segoe UI", 11F);
            btnMap.ForeColor = Color.White;
            btnMap.Location = new Point(0, 80);
            btnMap.Margin = new Padding(3, 4, 3, 4);
            btnMap.Name = "btnMap";
            btnMap.Size = new Size(229, 72);
            btnMap.TabIndex = 1;
            btnMap.Text = "Map";
            btnMap.Click += btnMap_Click;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Bottom;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnExit.ForeColor = Color.FromArgb(255, 120, 120);
            btnExit.Location = new Point(0, 720);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(229, 80);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.Click += btnExit_Click;
            // 
            // btnTraveler
            // 
            btnTraveler.Dock = DockStyle.Top;
            btnTraveler.FlatAppearance.BorderSize = 0;
            btnTraveler.FlatStyle = FlatStyle.Flat;
            btnTraveler.Font = new Font("Segoe UI", 11F);
            btnTraveler.ForeColor = Color.White;
            btnTraveler.Location = new Point(0, 0);
            btnTraveler.Margin = new Padding(3, 4, 3, 4);
            btnTraveler.Name = "btnTraveler";
            btnTraveler.Size = new Size(229, 80);
            btnTraveler.TabIndex = 0;
            btnTraveler.Text = "Traveler";
            btnTraveler.Click += btnTraveler_Click;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(42, 54, 80);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(229, 0);
            panelContent.Margin = new Padding(3, 4, 3, 4);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(914, 800);
            panelContent.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 40, 66);
            ClientSize = new Size(1143, 800);
            Controls.Add(panelContent);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Mission Control";
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
