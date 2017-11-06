using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

public enum UIState { NEUTRAL = 0, HOVERED = 1, CLICKED = 2 };
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

            if ((mouseState.LeftButton == ButtonState.Pressed && previousMouseState.LeftButton == ButtonState.Released) || ((mouseState.LeftButton == ButtonState.Released && previousMouseState.LeftButton == ButtonState.Pressed)))
            {
                foreach (Interactable element in interactable)
                {
                    if (element != null && element.screen == currentScreen && Logic.checkMouseCollison(element, mouseState))
                    {
                        if (previousMouseState.LeftButton == ButtonState.Released && mouseState.LeftButton == ButtonState.Pressed)
                            element.visualState = (int)UIState.CLICKED;
                        /* moving this out 
                        if (mouseState.LeftButton == ButtonState.Released && previousMouseState.LeftButton == ButtonState.Pressed)
                            element.onClick(mouseState);

                        */
                        return element;
                    }
                }
            }
            else
            {
                foreach (Interactable element in interactable)
                {
                    if (element != null && element.screen == currentScreen && Logic.checkMouseCollison(element, mouseState))
                    {
                        if (element.visualState != (int)UIState.CLICKED)
                        {

                            //element.visualState = (int)UIState.HOVERED;
                            element.onHover(); 
                        } //idea!!! send back interactable then check sent back for state!!! 
                            return element;
                    }
                }
            }
            clearState(interactable);

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
                if (element != null && element.visualState != (int)UIState.CLICKED)
                {
                    element.clear();
                }
            }
        }

        public static void clearClickedState(Interactable[] interactable)
        {
            foreach (Interactable element in interactable)
            {
                if (element != null && element.visualState == (int)UIState.CLICKED)
                {
                    element.clear();
                }
            }
        }
    }
}
