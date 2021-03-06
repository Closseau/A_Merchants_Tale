﻿using Microsoft.Xna.Framework;
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

        public override void onClick(MouseState mouseState, Vector2 mouse)
        {
            state = (int)UIState.CLICKED;
            AssetManager.setMenu(new Rectangle((int)mouse.X, (int)mouse.Y, 0, 0), this);
        }
    }
}
