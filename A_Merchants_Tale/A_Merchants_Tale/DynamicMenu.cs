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
        Interactable AttachedToo; // needs reference???
        Boolean AmDisplayed;
        public DynamicMenu(Rectangle rectangle) : base(rectangle)
        {
            AttachedToo = null;
            AmDisplayed = false;
        }
        public DynamicMenu(Rectangle rectangle, Interactable interactable) : base(rectangle)
        {
            AttachedToo = (Interactable)interactable;
            AmDisplayed = true;

        }
        public void Display()
        {


        }
        public Boolean getAmDisplayed()
        {
            return AmDisplayed;
        }
        public void setAmDisplayed(Boolean displayed)
        {
            AmDisplayed = displayed;
        }
    }
}
