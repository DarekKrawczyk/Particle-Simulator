using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Window;
using SFML.System;
using SFML.Graphics;
using SFML.Audio;

namespace Particle_Simulator
{
    public class Simulation
    {
        public List<Particle> particles { get; }
        public DrawingSurface surface { get; }
        public RenderWindow window { get; }
        private Particle particle { get; }
        public SFML.Graphics.Color backgroudColor { get; }
        public Simulation(ref RenderWindow window, System.Drawing.Size size, System.Drawing.Point location, SFML.Graphics.Color color, ContextSettings settings)
        {
            particles = new List<Particle>(){
                new Particle(150, 1500, new SFML.System.Vector2f(100, 74), SFML.Graphics.Color.Red),
                new Particle(100, 1500, new SFML.System.Vector2f(514, 422), SFML.Graphics.Color.Cyan),
                new Particle(200, 1500, new SFML.System.Vector2f(125, 222), SFML.Graphics.Color.Yellow),
                new Particle(300, 1500, new SFML.System.Vector2f(265, 333), SFML.Graphics.Color.Green),
                new Particle(20, 1500, new SFML.System.Vector2f(85, 182), SFML.Graphics.Color.Blue)
            };

            particle = new Particle(50, 1500, new SFML.System.Vector2f(100, 100), new SFML.Graphics.Color(64, 135, 67));
            surface = new DrawingSurface();
            surface.Size = size;
            surface.Location = location;
            backgroudColor = color;
            window = new RenderWindow(surface.Handle, settings);
        }

        public SFML.Graphics.Drawable getParticle() => particle.shape;

        //public SFML.Graphics.Drawable getParticles()
        //{
        //    return particles
        //}

        public void addParticle()
        {
            
        }
    }
}
