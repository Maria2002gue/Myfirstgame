using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Myfirstgame
{
    /// <summary>
    /// An evil species that wants to steal the treasure
    /// </summary>
    class Enemigo2 : Sprite
    {
        /// <summary>
        /// a reference to the game 
        /// </summary>
        Game1 root;


        /// <summary>
        /// respresents the number of pixels to move the enemy in the X axis
        /// </summary>
        Point velocity;


        /// <summary>
        /// initialize an enemy
        /// </summary>
        /// <param name="_root">this is the class that manipulates the game loop</param>
        /// <param name="_position">the initial position of the player</param>


        public Enemigo2(Game1 _root, Point _position) : base(_position, 150)
        {
            this.root = _root;
            this.velocity = new Point(2, 0);
            this.imageName = "imagen2";
            this.LoadContent();

        }





        /// <summary>
        /// method to load external content
        /// </summary>

        private void LoadContent()
        {
            spriteimageInmemory = this.root.Content.Load<Texture2D>(imageName);
        }

        public void Update(GameTime gameTime)
        {
            if (this.position.X > 0)
            {
                position = position - velocity;
            }

            else
            {
                position.X = this.root.Window.ClientBounds.Width - Size;
            }



        }




    }



}
