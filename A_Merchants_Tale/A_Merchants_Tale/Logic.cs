using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

public enum UIState { NEUTRAL = 0, HOVERED = 1, CLICKED = 2, HARDHOVER = 3 };
public enum UIType { START = 1000, EXIT = 1001, };

namespace A_Merchants_Tale
{
    class Logic
    {
        public static void checkUI()
        {

        }

        public static Interactable hasMouseClicked(Interactable[] interactable, MouseState mouseState, MouseState previousMouseState, int currentScreen)
        {
          //  Boolean hasFoundHover = false;

            if ( mouseState.LeftButton == ButtonState.Released && previousMouseState.LeftButton == ButtonState.Pressed)
            {
                foreach (Interactable element in interactable)
                {
                    if (element != null && element.screen == currentScreen && Logic.checkMouseCollison(element, mouseState))
                    {
                        element.uiState = (int)UIState.CLICKED;
                        element.active = true;

                        // make sure to run click code outside set visual states to know if they have been activated yet?
                        return element;
                    }
                }
            }
            else
            {
                foreach (Interactable element in interactable)
                {
                    if (element != null && element.screen == currentScreen && Logic.checkMouseCollison(element, mouseState) 
                        && element.uiState != (int)UIState.CLICKED)
                    {

                        if (mouseState.LeftButton == ButtonState.Pressed)
                        {
                            element.uiState = (int)UIState.HARDHOVER;
                            element.active = true;
                            //element.visualState = (int)UIState.CLICKED; set visual states to know if they have been activated yet?
                        }
                        else
                        {

                            element.uiState = (int)UIState.HOVERED;
                            element.active = true;
                            //element.visualState = (int)UIState.HOVERED; set visual states to know if they have been activated yet?
                        }


                        /// element.onHover();  
                        return element;
                    }
                }
            }
            //clearState(interactable);

            return null;
        }

        public static Boolean checkMouseCollison(Interactable interactable, MouseState mouseState)
        {
            //return interactable.getRectangle().Contains(mouseState.Position);

            return interactable.rectangle.Contains(mouseState.Position);

            /*
            Rectangle myRectangle = interactable.getRectangle();
            if (myRectangle.Contains(mouseState.Position))
            {
                return true;
            }
            return false;
            */
        }

        public static void clearState(Interactable[] interactable)
        {
            //need to get array of all interactables besides background
            foreach (Interactable element in interactable)
            {
                if (element != null && element.uiState != (int)UIState.CLICKED)
                {
                    element.uiState = (int)UIState.NEUTRAL;
                    element.visualState = (int)UIState.NEUTRAL;
                }
            }
        }

        public static void clearClickedState(Interactable[] interactable)
        {
            foreach (Interactable element in interactable)
            {
                if (element != null && element.uiState == (int)UIState.CLICKED)
                {
                    element.clear();
                }
            }
        }
    }
}
