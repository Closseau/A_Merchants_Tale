using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ItemGenerator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        HashSet<Item> Inventory = new HashSet<Item>();
        int nextItemID = 0;
        Random rand = new Random();

        private void frmMain_Load(object sender, EventArgs e)
        {
            cbxItemType.Items.Add("WEAPON");
            cbxItemType.Items.Add("ARMOR");
            cbxItemType.Items.Add("VALUABLE");
            cbxRarity.Items.Add("BROKEN");
            cbxRarity.Items.Add("DULL");
            cbxRarity.Items.Add("WEAK");
            cbxRarity.Items.Add("SHARPENED");
            cbxRarity.Items.Add("POPULAR");
            cbxRarity.Items.Add("PRISTINE");
            cbxValueMod.Items.Add("COMMON");
            cbxValueMod.Items.Add("UNCOMMON");
            cbxValueMod.Items.Add("RARE");
            cbxValueMod.Items.Add("EPIC");
            cbxValueMod.Items.Add("LEGENDARY");

            txtNextItemID.Text = nextItemID.ToString();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Item tempItem = new Item();

            validate(txtNextItemID, tempItem.ItemID);

            if (txtMinValue.Text.Trim() != "" && txtMaxValue.Text.Trim() != "")
            {
                tempItem.BaseValue = rand.Next(Convert.ToInt32(txtMinValue.Text.Trim()), Convert.ToInt32(txtMaxValue.Text.Trim()));
            }

            tempItem.ItemType = cbxItemType.SelectedIndex;
            tempItem.Rarity = cbxRarity.SelectedIndex;
            tempItem.ValueModifier = cbxValueMod.SelectedIndex;

            string[] itemProps = {
                tempItem.ItemID.ToString(),
                tempItem.ItemType.ToString(),
                tempItem.BaseValue.ToString(),
                tempItem.Rarity.ToString(),
                tempItem.ValueModifier.ToString()
            };

            ListViewItem itm = new ListViewItem(itemProps);
            lstItems.Items.Add(itm);

            Inventory.Add(tempItem);
        }

        void validate(TextBox txt, int property)
        {
            if (txt.Text != "")
            {
                property = Convert.ToInt32(txt.Text);
            }
        }

        
    }    
}
