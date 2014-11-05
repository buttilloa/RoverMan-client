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
    public class Lblock
    {
        public int x = 200, y = 200;
        public Boolean FlipVert = false;
        public Boolean FlipHor = false;
        
        public Texture2D text; //this.FlipHor ? SpriteEffects.FlipHorizontally : SpriteEffects.None
        public Lblock(int xpos,int ypos)
        {
            x = xpos;
            y = ypos;
        }
        
        public void Draw(SpriteBatch spriteBatch)
        {
            if (FlipHor)
            {
                if(FlipVert) spriteBatch.Draw(text, new Vector2(x, y), null, Color.White, 0, Vector2.Zero, 1 ,SpriteEffects.FlipHorizontally |  SpriteEffects.FlipVertically, 1);
                else spriteBatch.Draw(text, new Vector2(x, y), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.FlipHorizontally | SpriteEffects.None, 0);
            }
            else
            {
                if (FlipVert) spriteBatch.Draw(text, new Vector2(x, y), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None | SpriteEffects.FlipVertically, 0);
                else          spriteBatch.Draw(text, new Vector2(x, y), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0);
            }
            /*spriteBatch.Draw(
                text,
                new Rectangle(x, y, 100, 100),
                new Rectangle(0, 0, 32, 39),
                Color.White);
             */
        }
    }
}
