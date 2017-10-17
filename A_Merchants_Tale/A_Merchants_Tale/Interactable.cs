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
        }

        public int state { get; set; }

        public Boolean active { get; set; }
        
        public Interactable AttachedToo { get; set; }
        
        public virtual void onHover()
        {
            state = (int)UIState.HOVERED;
        }
        
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

    }
}
