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
            
        }

        public override void clear()
        {
            state = (int)UIState.NEUTRAL;
            active = false;
        }
    }
}
