using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace RoverMan
{
    public class Pellet{

        public int x = 0, y = 0;
        public Texture2D text;
        public Boolean isSuperPellet = false;
        public Pellet(int xpos , int ypos)
        {
            x = xpos;
            y = ypos;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            if (!isSuperPellet)
            {
                spriteBatch.Draw(
                    text,
                    new Rectangle(x, y, 12, 12),
                    new Rectangle(0, 0, 16, 16),
                    Color.White);
            }
            else
            {
                spriteBatch.Draw(
                           text,
                           new Rectangle(x, y, 18, 18),
                           new Rectangle(0, 0, 16, 16),
                           Color.White);
            }
        }
    }
}