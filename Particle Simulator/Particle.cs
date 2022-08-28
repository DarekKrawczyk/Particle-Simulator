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
    public class Particle
    {
        public CircleShape? shape;
        public Particle(float radius, uint pointCount, Vector2f position, SFML.Graphics.Color color)
        {
            shape = new CircleShape(radius, pointCount);
            shape.Position = position;
            shape.FillColor = color;
        }
        public Particle(CircleShape shape)
        {
            shape = new CircleShape(shape);
        }
    }
}
