using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ItemGenerator
{
    //public enum ItemTypes
    //{
    //    WEAPON, ARMOR, VALUABLE
    //}

    //public enum ValueModifiers
    //{
    //    BROKEN, DULL, WEAK, SHARPENED, POPULAR, PRISTINE
    //}

    //public enum Rarity
    //{
    //    COMMON, UNCOMMON, RARE, EPIC, LEGENDARY
    //}

    class Item
    {
        public Item()
        {

        }

        public int ItemID
        {
            get
            {
                return int.Parse("1" + Quality.ToString("D2") + Enchantment.ToString("D2") +
                    Material.ToString("D2") + ItemType.ToString("D2"));
            }
        }

        public int Quality { get; set; }
        public int Enchantment { get; set; }
        public int Material { get; set; }
        public int ItemType { get; set; }
        

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);            
        }

        public static string generateEnum(string enumName, ListBox.ObjectCollection items)
        {
            string enumString = "public enum " + enumName + "\n{\n\t";

            for (int i = 0; i < items.Count - 1; i++)
            {
                enumString += items[i].ToString().ToUpper() + ", ";
            }

            enumString += items[items.Count - 1].ToString().ToUpper();

            enumString += "\n}\n";
            return enumString;
        }

    }    
}
