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
        #region fields
        private CircleShape shape;
        #endregion fields

        #region properties
        public float angle { get; set; }
        public int flag { get; set; }
        public float mass { get; set; }
        public Vector3f position { get; set; }
        public Vector3f force { get; set; }
        public Vector3f velocity { get; set; }
        public Vector3f dr { get; set; }
        public Vector3f dv { get; set; }
        #endregion properties

        public Particle(float radius, uint pointCount, Vector3f position, SFML.Graphics.Color color, float mass, Vector3f velocity)
        {
            shape = new CircleShape(radius, pointCount);
            this.position = position;
            shape.FillColor = color;
            //angle = 20;
            this.velocity = velocity;
            this.mass = mass;
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

        public void updateParticlePosition()
        {
            shape.Position = new Vector2f(position.X, position.Y);
        }

        public CircleShape getParticleShape()
        {
            return shape;
        }
        public void CalculateEuler(float dt)
        {
            dv = Common.Euler_w(Common.MultiplyVector3fByScalar(force, (1 / mass)), dt);
            velocity = velocity + dv;
            dr = Common.MultiplyVector3fByScalar(velocity, dt);
            position = position + dr;
        }
        public void CalculateForce()
        {
            force = Common.MultiplyVector3fByScalar(Common.GravityForce, mass);
        }
    }
}
