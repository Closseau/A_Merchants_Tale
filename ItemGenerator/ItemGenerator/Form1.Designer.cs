namespace ItemGenerator
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpQuality = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lstQuality = new System.Windows.Forms.ListBox();
            this.grpEnchant = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.lstEnchant = new System.Windows.Forms.ListBox();
            this.grpMaterial = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.lstMaterial = new System.Windows.Forms.ListBox();
            this.grpType = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.lstType = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.grpQuality.SuspendLayout();
            this.grpEnchant.SuspendLayout();
            this.grpMaterial.SuspendLayout();
            this.grpType.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.loadSettingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(770, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateItemsToolStripMenuItem,
            this.saveSettingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // generateItemsToolStripMenuItem
            // 
            this.generateItemsToolStripMenuItem.Name = "generateItemsToolStripMenuItem";
            this.generateItemsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.generateItemsToolStripMenuItem.Text = "Generate Items";
            this.generateItemsToolStripMenuItem.Click += new System.EventHandler(this.generateItemsToolStripMenuItem_Click);
            // 
            // saveSettingsToolStripMenuItem
            // 
            this.saveSettingsToolStripMenuItem.Name = "saveSettingsToolStripMenuItem";
            this.saveSettingsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.saveSettingsToolStripMenuItem.Text = "Save Settings";
            this.saveSettingsToolStripMenuItem.Click += new System.EventHandler(this.saveSettingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // loadSettingsToolStripMenuItem
            // 
            this.loadSettingsToolStripMenuItem.Name = "loadSettingsToolStripMenuItem";
            this.loadSettingsToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.loadSettingsToolStripMenuItem.Text = "Load Settings";
            this.loadSettingsToolStripMenuItem.Click += new System.EventHandler(this.loadSettingsToolStripMenuItem_Click);
            // 
            // grpQuality
            // 
            this.grpQuality.Controls.Add(this.textBox1);
            this.grpQuality.Controls.Add(this.button4);
            this.grpQuality.Controls.Add(this.button3);
            this.grpQuality.Controls.Add(this.button2);
            this.grpQuality.Controls.Add(this.button1);
            this.grpQuality.Controls.Add(this.lstQuality);
            this.grpQuality.Location = new System.Drawing.Point(12, 38);
            this.grpQuality.Name = "grpQuality";
            this.grpQuality.Size = new System.Drawing.Size(182, 359);
            this.grpQuality.TabIndex = 0;
            this.grpQuality.TabStop = false;
            this.grpQuality.Text = "Quality";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 288);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Enter += new System.EventHandler(this.TextBox_Focused);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(17, 160);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(19, 29);
            this.button4.TabIndex = 4;
            this.button4.Text = "↓";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(17, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(19, 29);
            this.button3.TabIndex = 3;
            this.button3.Text = "↑";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(98, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // lstQuality
            // 
            this.lstQuality.FormattingEnabled = true;
            this.lstQuality.Location = new System.Drawing.Point(42, 33);
            this.lstQuality.Name = "lstQuality";
            this.lstQuality.Size = new System.Drawing.Size(116, 251);
            this.lstQuality.TabIndex = 5;
            // 
            // grpEnchant
            // 
            this.grpEnchant.Controls.Add(this.textBox2);
            this.grpEnchant.Controls.Add(this.button5);
            this.grpEnchant.Controls.Add(this.button6);
            this.grpEnchant.Controls.Add(this.button7);
            this.grpEnchant.Controls.Add(this.button8);
            this.grpEnchant.Controls.Add(this.lstEnchant);
            this.grpEnchant.Location = new System.Drawing.Point(200, 38);
            this.grpEnchant.Name = "grpEnchant";
            this.grpEnchant.Size = new System.Drawing.Size(182, 359);
            this.grpEnchant.TabIndex = 1;
            this.grpEnchant.TabStop = false;
            this.grpEnchant.Text = "Enchantment";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(42, 288);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 20);
            this.textBox2.TabIndex = 0;
            this.textBox2.Enter += new System.EventHandler(this.TextBox_Focused);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(17, 160);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(19, 29);
            this.button5.TabIndex = 4;
            this.button5.Text = "↓";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(17, 112);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(19, 29);
            this.button6.TabIndex = 3;
            this.button6.Text = "↑";
            this.button6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(98, 311);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 23);
            this.button7.TabIndex = 2;
            this.button7.Text = "Remove";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(42, 311);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(57, 23);
            this.button8.TabIndex = 1;
            this.button8.Text = "Add";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // lstEnchant
            // 
            this.lstEnchant.FormattingEnabled = true;
            this.lstEnchant.Location = new System.Drawing.Point(42, 33);
            this.lstEnchant.Name = "lstEnchant";
            this.lstEnchant.Size = new System.Drawing.Size(116, 251);
            this.lstEnchant.TabIndex = 5;
            // 
            // grpMaterial
            // 
            this.grpMaterial.Controls.Add(this.textBox3);
            this.grpMaterial.Controls.Add(this.button9);
            this.grpMaterial.Controls.Add(this.button10);
            this.grpMaterial.Controls.Add(this.button11);
            this.grpMaterial.Controls.Add(this.button12);
            this.grpMaterial.Controls.Add(this.lstMaterial);
            this.grpMaterial.Location = new System.Drawing.Point(388, 38);
            this.grpMaterial.Name = "grpMaterial";
            this.grpMaterial.Size = new System.Drawing.Size(182, 359);
            this.grpMaterial.TabIndex = 2;
            this.grpMaterial.TabStop = false;
            this.grpMaterial.Text = "Material";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(42, 288);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 20);
            this.textBox3.TabIndex = 0;
            this.textBox3.Enter += new System.EventHandler(this.TextBox_Focused);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(17, 160);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(19, 29);
            this.button9.TabIndex = 4;
            this.button9.Text = "↓";
            this.button9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(17, 112);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(19, 29);
            this.button10.TabIndex = 3;
            this.button10.Text = "↑";
            this.button10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(98, 311);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(60, 23);
            this.button11.TabIndex = 2;
            this.button11.Text = "Remove";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(42, 311);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(57, 23);
            this.button12.TabIndex = 1;
            this.button12.Text = "Add";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // lstMaterial
            // 
            this.lstMaterial.FormattingEnabled = true;
            this.lstMaterial.Location = new System.Drawing.Point(42, 33);
            this.lstMaterial.Name = "lstMaterial";
            this.lstMaterial.Size = new System.Drawing.Size(116, 251);
            this.lstMaterial.TabIndex = 5;
            // 
            // grpType
            // 
            this.grpType.Controls.Add(this.textBox4);
            this.grpType.Controls.Add(this.button13);
            this.grpType.Controls.Add(this.button14);
            this.grpType.Controls.Add(this.button15);
            this.grpType.Controls.Add(this.button16);
            this.grpType.Controls.Add(this.lstType);
            this.grpType.Location = new System.Drawing.Point(576, 38);
            this.grpType.Name = "grpType";
            this.grpType.Size = new System.Drawing.Size(182, 359);
            this.grpType.TabIndex = 3;
            this.grpType.TabStop = false;
            this.grpType.Text = "Item Type";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(42, 288);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(116, 20);
            this.textBox4.TabIndex = 0;
            this.textBox4.Enter += new System.EventHandler(this.TextBox_Focused);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(17, 160);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(19, 29);
            this.button13.TabIndex = 4;
            this.button13.Text = "↓";
            this.button13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(17, 112);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(19, 29);
            this.button14.TabIndex = 3;
            this.button14.Text = "↑";
            this.button14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(98, 311);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(60, 23);
            this.button15.TabIndex = 2;
            this.button15.Text = "Remove";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(42, 311);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(57, 23);
            this.button16.TabIndex = 1;
            this.button16.Text = "Add";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // lstType
            // 
            this.lstType.FormattingEnabled = true;
            this.lstType.Location = new System.Drawing.Point(42, 33);
            this.lstType.Name = "lstType";
            this.lstType.Size = new System.Drawing.Size(116, 251);
            this.lstType.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 410);
            this.Controls.Add(this.grpType);
            this.Controls.Add(this.grpMaterial);
            this.Controls.Add(this.grpEnchant);
            this.Controls.Add(this.grpQuality);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Item Generator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpQuality.ResumeLayout(false);
            this.grpQuality.PerformLayout();
            this.grpEnchant.ResumeLayout(false);
            this.grpEnchant.PerformLayout();
            this.grpMaterial.ResumeLayout(false);
            this.grpMaterial.PerformLayout();
            this.grpType.ResumeLayout(false);
            this.grpType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.GroupBox grpQuality;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.ListBox lstQuality;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.GroupBox grpEnchant;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button button6;
        public System.Windows.Forms.Button button7;
        public System.Windows.Forms.Button button8;
        public System.Windows.Forms.ListBox lstEnchant;
        public System.Windows.Forms.GroupBox grpMaterial;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.Button button9;
        public System.Windows.Forms.Button button10;
        public System.Windows.Forms.Button button11;
        public System.Windows.Forms.Button button12;
        public System.Windows.Forms.ListBox lstMaterial;
        public System.Windows.Forms.GroupBox grpType;
        public System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.Button button13;
        public System.Windows.Forms.Button button14;
        public System.Windows.Forms.Button button15;
        public System.Windows.Forms.Button button16;
        public System.Windows.Forms.ListBox lstType;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadSettingsToolStripMenuItem;
    }
}

