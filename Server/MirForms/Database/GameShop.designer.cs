﻿namespace Server
{
    partial class GameShop
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
            this.GameShopListBox = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.GoldPrice_textbox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.GPPrice_textbox = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.ItemDetails_gb = new System.Windows.Forms.GroupBox();
            this.LeftinStock_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TotalSold_label = new System.Windows.Forms.Label();
            this.TopItem_checkbox = new System.Windows.Forms.CheckBox();
            this.DealofDay_checkbox = new System.Windows.Forms.CheckBox();
            this.Individual_checkbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Stock_textbox = new System.Windows.Forms.TextBox();
            this.Catagory_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Class_combo = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CredxGold_textbox = new System.Windows.Forms.TextBox();
            this.Remove_button = new System.Windows.Forms.Button();
            this.ItemDetails_gb.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameShopListBox
            // 
            this.GameShopListBox.FormattingEnabled = true;
            this.GameShopListBox.Location = new System.Drawing.Point(12, 25);
            this.GameShopListBox.Name = "GameShopListBox";
            this.GameShopListBox.ScrollAlwaysVisible = true;
            this.GameShopListBox.Size = new System.Drawing.Size(135, 381);
            this.GameShopListBox.TabIndex = 11;
            this.GameShopListBox.SelectedIndexChanged += new System.EventHandler(this.GameShopListBox_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 90;
            this.label14.Text = "Gold Price:";
            // 
            // GoldPrice_textbox
            // 
            this.GoldPrice_textbox.Location = new System.Drawing.Point(86, 102);
            this.GoldPrice_textbox.MaxLength = 0;
            this.GoldPrice_textbox.Name = "GoldPrice_textbox";
            this.GoldPrice_textbox.Size = new System.Drawing.Size(113, 20);
            this.GoldPrice_textbox.TabIndex = 86;
            this.GoldPrice_textbox.TextChanged += new System.EventHandler(this.GoldPrice_textbox_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(18, 77);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(64, 13);
            this.label21.TabIndex = 91;
            this.label21.Text = "Credit Price:";
            // 
            // GPPrice_textbox
            // 
            this.GPPrice_textbox.Location = new System.Drawing.Point(86, 74);
            this.GPPrice_textbox.MaxLength = 0;
            this.GPPrice_textbox.Name = "GPPrice_textbox";
            this.GPPrice_textbox.Size = new System.Drawing.Size(113, 20);
            this.GPPrice_textbox.TabIndex = 87;
            this.GPPrice_textbox.TextChanged += new System.EventHandler(this.GPPrice_textbox_TextChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(8, 131);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(74, 13);
            this.label29.TabIndex = 93;
            this.label29.Text = "Class Section:";
            // 
            // ItemDetails_gb
            // 
            this.ItemDetails_gb.BackColor = System.Drawing.Color.White;
            this.ItemDetails_gb.Controls.Add(this.LeftinStock_label);
            this.ItemDetails_gb.Controls.Add(this.label3);
            this.ItemDetails_gb.Controls.Add(this.label5);
            this.ItemDetails_gb.Controls.Add(this.TotalSold_label);
            this.ItemDetails_gb.Controls.Add(this.TopItem_checkbox);
            this.ItemDetails_gb.Controls.Add(this.DealofDay_checkbox);
            this.ItemDetails_gb.Controls.Add(this.Individual_checkbox);
            this.ItemDetails_gb.Controls.Add(this.label1);
            this.ItemDetails_gb.Controls.Add(this.Stock_textbox);
            this.ItemDetails_gb.Controls.Add(this.GoldPrice_textbox);
            this.ItemDetails_gb.Controls.Add(this.label14);
            this.ItemDetails_gb.Controls.Add(this.label21);
            this.ItemDetails_gb.Controls.Add(this.Catagory_textbox);
            this.ItemDetails_gb.Controls.Add(this.GPPrice_textbox);
            this.ItemDetails_gb.Controls.Add(this.label4);
            this.ItemDetails_gb.Controls.Add(this.label29);
            this.ItemDetails_gb.Controls.Add(this.Class_combo);
            this.ItemDetails_gb.Location = new System.Drawing.Point(159, 115);
            this.ItemDetails_gb.Name = "ItemDetails_gb";
            this.ItemDetails_gb.Size = new System.Drawing.Size(265, 291);
            this.ItemDetails_gb.TabIndex = 98;
            this.ItemDetails_gb.TabStop = false;
            this.ItemDetails_gb.Text = "Item Details";
            // 
            // LeftinStock_label
            // 
            this.LeftinStock_label.AutoSize = true;
            this.LeftinStock_label.Location = new System.Drawing.Point(83, 47);
            this.LeftinStock_label.Name = "LeftinStock_label";
            this.LeftinStock_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LeftinStock_label.Size = new System.Drawing.Size(25, 13);
            this.LeftinStock_label.TabIndex = 115;
            this.LeftinStock_label.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 114;
            this.label3.Text = "Left in Stock:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 113;
            this.label5.Text = "Total Sold:";
            // 
            // TotalSold_label
            // 
            this.TotalSold_label.AutoSize = true;
            this.TotalSold_label.Location = new System.Drawing.Point(82, 21);
            this.TotalSold_label.Name = "TotalSold_label";
            this.TotalSold_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TotalSold_label.Size = new System.Drawing.Size(25, 13);
            this.TotalSold_label.TabIndex = 112;
            this.TotalSold_label.Text = "100";
            // 
            // TopItem_checkbox
            // 
            this.TopItem_checkbox.AutoSize = true;
            this.TopItem_checkbox.Location = new System.Drawing.Point(29, 228);
            this.TopItem_checkbox.Name = "TopItem_checkbox";
            this.TopItem_checkbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TopItem_checkbox.Size = new System.Drawing.Size(71, 17);
            this.TopItem_checkbox.TabIndex = 106;
            this.TopItem_checkbox.Text = ":Top Item";
            this.TopItem_checkbox.UseVisualStyleBackColor = true;
            this.TopItem_checkbox.CheckedChanged += new System.EventHandler(this.TopItem_checkbox_CheckedChanged);
            // 
            // DealofDay_checkbox
            // 
            this.DealofDay_checkbox.AutoSize = true;
            this.DealofDay_checkbox.Location = new System.Drawing.Point(27, 208);
            this.DealofDay_checkbox.Name = "DealofDay_checkbox";
            this.DealofDay_checkbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DealofDay_checkbox.Size = new System.Drawing.Size(73, 17);
            this.DealofDay_checkbox.TabIndex = 105;
            this.DealofDay_checkbox.Text = ":Sale Item";
            this.DealofDay_checkbox.UseVisualStyleBackColor = true;
            this.DealofDay_checkbox.CheckedChanged += new System.EventHandler(this.DealofDay_checkbox_CheckedChanged);
            // 
            // Individual_checkbox
            // 
            this.Individual_checkbox.AutoSize = true;
            this.Individual_checkbox.Location = new System.Drawing.Point(163, 184);
            this.Individual_checkbox.Name = "Individual_checkbox";
            this.Individual_checkbox.Size = new System.Drawing.Size(79, 17);
            this.Individual_checkbox.TabIndex = 110;
            this.Individual_checkbox.Text = "Player Limit";
            this.Individual_checkbox.UseVisualStyleBackColor = true;
            this.Individual_checkbox.CheckedChanged += new System.EventHandler(this.Individual_checkbox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 111;
            this.label1.Text = "Stock;";
            // 
            // Stock_textbox
            // 
            this.Stock_textbox.Location = new System.Drawing.Point(86, 182);
            this.Stock_textbox.MaxLength = 0;
            this.Stock_textbox.Name = "Stock_textbox";
            this.Stock_textbox.Size = new System.Drawing.Size(72, 20);
            this.Stock_textbox.TabIndex = 109;
            this.Stock_textbox.TextChanged += new System.EventHandler(this.Stock_textbox_TextChanged);
            // 
            // Catagory_textbox
            // 
            this.Catagory_textbox.Location = new System.Drawing.Point(86, 155);
            this.Catagory_textbox.MaxLength = 0;
            this.Catagory_textbox.Name = "Catagory_textbox";
            this.Catagory_textbox.Size = new System.Drawing.Size(173, 20);
            this.Catagory_textbox.TabIndex = 108;
            this.Catagory_textbox.TextChanged += new System.EventHandler(this.Catagory_textbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 106;
            this.label4.Text = "Catagory:";
            // 
            // Class_combo
            // 
            this.Class_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Class_combo.FormattingEnabled = true;
            this.Class_combo.Items.AddRange(new object[] {
            "All",
            "Warrior",
            "Assassin",
            "Taoist",
            "Wizard",
            "Archer"});
            this.Class_combo.Location = new System.Drawing.Point(86, 128);
            this.Class_combo.Name = "Class_combo";
            this.Class_combo.Size = new System.Drawing.Size(173, 21);
            this.Class_combo.TabIndex = 105;
            this.Class_combo.SelectedIndexChanged += new System.EventHandler(this.Class_combo_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.CredxGold_textbox);
            this.groupBox3.Location = new System.Drawing.Point(159, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(265, 84);
            this.groupBox3.TabIndex = 105;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gameshop Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 92;
            this.label2.Text = "Credit x Gold:";
            // 
            // CredxGold_textbox
            // 
            this.CredxGold_textbox.Location = new System.Drawing.Point(86, 22);
            this.CredxGold_textbox.MaxLength = 0;
            this.CredxGold_textbox.Name = "CredxGold_textbox";
            this.CredxGold_textbox.Size = new System.Drawing.Size(65, 20);
            this.CredxGold_textbox.TabIndex = 88;
            this.CredxGold_textbox.TextChanged += new System.EventHandler(this.CredxGold_textbox_TextChanged);
            // 
            // Remove_button
            // 
            this.Remove_button.Location = new System.Drawing.Point(12, 407);
            this.Remove_button.Name = "Remove_button";
            this.Remove_button.Size = new System.Drawing.Size(136, 23);
            this.Remove_button.TabIndex = 106;
            this.Remove_button.Text = "Remove Selected";
            this.Remove_button.UseVisualStyleBackColor = true;
            this.Remove_button.Click += new System.EventHandler(this.Remove_button_Click);
            // 
            // GameShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 440);
            this.Controls.Add(this.Remove_button);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ItemDetails_gb);
            this.Controls.Add(this.GameShopListBox);
            this.Name = "GameShop";
            this.Text = "GameShop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameShop_FormClosed);
            this.Load += new System.EventHandler(this.GameShop_Load);
            this.ItemDetails_gb.ResumeLayout(false);
            this.ItemDetails_gb.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox GameShopListBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox GoldPrice_textbox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox GPPrice_textbox;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.GroupBox ItemDetails_gb;
        private System.Windows.Forms.ComboBox Class_combo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox DealofDay_checkbox;
        private System.Windows.Forms.CheckBox TopItem_checkbox;
        private System.Windows.Forms.Button Remove_button;
        private System.Windows.Forms.TextBox Catagory_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Individual_checkbox;
        private System.Windows.Forms.TextBox Stock_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CredxGold_textbox;
        private System.Windows.Forms.Label TotalSold_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LeftinStock_label;
        private System.Windows.Forms.Label label3;
    }
}