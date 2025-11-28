using System.Drawing;
using System.Windows.Forms;

namespace Travelling.Controls
{
    partial class RouteControl
    {
        private Label lblTitle;
        private Label lblDestination;
        private TextBox txtDestination;
        private Button btnPlanRoute;
        private Button btnClearRoute;
        private Label routeLabel;

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblDestination = new Label();
            txtDestination = new TextBox();
            btnPlanRoute = new Button();
            btnClearRoute = new Button();
            routeLabel = new Label();
            totalDistanceLabel = new Label();
            txtCityInput = new TextBox();
            btnAddCity = new Button();
            btnRemoveCity = new Button();
            AddRemoveLabel = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(306, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(176, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Route Planner";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblDestination
            // 
            lblDestination.ForeColor = Color.White;
            lblDestination.Location = new Point(141, 80);
            lblDestination.Name = "lblDestination";
            lblDestination.Size = new Size(130, 31);
            lblDestination.TabIndex = 1;
            lblDestination.Text = "Destination City:";
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(306, 77);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(207, 29);
            txtDestination.TabIndex = 2;
            // 
            // btnPlanRoute
            // 
            btnPlanRoute.BackColor = Color.White;
            btnPlanRoute.Location = new Point(141, 130);
            btnPlanRoute.Name = "btnPlanRoute";
            btnPlanRoute.Size = new Size(150, 40);
            btnPlanRoute.TabIndex = 3;
            btnPlanRoute.Text = "Plan Route";
            btnPlanRoute.UseVisualStyleBackColor = false;
            btnPlanRoute.Click += btnPlanRoute_Click;
            // 
            // btnClearRoute
            // 
            btnClearRoute.BackColor = Color.White;
            btnClearRoute.Location = new Point(331, 130);
            btnClearRoute.Name = "btnClearRoute";
            btnClearRoute.Size = new Size(150, 40);
            btnClearRoute.TabIndex = 4;
            btnClearRoute.Text = "Clear Route";
            btnClearRoute.UseVisualStyleBackColor = false;
            btnClearRoute.Click += btnClearRoute_Click;
            // 
            // routeLabel
            // 
            routeLabel.ForeColor = Color.White;
            routeLabel.Location = new Point(141, 200);
            routeLabel.Name = "routeLabel";
            routeLabel.Size = new Size(541, 96);
            routeLabel.TabIndex = 5;
            routeLabel.Text = "Planned Route:";
            // 
            // totalDistanceLabel
            // 
            totalDistanceLabel.AutoSize = true;
            totalDistanceLabel.ForeColor = Color.White;
            totalDistanceLabel.Location = new Point(141, 330);
            totalDistanceLabel.Name = "totalDistanceLabel";
            totalDistanceLabel.Size = new Size(162, 23);
            totalDistanceLabel.TabIndex = 6;
            totalDistanceLabel.Text = "Total Distance: 0 km";
            totalDistanceLabel.Click += label1_Click;
            // 
            // txtCityInput
            // 
            txtCityInput.Location = new Point(141, 441);
            txtCityInput.Name = "txtCityInput";
            txtCityInput.Size = new Size(207, 29);
            txtCityInput.TabIndex = 7;
            txtCityInput.TextChanged += txtCityInput_TextChanged;
            // 
            // btnAddCity
            // 
            btnAddCity.BackColor = Color.White;
            btnAddCity.Location = new Point(141, 496);
            btnAddCity.Name = "btnAddCity";
            btnAddCity.Size = new Size(150, 40);
            btnAddCity.TabIndex = 8;
            btnAddCity.Text = "Add City";
            btnAddCity.UseVisualStyleBackColor = false;
            btnAddCity.Click += btnAddCity_Click;
            // 
            // btnRemoveCity
            // 
            btnRemoveCity.BackColor = Color.White;
            btnRemoveCity.Location = new Point(331, 496);
            btnRemoveCity.Name = "btnRemoveCity";
            btnRemoveCity.Size = new Size(150, 40);
            btnRemoveCity.TabIndex = 9;
            btnRemoveCity.Text = "Remove City";
            btnRemoveCity.UseVisualStyleBackColor = false;
            btnRemoveCity.Click += btnRemoveCity_Click;
            // 
            // AddRemoveLabel
            // 
            AddRemoveLabel.AutoSize = true;
            AddRemoveLabel.ForeColor = Color.White;
            AddRemoveLabel.Location = new Point(141, 405);
            AddRemoveLabel.Name = "AddRemoveLabel";
            AddRemoveLabel.Size = new Size(143, 23);
            AddRemoveLabel.TabIndex = 10;
            AddRemoveLabel.Text = "Add/Remove City";
            // 
            // RouteControl
            // 
            BackColor = Color.FromArgb(30, 40, 66);
            Controls.Add(AddRemoveLabel);
            Controls.Add(btnRemoveCity);
            Controls.Add(btnAddCity);
            Controls.Add(txtCityInput);
            Controls.Add(totalDistanceLabel);
            Controls.Add(lblTitle);
            Controls.Add(lblDestination);
            Controls.Add(txtDestination);
            Controls.Add(btnPlanRoute);
            Controls.Add(btnClearRoute);
            Controls.Add(routeLabel);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "RouteControl";
            Size = new Size(1368, 703);
            ResumeLayout(false);
            PerformLayout();
        }
        private Label totalDistanceLabel;
        private TextBox txtCityInput;
        private Button btnAddCity;
        private Button btnRemoveCity;
        private Label AddRemoveLabel;
    }
}
