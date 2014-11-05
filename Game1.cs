using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace RoverMan
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D L, Pellet,Pellet2,food, background;
        levelManager LM;
        List<Lblock> Llist = new List<Lblock>();
        List<block> blocklist = new List<block>();
        List<Pellet> foodList = new List<Pellet>();
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            this.Window.AllowUserResizing = true;
            //graphics.ToggleFullScreen();
            Content.RootDirectory = "Content";
        }
        protected override void Initialize()
        {
            
            
            base.Initialize();
        }

        protected override void LoadContent()
        {
         
            spriteBatch = new SpriteBatch(GraphicsDevice);
            L = Content.Load<Texture2D>(@"L");
            Pellet = Content.Load<Texture2D>(@"pellet");
            Pellet2 = Content.Load<Texture2D>(@"pellet2");
            food = Content.Load<Texture2D>(@"food");
            background = Content.Load<Texture2D>(@"background");
            
            LM = new levelManager(Pellet,Pellet2,L,food,this.Window);
            Llist = LM.level1LBlocks();
            blocklist = LM.level1Blocks();
            foodList = LM.level1Pellets();

        }

        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

    
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

     
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            
            spriteBatch.Begin(); 
            spriteBatch.Draw(background, new Rectangle(0, 0, this.Window.ClientBounds.Width, this.Window.ClientBounds.Height), Color.White);
             for (int i = 0; i <= Llist.Count - 1; i++)
            {
                Llist[i].Draw(spriteBatch);
            }
            for (int i = 0; i <= blocklist.Count - 1; i++)
            {
                blocklist[i].Draw(spriteBatch);
            }
            for (int i = 0; i <= foodList.Count - 1; i++)
            {
                foodList[i].Draw(spriteBatch);
            }
           
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
