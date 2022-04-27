using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Myfirstgame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        player myplayer;
        enemy myenemy;
        Enemigo2 myEnemigo2;
        Song mySong;
        Texture2D fondo;
        private SpriteFont letra;
        private int vidas = 5;
        Texture2D gameover;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            myplayer = new player(this, new Point(0, 300));
            myenemy = new enemy(this, new Point(this.Window.ClientBounds.Width, 300));
            myEnemigo2 = new Enemigo2(this, new Point(this.Window.ClientBounds.Width, 100));
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            mySong = this.Content.Load<Song>("sounds1");
            MediaPlayer.Play(mySong);
            fondo = Content.Load<Texture2D>("Escenario2");
            letra = this.Content.Load<SpriteFont>("File");
            gameover = Content.Load<Texture2D>("Game over");

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            myplayer.Update(gameTime);
            myenemy.Update(gameTime);
            myEnemigo2.Update(gameTime);
            if (myplayer.PositionRectangle.Intersects(myenemy.PositionRectangle))
            {
                vidas -= 1;
                myenemy.position = new Point(500,150);
            }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue); 

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(fondo, new Rectangle(0, 0, 1000, 500),Color.White);
            myplayer.Draw(gameTime, _spriteBatch,Color.White);
            myenemy.Draw(gameTime, _spriteBatch,Color.White);
            myEnemigo2.Draw(gameTime, _spriteBatch, Color.White);
            _spriteBatch.DrawString(letra,"vidas "+vidas, new Vector2(400, 50), Color.Black);
           
            if (vidas <= 0)
            {
                _spriteBatch.Draw(gameover, new Rectangle(0, 0, 1000, 500), Color.White);
            }
            _spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
