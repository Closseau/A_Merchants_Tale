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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxItemType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMinValue = new System.Windows.Forms.TextBox();
            this.txtMaxValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxRarity = new System.Windows.Forms.ComboBox();
            this.cbxValueMod = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddRandom = new System.Windows.Forms.Button();
            this.nud = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNextItemID = new System.Windows.Forms.TextBox();
            this.lstItems = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(309, 308);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(391, 308);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(473, 308);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(555, 308);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Items.json";
            // 
            // cbxItemType
            // 
            this.cbxItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxItemType.FormattingEnabled = true;
            this.cbxItemType.Location = new System.Drawing.Point(109, 63);
            this.cbxItemType.Name = "cbxItemType";
            this.cbxItemType.Size = new System.Drawing.Size(121, 21);
            this.cbxItemType.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Item Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Base Value";
            // 
            // txtMinValue
            // 
            this.txtMinValue.Location = new System.Drawing.Point(109, 101);
            this.txtMinValue.Name = "txtMinValue";
            this.txtMinValue.Size = new System.Drawing.Size(62, 20);
            this.txtMinValue.TabIndex = 9;
            // 
            // txtMaxValue
            // 
            this.txtMaxValue.Location = new System.Drawing.Point(198, 101);
            this.txtMaxValue.Name = "txtMaxValue";
            this.txtMaxValue.Size = new System.Drawing.Size(62, 20);
            this.txtMaxValue.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "to";
            // 
            // cbxRarity
            // 
            this.cbxRarity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRarity.FormattingEnabled = true;
            this.cbxRarity.Location = new System.Drawing.Point(109, 138);
            this.cbxRarity.Name = "cbxRarity";
            this.cbxRarity.Size = new System.Drawing.Size(121, 21);
            this.cbxRarity.TabIndex = 12;
            // 
            // cbxValueMod
            // 
            this.cbxValueMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxValueMod.FormattingEnabled = true;
            this.cbxValueMod.Location = new System.Drawing.Point(109, 176);
            this.cbxValueMod.Name = "cbxValueMod";
            this.cbxValueMod.Size = new System.Drawing.Size(121, 21);
            this.cbxValueMod.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Rarity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Value Modifier";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(43, 219);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(124, 219);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(82, 23);
            this.btnRemove.TabIndex = 17;
            this.btnRemove.Text = "Remove Item";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddRandom
            // 
            this.btnAddRandom.Location = new System.Drawing.Point(34, 281);
            this.btnAddRandom.Name = "btnAddRandom";
            this.btnAddRandom.Size = new System.Drawing.Size(109, 23);
            this.btnAddRandom.TabIndex = 18;
            this.btnAddRandom.Text = "Add Random Item";
            this.btnAddRandom.UseVisualStyleBackColor = true;
            // 
            // nud
            // 
            this.nud.Location = new System.Drawing.Point(156, 282);
            this.nud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud.Name = "nud";
            this.nud.Size = new System.Drawing.Size(49, 20);
            this.nud.TabIndex = 19;
            this.nud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Next Item ID";
            // 
            // txtNextItemID
            // 
            this.txtNextItemID.Location = new System.Drawing.Point(109, 26);
            this.txtNextItemID.Name = "txtNextItemID";
            this.txtNextItemID.ReadOnly = true;
            this.txtNextItemID.Size = new System.Drawing.Size(54, 20);
            this.txtNextItemID.TabIndex = 21;
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.HorizontalScrollbar = true;
            this.lstItems.Location = new System.Drawing.Point(302, 34);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(328, 264);
            this.lstItems.TabIndex = 22;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(663, 360);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.txtNextItemID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nud);
            this.Controls.Add(this.btnAddRandom);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxValueMod);
            this.Controls.Add(this.cbxRarity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaxValue);
            this.Controls.Add(this.txtMinValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxItemType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Name = "frmMain";
            this.Text = "Item Generator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxItemType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMinValue;
        private System.Windows.Forms.TextBox txtMaxValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxRarity;
        private System.Windows.Forms.ComboBox cbxValueMod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddRandom;
        private System.Windows.Forms.NumericUpDown nud;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNextItemID;
        private System.Windows.Forms.ListBox lstItems;
    }
}

