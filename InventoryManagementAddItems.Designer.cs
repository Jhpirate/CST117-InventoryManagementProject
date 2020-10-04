namespace CST117_InventoryManagementProject
{
    partial class frmInventoryManagementAddItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventoryManagementAddItems));
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtItemNameEntry = new System.Windows.Forms.TextBox();
            this.txtPriceEntry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSearchItems = new System.Windows.Forms.Button();
            this.btnHomeButton = new System.Windows.Forms.Button();
            this.btnSaveAndNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblVendor = new System.Windows.Forms.Label();
            this.lblItemType = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtQuantityEntry = new System.Windows.Forms.Label();
            this.txtUnitofMeasureEntry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAddItems = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(27, 159);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(88, 19);
            this.lblItemName.TabIndex = 0;
            this.lblItemName.Text = "Item Name:";
            this.lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtItemNameEntry
            // 
            this.txtItemNameEntry.Location = new System.Drawing.Point(122, 158);
            this.txtItemNameEntry.Name = "txtItemNameEntry";
            this.txtItemNameEntry.Size = new System.Drawing.Size(150, 20);
            this.txtItemNameEntry.TabIndex = 1;
            // 
            // txtPriceEntry
            // 
            this.txtPriceEntry.Location = new System.Drawing.Point(122, 201);
            this.txtPriceEntry.Name = "txtPriceEntry";
            this.txtPriceEntry.Size = new System.Drawing.Size(150, 20);
            this.txtPriceEntry.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Price:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(300, 87);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 43);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnSearchItems
            // 
            this.btnSearchItems.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchItems.Location = new System.Drawing.Point(161, 87);
            this.btnSearchItems.Name = "btnSearchItems";
            this.btnSearchItems.Size = new System.Drawing.Size(133, 43);
            this.btnSearchItems.TabIndex = 5;
            this.btnSearchItems.Text = "Search";
            this.btnSearchItems.UseVisualStyleBackColor = true;
            // 
            // btnHomeButton
            // 
            this.btnHomeButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeButton.Location = new System.Drawing.Point(24, 87);
            this.btnHomeButton.Name = "btnHomeButton";
            this.btnHomeButton.Size = new System.Drawing.Size(131, 43);
            this.btnHomeButton.TabIndex = 6;
            this.btnHomeButton.Text = "Home";
            this.btnHomeButton.UseVisualStyleBackColor = true;
            // 
            // btnSaveAndNew
            // 
            this.btnSaveAndNew.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAndNew.Location = new System.Drawing.Point(435, 87);
            this.btnSaveAndNew.Name = "btnSaveAndNew";
            this.btnSaveAndNew.Size = new System.Drawing.Size(129, 43);
            this.btnSaveAndNew.TabIndex = 7;
            this.btnSaveAndNew.Text = "Save / New";
            this.btnSaveAndNew.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(570, 87);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(129, 43);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel Entry";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Inventory Item",
            "Service",
            "Other"});
            this.listBox1.Location = new System.Drawing.Point(382, 217);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 43);
            this.listBox1.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(382, 280);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 11;
            // 
            // lblVendor
            // 
            this.lblVendor.AutoSize = true;
            this.lblVendor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendor.Location = new System.Drawing.Point(313, 281);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(62, 19);
            this.lblVendor.TabIndex = 10;
            this.lblVendor.Text = "Vendor:";
            this.lblVendor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblItemType
            // 
            this.lblItemType.AutoSize = true;
            this.lblItemType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemType.Location = new System.Drawing.Point(330, 217);
            this.lblItemType.Name = "lblItemType";
            this.lblItemType.Size = new System.Drawing.Size(46, 19);
            this.lblItemType.TabIndex = 12;
            this.lblItemType.Text = "Type:";
            this.lblItemType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(122, 280);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 20);
            this.textBox3.TabIndex = 16;
            // 
            // txtQuantityEntry
            // 
            this.txtQuantityEntry.AutoSize = true;
            this.txtQuantityEntry.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantityEntry.Location = new System.Drawing.Point(39, 281);
            this.txtQuantityEntry.Name = "txtQuantityEntry";
            this.txtQuantityEntry.Size = new System.Drawing.Size(73, 19);
            this.txtQuantityEntry.TabIndex = 15;
            this.txtQuantityEntry.Text = "Quantity:";
            this.txtQuantityEntry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUnitofMeasureEntry
            // 
            this.txtUnitofMeasureEntry.Location = new System.Drawing.Point(122, 240);
            this.txtUnitofMeasureEntry.Name = "txtUnitofMeasureEntry";
            this.txtUnitofMeasureEntry.Size = new System.Drawing.Size(150, 20);
            this.txtUnitofMeasureEntry.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "U/M:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(382, 160);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 39);
            this.textBox2.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(296, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Item Desc:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAddItems
            // 
            this.lblAddItems.AutoSize = true;
            this.lblAddItems.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddItems.Location = new System.Drawing.Point(22, 23);
            this.lblAddItems.Name = "lblAddItems";
            this.lblAddItems.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAddItems.Size = new System.Drawing.Size(224, 49);
            this.lblAddItems.TabIndex = 21;
            this.lblAddItems.Text = "Add Items...";
            this.lblAddItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmInventoryManagementAddItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAddItems);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUnitofMeasureEntry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtQuantityEntry);
            this.Controls.Add(this.lblItemType);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblVendor);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveAndNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSearchItems);
            this.Controls.Add(this.btnHomeButton);
            this.Controls.Add(this.txtPriceEntry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtItemNameEntry);
            this.Controls.Add(this.lblItemName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInventoryManagementAddItems";
            this.Text = "Inventory Management - Add Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox txtItemNameEntry;
        private System.Windows.Forms.TextBox txtPriceEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSearchItems;
        private System.Windows.Forms.Button btnHomeButton;
        private System.Windows.Forms.Button btnSaveAndNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblVendor;
        private System.Windows.Forms.Label lblItemType;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label txtQuantityEntry;
        private System.Windows.Forms.TextBox txtUnitofMeasureEntry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAddItems;
    }
}