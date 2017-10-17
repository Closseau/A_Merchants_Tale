using System;
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

        Texture2D shop;
        Texture2D startMenu;
        Texture2D[] startMenuButtons = new Texture2D[2];
        Texture2D[] tile = new Texture2D[3];
        Texture2D[] menuOption = new Texture2D[3];
        Texture2D menu;

        Background shopBackground;
        Background startMenuBackground;

        static DynamicMenu[] myMenu;
        static ShopTile[] myTiles;

        static MenuOption[] myOptions;

        static Interactable[] myStartMenuButtons;


        MouseState myMouse;

        Interactable previouslyClicked;
        Interactable currentlyClicked;

        bool atStartMenu;

        int amountOfTiles = 11;

        public AssetManager()
        {
            
        }

        public void initialize(float width, float height)
        {
            screenWidth = width;
            screenHeight = height;
            
            //shopBackground = new Background(new Rectangle(0, 0, (int)screenWidth, (int)screenHeight));
            myTiles = new ShopTile[amountOfTiles];
            myMenu = new DynamicMenu[amountOfTiles];
            myOptions = new MenuOption[4];
            myMenu[1] = new DynamicMenu(new Rectangle(0, 0, 150, 300));                

            for (int i = 0; i < amountOfTiles; i++)
            {
                myTiles[i] = new ShopTile(new Rectangle((int)(0.1875 * screenWidth) + (int)(0.09375 * screenWidth * (i % 5)), 
                    (int)(screenHeight/3) + ((int)(screenHeight / 6) * (int)(i / 5)), (int)screenWidth/16, (int)screenHeight/9));
            }


            atStartMenu = true;

            startMenuBackground = new Background(new Rectangle(0, 0, (int)screenWidth, (int)screenHeight));
            shopBackground = new Background(new Rectangle(0, 0, (int)screenWidth, (int)screenHeight));

            myStartMenuButtons = new Interactable[2];

            myStartMenuButtons[0] = new Interactable(new Rectangle(0, 0, 0, 0));
            myStartMenuButtons[0].width = (int)(0.375 * screenWidth);
            myStartMenuButtons[0].height = (int)(screenHeight / 6);
            myStartMenuButtons[0] = new Interactable(new Rectangle((int)((screenWidth / 2) - (myStartMenuButtons[0].width / 2)),
                (int)((screenHeight / 2) - (myStartMenuButtons[0].height / 2)), myStartMenuButtons[0].width, myStartMenuButtons[0].height));
            myStartMenuButtons[0].type = (int)UIType.START;

            myStartMenuButtons[1] = new Interactable(new Rectangle(0, 0, 0, 0));
            myStartMenuButtons[1].width = (int)(0.375 * screenWidth);
            myStartMenuButtons[1].height = (int)(screenHeight / 6);
            myStartMenuButtons[1] = new Interactable(new Rectangle((int)((screenWidth / 2) - (myStartMenuButtons[1].width / 2)),
                (int)((screenHeight / 2) + myStartMenuButtons[1].height), 
                myStartMenuButtons[1].width, myStartMenuButtons[1].height));
            myStartMenuButtons[1].type = (int)UIType.EXIT;

            
            myMenu[1] = new DynamicMenu(new Rectangle(0, 0, (int)(0.09375 * screenWidth), (int)(screenHeight/3)));

            previouslyClicked = new DynamicMenu(new Rectangle(0, 0, (int)screenWidth, (int)screenHeight));


            //0.1875 and 1/3 are the coefficients needed to start making the tiles at (300,300) on a 1600x900 screen
            //0.09375 and 1/6 are the coefficients needed to separate the tiles by 150 pixels on a 1600x900 screen

        }

        public void loadContent(Game game)
        {

            startMenu = game.Content.Load<Texture2D>("Textures/Static/Holo1");

            startMenuButtons[(int)UIState.NEUTRAL] = game.Content.Load<Texture2D>("Textures/Interactable/Tiles/Tile0");
            startMenuButtons[(int)UIState.HOVERED] = game.Content.Load<Texture2D>("Textures/Interactable/Tiles/Tile1");

            shop = game.Content.Load<Texture2D>("Textures/Static/Holo2");

            tile[(int)UIState.NEUTRAL] = game.Content.Load<Texture2D>("Textures/Interactable/Tiles/Tile0");
            tile[(int)UIState.HOVERED] = game.Content.Load<Texture2D>("Textures/Interactable/Tiles/Tile1");
            tile[(int)UIState.CLICKED] = game.Content.Load<Texture2D>("Textures/Interactable/Tiles/Tile2");

            menu = game.Content.Load<Texture2D>("Textures/Interactable/Menu/MenuDefault");

            menuOption[(int)UIState.NEUTRAL] = game.Content.Load<Texture2D>("Textures/Interactable/Menu/MenuOption0");
            menuOption[(int)UIState.HOVERED] = game.Content.Load<Texture2D>("Textures/Interactable/Menu/MenuOption1");
            menuOption[(int)UIState.CLICKED] = game.Content.Load<Texture2D>("Textures/Interactable/Menu/MenuOption2");
            
        }

        public void update(Game game)
        {
            myMouse = Mouse.GetState();
            //hover click logic ... need to move/change this
            //change idea.. condition too see if mouse is clicked if so run front to back on interactibles untill one is found activate Onclick() and "break out" and run the rest for hovers

            Logic.clearState(myMenu);
            Logic.clearState(myTiles);
            Logic.clearState(myOptions);


            if(atStartMenu)
            {
                Logic.clearState(myStartMenuButtons);

                currentlyClicked = Logic.hasMouseClicked(myStartMenuButtons, myMouse);

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

            

            currentlyClicked = Logic.hasMouseClicked(myOptions, myMouse);
            if (currentlyClicked == null)
            {
                currentlyClicked = Logic.hasMouseClicked(myMenu, myMouse);
                if (currentlyClicked == null)
                {
                    currentlyClicked = Logic.hasMouseClicked(myTiles, myMouse);
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
            myMenu[1] = new DynamicMenu(rectangle, interactable);
            for (int i = 0; i < myOptions.Length; i++)
            {
                myOptions[i] = new MenuOption(new Rectangle(rectangle.X + (rectangle.Width/2) - (65), rectangle.Y + ((rectangle.Height/(myOptions.Length * 2)) *(2*i+1)) - 25, 130, 50));
            }
        }

        public void draw(SpriteBatch spriteBatch)
        {
            //myBackground.Draw(background, spriteBatch);

            shopBackground.Draw(shop, spriteBatch);

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

            if (atStartMenu)
            {
                startMenuBackground.Draw(startMenu, spriteBatch);
                for(int i = 0; i < myStartMenuButtons.Length; i++)
                {
                    myStartMenuButtons[i].Draw(startMenuButtons[myStartMenuButtons[i].state], spriteBatch);
                }
            }
          
        }     
      
    }
}
