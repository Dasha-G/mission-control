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
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(306, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(134, 25);
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
            txtDestination.Size = new Size(207, 25);
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
            routeLabel.Size = new Size(500, 60);
            routeLabel.TabIndex = 5;
            routeLabel.Text = "Planned Route:";
            // 
            // RouteControl
            // 
            BackColor = Color.FromArgb(30, 40, 66);
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
    }
}
