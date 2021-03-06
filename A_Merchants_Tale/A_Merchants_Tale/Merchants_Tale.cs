﻿using Microsoft.Xna.Framework;
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
        
        AssetManager MyAssets;

        Camera camera;

        float screenWidth;
        float screenHeight;

        public Merchants_Tale()
        {
            graphics = new GraphicsDeviceManager(this);

            Content.RootDirectory = "Content";

            //16:9 Resolutions: 1024×576, 1152×648, 1280×720, 1366×768, 1600×900, 1920×1080
            graphics.PreferredBackBufferWidth = 1600;
            graphics.PreferredBackBufferHeight = 900;
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
            screenWidth = this.GraphicsDevice.Viewport.Bounds.Width;
            screenHeight = this.GraphicsDevice.Viewport.Bounds.Height;

            camera = new Camera(this.GraphicsDevice.Viewport);

            MyAssets = new AssetManager();
            MyAssets.initialize(screenWidth, screenHeight);

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

            // TODO: use this.Content to load your game content here

            MyAssets.loadContent(this);
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

            MyAssets.update(this, camera);

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            //Put everything you don't want zoomed, shifted, or rotated in HERE
            spriteBatch.Begin();
            MyAssets.drawFixed(spriteBatch);
            spriteBatch.End();

            //Refer to MonoGame's spriteBatch.Begin() documentation for information about its parameters
            //Anything within this spriteBatch.Begin() and the next spriteBatch.End() will be affected by the camera class
            //In other words, don't put anything in here that you don't want zoomed, shifted, or rotated
            spriteBatch.Begin(SpriteSortMode.BackToFront, null, null, null, null, null, camera.Transform);
            MyAssets.drawScaled(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
