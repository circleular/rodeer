
namespace RoDeer
{
    partial class OverrideSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OverrideSetting));
            this.OverrideSound = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OverrideSound
            // 
            this.OverrideSound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(93)))), ((int)(((byte)(0)))));
            this.OverrideSound.Enabled = false;
            this.OverrideSound.ForeColor = System.Drawing.Color.Silver;
            this.OverrideSound.Location = new System.Drawing.Point(12, 12);
            this.OverrideSound.Name = "OverrideSound";
            this.OverrideSound.Size = new System.Drawing.Size(254, 35);
            this.OverrideSound.TabIndex = 0;
            this.OverrideSound.Text = "Override Sound";
            this.OverrideSound.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Restore Classic Death";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OverrideSetting
            // 
            this.ClientSize = new System.Drawing.Size(278, 285);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OverrideSound);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OverrideSetting";
            this.Text = "RoDeer(BETA) - Override";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Surface;
        private System.Windows.Forms.Button OverrideSound;
        private System.Windows.Forms.Button button1;
    }
}