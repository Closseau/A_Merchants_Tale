using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;

namespace A_Merchants_Tale
{
    class ExitButton : MenuOption
    {
        public ExitButton(Rectangle rectangle) : base(rectangle)
        {

        }
        public ExitButton(Rectangle rectangle, Interactable interactable) : base(rectangle)
        {
            this.AttachedToo = interactable;
            //active = true;
            visualState = (int)UIState.NEUTRAL;
            this.screen = 1;

        }
        public override void onClick(MouseState mouseState)
        {
            this.clearAttachedToo();

        }
    }
}
