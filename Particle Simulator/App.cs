using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System.Diagnostics;
using System.Threading;

namespace Particle_Simulator
{
    public partial class App : Form, IApp
    {
        #region fields
        private Boolean openState = true;
        private Simulation simulation;
        private RenderWindow window;
        private ContextSettings contextSettings;
        private Clock executionClock;
        private Time extraTime;
        #endregion

        #region properties
        public float FPS { get => 1 / deltaTime.AsSeconds(); }
        public Time deltaTime { get; set; }
        #endregion

        public App()
        {
            InitializeComponent();
            deltaTime = new Time();
            Visible = true;
            simulationWindow.Visible = false;
            contextSettings.AntialiasingLevel = 16;
            executionClock = new Clock();
            window = new RenderWindow(IntPtr.Zero);
            simulation = new Simulation(ref window, WindowManager.size(simulationWindow),
                WindowManager.point(simulationWindow), new SFML.Graphics.Color(163, 165, 168),
                contextSettings);
            this.Controls.Add(simulation.surface);

            run();
        }
        public void run()
        {
            executionClock.Restart();
            while (openState == true)
            {
                textBox1.Text = $"{FPS}";
                textBox3.Text = $"force {simulation.particles[0].force.X}||{simulation.particles[0].force.Y}";
                textBox4.Text = $"position {simulation.particles[0].position.X}||{simulation.particles[0].position.Y}";
                textBox5.Text = $"velocity {simulation.particles[0].velocity.X}||{simulation.particles[0].velocity.Y}";
                textBox6.Text = $"shape position {simulation.particles[0].Shape.Position.X}||{simulation.particles[0].Shape.Position.Y}";

                //TODO - Je¿eli jakiœ event jest odpalony to pausuje dzia³anie symulacji, bo s¹ b³êdy typu przy ruszaniu okienkiem cz¹steczki znikaj¹
                System.Windows.Forms.Application.DoEvents();
                simulation.Logic(ref window);
                extraTime = simulation.Update(extraTime);
                simulation.Draw(ref window);


                textBox2.Text = deltaTime.AsSeconds().ToString();
                deltaTime = executionClock.Restart();
                extraTime += deltaTime;
                angletext.Text = angletrack.Value.ToString();
            }
        }

        private void App_Load(object sender, EventArgs e)
        {

        }

        private void App_FormClosing(object sender, FormClosingEventArgs e)
        {
            openState = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void App_ResizeEnd(object sender, EventArgs e)
        {
            WindowManager.windowResize(ref simulation, simulationWindow);
        }

        private void simulationsListPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void App_FontChanged(object sender, EventArgs e)
        {

        }

        private void simulationWindow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void App_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized ||
                this.WindowState == FormWindowState.Minimized ||
                this.WindowState == FormWindowState.Normal)
            {
                WindowManager.windowResize(ref simulation, simulationWindow);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            simulation.simulationSpeed = trackBar1.Value;
        }

        private void btnRestartSimulation_Click(object sender, EventArgs e)
        {
            simulation.restartSimulation();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}