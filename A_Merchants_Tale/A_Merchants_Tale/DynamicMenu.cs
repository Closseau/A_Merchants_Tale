﻿using Microsoft.Xna.Framework;
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

            setActive(false);
        }

        public DynamicMenu(Rectangle rectangle, Interactable interactable) : base(rectangle)
        {
            this.setAttachedToo(interactable);
            setActive(true);
            setState((int)Interactable.UIState.CLICKED);

        }

        public override void clear()
        {
            setState((int)Interactable.UIState.NEUTRAL);
            setActive(false);
            setRectangle(new Rectangle(0,0,0,0));
        }

        public void Display()
        {


        }
    }
}
