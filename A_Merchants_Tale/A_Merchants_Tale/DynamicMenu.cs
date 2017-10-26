using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Merchants_Tale
{
    class DynamicMenu : Interactable
    {
        //num of options
        public DynamicMenu(Rectangle rectangle) : base(rectangle)
        {
            active = false;
        }

        public DynamicMenu(Rectangle rectangle, Interactable interactable) : base(rectangle)
        {
            this.AttachedToo = interactable;
            //active = true;
            state = (int)UIState.CLICKED;   
            
        }

        public override void clear()
        {
            state = (int)UIState.NEUTRAL;
           // active = false;
            //setRectangle(new Rectangle(0,0,0,0));
            rectangle = new Rectangle(0, 0, 0, 0);
        }

        public void Display()
        {

        }
    }
}
