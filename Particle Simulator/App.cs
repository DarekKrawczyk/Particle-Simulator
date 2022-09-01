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
    public partial class App : Form
    {
        #region fields

        private Boolean openState = true;
        private Simulation simulation;
        private SFML.Graphics.RenderWindow window;
        private ContextSettings contextSettings;
        private Clock executionClock;
        private Time extraTime;
        private List<float> extraTimeList = new List<float>();
        private const float timeConst = 0.1f;
        public float FPS { 
            get => 1/deltaTime.AsSeconds(); 
        }
        public float simulationSpeed { get; set; }
        public Time deltaTime { get; set; }

        #endregion fields

        public App()
        {
            InitializeComponent();
            deltaTime = new Time();
            Visible = true;
            simulationSpeed = 60;
            simulationWindow.Visible = false;
            contextSettings.AntialiasingLevel = 16;
            executionClock = new Clock();
            window = new SFML.Graphics.RenderWindow(IntPtr.Zero);
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
                logic();
                update();
                draw();
                textBox2.Text = deltaTime.AsSeconds().ToString();
                deltaTime = executionClock.Restart();
                extraTime += deltaTime;
                angletext.Text = angletrack.Value.ToString();
            }
        }

        public void logic()
        {
            System.Windows.Forms.Application.DoEvents();
            window.DispatchEvents();
        }

        public void update()
        {
            float a = 270f;
            if (extraTime.AsSeconds() >= 1 / simulationSpeed)
            {

                foreach(Particle particle in simulation.particles)
                {
                    particle.CalculateForce();
                    //particle.updateParticlePosition(Common.AngleToPosition(angletrack.Value));
                    particle.CalculateEuler(20*deltaTime.AsSeconds());
                    particle.updateParticlePosition();
                    textBox3.Text = $"force {simulation.particles[0].force.X}||{simulation.particles[0].force.Y}";
                    textBox4.Text = $"position {simulation.particles[0].position.X}||{simulation.particles[0].position.Y}";
                    textBox5.Text = $"velocity {simulation.particles[0].velocity.X}||{simulation.particles[0].velocity.Y}";
                    textBox6.Text = $"shape position {simulation.particles[0].getParticleShape().Position.X}||{simulation.particles[0].getParticleShape().Position.Y}";
                }

                /*
                 * Frames per second
                 */
                extraTimeList.Add(extraTime.AsSeconds());
                if(extraTimeList.Count > 10 - trackBar1.Value)
                {
                    textBox1.Text = (1 / extraTimeList.Average()).ToString();
                    extraTimeList.Clear();
                }
                extraTime = Time.Zero;
            }
        }

        public void draw()
        {
            try
            {
                window.Clear(simulation.backgroudColor);
                foreach (Particle particle in simulation.particles)
                {
                    window.Draw(particle.getParticleShape());
                }
                window.Display();
            } catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            if(this.WindowState == FormWindowState.Maximized ||
                this.WindowState == FormWindowState.Minimized ||
                this.WindowState == FormWindowState.Normal) {
                WindowManager.windowResize(ref simulation, simulationWindow);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            simulationSpeed = trackBar1.Value;
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