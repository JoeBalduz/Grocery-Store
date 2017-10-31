namespace GroceryStore
{
    partial class Form1
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
            this.listBoxStoreInventory = new System.Windows.Forms.ListBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStoreInventory = new System.Windows.Forms.Label();
            this.lblYourCart = new System.Windows.Forms.Label();
            this.listBoxYourCart = new System.Windows.Forms.ListBox();
            this.btnRemoveFromCart = new System.Windows.Forms.Button();
            this.lblTotalPriceText = new System.Windows.Forms.Label();
            this.lblTaxIncludedText = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTaxIncluded = new System.Windows.Forms.Label();
            this.lblBalanceText = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxStoreInventory
            // 
            this.listBoxStoreInventory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxStoreInventory.FormattingEnabled = true;
            this.listBoxStoreInventory.ItemHeight = 19;
            this.listBoxStoreInventory.Location = new System.Drawing.Point(12, 39);
            this.listBoxStoreInventory.Name = "listBoxStoreInventory";
            this.listBoxStoreInventory.Size = new System.Drawing.Size(306, 289);
            this.listBoxStoreInventory.TabIndex = 0;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.Location = new System.Drawing.Point(110, 334);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(111, 51);
            this.btnAddToCart.TabIndex = 1;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // lblStoreInventory
            // 
            this.lblStoreInventory.AutoSize = true;
            this.lblStoreInventory.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreInventory.Location = new System.Drawing.Point(92, 10);
            this.lblStoreInventory.Name = "lblStoreInventory";
            this.lblStoreInventory.Size = new System.Drawing.Size(147, 26);
            this.lblStoreInventory.TabIndex = 3;
            this.lblStoreInventory.Text = "Store Inventory";
            // 
            // lblYourCart
            // 
            this.lblYourCart.AutoSize = true;
            this.lblYourCart.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourCart.Location = new System.Drawing.Point(534, 10);
            this.lblYourCart.Name = "lblYourCart";
            this.lblYourCart.Size = new System.Drawing.Size(90, 26);
            this.lblYourCart.TabIndex = 5;
            this.lblYourCart.Text = "Your Cart";
            // 
            // listBoxYourCart
            // 
            this.listBoxYourCart.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxYourCart.FormattingEnabled = true;
            this.listBoxYourCart.ItemHeight = 19;
            this.listBoxYourCart.Location = new System.Drawing.Point(426, 39);
            this.listBoxYourCart.Name = "listBoxYourCart";
            this.listBoxYourCart.Size = new System.Drawing.Size(306, 289);
            this.listBoxYourCart.TabIndex = 4;
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFromCart.Location = new System.Drawing.Point(524, 334);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Size = new System.Drawing.Size(111, 51);
            this.btnRemoveFromCart.TabIndex = 6;
            this.btnRemoveFromCart.Text = "Remove From Cart";
            this.btnRemoveFromCart.UseVisualStyleBackColor = true;
            this.btnRemoveFromCart.Click += new System.EventHandler(this.btnRemoveFromCart_Click);
            // 
            // lblTotalPriceText
            // 
            this.lblTotalPriceText.AutoSize = true;
            this.lblTotalPriceText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPriceText.Location = new System.Drawing.Point(303, 420);
            this.lblTotalPriceText.Name = "lblTotalPriceText";
            this.lblTotalPriceText.Size = new System.Drawing.Size(81, 19);
            this.lblTotalPriceText.TabIndex = 7;
            this.lblTotalPriceText.Text = "Total Price:";
            // 
            // lblTaxIncludedText
            // 
            this.lblTaxIncludedText.AutoSize = true;
            this.lblTaxIncludedText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxIncludedText.Location = new System.Drawing.Point(208, 439);
            this.lblTaxIncludedText.Name = "lblTaxIncludedText";
            this.lblTaxIncludedText.Size = new System.Drawing.Size(176, 19);
            this.lblTaxIncludedText.TabIndex = 8;
            this.lblTaxIncludedText.Text = "Total Price (Tax Included):";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(379, 420);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(0, 19);
            this.lblTotalPrice.TabIndex = 10;
            // 
            // lblTaxIncluded
            // 
            this.lblTaxIncluded.AutoSize = true;
            this.lblTaxIncluded.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxIncluded.Location = new System.Drawing.Point(379, 439);
            this.lblTaxIncluded.Name = "lblTaxIncluded";
            this.lblTaxIncluded.Size = new System.Drawing.Size(0, 19);
            this.lblTaxIncluded.TabIndex = 11;
            // 
            // lblBalanceText
            // 
            this.lblBalanceText.AutoSize = true;
            this.lblBalanceText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceText.Location = new System.Drawing.Point(319, 401);
            this.lblBalanceText.Name = "lblBalanceText";
            this.lblBalanceText.Size = new System.Drawing.Size(65, 19);
            this.lblBalanceText.TabIndex = 12;
            this.lblBalanceText.Text = "Balance:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(379, 401);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(0, 19);
            this.lblBalance.TabIndex = 13;
            // 
            // btnPurchase
            // 
            this.btnPurchase.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchase.Location = new System.Drawing.Point(323, 474);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(111, 51);
            this.btnPurchase.TabIndex = 14;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 537);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblBalanceText);
            this.Controls.Add(this.lblTaxIncluded);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblTaxIncludedText);
            this.Controls.Add(this.lblTotalPriceText);
            this.Controls.Add(this.btnRemoveFromCart);
            this.Controls.Add(this.lblYourCart);
            this.Controls.Add(this.listBoxYourCart);
            this.Controls.Add(this.lblStoreInventory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.listBoxStoreInventory);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grocery Store";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxStoreInventory;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStoreInventory;
        private System.Windows.Forms.Label lblYourCart;
        private System.Windows.Forms.ListBox listBoxYourCart;
        private System.Windows.Forms.Button btnRemoveFromCart;
        private System.Windows.Forms.Label lblTotalPriceText;
        private System.Windows.Forms.Label lblTaxIncludedText;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTaxIncluded;
        private System.Windows.Forms.Label lblBalanceText;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnPurchase;
    }
}

