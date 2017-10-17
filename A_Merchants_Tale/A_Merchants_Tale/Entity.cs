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

<<<<<<< HEAD
        Rectangle MyRectangle;
=======
        private Rectangle MyRectangle;

>>>>>>> origin/Bobby's_Branch
        public Entity(Rectangle rectangle)
        {
            MyRectangle = rectangle;
        }
        public void Draw(Texture2D texture, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, MyRectangle, Color.White);
        }
<<<<<<< HEAD
        public Rectangle getRectangle()
        {
            return MyRectangle;

        }
        public void setRectangle(Rectangle rectangle)
        {
            MyRectangle = rectangle;
        }

        public int getXPos()
=======
               
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
>>>>>>> origin/Bobby's_Branch
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
<<<<<<< HEAD
        public int getYPos()
=======

        public int yPos
>>>>>>> origin/Bobby's_Branch
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
<<<<<<< HEAD
        public int getWidth()
=======

        public int width
>>>>>>> origin/Bobby's_Branch
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
<<<<<<< HEAD
        public int getHeight()
=======

        public int height
>>>>>>> origin/Bobby's_Branch
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
