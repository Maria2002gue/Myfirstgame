using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Myfirstgame
{
    class Sprite
    {
        /// <summary>
        /// the current position the sprite is in
        /// </summary> 
        public Point position;

        /// <summary>
        /// the name of the  image
        /// </summary>
        protected String imageName; 

        /// <summary>
        /// an image texture for the gamer
        /// </summary> 
        protected Texture2D spriteimageInmemory;

        /// <summary>
        /// This is a variable that indicates the scale size of the sprite
        /// </summary>
        public int Size { get; set; }
      

        public Rectangle PositionRectangle
        {
            get
            {


                return new Rectangle(position, new Point(Size));
              //  return new Rectangle(position,Size);
                //return new Rectangle(position.X,position.Y,Size, Size);
            }


        }

        public Sprite(Point _position, int _size)
        {
            this.position = _position;
            Size = _size;
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch, Color _color)
        {
            spriteBatch.Draw(spriteimageInmemory, PositionRectangle, _color);
        }
    
    }
}

    

