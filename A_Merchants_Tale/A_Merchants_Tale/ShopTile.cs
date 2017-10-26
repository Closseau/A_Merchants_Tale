using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Merchants_Tale
{
    class ShopTile : Interactable
    {
        public ShopTile(Rectangle rectangle) : base(rectangle)
        {

        }

        public override void onClick(MouseState mouseState)
        {
            state = (int)UIState.CLICKED;
            //AssetManager.setMenu(new Rectangle(mouseState.X, mouseState.Y, 150, 300), this);
            if (this.AttachedFrom[0] == null)
            {
                this.AttachedFrom[0] = new DynamicMenu(new Rectangle(mouseState.X + 1, mouseState.Y + 1, 150, 300), this);
                this.AttachedFrom[0].screen = 1;
            }
            //this.lastAttachedIndex++;
        }
    }
}
