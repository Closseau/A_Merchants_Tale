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

        public Interactable(Rectangle rectangle) : base(rectangle)
        {
            active = false;
            AttachedToo = null;
            lastAttachedIndex = 0;
            AttachedFrom = new Interactable[10];
            screen = 0;
        }

        public int state { get; set; }
        public int id { get; set; }
        public int type { get; set; }
        public int screen { get; set; }
        public Boolean active { get; set; }

        public virtual void onHover()
        {
            state = (int)UIState.HOVERED;
        }

        public Interactable AttachedToo { get; set; }
        // this is an array of interactables that are attached to this interactable.
        public Interactable[] AttachedFrom { get; set; }
        // control varible to know what the next 'open' slot in the array
        public int lastAttachedIndex { get; set; }

        public virtual void onClick(MouseState mouseState)
        {
            state = (int)UIState.CLICKED;
            active = true;
            // popups and stuff would go here
        }

        public virtual void clear()
        {
            state = (int)UIState.NEUTRAL;
        }
        // Here we go 
        // goes 'down' the attached hierarchy until it reaches the base
        public void clearAttachedToo()
        {
            if (this.AttachedToo == null)
            {
                this.clearAttachedFrom();
            }
            else
            {
                this.AttachedToo.clearAttachedToo();
            }
        }
        // clears everthing from the base up the hierarchy
        public void clearAttachedFrom()
        {
            int i;
            for (i = 0; i < AttachedFrom.Length; i++)
            {
                if (AttachedFrom[i] != null)
                {
                    AttachedFrom[i].clearAttachedFrom();
                    AttachedFrom[i] = null;
                }
            }
            clear();
        }
        //moves everything above this object (including itself) to a new position based on the new mouse position
        public void moveEntity(MouseState mouseState)
        {
            int xMovementAdjust = mouseState.X - this.xPos;
            int yMovementAdjust = mouseState.Y - this.yPos;

            int i;
            for (i = 0; i < AttachedFrom.Length; i++)
            {
                if (AttachedFrom[i] != null)
                {
                    AttachedFrom[i].moveEntity(xMovementAdjust, yMovementAdjust);
                }
            }

            this.xPos += xMovementAdjust;
            this.yPos += yMovementAdjust;
        }
        //less cumbersome this way 
        public void moveEntity(int xMovementAdjust, int yMovementAdjust)
        {

            int i;
            for (i = 0; i < AttachedFrom.Length; i++)
            {
                if (AttachedFrom[i] != null)
                {
                    AttachedFrom[i].moveEntity(xMovementAdjust, yMovementAdjust);
                }
            }

            this.xPos += xMovementAdjust;
            this.yPos += yMovementAdjust;
        }
        // checks if the mouse is colliding with any element attached to the element sent.
        public Boolean extendedClickCheck(MouseState mouseState)
        {
            int i;
            for (i = 0; i < AttachedFrom.Length; i++)
            {
                if (AttachedFrom[i] != null)
                {
                    if (AttachedFrom[i].climbingClickCheck(mouseState))
                        return true;
                }
            }
            return false;
        }
        //so it doesn't check the origin
        public Boolean climbingClickCheck(MouseState mouseState)
        {
            int i;
            for (i = 0; i < AttachedFrom.Length; i++)
            {
                if (AttachedFrom[i] != null)
                {
                      return AttachedFrom[i].climbingClickCheck(mouseState);
                }
            }
            return Logic.checkMouseCollison(this, mouseState);
        }

    }
}
