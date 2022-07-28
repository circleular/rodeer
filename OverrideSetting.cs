using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using RoTor;
using Override;

namespace RoDeer
{
    public partial class OverrideSetting : Form
    {
        public OverrideSetting()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        // RestoreClassicDeath
        // Restores the classic OOF sound to ROBLOX.
        private void button1_Click(object sender, EventArgs e)
        {
            // Restore Standard Oof :)
            Override.Program.RestoreOof();
        }
    }
}
