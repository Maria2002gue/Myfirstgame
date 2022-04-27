using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Myfirstgame
{
    /// <summary>
    /// the player, controlled by the keyboard 
    /// </summary>
    class player: Sprite
    {
        /// <summary>
        /// a reference to the game 
        /// </summary>
        Game1 root;

        /// <summary>
        /// respresents the number of pixels to move the player in the y axis
        /// </summary>
        Point velocity;
        Point velocity2;

        /// <summary>
        /// to save the previous state of the keyboard 
        /// </summary> 
        KeyboardState previousKeyboardState;


         
        /// <summary>
        /// initialize a player 
        /// </summary>
        /// <param name="root"></param>
        public player(Game1 _root, Point _position) : base(_position,130)
        {
            // initialize values
            this.root = _root; 
            velocity = new Point(0, 10);
            velocity2 = new Point(10, 0);
            imageName = "imagen4";
            this.LoadContent();
            previousKeyboardState = Keyboard.GetState(); 

        }

       
        
        private void LoadContent()
        {
            spriteimageInmemory = this.root.Content.Load<Texture2D>("imagen1");   
        }

        private void HandleInput(KeyboardState currentkeyboardState)
        {
            if(currentkeyboardState.IsKeyDown(Keys.Up))
            {
                if (position.Y > 0)
                {
                    position = position - velocity; 
                }
            }
            
            if (currentkeyboardState.IsKeyDown(Keys.Down))
            {
                if (position.Y < (root.Window.ClientBounds.Height - Size))
                {
                    position = position + velocity; 
                }
            }



            if (currentkeyboardState.IsKeyDown(Keys.Right))
            {
                
                   position = position + velocity2;
                
            }

            if (currentkeyboardState.IsKeyDown(Keys.Left))
            {

                position = position - velocity2;

            }

            previousKeyboardState = currentkeyboardState;

        }


        public void Update(GameTime gameTime)
        {
            HandleInput(Keyboard.GetState());
        }


        
        

    }
}
