using Microsoft.Xna.Framework;
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
        private Rectangle MyRectangle;

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
      
        public Rectangle rectangle
        {
            get
            {
                return MyRectangle;
            }
            set
            {
                MyRectangle = value;
            }
        }
        
        public int xPos
        {
            get
            {
                return MyRectangle.X;
            }
            set
            {
                MyRectangle.X = value;
            }
        }

        public int yPos
        {
            get
            {
                return MyRectangle.Y;
            }
            set
            {
                MyRectangle.Y = value;
            }
        }
        
        public int width
        {
            get
            {
                return MyRectangle.Width;
            }
            set
            {
                MyRectangle.Width = value;
            }
        }
        
        public int height
        {
            get
            {
                return MyRectangle.Height;
            }
            set
            {
                MyRectangle.Height = value;
            }
        }


    }
}
