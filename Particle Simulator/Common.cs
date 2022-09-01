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
    public class Common
    {
        public static Vector3f GravityForce
        {
            get => new Vector3f(0, -1, 0);
        }
        public static Vector2f AngleToPosition(float angle)
        {
            if (angle >= 0 && angle <= 90)
            {
                return new Vector2f(MathF.Cos(angle * MathF.PI / 180),
                        MathF.Sin(-angle * MathF.PI / 180));
            }
            if (angle >= 90 && angle <= 180)
            {
                return new Vector2f(MathF.Cos(-angle * MathF.PI / 180),
                        MathF.Sin(-angle * MathF.PI / 180));
            }
            if (angle > 180 && angle <= 270)
            {
                return new Vector2f(MathF.Cos(angle * MathF.PI / 180),
                        MathF.Sin(-angle * MathF.PI / 180));
            }
            if (angle > 270 && angle <= 360)
            {
                return new Vector2f(MathF.Cos(-angle * MathF.PI / 180),
                        MathF.Sin(-angle * MathF.PI / 180));
            }
            return new Vector2f(MathF.Cos(angle * MathF.PI / 180),
                        MathF.Sin(angle * MathF.PI / 180));
        }
        public static Vector3f AddVector3f(Vector3f x, Vector3f y)
        {
            return new Vector3f(x.X + y.X, x.Y + y.Y, x.Z + y.Z);
        }
        public static Vector3f SubtractVector3f(Vector3f x, Vector3f y)
        {
            return new Vector3f(x.X - y.X, x.Y - y.Y, x.Z - y.Z);
        }
        public static Vector3f MultiplyVector3fByScalar(Vector3f x, float y)
        {
            return new Vector3f(x.X * y, x.Y * y, x.Z * y);
        }
        public static float LengthVector3f(Vector3f x)
        {
            return MathF.Sqrt(MathF.Pow(x.X, 2) + MathF.Pow(x.Y, 2) + MathF.Pow(x.Z, 2));
        }
        public static void Normalize(ref Vector3f vector)
        {
            float d = LengthVector3f(vector);
            vector = MultiplyVector3fByScalar(vector, d);
        }
        public static Vector3f MultiplyVector3fByVector(Vector3f a, Vector3f b)
        {
            return new Vector3f();
        }
        public static Vector3f Euler_w(Vector3f vector, float h)
        {
            return MultiplyVector3fByScalar(vector, h);
        }
    }
}
