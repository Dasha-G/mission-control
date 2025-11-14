using System.Drawing;
using System.Windows.Forms;

namespace Travelling.Controls
{
    partial class TravelerControl
    {
        private Label lblTitle;
        private Label lblName;
        private Label lblCurrentCity;
        private TextBox txtName;
        private TextBox txtCurrentCity;
        private Button btnCreateTraveler;
        private Button btnSave;
        private Button btnLoad;

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblName = new Label();
            lblCurrentCity = new Label();
            txtName = new TextBox();
            txtCurrentCity = new TextBox();
            btnCreateTraveler = new Button();
            btnSave = new Button();
            btnLoad = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(306, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(206, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Traveler Management";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblName
            // 
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(141, 80);
            lblName.Name = "lblName";
            lblName.Size = new Size(106, 31);
            lblName.TabIndex = 1;
            lblName.Text = "Traveler Name:";
            // 
            // lblCurrentCity
            // 
            lblCurrentCity.ForeColor = Color.White;
            lblCurrentCity.Location = new Point(141, 130);
            lblCurrentCity.Name = "lblCurrentCity";
            lblCurrentCity.Size = new Size(100, 23);
            lblCurrentCity.TabIndex = 3;
            lblCurrentCity.Text = "Current City:";
            // 
            // txtName
            // 
            txtName.Location = new Point(306, 77);
            txtName.Name = "txtName";
            txtName.Size = new Size(207, 25);
            txtName.TabIndex = 2;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtCurrentCity
            // 
            txtCurrentCity.Location = new Point(306, 127);
            txtCurrentCity.Name = "txtCurrentCity";
            txtCurrentCity.Size = new Size(207, 25);
            txtCurrentCity.TabIndex = 4;
            // 
            // btnCreateTraveler
            // 
            btnCreateTraveler.BackColor = Color.White;
            btnCreateTraveler.Location = new Point(141, 180);
            btnCreateTraveler.Name = "btnCreateTraveler";
            btnCreateTraveler.Size = new Size(150, 40);
            btnCreateTraveler.TabIndex = 5;
            btnCreateTraveler.Text = "Create Traveler";
            btnCreateTraveler.UseVisualStyleBackColor = false;
            btnCreateTraveler.Click += btnCreateTraveler_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.ForeColor = SystemColors.ActiveCaptionText;
            btnSave.Location = new Point(331, 180);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 40);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save Traveler";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.White;
            btnLoad.Location = new Point(514, 180);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(142, 40);
            btnLoad.TabIndex = 7;
            btnLoad.Text = "Load Traveler";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // TravelerControl
            // 
            BackColor = Color.FromArgb(30, 40, 66);
            Controls.Add(lblTitle);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblCurrentCity);
            Controls.Add(txtCurrentCity);
            Controls.Add(btnCreateTraveler);
            Controls.Add(btnSave);
            Controls.Add(btnLoad);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "TravelerControl";
            Size = new Size(1368, 703);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
