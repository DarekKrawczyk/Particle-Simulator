using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle_Simulator
{
    public class Wall
    {
        #region enums
        public enum Side
        {
            Left, Top, Right, Bottom
        }
        #endregion

        #region fields
        private RectangleShape _shape;
        private Side _wallSide;
        #endregion

        #region properties
        public static int BorderWidth = 100;
        public RectangleShape Shape
        {
            get => _shape;
        }
        public Side WallSide
        {
            get => _wallSide;
        }
        #endregion

        #region const/dest
        public Wall(Vector2f position, Vector2f borderSize, SFML.Graphics.Color color, Side side)
        {
            _shape = new RectangleShape() { Position = position, Size = borderSize, FillColor = color};
            _wallSide = side;
        }
        #endregion

        #region methods
        public void generateWall()
        {

        }
        #endregion
    }
}
