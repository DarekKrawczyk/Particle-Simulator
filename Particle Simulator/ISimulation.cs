using SFML.Graphics;
using SFML.System;

namespace Particle_Simulator
{
    public interface ISimulation
    {
        SFML.Graphics.Color backgroudColor { get; }
        Border border { get; set; }
        List<Particle> particles { get; set; }
        float simulationSpeed { get; set; }
        Simulation.State simulationState { get; set; }
        DrawingSurface surface { get; }

        void Draw(ref RenderWindow window);
        void generateParticles();
        void Logic(ref RenderWindow window);
        void restartSimulation();
        Time Update(Time timeElapsed);
    }
}