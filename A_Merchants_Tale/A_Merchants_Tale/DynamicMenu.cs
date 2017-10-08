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
        Boolean AmDisplayed;
        public DynamicMenu(Rectangle rectangle) : base(rectangle)
        {
            
            AmDisplayed = false;
        }
        public DynamicMenu(Rectangle rectangle, Interactable interactable) : base(rectangle)
        {
            this.setAttachedToo(interactable);
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
