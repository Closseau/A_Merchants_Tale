using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Merchants_Tale
{
    class Interactable : MyEntity
    {
        private int myState = 0;
        

        public Interactable(Rectangle rectangle) : base(rectangle)
        {


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

        public void onHover()
        {
            myState = 1;
        }
        public void onClick()
        {
            myState = 2;
            // popups and stuff would go here
        }
    }
}
