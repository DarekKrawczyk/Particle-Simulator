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
    public class Border
    {
        #region enums
        public enum Side
        {
            Left, Top, Right, Bottom
        }
        #endregion

        #region fields
        #endregion

        #region properties
        public List<Wall> walls { get; set; }
        #endregion

        #region const/dest
        public Border(Size borderSize)
        {
            walls = new List<Wall>()
            {
                new Wall(new Vector2f(0,0-Wall.BorderWidth), new Vector2f(borderSize.Width, Wall.BorderWidth), SFML.Graphics.Color.Black, Wall.Side.Top),
                new Wall(new Vector2f(0,borderSize.Height), new Vector2f(borderSize.Width, Wall.BorderWidth), SFML.Graphics.Color.Black, Wall.Side.Bottom),
                new Wall(new Vector2f(borderSize.Width,0), new Vector2f(Wall.BorderWidth, borderSize.Height), SFML.Graphics.Color.Black, Wall.Side.Left),
                new Wall(new Vector2f(0-Wall.BorderWidth,0), new Vector2f(Wall.BorderWidth, borderSize.Width), SFML.Graphics.Color.Black, Wall.Side.Right)
            };
        }
        #endregion

        #region methods
        public void generateWall()
        {

        }
        #endregion
    }
}
