using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Merchants_Tale
{
    public class MyEntity
    {
       
        Rectangle MyRectangle;
        public MyEntity(Rectangle rectangle)
        {
            MyRectangle = rectangle;
            
        }
        public void Draw(Texture2D texture, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, MyRectangle, Color.White);

        }
    }
}
