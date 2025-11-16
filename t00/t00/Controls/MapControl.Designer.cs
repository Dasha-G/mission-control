using System.Drawing;
using System.Windows.Forms;

namespace Travelling.Controls
{
    partial class MapControl
    {
        private Label lblTitle;
        private Label lblDescription;
        private Button btnLoadMap;
        private Label lblStatus;
        private ListBox lstCities;

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblDescription = new Label();
            btnLoadMap = new Button();
            lblStatus = new Label();
            lstCities = new ListBox();
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
            lblTitle.Size = new Size(150, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Map Loader";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblDescription
            // 
            lblDescription.ForeColor = Color.White;
            lblDescription.Location = new Point(141, 80);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(400, 40);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Load a map from a .txt file";
            // 
            // btnLoadMap
            // 
            btnLoadMap.BackColor = Color.White;
            btnLoadMap.Location = new Point(141, 140);
            btnLoadMap.Name = "btnLoadMap";
            btnLoadMap.Size = new Size(150, 40);
            btnLoadMap.TabIndex = 2;
            btnLoadMap.Text = "Load Map";
            btnLoadMap.UseVisualStyleBackColor = false;
            btnLoadMap.Click += btnLoadMap_Click;
            // 
            // lblStatus
            // 
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(141, 200);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(300, 46);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "No map loaded";
            // 
            // lstCities
            // 
            lstCities.BackColor = Color.White;
            lstCities.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lstCities.ForeColor = Color.FromArgb(30, 40, 66);
            lstCities.ItemHeight = 17;
            lstCities.Location = new Point(141, 249);
            lstCities.Name = "lstCities";
            lstCities.Size = new Size(300, 191);
            lstCities.TabIndex = 4;
            // 
            // 
            // MapControl
            // 
            BackColor = Color.FromArgb(30, 40, 66);
            Controls.Add(AddRemoveLabel);
            Controls.Add(btnRemoveCity);
            Controls.Add(btnAddCity);
            Controls.Add(txtCityInput);
            Controls.Add(lblTitle);
            Controls.Add(lblDescription);
            Controls.Add(btnLoadMap);
            Controls.Add(lblStatus);
            Controls.Add(lstCities);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "MapControl";
            Size = new Size(1368, 703);
            Load += MapControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        private TextBox txtCityInput;
        private Button btnAddCity;
        private Button btnRemoveCity;
        private Label AddRemoveLabel;
    }
}
