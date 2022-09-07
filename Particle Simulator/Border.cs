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
    public class Border : IDrawable
    {
        public static int borderWidth = 100;
        public List<RectangleShape> walls { get; }
        public Border(Size borderSize)
        {
            walls = new List<RectangleShape>()
            {
                new RectangleShape(){ Position=new Vector2f(0,0-borderWidth), Size = new Vector2f(borderSize.Width, borderWidth), FillColor = SFML.Graphics.Color.Black},
                new RectangleShape(){ Position=new Vector2f(0,borderSize.Height), Size = new Vector2f(borderSize.Width, borderWidth), FillColor = SFML.Graphics.Color.Black},
                new RectangleShape(){ Position=new Vector2f(borderSize.Width,0), Size = new Vector2f(borderWidth, borderSize.Height), FillColor = SFML.Graphics.Color.Black},
                new RectangleShape(){ Position=new Vector2f(0-borderWidth,0), Size = new Vector2f(borderWidth, borderSize.Width), FillColor = SFML.Graphics.Color.Black},
            };
        }
        public void generateWall()
        {

        }
        public void Draw()
        {

        }
    }
}
