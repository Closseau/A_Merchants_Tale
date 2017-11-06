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
        SettingsForm settingsForm = new SettingsForm();

        public frmMain()
        {
            InitializeComponent();
            
            settingsFilePath = Path.GetFullPath("./") + "Settings.json";
            itemFilePath = Path.GetFullPath("./") + "Items.json";
        }

        public static string settingsFilePath { get; set; }
        public static string itemFilePath { get; set; }

        
        private void UpButton_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is GroupBox && item.Contains((Control)sender))
                {
                    foreach (Control lstBox in item.Controls)
                    {
                        if (lstBox is ListBox && ((ListBox)lstBox).SelectedIndex != -1)
                        {
                            String currItem = ((ListBox)lstBox).SelectedItem.ToString();
                            int currIndex = ((ListBox)lstBox).SelectedIndex;

                            if (currIndex != 0)
                            {
                                ((ListBox)lstBox).Items.RemoveAt(currIndex);
                                ((ListBox)lstBox).Items.Insert(currIndex -= 1, currItem);
                                ((ListBox)lstBox).SelectedIndex = currIndex;
                            }

                        }
                    }
                    break;
                }
            }
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is GroupBox && item.Contains((Control)sender))
                {
                    foreach (Control lstBox in item.Controls)
                    {
                        if (lstBox is ListBox && ((ListBox)lstBox).SelectedIndex != -1)
                        {
                            String currItem = ((ListBox)lstBox).SelectedItem.ToString();
                            int currIndex = ((ListBox)lstBox).SelectedIndex;

                            if (currIndex != ((ListBox)lstBox).Items.Count - 1)
                            {
                                ((ListBox)lstBox).Items.RemoveAt(currIndex);
                                ((ListBox)lstBox).Items.Insert(currIndex += 1, currItem);
                                ((ListBox)lstBox).SelectedIndex = currIndex;
                            }
                        }
                    }
                    break;
                }
            }
        }
       
        private void AddButton_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is GroupBox && item.Contains((Control)sender))
                {
                    String itemToAdd = "";

                    foreach (Control myControl in item.Controls)
                    {                   
                        if (myControl is TextBox)
                        {
                            itemToAdd = (myControl.Text.Trim() != "")? myControl.Text : "";
                            myControl.Text = "";
                            myControl.Focus();
                        }

                        if (myControl is ListBox && itemToAdd != "")
                        {
                            ((ListBox)myControl).Items.Add(itemToAdd);
                            ((ListBox)myControl).SelectedItem = itemToAdd;
                            break;
                        }
                    }                    
                    break;
                }
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is GroupBox && item.Contains((Control)sender))
                {
                    foreach (Control lstBox in item.Controls)
                    {
                        if (lstBox is ListBox && ((ListBox)lstBox).SelectedIndex != -1)
                        {
                            int currIndex = ((ListBox)lstBox).SelectedIndex;                            

                            if (currIndex == ((ListBox)lstBox).Items.Count - 1)
                            {
                                ((ListBox)lstBox).SelectedIndex = currIndex - 1;
                                ((ListBox)lstBox).Items.RemoveAt(currIndex);
                            }
                            else
                            {
                                ((ListBox)lstBox).Items.RemoveAt(currIndex);
                                ((ListBox)lstBox).SelectedIndex = currIndex;
                            }
                        }

                        if (lstBox is TextBox)
                        {
                            lstBox.Text = "";
                            lstBox.Focus();
                        }
                    }
                    break;
                }
            }
        }

        private void TextBox_Focused(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is GroupBox && ((GroupBox)item).Contains((Control)sender))
                {
                    foreach (Control button in ((GroupBox)item).Controls)
                    {
                        if (button is Button && button.Text == "Add")
                        {
                            this.AcceptButton = (Button)button;
                        }
                        else if (button is Button && button.Text == "Remove")
                        {
                            this.CancelButton = (Button)button;
                        }
                    }
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingsForm.ShowDialog();
        }

        private void saveSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settingsFilePath != "" && File.Exists(settingsFilePath))
            {
                try
                {
                    using (StreamWriter file = File.CreateText(settingsFilePath))
                    {
                        file.WriteLine(JsonConvert.SerializeObject(lstQuality.Items));
                        file.WriteLine(JsonConvert.SerializeObject(lstEnchant.Items));
                        file.WriteLine(JsonConvert.SerializeObject(lstMaterial.Items));
                        file.WriteLine(JsonConvert.SerializeObject(lstType.Items));

                        string enums = Item.generateEnum("Quality", lstQuality.Items);
                        enums += Item.generateEnum("Enchantment", lstEnchant.Items);
                        enums += Item.generateEnum("Material", lstMaterial.Items);
                        enums += Item.generateEnum("Type", lstType.Items);

                        file.Write(enums);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                

                MessageBox.Show("Saved file succesfully to " + settingsFilePath, "Complete", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Cannot find settings file. \nPlease set a valid path in the settings menu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void generateItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (itemFilePath != "" && File.Exists(itemFilePath))
            {
                List<Item> itemList = new List<Item>();

                foreach (var quality in lstQuality.Items)
                {
                    foreach (var enchant in lstEnchant.Items)
                    {
                        foreach (var material in lstMaterial.Items)
                        {
                            foreach (var type in lstType.Items)
                            {
                                itemList.Add(new Item
                                {
                                    Quality = lstQuality.Items.IndexOf(quality),
                                    Enchantment = lstEnchant.Items.IndexOf(enchant),
                                    Material = lstMaterial.Items.IndexOf(material),
                                    ItemType = lstType.Items.IndexOf(type)
                                });
                            }
                        }
                    }
                }

                File.WriteAllText(itemFilePath, JsonConvert.SerializeObject(itemList, Formatting.Indented));

                MessageBox.Show("Saved file succesfully to " + itemFilePath, "Complete", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Cannot find item file. \nPlease set a valid path in the settings menu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(settingsFilePath != "" && File.Exists(settingsFilePath))
            {
                try
                {
                    using (StreamReader file = File.OpenText(settingsFilePath))
                    {
                        lstQuality.Items.AddRange(JsonConvert.DeserializeObject<object[]>(file.ReadLine()));
                        lstEnchant.Items.AddRange(JsonConvert.DeserializeObject<object[]>(file.ReadLine()));
                        lstMaterial.Items.AddRange(JsonConvert.DeserializeObject<object[]>(file.ReadLine()));
                        lstType.Items.AddRange(JsonConvert.DeserializeObject<object[]>(file.ReadLine()));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Cannot find settings file. \nPlease set a valid path in the settings menu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }    
}
