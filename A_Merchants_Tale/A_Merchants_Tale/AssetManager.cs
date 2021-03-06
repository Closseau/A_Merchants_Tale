﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace A_Merchants_Tale
{
    class AssetManager
    {
        static float xAdjust;
        static float yAdjust;

        Texture2D shop;
        Texture2D startMenu;
        Texture2D[] startMenuStart = new Texture2D[3];
        Texture2D[] startMenuExit = new Texture2D[3];
        Texture2D[] tile = new Texture2D[3];
        Texture2D[] menuOption = new Texture2D[3];
        Texture2D menu;

        Background shopBackground;
        Background startMenuBackground;

        static DynamicMenu[] myMenu;
        static ShopTile[] myTiles;

        static MenuOption[] myOptions;

        static Interactable[] myStartMenuButtons;

        KeyboardState myKeys;
        MouseState myMouse;
        Vector2 mousePosition;

        Interactable previouslyClicked;
        Interactable currentlyClicked;

        bool atStartMenu;

        int amountOfTiles = 10;

        public AssetManager()
        {
            
        }

        public void initialize(float screenWidth, float screenHeight)
        {
            xAdjust = screenWidth / 1920;
            yAdjust = screenHeight / 1080;
            
            myTiles = new ShopTile[amountOfTiles];
            myMenu = new DynamicMenu[amountOfTiles];
            myOptions = new MenuOption[4];
            myMenu[1] = new DynamicMenu(new Rectangle(0, 0, 150, 300));                

            for (int i = 0; i < amountOfTiles; i++)
            {
                myTiles[i] = new ShopTile(new Rectangle((int)(300 * xAdjust) + (int)(150 * xAdjust * (i % 5)), 
                    (int)(300 * yAdjust) + ((int)(150 * yAdjust) * (int)(i / 5)), (int)(100 * xAdjust), (int)(100 * yAdjust)));
            }

            atStartMenu = true;

            startMenuBackground = new Background(new Rectangle(0, 0, (int)screenWidth, (int)screenHeight));
            shopBackground = new Background(new Rectangle(0, 0, (int)screenWidth, (int)screenHeight));

            myStartMenuButtons = new Interactable[2];

            myStartMenuButtons[0] = new Interactable(new Rectangle(0, 0, 0, 0));
            myStartMenuButtons[0].width = (int)(600 * xAdjust);
            myStartMenuButtons[0].height = (int)(150 * yAdjust);
            myStartMenuButtons[0] = new Interactable(new Rectangle((int)((screenWidth / 2) - (myStartMenuButtons[0].width / 2)),
                (int)((screenHeight / 2) - (myStartMenuButtons[0].height / 2)), 
                myStartMenuButtons[0].width, myStartMenuButtons[0].height));
            myStartMenuButtons[0].type = (int)UIType.START;

            myStartMenuButtons[1] = new Interactable(new Rectangle(0, 0, 0, 0));
            myStartMenuButtons[1].width = (int)(600 * xAdjust);
            myStartMenuButtons[1].height = (int)(150 * yAdjust);
            myStartMenuButtons[1] = new Interactable(new Rectangle((int)((screenWidth / 2) - (myStartMenuButtons[1].width / 2)),
                (int)((screenHeight / 2) + myStartMenuButtons[1].height), 
                myStartMenuButtons[1].width, myStartMenuButtons[1].height));
            myStartMenuButtons[1].type = (int)UIType.EXIT;

            
            myMenu[1] = new DynamicMenu(new Rectangle(0, 0, (int)(150 * xAdjust), (int)(300 * yAdjust)));

            previouslyClicked = new DynamicMenu(new Rectangle(0, 0, (int)screenWidth, (int)screenHeight));

        }

        public void loadContent(Game game)
        {

            startMenu = game.Content.Load<Texture2D>("Textures/Static/Holo1");

            startMenuStart[(int)UIState.NEUTRAL] = game.Content.Load<Texture2D>("Textures/Interactable/Buttons/Start Menu/Start Button");
            startMenuStart[(int)UIState.HOVERED] = game.Content.Load<Texture2D>("Textures/Interactable/Buttons/Start Menu/Start Button Hover");
            startMenuStart[(int)UIState.CLICKED] = game.Content.Load<Texture2D>("Textures/Interactable/Buttons/Start Menu/Start Button Click");

            startMenuExit[(int)UIState.NEUTRAL] = game.Content.Load<Texture2D>("Textures/Interactable/Buttons/Start Menu/Exit Button");
            startMenuExit[(int)UIState.HOVERED] = game.Content.Load<Texture2D>("Textures/Interactable/Buttons/Start Menu/Exit Button Hover");
            startMenuExit[(int)UIState.CLICKED] = game.Content.Load<Texture2D>("Textures/Interactable/Buttons/Start Menu/Exit Button Click");

            shop = game.Content.Load<Texture2D>("Textures/Static/Holo2");

            tile[(int)UIState.NEUTRAL] = game.Content.Load<Texture2D>("Textures/Interactable/Tiles/Tile0");
            tile[(int)UIState.HOVERED] = game.Content.Load<Texture2D>("Textures/Interactable/Tiles/Tile1");
            tile[(int)UIState.CLICKED] = game.Content.Load<Texture2D>("Textures/Interactable/Tiles/Tile2");

            menu = game.Content.Load<Texture2D>("Textures/Interactable/Menu/MenuDefault");

            menuOption[(int)UIState.NEUTRAL] = game.Content.Load<Texture2D>("Textures/Interactable/Menu/MenuOption0");
            menuOption[(int)UIState.HOVERED] = game.Content.Load<Texture2D>("Textures/Interactable/Menu/MenuOption1");
            menuOption[(int)UIState.CLICKED] = game.Content.Load<Texture2D>("Textures/Interactable/Menu/MenuOption2");
            
        }

        public void update(Game game, Camera camera)
        {
            myMouse = Mouse.GetState();
            myKeys = Keyboard.GetState();

            if(!atStartMenu)
            {
                camera.Update(myMouse, myKeys);

                mousePosition = new Vector2(myMouse.X, myMouse.Y);
                mousePosition = Vector2.Transform(mousePosition, camera.InverseTransform);
            }
            if (atStartMenu)
                mousePosition = new Vector2(myMouse.X, myMouse.Y);

            Logic.clearState(myMenu);
            Logic.clearState(myTiles);
            Logic.clearState(myOptions);

            if(atStartMenu)
            {
                Logic.clearState(myStartMenuButtons);

                currentlyClicked = Logic.hasMouseClicked(myStartMenuButtons, myMouse, mousePosition);

                if(currentlyClicked != null && currentlyClicked.state == (int)UIState.CLICKED 
                    && currentlyClicked.type == (int)UIType.START)
                {
                    atStartMenu = false;
                } 
                else if(currentlyClicked != null && currentlyClicked.state == (int)UIState.CLICKED 
                   && currentlyClicked.type == (int)UIType.EXIT)
                {
                    game.Exit();
                }
            }

            currentlyClicked = Logic.hasMouseClicked(myOptions, myMouse, mousePosition);
            if (currentlyClicked == null)
            {
                currentlyClicked = Logic.hasMouseClicked(myMenu, myMouse, mousePosition);
                if (currentlyClicked == null)
                {
                    currentlyClicked = Logic.hasMouseClicked(myTiles, myMouse, mousePosition);
                    if (currentlyClicked == null)
                    {
                        // then on the last one clear clicked
                        if (myMouse.LeftButton == ButtonState.Pressed)
                        {
                            Logic.clearClickedState(myOptions);
                            Logic.clearClickedState(myMenu);
                            Logic.clearClickedState(myTiles);                            
                        }
                    }
                    else if (currentlyClicked.state == (int)UIState.CLICKED && currentlyClicked != previouslyClicked && currentlyClicked.AttachedToo != previouslyClicked)
                    {
                        previouslyClicked.state = (int)UIState.NEUTRAL;
                        previouslyClicked = currentlyClicked;
                    }
                }
                else if (currentlyClicked.state == (int)UIState.CLICKED && currentlyClicked != previouslyClicked && currentlyClicked.AttachedToo != previouslyClicked)
                {
                    previouslyClicked.state = (int)UIState.NEUTRAL;
                    previouslyClicked = currentlyClicked;
                }
            }
            else if (currentlyClicked.state == (int)UIState.CLICKED && currentlyClicked != previouslyClicked && currentlyClicked.AttachedToo != previouslyClicked)
            {                
                previouslyClicked.state = (int)UIState.NEUTRAL;
                previouslyClicked = currentlyClicked;
            }

            currentlyClicked = null;

        }

        public static void setMenu(Rectangle rectangle, Interactable interactable)
        {
            rectangle.Width = (int)(150 * xAdjust);
            rectangle.Height = (int)(300 * yAdjust);

            myMenu[1] = new DynamicMenu(rectangle, interactable);

            for (int i = 0; i < myOptions.Length; i++)
            {
                myOptions[i] = new MenuOption(new Rectangle(rectangle.X + (rectangle.Width/2) - (int)(65 * xAdjust), 
                    rectangle.Y + ((rectangle.Height/(myOptions.Length * 2)) *(2*i+1)) - (int)(25 * yAdjust), 
                    (int)(130 * xAdjust), (int)(50 * yAdjust)));
            }
        }

        public void drawFixed(SpriteBatch spriteBatch)
        {
            if(!atStartMenu)
            {
                shopBackground.Draw(shop, spriteBatch);
            }

            if(atStartMenu)
            {
                startMenuBackground.Draw(startMenu, spriteBatch);

                for (int i = 0; i < myStartMenuButtons.Length; i++)
                {
                    if (myStartMenuButtons[i].type == (int)UIType.START)
                        myStartMenuButtons[i].Draw(startMenuStart[myStartMenuButtons[i].state], spriteBatch);
                    else if (myStartMenuButtons[i].type == (int)UIType.EXIT)
                        myStartMenuButtons[i].Draw(startMenuExit[myStartMenuButtons[i].state], spriteBatch);
                }
            }
        }

        public void drawScaled(SpriteBatch spriteBatch)
        {
            if (!atStartMenu)
            {
                for (int i = 0; i < amountOfTiles; i++)
                {
                    myTiles[i].Draw(tile[myTiles[i].state], spriteBatch);
                }

                if (myMenu[1].active)
                {
                    myMenu[1].Draw(menu, spriteBatch);

                    for (int i = 0; i < myOptions.Length; i++)
                    {
                        myOptions[i].Draw(menuOption[myOptions[i].state], spriteBatch);
                    }
                } 
            }
        }
    }
}
