namespace CST117_InventoryManagementProject
{
    partial class frmInventoryManagementHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventoryManagementHome));
            this.lblWelcomeLabel = new System.Windows.Forms.Label();
            this.lblTodaysDate = new System.Windows.Forms.Label();
            this.lblTodaysDateData = new System.Windows.Forms.Label();
            this.btnHomeButton = new System.Windows.Forms.Button();
            this.btnSearchItems = new System.Windows.Forms.Button();
            this.btnAddItems = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcomeLabel
            // 
            this.lblWelcomeLabel.AutoSize = true;
            this.lblWelcomeLabel.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeLabel.Location = new System.Drawing.Point(28, 24);
            this.lblWelcomeLabel.Name = "lblWelcomeLabel";
            this.lblWelcomeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWelcomeLabel.Size = new System.Drawing.Size(301, 49);
            this.lblWelcomeLabel.TabIndex = 0;
            this.lblWelcomeLabel.Text = "Welcome Home!";
            this.lblWelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTodaysDate
            // 
            this.lblTodaysDate.AutoSize = true;
            this.lblTodaysDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodaysDate.Location = new System.Drawing.Point(37, 77);
            this.lblTodaysDate.Name = "lblTodaysDate";
            this.lblTodaysDate.Size = new System.Drawing.Size(97, 19);
            this.lblTodaysDate.TabIndex = 1;
            this.lblTodaysDate.Text = "Today\'s Date:";
            this.lblTodaysDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTodaysDateData
            // 
            this.lblTodaysDateData.AutoSize = true;
            this.lblTodaysDateData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodaysDateData.Location = new System.Drawing.Point(140, 77);
            this.lblTodaysDateData.Name = "lblTodaysDateData";
            this.lblTodaysDateData.Size = new System.Drawing.Size(146, 19);
            this.lblTodaysDateData.TabIndex = 2;
            this.lblTodaysDateData.Text = "00/00/0000 12:00PM";
            this.lblTodaysDateData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnHomeButton
            // 
            this.btnHomeButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeButton.Location = new System.Drawing.Point(41, 134);
            this.btnHomeButton.Name = "btnHomeButton";
            this.btnHomeButton.Size = new System.Drawing.Size(227, 89);
            this.btnHomeButton.TabIndex = 3;
            this.btnHomeButton.Text = "Home";
            this.btnHomeButton.UseVisualStyleBackColor = true;
            // 
            // btnSearchItems
            // 
            this.btnSearchItems.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchItems.Location = new System.Drawing.Point(335, 266);
            this.btnSearchItems.Name = "btnSearchItems";
            this.btnSearchItems.Size = new System.Drawing.Size(227, 89);
            this.btnSearchItems.TabIndex = 3;
            this.btnSearchItems.Text = "Search";
            this.btnSearchItems.UseVisualStyleBackColor = true;
            // 
            // btnAddItems
            // 
            this.btnAddItems.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItems.Location = new System.Drawing.Point(335, 134);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(227, 89);
            this.btnAddItems.TabIndex = 3;
            this.btnAddItems.Text = "Add Items";
            this.btnAddItems.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(41, 266);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(227, 89);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmInventoryManagementHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 438);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddItems);
            this.Controls.Add(this.btnSearchItems);
            this.Controls.Add(this.btnHomeButton);
            this.Controls.Add(this.lblTodaysDateData);
            this.Controls.Add(this.lblTodaysDate);
            this.Controls.Add(this.lblWelcomeLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInventoryManagementHome";
            this.Text = "Inventory Management - Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeLabel;
        private System.Windows.Forms.Label lblTodaysDate;
        private System.Windows.Forms.Label lblTodaysDateData;
        private System.Windows.Forms.Button btnHomeButton;
        private System.Windows.Forms.Button btnSearchItems;
        private System.Windows.Forms.Button btnAddItems;
        private System.Windows.Forms.Button btnExit;
    }
}

