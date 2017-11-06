using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Merchants_Tale
{
    class MenuOption : Interactable
    {
        public MenuOption(Rectangle rectangle) : base(rectangle)
        {
            screen = 1;
        }

        public override void clear()
        {
            visualState = (int)UIState.NEUTRAL;
            active = false;
            // active = false;
            //setRectangle(new Rectangle(0,0,0,0));
            rectangle = new Rectangle(0, 0, 0, 0);
        }
    }
}
