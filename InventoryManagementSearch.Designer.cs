namespace CST117_InventoryManagementProject
{
    partial class frmInventoryManagementSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventoryManagementSearch));
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchField = new System.Windows.Forms.TextBox();
            this.lblSearchHeading = new System.Windows.Forms.Label();
            this.btnHomeButton = new System.Windows.Forms.Button();
            this.tblSearchResults = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(429, 153);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 24);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearchField
            // 
            this.txtSearchField.Location = new System.Drawing.Point(24, 153);
            this.txtSearchField.Multiline = true;
            this.txtSearchField.Name = "txtSearchField";
            this.txtSearchField.Size = new System.Drawing.Size(386, 24);
            this.txtSearchField.TabIndex = 1;
            // 
            // lblSearchHeading
            // 
            this.lblSearchHeading.AutoSize = true;
            this.lblSearchHeading.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchHeading.Location = new System.Drawing.Point(22, 18);
            this.lblSearchHeading.Name = "lblSearchHeading";
            this.lblSearchHeading.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSearchHeading.Size = new System.Drawing.Size(165, 49);
            this.lblSearchHeading.TabIndex = 23;
            this.lblSearchHeading.Text = "Search...";
            this.lblSearchHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnHomeButton
            // 
            this.btnHomeButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeButton.Location = new System.Drawing.Point(24, 82);
            this.btnHomeButton.Name = "btnHomeButton";
            this.btnHomeButton.Size = new System.Drawing.Size(131, 43);
            this.btnHomeButton.TabIndex = 22;
            this.btnHomeButton.Text = "Home";
            this.btnHomeButton.UseVisualStyleBackColor = true;
            // 
            // tblSearchResults
            // 
            this.tblSearchResults.ColumnCount = 7;
            this.tblSearchResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.67164F));
            this.tblSearchResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.32836F));
            this.tblSearchResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tblSearchResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tblSearchResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tblSearchResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tblSearchResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tblSearchResults.Location = new System.Drawing.Point(24, 203);
            this.tblSearchResults.Name = "tblSearchResults";
            this.tblSearchResults.RowCount = 4;
            this.tblSearchResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.58974F));
            this.tblSearchResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.41026F));
            this.tblSearchResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblSearchResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tblSearchResults.Size = new System.Drawing.Size(744, 220);
            this.tblSearchResults.TabIndex = 24;
            // 
            // frmInventoryManagementSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tblSearchResults);
            this.Controls.Add(this.lblSearchHeading);
            this.Controls.Add(this.btnHomeButton);
            this.Controls.Add(this.txtSearchField);
            this.Controls.Add(this.btnSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInventoryManagementSearch";
            this.Text = "Inventory Management - Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchField;
        private System.Windows.Forms.Label lblSearchHeading;
        private System.Windows.Forms.Button btnHomeButton;
        private System.Windows.Forms.TableLayoutPanel tblSearchResults;
    }
}