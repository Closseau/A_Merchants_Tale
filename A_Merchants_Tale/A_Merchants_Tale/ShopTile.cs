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
        public override void onClick(MouseState mouseState)
        {

            setState(2);
            AssetManager.setMenu(new Rectangle(mouseState.X, mouseState.Y, 150, 300), this);

        }
    }
}