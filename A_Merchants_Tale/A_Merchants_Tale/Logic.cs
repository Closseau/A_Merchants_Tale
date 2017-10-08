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
    class Logic
    {
        public static void checkUI()
        {

        }
        public static Interactable hasMouseClicked(Interactable[] interactable, MouseState mouseState)
        {
          //  Boolean hasFoundHover = false;

            if (mouseState.LeftButton == ButtonState.Pressed)
            {
                foreach (Interactable element in interactable)
                {
                    if (element != null && Logic.checkMouseCollison(element, mouseState))
                    {
                        element.onClick(mouseState);
                        return element;
                    }
                }
            }
            else
            {
                foreach (Interactable element in interactable)
                {
                    if (element != null && Logic.checkMouseCollison(element, mouseState))
                    {
                        if (element.getState() != 2)
                        {
                            clearState(interactable);
                            element.onHover();
                        }
                        return element; //idea!!! send back interactable then check sent back for state!!! 
                    }
                }
            }
            clearState(interactable);

            return null;
        }
        public static Boolean checkMouseCollison(Interactable interactable, MouseState mouseState)
        {
            
            Rectangle myRectangle = interactable.getRectangle();
            if (myRectangle.Contains(mouseState.Position))
            {
                return true;
            }
            return false;

        }
        public static void clearState(Interactable[] interactable)
        {
            //need to get array of all interactables besides background
            foreach (Interactable element in interactable)
            {
                if (element != null && element.getState() != 2)
                    element.clear();
            }
         }
        public static void clearClickedState(Interactable[] interactable)
        {
            foreach (Interactable element in interactable)
            {
                if (element != null && element.getState() == 2)
                {
                    element.clear();

                }
                

            }
        }
    }
}
