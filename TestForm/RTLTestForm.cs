using System;
using System.Drawing;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace TestForm
{
    public partial class RTLTestForm : KryptonForm
    {
        private KryptonButton _toggleRTLButton;
        private KryptonLabel _statusLabel;

        public RTLTestForm()
        {
            InitializeComponent();
            SetupForm();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            
            // Form properties
            this.Text = "RTL Test Form";
            this.Size = new Size(600, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            
            // Create toggle button
            _toggleRTLButton = new KryptonButton
            {
                Text = "Toggle RTL",
                Location = new Point(20, 20),
                Size = new Size(100, 30)
            };
            _toggleRTLButton.Click += OnToggleRTLClick;
            
            // Create status label
            _statusLabel = new KryptonLabel
            {
                Text = "RTL: Disabled",
                Location = new Point(20, 60),
                Size = new Size(200, 20)
            };
            
            // Add controls to form
            this.Controls.Add(_toggleRTLButton);
            this.Controls.Add(_statusLabel);
            
            this.ResumeLayout(false);
        }

        private void SetupForm()
        {
            // Set initial RTL state
            UpdateRTLStatus();
        }

        private void OnToggleRTLClick(object sender, EventArgs e)
        {
            // Toggle RTL settings
            if (this.RightToLeft == RightToLeft.Yes)
            {
                this.RightToLeft = RightToLeft.No;
                this.RightToLeftLayout = false;
            }
            else
            {
                this.RightToLeft = RightToLeft.Yes;
                this.RightToLeftLayout = true;
            }
            
            UpdateRTLStatus();
        }

        private void UpdateRTLStatus()
        {
            string status = this.RightToLeft == RightToLeft.Yes ? "RTL: Enabled" : "RTL: Disabled";
            _statusLabel.Text = status;
        }
    }
} 