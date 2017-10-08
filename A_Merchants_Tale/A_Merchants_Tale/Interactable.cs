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
        private int myState = 0;
        Interactable AttachedToo;
        private Boolean Active;

        public Interactable(Rectangle rectangle) : base(rectangle)
        {
            Active = false;
            AttachedToo = null;
        }
        public int getState()
        {
            return myState;
        }
        // make a array of all the 'active' hovers and clicks to undo them later 
        public void setState(int state)
        {
            myState = state;
        }
        public Boolean getActive()
        {
            return Active;
        }
        public void setActive(Boolean active)
        {
            Active = active;
        }
        public virtual void onHover()
        {
            myState = 1;
        }
        public Interactable getAttachedToo()
        {
            return AttachedToo;
        }
        public void setAttachedToo(Interactable interactable)
        {
            AttachedToo = interactable;
        }
        public virtual void onClick(MouseState mouseState)
        {
            myState = 2;
            Active = true;
            // popups and stuff would go here
        }
        public virtual void clear()
        {
            myState = 0;
        }

    }
}
