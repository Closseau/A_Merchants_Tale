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
        static DynamicMenu myMenu;
        ShopTile[] myTiles;
        MouseState myMouse;
        public AssetManager()
        {
            
        }
        public void initialize()
        {

            int i;
            myBackground = new Background(new Rectangle(0, 0, 1920, 1080));
            myTiles = new ShopTile[10];
            for (i = 0; i < 10; i++)
            {
                myTiles[i] = new ShopTile(new Rectangle(300 + (150 * (i % 5)), 300 + (150 * (int)(i / 5)), 100, 100));
            }
            myMenu = new DynamicMenu(new Rectangle(0, 0, 150, 300));
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
            int i;
            for (i = 0; i < 10; i++)
            {
                if (Logic.checkMouseCollison(myTiles[i], myMouse))
                {
                    if (Mouse.GetState().LeftButton == ButtonState.Pressed)
                    {

                        myTiles[i].onClick(myMouse);

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
        }
        public static void setMenu(Rectangle rectangle, Interactable interactable)
        {
            myMenu = new DynamicMenu(rectangle, interactable);

        }
        public void draw(SpriteBatch spriteBatch)
        {
            myBackground.Draw(background, spriteBatch);
            int i;
            for (i = 0; i < 10; i++)
                myTiles[i].Draw(tile[myTiles[i].getState()], spriteBatch);

            if (myMenu.getAmDisplayed())
                myMenu.Draw(menu, spriteBatch);
        }
        
    }
}
