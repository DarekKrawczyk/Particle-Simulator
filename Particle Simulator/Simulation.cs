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
    public class Simulation : ISimulation
    {
        #region enums
        public enum State
        {
            Runing,
            Closed
        }
        #endregion

        #region fields
        #endregion

        #region properties
        public State simulationState { get; set; }
        public float simulationSpeed { get; set; }
        public List<Particle> particles { get; set; }
        public DrawingSurface surface { get; }
        public SFML.Graphics.Color backgroudColor { get; }
        public Border border { get; set; }
        #endregion

        #region const/dest
        public Simulation(ref RenderWindow window, System.Drawing.Size size, System.Drawing.Point location, SFML.Graphics.Color color, ContextSettings settings)
        {
            simulationState = State.Runing;
            simulationSpeed = 1;
            border = new Border(size);
            particles = new List<Particle>();
            generateParticles();
            surface = new DrawingSurface();
            surface.Size = size;
            surface.Location = location;
            backgroudColor = color;
            window = new RenderWindow(surface.Handle, settings);
        }
        #endregion

        #region methods
        public void generateParticles()
        {
            Random rand = new Random();
            for (int i = 0; i < 69; i++)
            {
                int velocityX = rand.Next(-i, i);
                int velocityY = rand.Next(-i, i);
                particles.Add(new Particle(2, 1500, new SFML.System.Vector3f(250, 250, 0), SFML.Graphics.Color.White, 10f, new Vector3f(velocityX, velocityY, 0)));
            }
        }

        public void restartSimulation()
        {
            if (particles.Count > 0)
            {
                particles.Clear();
            }
            generateParticles();
        }

        public void Logic(ref RenderWindow window)
        {
            window.DispatchEvents();
        }
        public Time Update(Time timeElapsed)
        {
            if (simulationSpeed * timeElapsed.AsSeconds() >= 0.0016)
            {
                foreach (Particle particle in particles)
                {
                    particle.CalculateForce();
                    //particle.updateParticlePosition(Common.AngleToPosition(angletrack.Value));
                    particle.CalculateEuler(simulationSpeed * timeElapsed.AsSeconds());
                    particle.updateParticlePosition();
                    foreach (Wall wall in border.walls)
                    {
                        if (particle.Shape.GetGlobalBounds().Intersects(wall.Shape.GetGlobalBounds()))
                        {
                            if (wall.WallSide == Wall.Side.Top)
                            {
                                particle.velocity = new Vector3f(particle.velocity.X, -particle.velocity.Y, 0);
                                //particle.Shape.FillColor = SFML.Graphics.Color.Yellow;
                            }
                            if (wall.WallSide == Wall.Side.Bottom)
                            {
                                particle.velocity = new Vector3f(particle.velocity.X, -particle.velocity.Y, 0);
                                //particle.Shape.FillColor = SFML.Graphics.Color.Red;
                            }
                            if (wall.WallSide == Wall.Side.Left)
                            {
                                particle.velocity = new Vector3f(-particle.velocity.X, particle.velocity.Y, 0);
                                //particle.Shape.FillColor = SFML.Graphics.Color.Black;
                            }
                            if (wall.WallSide == Wall.Side.Right)
                            {
                                particle.velocity = new Vector3f(-particle.velocity.X, particle.velocity.Y, 0);
                                //particle.Shape.FillColor = SFML.Graphics.Color.Magenta;
                            }
                            Random random = new Random();
                            int a = random.Next(0, 255);
                            int b = random.Next(0, 255);
                            int c = random.Next(0, 255);
                            int d = random.Next(0, 255);

                            particle.Shape.FillColor = new SFML.Graphics.Color((byte)a, (byte)b, (byte)c);
                            //particle.velocity = new Vector3f(-particle.velocity.X, -particle.velocity.Y,0);
                        }
                    }
                }




                return Time.Zero;
            }
            else
            {
                return timeElapsed;
            }
        }
        public void Draw(ref RenderWindow window)
        {
            window.Clear(SFML.Graphics.Color.Black);
            foreach (Wall wall in border.walls)
            {
                window.Draw(wall.Shape);
            }
            foreach (Particle particle in particles)
            {
                window.Draw(particle.Shape);
            }
            window.Display();
        }
        #endregion
    }
}