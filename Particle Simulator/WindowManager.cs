using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle_Simulator
{
    public class WindowManager
    {
        public static Size size(Panel panel)
        {
            return new Size(panel.Width, panel.Height);
        }
        public static Point point(Panel panel)
        {
            return new Point(panel.Location.X, panel.Location.Y);
        }
        public static void windowResize(ref Simulation simulation, Panel panel)
        {
            simulation.surface.Size = WindowManager.size(panel);
            simulation.surface.Location = WindowManager.point(panel);
        }
    }
}
