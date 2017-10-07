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

        public DynamicMenu(Rectangle rectangle) : base(rectangle)
        {
            AttachedToo = null;

        }
        public DynamicMenu(Rectangle rectangle, Interactable interactable) : base(rectangle)
        {
            AttachedToo = (Interactable)interactable;

        }
        public void Display()
        {


        }
    }
}
