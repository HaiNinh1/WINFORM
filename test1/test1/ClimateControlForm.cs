using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace test1
{
    public partial class ClimateControlForm : Form
    {
        private bool isPowerOn = false;
        private decimal currentTemperature = 22.5M;
        private decimal targetTemperature = 22.5M;
        private decimal humidity = 45.0M;
        private string currentMode = "Auto";
        private string fanSpeed = "Auto";
        private bool isDarkMode = false;
        private List<string> presets = new List<string> { "Home", "Sleep", "Work" };

        private Color primaryColor = Color.FromArgb(52, 152, 219);
        private Color heatingColor = Color.FromArgb(231, 76, 60);
        private Color coolingColor = Color.FromArgb(52, 152, 219);
        private Color backgroundColor;
        private Color foregroundColor;
        private Color panelColor;
        private Color textColor;

        private Panel mainPanel;
        private Button powerButton;
        private TrackBar humiditySlider;
        private Label humidityValueLabel;

        public ClimateControlForm()
        {
            InitializeComponent();
            SetupColors(false);
            InitializeUI();
        }

        private void SetupColors(bool darkMode)
        {
            if (darkMode)
            {
                backgroundColor = Color.FromArgb(30, 30, 30);
                foregroundColor = Color.FromArgb(45, 45, 45);
                panelColor = Color.FromArgb(60, 60, 60);
                textColor = Color.FromArgb(240, 240, 240);
            }
            else
            {
                backgroundColor = Color.FromArgb(240, 240, 240);
                foregroundColor = Color.FromArgb(255, 255, 255);
                panelColor = Color.FromArgb(248, 248, 248);
                textColor = Color.FromArgb(60, 60, 60);
            }
        }

        private void InitializeUI()
        {
            this.Text = "Modern Climate Control";
            this.Size = new Size(900, 650);
            this.BackColor = backgroundColor;
            this.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;

            mainPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = backgroundColor,
                Padding = new Padding(20)
            };
            this.Controls.Add(mainPanel);
        }

        private void PowerButton_Click(object sender, EventArgs e)
        {
            isPowerOn = !isPowerOn;
            powerButton.BackColor = isPowerOn ? Color.FromArgb(46, 204, 113) : Color.FromArgb(52, 152, 219);
            powerButton.Text = isPowerOn ? "ON" : "Power";
        }

        private void DarkModeToggle_CheckedChanged(object sender, EventArgs e)
        {
            isDarkMode = !isDarkMode;
            SetupColors(isDarkMode);
            UpdateUIColors();
        }

        private void UpdateUIColors()
        {
            this.BackColor = backgroundColor;
            mainPanel.BackColor = backgroundColor;
        }
    }
}
