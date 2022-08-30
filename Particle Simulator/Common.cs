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
    internal class Common
    {
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
    }
}
