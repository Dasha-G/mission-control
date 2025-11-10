namespace t00
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnExit = new Button();
            txtName = new TextBox();
            txtCurrentCity = new TextBox();
            btnCreateTraveler = new Button();
            btnLoadMap = new Button();
            btnSave = new Button();
            btnLoad = new Button();
            citiesListBox = new ListBox();
            txtNewCity = new TextBox();
            btnAddCity = new Button();
            btnRemoveCity = new Button();
            routeLabel = new Label();
            totalDistanceLabel = new Label();
            TravelerNameLabel = new Label();
            CurrentCityLabel = new Label();
            AvailCityLabel = new Label();
            routeListBox = new ListBox();
            panel1 = new Panel();
            DestinationLabel = new Label();
            btnClearRoute = new Button();
            btnPlanRoute = new Button();
            txtDestination = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnExit.Font = new Font("Avignon Pro", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.FromArgb(30, 40, 66);
            btnExit.Location = new Point(3, 712);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(1361, 50);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtName
            // 
            txtName.Font = new Font("Avignon Pro", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.FromArgb(30, 40, 66);
            txtName.Location = new Point(71, 65);
            txtName.Name = "txtName";
            txtName.Size = new Size(316, 27);
            txtName.TabIndex = 1;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // txtCurrentCity
            // 
            txtCurrentCity.Font = new Font("Avignon Pro", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCurrentCity.ForeColor = Color.FromArgb(30, 40, 66);
            txtCurrentCity.Location = new Point(71, 143);
            txtCurrentCity.Name = "txtCurrentCity";
            txtCurrentCity.Size = new Size(316, 27);
            txtCurrentCity.TabIndex = 2;
            // 
            // btnCreateTraveler
            // 
            btnCreateTraveler.Font = new Font("Avignon Pro", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateTraveler.ForeColor = Color.FromArgb(30, 40, 66);
            btnCreateTraveler.Location = new Point(71, 277);
            btnCreateTraveler.Name = "btnCreateTraveler";
            btnCreateTraveler.Size = new Size(316, 58);
            btnCreateTraveler.TabIndex = 4;
            btnCreateTraveler.Text = "Create Traveler";
            btnCreateTraveler.UseVisualStyleBackColor = true;
            btnCreateTraveler.Click += btnCreateTraveler_Click;
            // 
            // btnLoadMap
            // 
            btnLoadMap.Font = new Font("Avignon Pro", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoadMap.ForeColor = Color.FromArgb(30, 40, 66);
            btnLoadMap.Location = new Point(71, 198);
            btnLoadMap.Name = "btnLoadMap";
            btnLoadMap.Size = new Size(316, 58);
            btnLoadMap.TabIndex = 5;
            btnLoadMap.Text = "Load Map";
            btnLoadMap.UseVisualStyleBackColor = true;
            btnLoadMap.Click += btnLoadMap_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Avignon Pro", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.FromArgb(30, 40, 66);
            btnSave.Location = new Point(71, 353);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(155, 58);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Avignon Pro", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoad.ForeColor = Color.FromArgb(30, 40, 66);
            btnLoad.Location = new Point(232, 353);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(155, 58);
            btnLoad.TabIndex = 8;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // citiesListBox
            // 
            citiesListBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            citiesListBox.Font = new Font("Avignon Pro", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            citiesListBox.ForeColor = Color.FromArgb(30, 40, 66);
            citiesListBox.FormattingEnabled = true;
            citiesListBox.Location = new Point(972, 65);
            citiesListBox.Name = "citiesListBox";
            citiesListBox.Size = new Size(316, 64);
            citiesListBox.TabIndex = 10;
            citiesListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // txtNewCity
            // 
            txtNewCity.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtNewCity.Font = new Font("Avignon Pro", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewCity.ForeColor = Color.FromArgb(30, 40, 66);
            txtNewCity.Location = new Point(972, 198);
            txtNewCity.Name = "txtNewCity";
            txtNewCity.Size = new Size(316, 27);
            txtNewCity.TabIndex = 11;
            // 
            // btnAddCity
            // 
            btnAddCity.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddCity.Font = new Font("Avignon Pro", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddCity.ForeColor = Color.FromArgb(30, 40, 66);
            btnAddCity.Location = new Point(972, 277);
            btnAddCity.Name = "btnAddCity";
            btnAddCity.Size = new Size(316, 58);
            btnAddCity.TabIndex = 12;
            btnAddCity.Text = "Add City";
            btnAddCity.UseVisualStyleBackColor = true;
            btnAddCity.Click += btnAddCity_Click;
            // 
            // btnRemoveCity
            // 
            btnRemoveCity.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRemoveCity.Font = new Font("Avignon Pro", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemoveCity.ForeColor = Color.FromArgb(30, 40, 66);
            btnRemoveCity.Location = new Point(972, 353);
            btnRemoveCity.Name = "btnRemoveCity";
            btnRemoveCity.Size = new Size(316, 58);
            btnRemoveCity.TabIndex = 13;
            btnRemoveCity.Text = "Remove City";
            btnRemoveCity.UseVisualStyleBackColor = true;
            btnRemoveCity.Click += btnRemoveCity_Click;
            // 
            // routeLabel
            // 
            routeLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            routeLabel.AutoSize = true;
            routeLabel.Font = new Font("Avignon Pro", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            routeLabel.ForeColor = Color.FromArgb(230, 215, 196);
            routeLabel.Location = new Point(289, 505);
            routeLabel.Name = "routeLabel";
            routeLabel.Size = new Size(120, 20);
            routeLabel.TabIndex = 14;
            routeLabel.Text = "Planned Route:";
            routeLabel.Click += routeLabel_Click;
            // 
            // totalDistanceLabel
            // 
            totalDistanceLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            totalDistanceLabel.AutoSize = true;
            totalDistanceLabel.Font = new Font("Avignon Pro", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalDistanceLabel.ForeColor = Color.FromArgb(230, 215, 196);
            totalDistanceLabel.Location = new Point(799, 551);
            totalDistanceLabel.Name = "totalDistanceLabel";
            totalDistanceLabel.Size = new Size(273, 33);
            totalDistanceLabel.TabIndex = 15;
            totalDistanceLabel.Text = "Total Distance: __ km";
            totalDistanceLabel.Click += totalDistanceLabel_Click;
            // 
            // TravelerNameLabel
            // 
            TravelerNameLabel.AutoSize = true;
            TravelerNameLabel.Font = new Font("Avignon Pro", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TravelerNameLabel.ForeColor = Color.FromArgb(230, 215, 196);
            TravelerNameLabel.Location = new Point(71, 28);
            TravelerNameLabel.Name = "TravelerNameLabel";
            TravelerNameLabel.Size = new Size(119, 20);
            TravelerNameLabel.TabIndex = 16;
            TravelerNameLabel.Text = "Traveler Name:";
            TravelerNameLabel.Click += label1_Click;
            // 
            // CurrentCityLabel
            // 
            CurrentCityLabel.AutoSize = true;
            CurrentCityLabel.Font = new Font("Avignon Pro", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CurrentCityLabel.ForeColor = Color.FromArgb(230, 215, 196);
            CurrentCityLabel.Location = new Point(71, 109);
            CurrentCityLabel.Name = "CurrentCityLabel";
            CurrentCityLabel.Size = new Size(98, 20);
            CurrentCityLabel.TabIndex = 17;
            CurrentCityLabel.Text = "Current City:";
            // 
            // AvailCityLabel
            // 
            AvailCityLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AvailCityLabel.AutoSize = true;
            AvailCityLabel.Font = new Font("Avignon Pro", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AvailCityLabel.ForeColor = Color.FromArgb(230, 215, 196);
            AvailCityLabel.Location = new Point(972, 28);
            AvailCityLabel.Name = "AvailCityLabel";
            AvailCityLabel.Size = new Size(123, 20);
            AvailCityLabel.TabIndex = 19;
            AvailCityLabel.Text = "Available Cities:";
            // 
            // routeListBox
            // 
            routeListBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            routeListBox.Font = new Font("Avignon Pro", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            routeListBox.ForeColor = Color.FromArgb(30, 40, 66);
            routeListBox.FormattingEnabled = true;
            routeListBox.Location = new Point(289, 540);
            routeListBox.Name = "routeListBox";
            routeListBox.Size = new Size(316, 64);
            routeListBox.TabIndex = 20;
            routeListBox.SelectedIndexChanged += routeListBox_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(DestinationLabel);
            panel1.Controls.Add(btnClearRoute);
            panel1.Controls.Add(btnPlanRoute);
            panel1.Controls.Add(txtDestination);
            panel1.Location = new Point(470, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(452, 407);
            panel1.TabIndex = 21;
            panel1.Paint += panel1_Paint;
            // 
            // DestinationLabel
            // 
            DestinationLabel.AutoSize = true;
            DestinationLabel.ForeColor = Color.FromArgb(230, 215, 196);
            DestinationLabel.Location = new Point(68, 12);
            DestinationLabel.Name = "DestinationLabel";
            DestinationLabel.Size = new Size(117, 20);
            DestinationLabel.TabIndex = 22;
            DestinationLabel.Text = "Destination City:";
            // 
            // btnClearRoute
            // 
            btnClearRoute.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnClearRoute.Font = new Font("Avignon Pro", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClearRoute.ForeColor = Color.FromArgb(30, 40, 66);
            btnClearRoute.Location = new Point(68, 337);
            btnClearRoute.Name = "btnClearRoute";
            btnClearRoute.Size = new Size(316, 58);
            btnClearRoute.TabIndex = 21;
            btnClearRoute.Text = "Clear Route";
            btnClearRoute.UseVisualStyleBackColor = true;
            // 
            // btnPlanRoute
            // 
            btnPlanRoute.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnPlanRoute.Font = new Font("Avignon Pro", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlanRoute.ForeColor = Color.FromArgb(30, 40, 66);
            btnPlanRoute.Location = new Point(68, 261);
            btnPlanRoute.Name = "btnPlanRoute";
            btnPlanRoute.Size = new Size(316, 58);
            btnPlanRoute.TabIndex = 20;
            btnPlanRoute.Text = "Plan Route";
            btnPlanRoute.UseVisualStyleBackColor = true;
            // 
            // txtDestination
            // 
            txtDestination.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDestination.Font = new Font("Avignon Pro", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDestination.ForeColor = Color.FromArgb(30, 40, 66);
            txtDestination.Location = new Point(68, 49);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(316, 27);
            txtDestination.TabIndex = 19;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 40, 66);
            ClientSize = new Size(1368, 766);
            Controls.Add(panel1);
            Controls.Add(routeListBox);
            Controls.Add(AvailCityLabel);
            Controls.Add(CurrentCityLabel);
            Controls.Add(TravelerNameLabel);
            Controls.Add(totalDistanceLabel);
            Controls.Add(routeLabel);
            Controls.Add(btnRemoveCity);
            Controls.Add(btnAddCity);
            Controls.Add(txtNewCity);
            Controls.Add(citiesListBox);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(btnLoadMap);
            Controls.Add(btnCreateTraveler);
            Controls.Add(txtCurrentCity);
            Controls.Add(txtName);
            Controls.Add(btnExit);
            ForeColor = SystemColors.Info;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Simple Button App";
            Load += MainForm_Load;
            Resize += MainForm_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        private TextBox txtName;
        private TextBox txtCurrentCity;
        private Button btnCreateTraveler;
        private Button btnLoadMap;
        private Button btnSave;
        private Button btnLoad;
        private ListBox citiesListBox;
        private TextBox txtNewCity;
        private Button btnAddCity;
        private Button btnRemoveCity;
        private Label routeLabel;
        private Label totalDistanceLabel;
        private Label TravelerNameLabel;
        private Label CurrentCityLabel;
        private Label AvailCityLabel;
        private ListBox routeListBox;
        private Panel panel1;
        private Label DestinationLabel;
        private Button btnClearRoute;
        private Button btnPlanRoute;
        private TextBox txtDestination;
    }
}

