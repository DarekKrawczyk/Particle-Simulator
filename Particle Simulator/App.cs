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
        private Boolean openState = true;
        private Simulation simulation;
        private SFML.Graphics.RenderWindow window;
        private ContextSettings contextSettings;
        private Stopwatch stopwatch;
        private TimeSpan deltaTime;
        private TimeSpan time;
        private Clock clock;
        private Time currentTime;
        private Time lastTime;
        public float FPS { get; set; }

        public float simulationSpeed { get; set; }

        public App()
        {
            InitializeComponent();
            clock = new Clock();
            stopwatch = new Stopwatch();
            Visible = true;
            simulationWindow.Visible = false;
            contextSettings.AntialiasingLevel = 16;
            window = new SFML.Graphics.RenderWindow(IntPtr.Zero);
            simulation = new Simulation(ref window, WindowManager.size(simulationWindow), 
                WindowManager.point(simulationWindow), new SFML.Graphics.Color(163, 165, 168),
                contextSettings);            
            this.Controls.Add(simulation.surface);

            run();        
        }
        public void run()
        {
            while (openState == true)
            {
                //currentTime = clock.Restart().AsSeconds();
                //FPS = 1 / (currentTime - lastTime);
                //textBox2.Text = (currentTime - lastTime).ToString();
                //lastTime = currentTime;
                lastTime += currentTime;
                logic();
                textBox1.Text = FPS.ToString();
                update();
                draw();
            }
        }

        public void logic()
        {
            System.Windows.Forms.Application.DoEvents();
            window.DispatchEvents();
        }

        public void update()
        {
           // if(lastTime >= (1/simulationSpeed))
        }

        public void draw()
        {
            try
            {
                window.Clear(simulation.backgroudColor);
                foreach (Particle particle in simulation.particles)
                {
                    window.Draw(particle.shape);
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
    }
}