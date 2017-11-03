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

        public static Interactable hasMouseClicked(Interactable[] interactable, MouseState mouseState, Vector2 mouse)
        {
            //  Boolean hasFoundHover = false;

            if (mouseState.LeftButton == ButtonState.Pressed)
            {
                foreach (Interactable element in interactable)
                {
                    if (element != null && Logic.checkMouseCollison(element, mouse))
                    {
                        element.onClick(mouseState, mouse);
                        return element;
                    }
                }
            }
            else
            {
                foreach (Interactable element in interactable)
                {
                    if (element != null && Logic.checkMouseCollison(element, mouse))
                    {
                        if (element.state != (int)UIState.CLICKED)
                        {
                            element.onHover();
                        }
                        return element; //idea!!! send back interactable then check sent back for state!!! 
                    }
                }
            }
            clearState(interactable);

            return null;
        }

        public static Boolean checkMouseCollison(Interactable interactable, Vector2 mouse)
        {
            //return interactable.getRectangle().Contains(mouseState.Position);

            return interactable.rectangle.Contains(mouse);

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
                if (element != null && element.state != (int)UIState.CLICKED)
                {
                    element.clear();
                }
            }
        }

        public static void clearClickedState(Interactable[] interactable)
        {
            foreach (Interactable element in interactable)
            {
                if (element != null && element.state == (int)UIState.CLICKED)
                {
                    element.clear();
                }
            }
        }

        public static Boolean checkZoomIn(MouseState mouseState, int previousScrollValue)
        {
            if (mouseState.ScrollWheelValue > previousScrollValue)
                return true;
            else
                return false;
        }

        public static Boolean checkZoomOut(MouseState mouseState, int previousScrollValue)
        {
            if (mouseState.ScrollWheelValue < previousScrollValue)
                return true;
            else
                return false;
        }
    }
}
