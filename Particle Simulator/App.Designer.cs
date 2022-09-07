namespace Particle_Simulator
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
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.angletext = new System.Windows.Forms.TextBox();
            this.angletrack = new System.Windows.Forms.TrackBar();
            this.btnRestartSimulation = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddParticleButton = new System.Windows.Forms.Button();
            this.simulationsListPanel = new System.Windows.Forms.Panel();
            this.simulationsListBox = new System.Windows.Forms.ListBox();
            this.simulationWindow = new System.Windows.Forms.Panel();
            this.simulationSettingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.angletrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.simulationsListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // simulationSettingsPanel
            // 
            this.simulationSettingsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simulationSettingsPanel.Controls.Add(this.textBox6);
            this.simulationSettingsPanel.Controls.Add(this.textBox5);
            this.simulationSettingsPanel.Controls.Add(this.textBox4);
            this.simulationSettingsPanel.Controls.Add(this.textBox3);
            this.simulationSettingsPanel.Controls.Add(this.angletext);
            this.simulationSettingsPanel.Controls.Add(this.angletrack);
            this.simulationSettingsPanel.Controls.Add(this.btnRestartSimulation);
            this.simulationSettingsPanel.Controls.Add(this.textBox2);
            this.simulationSettingsPanel.Controls.Add(this.trackBar1);
            this.simulationSettingsPanel.Controls.Add(this.textBox1);
            this.simulationSettingsPanel.Controls.Add(this.AddParticleButton);
            this.simulationSettingsPanel.Location = new System.Drawing.Point(712, 126);
            this.simulationSettingsPanel.Name = "simulationSettingsPanel";
            this.simulationSettingsPanel.Size = new System.Drawing.Size(292, 414);
            this.simulationSettingsPanel.TabIndex = 0;
            this.simulationSettingsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(3, 125);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(286, 23);
            this.textBox6.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(3, 96);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(286, 23);
            this.textBox5.TabIndex = 8;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(3, 67);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(286, 23);
            this.textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(3, 38);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(287, 23);
            this.textBox3.TabIndex = 3;
            // 
            // angletext
            // 
            this.angletext.Location = new System.Drawing.Point(37, 362);
            this.angletext.Name = "angletext";
            this.angletext.Size = new System.Drawing.Size(100, 23);
            this.angletext.TabIndex = 6;
            // 
            // angletrack
            // 
            this.angletrack.Location = new System.Drawing.Point(33, 311);
            this.angletrack.Maximum = 360;
            this.angletrack.Name = "angletrack";
            this.angletrack.Size = new System.Drawing.Size(104, 45);
            this.angletrack.TabIndex = 5;
            this.angletrack.Value = 6;
            // 
            // btnRestartSimulation
            // 
            this.btnRestartSimulation.Location = new System.Drawing.Point(108, 3);
            this.btnRestartSimulation.Name = "btnRestartSimulation";
            this.btnRestartSimulation.Size = new System.Drawing.Size(87, 29);
            this.btnRestartSimulation.TabIndex = 4;
            this.btnRestartSimulation.Text = "Restart";
            this.btnRestartSimulation.UseVisualStyleBackColor = true;
            this.btnRestartSimulation.Click += new System.EventHandler(this.btnRestartSimulation_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(33, 237);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 3;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(33, 199);
            this.trackBar1.Maximum = 11;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 170);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AddParticleButton
            // 
            this.AddParticleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddParticleButton.Location = new System.Drawing.Point(3, 3);
            this.AddParticleButton.Name = "AddParticleButton";
            this.AddParticleButton.Size = new System.Drawing.Size(193, 29);
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
            this.simulationWindow.Size = new System.Drawing.Size(673, 528);
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
            this.simulationSettingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.angletrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
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
        private TextBox textBox1;
        private TrackBar trackBar1;
        private TextBox textBox2;
        private Button btnRestartSimulation;
        private TextBox angletext;
        private TrackBar angletrack;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox6;
    }
}