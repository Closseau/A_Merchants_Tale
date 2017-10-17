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

        float screenWidth;
        float screenHeight;

        Texture2D background;
        Texture2D[] tile = new Texture2D[3];
        Texture2D[] menuOption = new Texture2D[3];
        Texture2D menu;
        Background myBackground;
        static DynamicMenu[] myMenu;
        static ShopTile[] myTiles;
        MouseState myMouse;
        Interactable previouslyClicked = new DynamicMenu(new Rectangle(0, 0, 150, 300));
        Interactable currentlyClicked;

        bool atMenu;

        public AssetManager()
        {
            
        }
        public void initialize(float width, float height)
        {

            screenWidth = width;
            screenHeight = height;

            myBackground = new Background(new Rectangle(0, 0, (int)screenWidth, (int)screenHeight));
            myTiles = new ShopTile[10];
            myMenu = new DynamicMenu[10];
            myMenu[1] = new DynamicMenu(new Rectangle(0, 0, 150, 300));

                

            for (int i = 0; i < 10; i++)
            {
                myTiles[i] = new ShopTile(new Rectangle(300 + (150 * (i % 5)), 300 + (150 * (int)(i / 5)), (int)screenWidth/16, (int)screenHeight/9));
            }
        }
        public void loadContent(Game game)
        {

            background = game.Content.Load<Texture2D>("Textures/Static/BackGround");

            tile[0] = game.Content.Load<Texture2D>("Textures/Interactable/Tiles/Tile0");
            tile[1] = game.Content.Load<Texture2D>("Textures/Interactable/Tiles/Tile1");
            tile[2] = game.Content.Load<Texture2D>("Textures/Interactable/Tiles/Tile2");

            menu = game.Content.Load<Texture2D>("Textures/Interactable/Menu/MenuDefault");

            menuOption[0] = game.Content.Load<Texture2D>("Textures/Interactable/Menu/MenuOption0");
            menuOption[1] = game.Content.Load<Texture2D>("Textures/Interactable/Menu/MenuOption1");
            menuOption[2] = game.Content.Load<Texture2D>("Textures/Interactable/Menu/MenuOption2");

        }
        public void update()
        {
            myMouse = Mouse.GetState();
            //hover click logic ... need to move/change this
            //change idea.. condition too see if mouse is clicked if so run front to back on interactibles untill one is found activate Onclick() and "break out" and run the rest for hovers

            Logic.clearState(myMenu);
            Logic.clearState(myTiles);

            currentlyClicked = Logic.hasMouseClicked(myMenu,myMouse);
            if (currentlyClicked == null)
            {
                currentlyClicked = Logic.hasMouseClicked(myTiles, myMouse);
                if (currentlyClicked == null)
                {
                    // repeat for other arrays

                    // then on the last one clear clicked
                    if (myMouse.LeftButton == ButtonState.Pressed)
                    {
                        Logic.clearClickedState(myMenu);
                        Logic.clearClickedState(myTiles);
                    }
                }
                else if (currentlyClicked.getState() == 2 && currentlyClicked != previouslyClicked && currentlyClicked.getAttachedToo() != previouslyClicked)
                {
                      previouslyClicked.setState(0);
                      previouslyClicked = currentlyClicked;
                }
            }
            else if (currentlyClicked.getState() == 2 && currentlyClicked != previouslyClicked && currentlyClicked.getAttachedToo() != previouslyClicked)
            {
                previouslyClicked.setState(0);
                previouslyClicked = currentlyClicked;
            }

            currentlyClicked = null;


        }
        public static void setMenu(Rectangle rectangle, Interactable interactable)
        {
            myMenu[1] = new DynamicMenu(rectangle, interactable);
        }
        public void draw(SpriteBatch spriteBatch)
        {
            
            myBackground.Draw(background, spriteBatch);
            for (int i = 0; i < 10; i++)
                myTiles[i].Draw(tile[myTiles[i].getState()], spriteBatch);

            if (myMenu[1].getActive())
                myMenu[1].Draw(menu, spriteBatch);
        }
        
    }
}