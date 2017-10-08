﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Merchants_Tale
{
    public class Entity
    {

        Rectangle MyRectangle;
        public Entity(Rectangle rectangle)
        {
            MyRectangle = rectangle;

        }
        public void Draw(Texture2D texture, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, MyRectangle, Color.White);

        }
        public Rectangle getRectangle()
        {
            return MyRectangle;

        }
        public void setRectangle(Rectangle rectangle)
        {
            MyRectangle = rectangle;
        }

        public int getXPos()
        {
            return MyRectangle.X;
        }
        public int getYPos()
        {
            return MyRectangle.Y;
        }
        public int getWidth()
        {
            return MyRectangle.Width;
        }
        public int getHeight()
        {
            return MyRectangle.Height;
        }


    }
}
