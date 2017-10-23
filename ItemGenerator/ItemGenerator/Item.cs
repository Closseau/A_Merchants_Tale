using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
