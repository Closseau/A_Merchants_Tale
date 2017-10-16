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

        public AssetManager()
        {

        }

        public void initialize()
        {
            myBackground = new Background(new Rectangle(0, 0, 1920, 1080));
            myTiles = new ShopTile[10];
            myMenu = new DynamicMenu[10];
            myMenu[1] = new DynamicMenu(new Rectangle(0, 0, 150, 300));

            for (int i = 0; i < 10; i++)
            {
                myTiles[i] = new ShopTile(new Rectangle(300 + (150 * (i % 5)), 300 + (150 * (int)(i / 5)), 100, 100));
            }
        }

        public void loadContent(Game game)
        {
            background = game.Content.Load<Texture2D>("Textures/Static/BackGround");
            
            tile[(int)Interactable.UIState.NEUTRAL] = game.Content.Load<Texture2D>("Textures/Interactable/Tiles/Tile0");
            tile[(int)Interactable.UIState.HOVERED] = game.Content.Load<Texture2D>("Textures/Interactable/Tiles/Tile1");
            tile[(int)Interactable.UIState.CLICKED] = game.Content.Load<Texture2D>("Textures/Interactable/Tiles/Tile2");

            menu = game.Content.Load<Texture2D>("Textures/Interactable/Menu/MenuDefault");

            menuOption[(int)Interactable.UIState.NEUTRAL] = game.Content.Load<Texture2D>("Textures/Interactable/Menu/MenuOption0");
            menuOption[(int)Interactable.UIState.HOVERED] = game.Content.Load<Texture2D>("Textures/Interactable/Menu/MenuOption1");
            menuOption[(int)Interactable.UIState.CLICKED] = game.Content.Load<Texture2D>("Textures/Interactable/Menu/MenuOption2");
        }

        public void update()
        {
            myMouse = Mouse.GetState();
            //hover click logic ... need to move/change this
            //change idea.. condition too see if mouse is clicked if so run front to back on interactibles untill one is found activate Onclick() and "break out" and run the rest for hovers

            Logic.clearState(myMenu);
            Logic.clearState(myTiles);

            currentlyClicked = Logic.hasMouseClicked(myMenu, myMouse);

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
                    previouslyClicked.setState((int)Interactable.UIState.NEUTRAL);
                    previouslyClicked = currentlyClicked;
                }
            }
            else if (currentlyClicked.getState() == (int)Interactable.UIState.CLICKED && currentlyClicked != previouslyClicked && currentlyClicked.getAttachedToo() != previouslyClicked)
            {
                previouslyClicked.setState((int)Interactable.UIState.NEUTRAL);
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
            {
                myTiles[i].Draw(tile[myTiles[i].getState()], spriteBatch);
            }

            if (myMenu[1].getActive())
            {
                myMenu[1].Draw(menu, spriteBatch);
            }
        }

    }
}
