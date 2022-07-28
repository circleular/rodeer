using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

using RoTor;

namespace RoDeer
{
    public partial class RoDeerApp : Form
    {
        OverrideSetting currentOverrideSetting = new OverrideSetting();
        public RoDeerApp()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            // Load Intro
            Intro();
        }

        // Intro
        // Plays intro sequence
        private void Intro()
        {
            // IntroLater
        }

        // OverrideSetting
        // Loads the new Form(OverrideSetting)
        private void MusicReplace_Click(object sender, EventArgs e)
        {
            // Make sure we don't create multiple
            if (currentOverrideSetting.IsDisposed || currentOverrideSetting == null) // l27(1): Make sure we don't use something that doesn't exist
            {
                currentOverrideSetting = new OverrideSetting();
                currentOverrideSetting.Show();
            }
            else
            {
                // l27(2): Continue this so we show one if it already exists but is not disposed of yet.
                currentOverrideSetting.Show();
            }
        }
    }
}
