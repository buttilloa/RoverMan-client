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
    public class levelManager
    {
        public int LCount=0,pelletCount=0;
        List<Lblock> Llist = new List<Lblock>();
        List<block>blockList = new List<block>();
        List<Pellet>foodList = new List<Pellet>();
        Texture2D PelletText,PelletText2, lText, foodText;
        GameWindow Gamewin;
        public levelManager(Texture2D pelletText, Texture2D Pellet2Text, Texture2D LText, Texture2D food, GameWindow win)
        {
            PelletText = pelletText;
            PelletText2 = Pellet2Text;
            lText = LText;
            foodText = food;
            Gamewin = win;

        }
        //Rectanlge Shaped Blocks
        public List<block> level1Blocks()
        {
            blockList.Clear();
            blockList.Add(new block(194, 90));// left/middle rectangles
            blockList.Add(new block(194, Gamewin.ClientBounds.Height - 110));

            blockList.Add(new block((Gamewin.ClientBounds.Width -274), 90));// right/middle rectangles
            blockList.Add(new block((Gamewin.ClientBounds.Width - 274), Gamewin.ClientBounds.Height - 110));

            blockList.Add(new block(295,150,45,20));// top middleish rectangles
            blockList.Add(new block(295, Gamewin.ClientBounds.Height - 170, 45, 20));

            blockList.Add(new block(Gamewin.ClientBounds.Width-330, 150, 45, 20));//bottom middleish rectangles
            blockList.Add(new block(Gamewin.ClientBounds.Width - 330, Gamewin.ClientBounds.Height - 170, 45, 20));

            blockList.Add(new block(125, 150, 25, 20));//left top 
            blockList.Add(new block(120, (Gamewin.ClientBounds.Height / 2) - 10, 45, 20));//left middle
            blockList.Add(new block(125, Gamewin.ClientBounds.Height -170, 25, 20));//left bottom

            blockList.Add(new block(Gamewin.ClientBounds.Width - 150, 150, 25, 20));//right top 
            blockList.Add(new block(Gamewin.ClientBounds.Width - 165, (Gamewin.ClientBounds.Height / 2) - 10, 45, 20));//right middle
            blockList.Add(new block(Gamewin.ClientBounds.Width - 150, Gamewin.ClientBounds.Height - 170, 25, 20));//right bottom


            for (int i = 0; i <= blockList.Count - 1; i++)
            {
                blockList[i].text = PelletText;//Texture Loading
            }
            
            return blockList;
        }
        //L Shaped Blocks
        public List<Lblock> level1LBlocks()
        {
            Llist.Clear();
            Llist.Add(new Lblock(65,50));//top left
            Llist.Add(new Lblock(65,Gamewin.ClientBounds.Height - 125));//bottom left
            
            Llist.Add(new Lblock(Gamewin.ClientBounds.Width - 125,50));//top right
            Llist.Add(new Lblock(Gamewin.ClientBounds.Width - 125, Gamewin.ClientBounds.Height - 125)); // bottom right
           
            Llist.Add(new Lblock(160,(Gamewin.ClientBounds.Height / 2)-70)); //left double
            Llist.Add(new Lblock(160,(Gamewin.ClientBounds.Height / 2)-8));

            Llist.Add(new Lblock(Gamewin.ClientBounds.Width - 210, (Gamewin.ClientBounds.Height / 2) - 70)); // rigth double
            Llist.Add(new Lblock(Gamewin.ClientBounds.Width - 210, (Gamewin.ClientBounds.Height / 2) - 8));

            Llist.Add(new Lblock((Gamewin.ClientBounds.Width/2), 90)); // top middle double
            Llist.Add(new Lblock((Gamewin.ClientBounds.Width /2)-48, 90));

            Llist.Add(new Lblock((Gamewin.ClientBounds.Width / 2), Gamewin.ClientBounds.Height - 170)); // bottom middle double
            Llist.Add(new Lblock((Gamewin.ClientBounds.Width / 2) - 48, Gamewin.ClientBounds.Height - 170));

            for (int i = 0; i <= Llist.Count-1; i++)
            {
                Llist[i].text = lText; //Texture Loading
            }
           
            Llist[0].FlipVert = true;

            Llist[2].FlipVert = true;
            Llist[2].FlipHor = true;

            Llist[3].FlipHor = true;
            
            Llist[4].FlipHor = true;
            
            Llist[5].FlipVert = true;
            Llist[5].FlipHor = true;
            
            Llist[7].FlipVert = true;
            
            Llist[8].FlipVert = true;
           
            Llist[9].FlipVert = true;
            Llist[9].FlipHor = true;
            Llist[11].FlipHor = true;



            return Llist;
        
         }
        public List<Pellet> level1Pellets()
        {
            int tempX = 33, tempY = 22;
            foodList.Add(new Pellet(tempX-3, tempY-2));
            foodList.Add(new Pellet((tempX +720)- 3, tempY - 2));
            foodList.Add(new Pellet(tempX - 3, 440));
            foodList.Add(new Pellet(tempX +717, 440));
            foodList[0].isSuperPellet = true;
            foodList[1].isSuperPellet = true;
            foodList[2].isSuperPellet = true;
            foodList[3].isSuperPellet = true;
            tempY += 5;
            int loop=70;
            for (int q = 0; q <= loop; q++){
                if (q > -1 && q <= 6)
                {
                    tempY += 20;
                    foodList.Add(new Pellet(tempX, tempY));
                } 
                if(q==7)tempY = 275;
                if (q > 6 && q <= 13)
                {
                     tempY += 20;
                foodList.Add(new Pellet(tempX, tempY));
            
                }
                if (q == 14) { tempY = 22; tempX += 4; }
                if (q > 13 && q <= 19)
                {
                    tempX += 20;
                    foodList.Add(new Pellet(tempX, tempY));
                }
             if (q == 20) tempX = 607;
             if (q > 20 && q <= 26)
             {
                    tempX += 20;
                    foodList.Add(new Pellet(tempX, tempY));
             }
             if (q == 27) { tempX = 755; tempY += 5; }
             if (q > 27 && q <= 34)
             {
                 tempY += 20;
                 foodList.Add(new Pellet(tempX, tempY));
             }
             if (q == 35)  tempY = 275;
             if (q > 35 && q <= 42)
             {
                 tempY += 20;
                 foodList.Add(new Pellet(tempX, tempY));
             }
             // if (q == 43)
              //if (q > 43 && q <= 63)
            }
            for (int i = 0; i <= foodList.Count - 1; i++)
            {
                foodList[i].text = foodText;//Texture Loading
            }
            
            return foodList;
        }
        public void DrawPellets(SpriteBatch spritebatch)
        {
            for (int i = 0; i <= foodList.Count - 1; i++)
            {
                foodList[i].Draw(spritebatch);
            }
        }
    }
}
