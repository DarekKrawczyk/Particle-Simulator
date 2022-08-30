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
        private CircleShape shape;
        public float angle { get; set; }
        public Particle(float radius, uint pointCount, Vector2f position, SFML.Graphics.Color color, float angle = 5)
        {
            shape = new CircleShape(radius, pointCount);
            shape.Position = position;
            shape.FillColor = color;
            angle = 20;
        }
        public Particle(CircleShape shape)
        {
            this.shape = new CircleShape(shape);
        }

        public Vector2f getParticlePosition()
        {
            return shape.Position;
        }

        public void setParticlePosition(Vector2f position)
        {
            shape.Position = new Vector2f(position.X, position.Y);
        }

        public void updateParticlePosition(Vector2f position)
        {
            shape.Position += position;
        }

        public CircleShape getParticleShape()
        {
            return shape;
        }
    }
}
