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
        Texture2D[] startMenuStart = new Texture2D[3];
        Texture2D[] startMenuExit = new Texture2D[3];
        Texture2D[] tile = new Texture2D[3];
        Texture2D[] menuOption = new Texture2D[3];
        Texture2D menu;

        Background shopBackground;
        Background startMenuBackground;

        DynamicMenu[] myMenu;
        ShopTile[] myTiles;


        MenuOption[] myOptions;

        Interactable[] myStartMenuButtons;

        MouseState previousMouseState;
        MouseState myMouse;

        Interactable previouslyClicked;
        Interactable previouslyHovered;
        Interactable currentMouseLogicResult;
        Interactable mouseUpProspect;

        bool atStartMenu;
        int currentScreen = 0;
        int amountOfTiles = 10;

        public AssetManager()
        {
            
        }

        public void initialize(float width, float height)
        {
            screenWidth = width;
            screenHeight = height;
            
            myTiles = new ShopTile[amountOfTiles];
            myMenu = new DynamicMenu[amountOfTiles];
            myOptions = new MenuOption[4];
            myMenu[1] = new DynamicMenu(new Rectangle(0, 0, 150, 300));
            myMenu[1].screen = 1;

            for (int i = 0; i < amountOfTiles; i++)
            {
                myTiles[i] = new ShopTile(new Rectangle((int)(0.1875 * screenWidth) + (int)(0.09375 * screenWidth * (i % 5)), 
                    (int)(screenHeight/3) + ((int)(screenHeight / 6) * (int)(i / 5)), (int)screenWidth/16, (int)screenHeight/9));
                myTiles[i].screen = 1;
            }

            atStartMenu = true;

            startMenuBackground = new Background(new Rectangle(0, 0, (int)screenWidth, (int)screenHeight));
            
            shopBackground = new Background(new Rectangle(0, 0, (int)screenWidth, (int)screenHeight));

            myStartMenuButtons = new Interactable[2];

            myStartMenuButtons[0] = new Interactable(new Rectangle(0, 0, 0, 0));
            myStartMenuButtons[0].width = (int)(0.375 * screenWidth);
            myStartMenuButtons[0].height = (int)(screenHeight / 6);
            myStartMenuButtons[0] = new Interactable(new Rectangle((int)((screenWidth / 2) - (myStartMenuButtons[0].width / 2)),
                (int)((screenHeight / 2) - (myStartMenuButtons[0].height / 2)), 
                myStartMenuButtons[0].width, myStartMenuButtons[0].height));
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

            // getting an initial previous state
            previousMouseState = Mouse.GetState();
            //0.1875 and 1/3 are the coefficients needed to start making the tiles at (300,300) on a 1600x900 screen
            //0.09375 and 1/6 are the coefficients needed to separate the tiles by 150 pixels on a 1600x900 screen

        }

        public void loadContent(Game game)
        {

            startMenu = game.Content.Load<Texture2D>("Textures/Static/Holo1");

            startMenuStart[(int)UIState.NEUTRAL] = game.Content.Load<Texture2D>("Textures/Interactable/Buttons/Start Menu/Start Button");
            startMenuStart[(int)UIState.HOVERED] = game.Content.Load<Texture2D>("Textures/Interactable/Buttons/Start Menu/Start Button Hover");
            startMenuStart[(int)UIState.CLICKED] = game.Content.Load<Texture2D>("Textures/Interactable/Menu/MenuOption2");

            startMenuExit[(int)UIState.NEUTRAL] = game.Content.Load<Texture2D>("Textures/Interactable/Buttons/Start Menu/Exit Button");
            startMenuExit[(int)UIState.HOVERED] = game.Content.Load<Texture2D>("Textures/Interactable/Buttons/Start Menu/Exit Button Hover");
            startMenuExit[(int)UIState.CLICKED] = game.Content.Load<Texture2D>("Textures/Interactable/Menu/MenuOption2");

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

            //Logic.clearState(myMenu);
            //Logic.clearState(myTiles);
            //Logic.clearState(myOptions);

            //nonsense Conditional booleans!!

            bool currentMouseLogicResultDoesntExist;

            currentMouseLogicResult = Logic.hasMouseClicked(myMenu, myMouse, previousMouseState, currentScreen);

            currentMouseLogicResultDoesntExist = (currentMouseLogicResult == null);
                
            if (currentMouseLogicResultDoesntExist)
            {
                currentMouseLogicResult = Logic.hasMouseClicked(myTiles, myMouse, previousMouseState, currentScreen);

                currentMouseLogicResultDoesntExist = (currentMouseLogicResult == null);

                if (currentMouseLogicResultDoesntExist)
                {
                    // to clear hover when not hoving over something
                    if (previouslyHovered != null && previouslyHovered.uiState != (int)UIState.CLICKED)
                    {

                        //clear previous
                        previouslyHovered.uiState = (int)UIState.NEUTRAL;
                        previouslyHovered.visualState = (int)UIState.NEUTRAL;
                    }
                        /*
                        if (mouseDown && previouslyClicked != null)
                        {
                            previouslyClicked.clearAttachedToo();

                            previouslyClicked = null;
                        }
                        */
                    }
                else
                {
                    

                    if (currentMouseLogicResult == previouslyClicked && currentMouseLogicResult.uiState == (int)UIState.CLICKED && currentMouseLogicResult.active)
                    {
                        // same shop tile clicked again
                        currentMouseLogicResult.AttachedFrom[0].moveEntity(myMouse);
                        // reseting active state
                        currentMouseLogicResult.active = false;
                    }
                    else if (currentMouseLogicResult.uiState == (int)UIState.CLICKED && currentMouseLogicResult.active)
                    {
                        //New ShopTile clicked

                        // reseting active state
                        currentMouseLogicResult.active = false;
                        // does previous exist?
                        if (previouslyClicked != null)
                        {
                            //clear previous
                            previouslyClicked.uiState = (int)UIState.NEUTRAL;
                            previouslyClicked.visualState = (int)UIState.NEUTRAL;
                            //this is where a clear method in future would be called

                        }
                        //set previous for clearing later
                        previouslyClicked = currentMouseLogicResult;
                        // do click event -> conditional for multiple possiblilities would go here
                        // make new menu[1]
                        shopTileMenuCreation(currentMouseLogicResult);
                        //set visual state
                        currentMouseLogicResult.visualState = (int)UIState.CLICKED;
                        //currentMouseLogicResult.onClick(myMouse);


                    }
                    else if (currentMouseLogicResult.uiState == (int)UIState.HOVERED && currentMouseLogicResult.active)
                    {
                        // shoptile hovered

                        // reseting active state
                        currentMouseLogicResult.active = false;
                        // does previous exist?
                        if (previouslyHovered != null && previouslyHovered.uiState != (int)UIState.CLICKED)
                        {
                        //clear previous
                            previouslyHovered.uiState = (int)UIState.NEUTRAL;
                            previouslyHovered.visualState = (int)UIState.NEUTRAL;
                        }
                        //set previous for clearing later
                        previouslyHovered = currentMouseLogicResult;
                        //set visual state
                        currentMouseLogicResult.visualState = (int)UIState.HOVERED;
                    }
                    else if (currentMouseLogicResult.uiState == (int)UIState.HARDHOVER && currentMouseLogicResult.active)
                    {
                        //shoptile hard hover

                        // reseting active state
                        currentMouseLogicResult.active = false;
                        // does previous exist?
                        if (previouslyHovered != null && previouslyHovered.uiState != (int)UIState.CLICKED)
                        {
                            //clear previous
                            previouslyHovered.uiState = (int)UIState.NEUTRAL;
                            previouslyHovered.visualState = (int)UIState.NEUTRAL;
                        }
                        //set previous for clearing later
                        previouslyHovered = currentMouseLogicResult;
                        //set visual state
                        currentMouseLogicResult.visualState = (int)UIState.CLICKED;
                    }
                }
            }
            else
            {
                if (currentMouseLogicResult.uiState != (int)UIState.NEUTRAL && currentMouseLogicResult.active)
                {
                    //reset active state on menu to stop further calls
                    //currentMouseLogicResult.active = false;
                    //conditional/switch to determine which menu this is 
                    // catch-all for shopmenu related actions
                    shopTileMenuClick();
                }
            }


            if (currentScreen == 0)
            {
                Logic.clearState(myStartMenuButtons);

                currentMouseLogicResult = Logic.hasMouseClicked(myStartMenuButtons, myMouse, previousMouseState, currentScreen);

                if (currentMouseLogicResult != null &&  currentMouseLogicResult.type == (int)UIType.START)
                {
                    if (currentMouseLogicResult.uiState == (int)UIState.CLICKED && currentMouseLogicResult.active)
                    {
                        currentScreen++;
                    }
                    else if (currentMouseLogicResult.uiState == (int)UIState.HOVERED && currentMouseLogicResult.active)
                    {

                        // reseting active state
                        currentMouseLogicResult.active = false;
                        // does previous exist?
                        if (previouslyHovered != null && previouslyHovered.uiState != (int)UIState.CLICKED)
                        {
                            //clear previous
                            previouslyHovered.uiState = (int)UIState.NEUTRAL;
                            previouslyHovered.visualState = (int)UIState.NEUTRAL;
                        }
                        //set previous for clearing later
                        previouslyHovered = currentMouseLogicResult;
                        //set visual state
                        currentMouseLogicResult.visualState = (int)UIState.HOVERED;
                    }
                    else if (currentMouseLogicResult.uiState == (int)UIState.HARDHOVER && currentMouseLogicResult.active)
                    {

                        // reseting active state
                        currentMouseLogicResult.active = false;
                        // does previous exist?
                        if (previouslyHovered != null && previouslyHovered.uiState != (int)UIState.CLICKED)
                        {
                            //clear previous
                            previouslyHovered.uiState = (int)UIState.NEUTRAL;
                            previouslyHovered.visualState = (int)UIState.NEUTRAL;
                        }
                        //set previous for clearing later
                        previouslyHovered = currentMouseLogicResult;
                        //set visual state
                        currentMouseLogicResult.visualState = (int)UIState.CLICKED;
                    }


                }
                else if (currentMouseLogicResult != null && currentMouseLogicResult.type == (int)UIType.EXIT)
                {
                    if (currentMouseLogicResult.uiState == (int)UIState.CLICKED && currentMouseLogicResult.active)
                    {
                        game.Exit();
                    }
                    else if (currentMouseLogicResult.uiState == (int)UIState.HOVERED && currentMouseLogicResult.active)
                    {

                        // reseting active state
                        currentMouseLogicResult.active = false;
                        // does previous exist?
                        if (previouslyHovered != null && previouslyHovered.uiState != (int)UIState.CLICKED)
                        {
                            //clear previous
                            previouslyHovered.uiState = (int)UIState.NEUTRAL;
                            previouslyHovered.visualState = (int)UIState.NEUTRAL;
                        }
                        //set previous for clearing later
                        previouslyHovered = currentMouseLogicResult;
                        //set visual state
                        currentMouseLogicResult.visualState = (int)UIState.HOVERED;
                    }
                    else if (currentMouseLogicResult.uiState == (int)UIState.HARDHOVER && currentMouseLogicResult.active)
                    {

                        // reseting active state
                        currentMouseLogicResult.active = false;
                        // does previous exist?
                        if (previouslyHovered != null && previouslyHovered.uiState != (int)UIState.CLICKED)
                        {
                            //clear previous
                            previouslyHovered.uiState = (int)UIState.NEUTRAL;
                            previouslyHovered.visualState = (int)UIState.NEUTRAL;
                        }
                        //set previous for clearing later
                        previouslyHovered = currentMouseLogicResult;
                        //set visual state
                        currentMouseLogicResult.visualState = (int)UIState.CLICKED;
                    }

                }
            }



            
            currentMouseLogicResult = null;

            previousMouseState = myMouse;
        }
        public void draw(SpriteBatch spriteBatch)
        {            
            shopBackground.Draw(shop, spriteBatch);

            for (int i = 0; i < amountOfTiles; i++)
            {
                if (myTiles[i].screen == currentScreen)
                    myTiles[i].Draw(tile[myTiles[i].visualState], spriteBatch);
            }
            


            for (int i = 0; i < myMenu.Length; i++)
            {
                if (myMenu[i] != null && myMenu[i].visualState == (int)UIState.CLICKED && myMenu[i].screen == currentScreen)
                {
                    myMenu[i].Draw(menu, spriteBatch);
                    /*
                    for (i = 0; i < myOptions.Length; i++)
                    {
                        if (myOptions[i] != null)
                            myOptions[i].Draw(menuOption[myOptions[i].visualState], spriteBatch);
                    }
                    */
                }
            }


            for (int i = 0; i < myOptions.Length; i++)
            {
                if (myOptions[i] != null && myOptions[i].screen == currentScreen)
                    myOptions[i].Draw(menuOption[myOptions[i].visualState], spriteBatch);
            }


            if (currentScreen == 0)
            {
                startMenuBackground.Draw(startMenu, spriteBatch);
            }

            for(int i = 0; i < myStartMenuButtons.Length; i++)
            {
                if(myStartMenuButtons[i] != null && myStartMenuButtons[i].type == (int)UIType.START && myStartMenuButtons[i].screen == currentScreen)
                    myStartMenuButtons[i].Draw(startMenuStart[myStartMenuButtons[i].visualState], spriteBatch);
                else if(myStartMenuButtons[i] != null && myStartMenuButtons[i].type == (int)UIType.EXIT && myStartMenuButtons[i].screen == currentScreen)
                    myStartMenuButtons[i].Draw(startMenuExit[myStartMenuButtons[i].visualState], spriteBatch);
            }
            

        }
        public void shopTileMenuCreation(Interactable interactable)
        {
            //not excatly sure where to put this so for now its here
            //so like we can make menu options and putthem here and know that like menuoptions[1-5] are for menu[1] and stuff
            myMenu[1] = new DynamicMenu(new Rectangle(myMouse.X + 1, myMouse.Y + 1, 150, 300), interactable, 1);
            myMenu[1].screen = 1;
            //myMenu[1].uiState = (int)UIState.CLICKED;
            for (int i = 0; i < 2; i++)
            {
                myOptions[i] = new MenuOption(new Rectangle(myMenu[1].xPos + 5,
                    myMouse.Y + 50 + (100 * i),
                    130 , 50 ));
                myMenu[1].AttachedFrom[i] = myOptions[i];
                myOptions[i].AttachedToo = myMenu[1];
            }
            myOptions[2] = new ExitButton(new Rectangle(myMenu[1].xPos + myMenu[1].width - 35, myMenu[1].yPos + 5, 30, 30), myMenu[1]);
            myMenu[1].AttachedFrom[2] = myOptions[2];
        }
        public void shopTileMenuClick()
        {
            //not excatly sure where to put this so for now its here
            Boolean currentMouseLogicResultDoesntExist;

            currentMouseLogicResult = Logic.hasMouseClicked(myMenu[1].AttachedFrom, myMouse, previousMouseState, currentScreen);

            currentMouseLogicResultDoesntExist = (currentMouseLogicResult == null);

            if (currentMouseLogicResultDoesntExist)
            {
                Logic.clearState(myMenu[1].AttachedFrom);
            }
            else
            {

                if (currentMouseLogicResult.uiState == (int)UIState.CLICKED && currentMouseLogicResult.active)
                {
                    currentMouseLogicResult.active = false;
                    //New Menu clicked (idea: no need to reset anything if menu is clicked)

                    //make switch statement to determine which menu it is via ID

                    //call corisponding method to deal with that menu (type?)
                    currentMouseLogicResult.onClick();
                    // reseting active state
                    // does previous exist?
                    if (previouslyClicked != null && currentMouseLogicResult.isRelated(previouslyClicked) == false)
                    {
                        //clear previous
                        previouslyClicked.uiState = (int)UIState.NEUTRAL;
                        previouslyClicked.visualState = (int)UIState.NEUTRAL;
                    }
                    //set previous for clearing later
                    previouslyClicked = currentMouseLogicResult;
                    //set visual state
                    currentMouseLogicResult.visualState = (int)UIState.CLICKED;
                }
                else if (currentMouseLogicResult.uiState == (int)UIState.HOVERED && currentMouseLogicResult.active)
                {
                    currentMouseLogicResult.active = false;
                    // menu hovered (menus should be checked for hover props event though they dont had an effect do to there menu opts)


                    //deal with previously hovered element

                    if (previouslyHovered != null && previouslyHovered.uiState != (int)UIState.CLICKED)
                    {
                        //clear previous
                        previouslyHovered.uiState = (int)UIState.NEUTRAL;
                        previouslyHovered.visualState = (int)UIState.NEUTRAL;
                    }

                    //make switch statement to determine which menu it is via ID

                    //call corisponding method to deal with that menu (type?)

                    //set previous for clearing later
                    previouslyHovered = currentMouseLogicResult;
                    //set visual state, rewrite when a above is finished
                    currentMouseLogicResult.visualState = (int)UIState.HOVERED;
                }
                else if (currentMouseLogicResult.uiState == (int)UIState.HARDHOVER && currentMouseLogicResult.active)
                {
                    currentMouseLogicResult.active = false;
                    //menu option hard hover

                    if (previouslyHovered != null && previouslyHovered.uiState != (int)UIState.CLICKED)
                    {
                        //clear previous
                        previouslyHovered.uiState = (int)UIState.NEUTRAL;
                        previouslyHovered.visualState = (int)UIState.NEUTRAL;
                    }

                    previouslyHovered = currentMouseLogicResult;
                    currentMouseLogicResult.visualState = (int)UIState.CLICKED;

                }
            }
        }
    }
}
