using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace A_Merchants_Tale
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Merchants_Tale : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D background;
        Texture2D[] tile = new Texture2D[3];
        Background myTest;
        Interactable[] myTiles;
        public Merchants_Tale()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            graphics.PreferredBackBufferWidth = 1920;
            graphics.PreferredBackBufferHeight = 1080;  
            graphics.ApplyChanges();
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            int i;
            myTest = new Background(new Rectangle(0, 0, 1920, 1080));
            myTiles = new Interactable[10];
            for (i = 0; i < 10; i++)
            { 
                myTiles[i] = new Interactable(new Rectangle(300 + (150 * (i % 5)), 300 + (150 * (int)(i/5)), 100, 100));
            }
            base.Initialize();
            IsMouseVisible = true;
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            background = Content.Load<Texture2D>("Textures/Static/BackGround");
            tile[0] = Content.Load<Texture2D>("Textures/Interactable/Tiles/Tile0");
            tile[1] = Content.Load<Texture2D>("Textures/Interactable/Tiles/Tile1");
            tile[2] = Content.Load<Texture2D>("Textures/Interactable/Tiles/Tile2");
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            int i;
            for (i = 0; i < 10; i++)
            {
                if (Logic.checkMouseCollison(myTiles[i]))
                {
                    if (Mouse.GetState().LeftButton == ButtonState.Pressed)
                    {

                        myTiles[i].onClick();

                    }
                    else if (myTiles[i].getState() != 2)
                    {
                        myTiles[i].onHover();
                    }
                }
                else
                {
                    if (myTiles[i].getState() == 1 || myTiles[i].getState() == 0)
                    {
                        myTiles[i].setState(0);
                    }
                    else if (Mouse.GetState().LeftButton == ButtonState.Pressed)
                    {
                        myTiles[i].setState(0);
                    }

                }
            }
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            myTest.Draw(background, spriteBatch);
            int i;
            for (i = 0; i < 10; i++)
                myTiles[i].Draw(tile[myTiles[i].getState()], spriteBatch);
            spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
