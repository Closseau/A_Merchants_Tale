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
        public static Boolean checkMouseCollison(Interactable interactable)
        {

            MouseState myMouse = Mouse.GetState();
            int myWidth = interactable.getWidth();
            int myHeight = interactable.getHeight();
            int myXPosition = interactable.getXPos();
            int myYPosition = interactable.getYPos();
            if (myMouse.X > myXPosition && myMouse.X < myXPosition + myWidth)
            {
                if (myMouse.Y > myYPosition && myMouse.Y < myYPosition + myHeight)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
