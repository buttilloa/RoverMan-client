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
    public class block
    {
        public int x = 0, y = 0 ,height=80,width=20;
        public Texture2D text;
        public Boolean Rotated = false;
        public block(int xpos , int ypos)
        {
            x = xpos;
            y = ypos;
        }
        public block(int xpos, int ypos,int Height, int Width)
        {
            x = xpos;
            y = ypos;
            height = Height;
            width = Width;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            if (!Rotated)
            {
                spriteBatch.Draw(
                    text,
                    new Rectangle(x, y, height, width),
                    new Rectangle(0, 0, 52, 20),
                    Color.White);
            }
            else
            {
                spriteBatch.Draw(
                   text,
                   new Rectangle(x, y, height, width),
                   new Rectangle(0, 0, 20, 52),
                   Color.White);
            }
        }
    }
}
