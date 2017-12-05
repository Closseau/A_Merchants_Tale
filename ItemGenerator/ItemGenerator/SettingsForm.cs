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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();            
        }

        private void SaveForm_Load(object sender, EventArgs e)
        {
            itemFileDialog.FileName = frmMain.itemFilePath;
            settingsFileDialog.FileName = frmMain.settingsFilePath;
            txtItemPath.Text = itemFileDialog.FileName;
            txtSettingsPath.Text = settingsFileDialog.FileName;
        }

        private void btnItemBrowse_Click(object sender, EventArgs e)
        {
            itemFileDialog.ShowDialog();
            txtItemPath.Text = itemFileDialog.FileName;
        }

        private void btnSettingsBrowse_Click(object sender, EventArgs e)
        {
            settingsFileDialog.ShowDialog();
            txtSettingsPath.Text = settingsFileDialog.FileName;
        }                

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

            frmMain.settingsFilePath = settingsFileDialog.FileName;
            frmMain.itemFilePath = itemFileDialog.FileName;
            this.Hide();
        }
    }
}
