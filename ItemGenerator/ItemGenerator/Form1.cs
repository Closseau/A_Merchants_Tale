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
using System.IO;

namespace ItemGenerator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        List<Item> inventory = new List<Item>();

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
            File.WriteAllText(".\\Items.json", JsonConvert.SerializeObject(inventory));
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            inventory = JsonConvert.DeserializeObject<List<Item>>(File.ReadAllText(".\\Items.json"));
            lstItems.Items.Clear();
            foreach (var item in inventory)
            {
                lstItems.Items.Add(JsonConvert.SerializeObject(item));
            }

            nextItemID = inventory[inventory.Count - 1].ItemID + 1;
            txtNextItemID.Text = nextItemID.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Item tempItem = new Item()
            {
                ItemID = nextItemID,
                ItemType = cbxItemType.SelectedIndex,
                Rarity = cbxRarity.SelectedIndex,
                ValueModifier = cbxValueMod.SelectedIndex
            };

            if (txtMinValue.Text.Trim() != "" && txtMaxValue.Text.Trim() != "")
            {
                tempItem.BaseValue = rand.Next(Convert.ToInt32(txtMinValue.Text.Trim()), Convert.ToInt32(txtMaxValue.Text.Trim()));
            }            

            inventory.Add(tempItem);
            lstItems.Items.Add(tempItem.ToString());

            nextItemID++;
            txtNextItemID.Text = nextItemID.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control myControl in Controls)
            {
                if (myControl is TextBox)
                {
                    myControl.Text = "";
                }
                else if (myControl is ComboBox)
                {
                    myControl.ResetText();
                }                
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            inventory.Remove(JsonConvert.DeserializeObject<Item>(lstItems.SelectedItem.ToString()));
            lstItems.Items.RemoveAt(lstItems.SelectedIndex);            
        }

    }    
}
