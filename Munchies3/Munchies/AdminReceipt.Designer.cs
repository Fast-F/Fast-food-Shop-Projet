namespace Munchies
{
    partial class AdminReceipt
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
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuItemsAdmin = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NewItem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newItemPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btndelete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btndelete.Location = new System.Drawing.Point(438, 458);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(153, 49);
            this.btndelete.TabIndex = 30;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnupdate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnupdate.Location = new System.Drawing.Point(157, 458);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(153, 49);
            this.btnupdate.TabIndex = 29;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonLogin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonLogin.Location = new System.Drawing.Point(293, 362);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(157, 49);
            this.buttonLogin.TabIndex = 28;
            this.buttonLogin.Text = "Add Item";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 67);
            this.label1.TabIndex = 27;
            this.label1.Text = "Admin Menu Item ";
            // 
            // MenuItemsAdmin
            // 
            this.MenuItemsAdmin.FormattingEnabled = true;
            this.MenuItemsAdmin.ItemHeight = 16;
            this.MenuItemsAdmin.Items.AddRange(new object[] {
            "*************************MENU ITEMS*************************",
            "Chicken and Chips ------------44",
            "Karpow Burger ----------------50",
            "Italian Pizza -------------------62",
            "Pasta --------------------------35",
            "Soft Drinks --------------------10"});
            this.MenuItemsAdmin.Location = new System.Drawing.Point(684, 105);
            this.MenuItemsAdmin.Name = "MenuItemsAdmin";
            this.MenuItemsAdmin.Size = new System.Drawing.Size(341, 388);
            this.MenuItemsAdmin.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "NEW ITEM NAME";
            // 
            // NewItem
            // 
            this.NewItem.Location = new System.Drawing.Point(314, 171);
            this.NewItem.Name = "NewItem";
            this.NewItem.Size = new System.Drawing.Size(214, 22);
            this.NewItem.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "NEW ITEM PRICE";
            // 
            // newItemPrice
            // 
            this.newItemPrice.Location = new System.Drawing.Point(314, 264);
            this.newItemPrice.Name = "newItemPrice";
            this.newItemPrice.Size = new System.Drawing.Size(214, 22);
            this.newItemPrice.TabIndex = 35;
            // 
            // AdminReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1097, 554);
            this.Controls.Add(this.newItemPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NewItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MenuItemsAdmin);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminReceipt";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.AdminReceipt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox MenuItemsAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NewItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newItemPrice;
    }
}