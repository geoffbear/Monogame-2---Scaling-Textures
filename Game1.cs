using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Runtime.CompilerServices;

namespace Monogame_2___Scaling_Textures
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D rectangleTexture;
        Texture2D circleTexture;
        Rectangle purpleRectangle;
        Rectangle blackRectange;
        Random generator;
        SpriteFont messageFont;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
            generator = new Random();
            purpleRectangle = new Rectangle(200, 450,  100, 25);
            blackRectange = new Rectangle(100, 200, 250, 50);
            
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            rectangleTexture = Content.Load<Texture2D>("rectangle");
            circleTexture = Content.Load<Texture2D>("circle");
            messageFont = Content.Load<SpriteFont>("message");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            // TODO: Add your drawing code here

            base.Draw(gameTime);

            _spriteBatch.Begin();
            _spriteBatch.Draw(rectangleTexture, new Rectangle(300, 0, 375, 45), Color.RosyBrown);
            _spriteBatch.Draw(circleTexture, new Rectangle(200, 75, 200, 400), Color.DarkSalmon);
            _spriteBatch.Draw(circleTexture, new Rectangle(200, 10, 110, 110), Color.DarkSalmon);

            _spriteBatch.Draw(circleTexture, new Rectangle(205, 30, 50, 50), Color.Black);
            _spriteBatch.Draw(circleTexture, new Rectangle(205, 30, 25, 25), Color.White);

            _spriteBatch.Draw(circleTexture, new Rectangle(240, 30, 50, 50), Color.Black);
            _spriteBatch.Draw(circleTexture, new Rectangle(240, 30, 25, 25), Color.White);

            _spriteBatch.Draw(circleTexture, new Rectangle(0, 0, 52, 52), Color.Black);
            _spriteBatch.Draw(circleTexture, new Rectangle(1, 1, 50, 50), Color.Yellow);

            for (int i = 0; i < 25; i++)
            {
                _spriteBatch.Draw(circleTexture, new Rectangle(i, i, i, i), Color.Black);
            }


            _spriteBatch.Draw(rectangleTexture, purpleRectangle, Color.BlueViolet);
            _spriteBatch.Draw(rectangleTexture, blackRectange, Color.DarkSalmon);
            _spriteBatch.DrawString(messageFont, "Welcome to my program!!", new Vector2(305, 0), Color.Black);
            _spriteBatch.End();



        }
    }
}