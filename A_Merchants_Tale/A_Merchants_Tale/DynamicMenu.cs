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
            id = 0;
            active = false;
            //addExitButton();
        }

        public DynamicMenu(Rectangle rectangle, Interactable interactable, int myID) : base(rectangle)
        {
            id = myID;
            this.AttachedToo = interactable;
            interactable.AttachedFrom[0] = this;
            //active = true;
            visualState = (int)UIState.CLICKED;
            addExitButton();
        }

        public override void clear()
        {
            visualState = (int)UIState.NEUTRAL;
           // active = false;
            //setRectangle(new Rectangle(0,0,0,0));
            rectangle = new Rectangle(0, 0, 0, 0);
        }

        public void addExitButton()
        {
            this.AttachedFrom[0] = new ExitButton(new Rectangle(this.xPos + this.width - 35, this.yPos + 5, 30, 30), this);
        }

        public void Display()
        {

        }
    }
}
