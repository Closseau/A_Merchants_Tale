using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Merchants_Tale
{
    class Interactable : Entity
    {   
        private int myState = (int)UIState.NEUTRAL;

        //Interactable AttachedToo;
        
        public Interactable(Rectangle rectangle) : base(rectangle)
        {
            active = false;
            AttachedToo = null;
        }

        public int state { get; set; }

        public Boolean active { get; set; }

        public virtual void onHover()
        {
            myState = (int)UIState.HOVERED;
        }

        public Interactable AttachedToo { get; set; }

        /*
        public Interactable getAttachedToo()
        {
            return AttachedToo;
        }
       
        public void setAttachedToo(Interactable interactable)
        {
            AttachedToo = interactable;
        }
        */

        public virtual void onClick(MouseState mouseState)
        {
            myState = (int)UIState.CLICKED;
            active = true;
            // popups and stuff would go here
        }

        public virtual void clear()
        {
            myState = (int)UIState.NEUTRAL;
        }

    }
}
