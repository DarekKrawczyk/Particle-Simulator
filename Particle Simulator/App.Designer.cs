﻿namespace Particle_Simulator
{
    partial class App
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.simulationSettingsPanel = new System.Windows.Forms.Panel();
            this.AddParticleButton = new System.Windows.Forms.Button();
            this.simulationsListPanel = new System.Windows.Forms.Panel();
            this.simulationsListBox = new System.Windows.Forms.ListBox();
            this.simulationWindow = new System.Windows.Forms.Panel();
            this.simulationSettingsPanel.SuspendLayout();
            this.simulationsListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // simulationSettingsPanel
            // 
            this.simulationSettingsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simulationSettingsPanel.Controls.Add(this.AddParticleButton);
            this.simulationSettingsPanel.Location = new System.Drawing.Point(806, 126);
            this.simulationSettingsPanel.Name = "simulationSettingsPanel";
            this.simulationSettingsPanel.Size = new System.Drawing.Size(198, 414);
            this.simulationSettingsPanel.TabIndex = 0;
            this.simulationSettingsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // AddParticleButton
            // 
            this.AddParticleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddParticleButton.Location = new System.Drawing.Point(3, 3);
            this.AddParticleButton.Name = "AddParticleButton";
            this.AddParticleButton.Size = new System.Drawing.Size(99, 29);
            this.AddParticleButton.TabIndex = 0;
            this.AddParticleButton.Text = "Add particle";
            this.AddParticleButton.UseVisualStyleBackColor = true;
            this.AddParticleButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // simulationsListPanel
            // 
            this.simulationsListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simulationsListPanel.Controls.Add(this.simulationsListBox);
            this.simulationsListPanel.Location = new System.Drawing.Point(806, 12);
            this.simulationsListPanel.Name = "simulationsListPanel";
            this.simulationsListPanel.Size = new System.Drawing.Size(198, 108);
            this.simulationsListPanel.TabIndex = 1;
            this.simulationsListPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.simulationsListPanel_Paint);
            // 
            // simulationsListBox
            // 
            this.simulationsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simulationsListBox.FormattingEnabled = true;
            this.simulationsListBox.ItemHeight = 15;
            this.simulationsListBox.Items.AddRange(new object[] {
            "Simulation 1",
            "Simulation 2",
            "Simulation 3 ",
            "Simulation 4",
            "Simulation 5",
            "Simulation 6",
            "Simulation 7",
            "Simulation 8"});
            this.simulationsListBox.Location = new System.Drawing.Point(3, 6);
            this.simulationsListBox.Name = "simulationsListBox";
            this.simulationsListBox.Size = new System.Drawing.Size(192, 94);
            this.simulationsListBox.TabIndex = 0;
            this.simulationsListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // simulationWindow
            // 
            this.simulationWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simulationWindow.Location = new System.Drawing.Point(12, 12);
            this.simulationWindow.Name = "simulationWindow";
            this.simulationWindow.Size = new System.Drawing.Size(788, 528);
            this.simulationWindow.TabIndex = 2;
            this.simulationWindow.Paint += new System.Windows.Forms.PaintEventHandler(this.simulationWindow_Paint);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 552);
            this.Controls.Add(this.simulationWindow);
            this.Controls.Add(this.simulationsListPanel);
            this.Controls.Add(this.simulationSettingsPanel);
            this.Name = "App";
            this.Text = "Particle Simulator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.App_FormClosing);
            this.Load += new System.EventHandler(this.App_Load);
            this.ResizeEnd += new System.EventHandler(this.App_ResizeEnd);
            this.FontChanged += new System.EventHandler(this.App_FontChanged);
            this.Resize += new System.EventHandler(this.App_Resize);
            this.simulationSettingsPanel.ResumeLayout(false);
            this.simulationsListPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel simulationSettingsPanel;
        private Panel simulationsListPanel;
        private ListBox simulationsListBox;
        private Panel simulationWindow;
        private Button AddParticleButton;
    }
}