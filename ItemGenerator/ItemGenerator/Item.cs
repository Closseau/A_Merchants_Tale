using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ItemGenerator
{
    public enum ItemTypes
    {
        WEAPON, ARMOR, VALUABLE
    }

    public enum ValueModifiers
    {
        BROKEN, DULL, WEAK, SHARPENED, POPULAR, PRISTINE
    }

    public enum Rarity
    {
        COMMON, UNCOMMON, RARE, EPIC, LEGENDARY
    }

    class Item
    {
        public Item()
        {

        }

        public int ItemID { get; set; }
        public int ItemType { get; set; }
        public int BaseValue { get; set; }
        public int Rarity { get; set; }
        public int ValueModifier { get; set; }
        public int[] Enchantments { get; set; }


        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);

            /*
            string tempString = "";
            tempString += this.ItemID.ToString() + ", ";
            tempString += this.ItemType.ToString() + ", ";
            tempString += this.BaseValue.ToString() + ", ";
            tempString += this.Rarity.ToString() + ", ";
            tempString += this.ValueModifier.ToString() + ", ";
            tempString += this.Enchantments.ToString();
            return tempString;
            */
        }
    }
}
