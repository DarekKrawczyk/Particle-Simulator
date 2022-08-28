using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace Particle_Simulator
{
    public partial class App : Form
    {
        private Boolean openState = true;
        private Simulation simulation;
        private SFML.Graphics.RenderWindow window;
        private ContextSettings contextSettings;

        public App()
        {
            InitializeComponent();
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
                System.Windows.Forms.Application.DoEvents();
                window.DispatchEvents();
                draw();
                window.Display();
            }
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
    }
}