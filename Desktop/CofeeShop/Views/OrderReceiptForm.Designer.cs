namespace CofeeShop.Views
{
    partial class OrderReceiptForm
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
            lblCustomerName = new Label();
            lblOrderDate = new Label();
            lblOrderTime = new Label();
            lblTotalCost = new Label();
            txtOrderedItems = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(42, 20);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(38, 15);
            lblCustomerName.TabIndex = 0;
            lblCustomerName.Text = "label1";
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Location = new Point(246, 20);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(38, 15);
            lblOrderDate.TabIndex = 1;
            lblOrderDate.Text = "label2";
            // 
            // lblOrderTime
            // 
            lblOrderTime.AutoSize = true;
            lblOrderTime.Location = new Point(424, 20);
            lblOrderTime.Name = "lblOrderTime";
            lblOrderTime.Size = new Size(38, 15);
            lblOrderTime.TabIndex = 2;
            lblOrderTime.Text = "label3";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Location = new Point(424, 274);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(38, 15);
            lblTotalCost.TabIndex = 3;
            lblTotalCost.Text = "label3";
            // 
            // txtOrderedItems
            // 
            txtOrderedItems.AutoSize = true;
            txtOrderedItems.Location = new Point(110, 87);
            txtOrderedItems.Name = "txtOrderedItems";
            txtOrderedItems.Size = new Size(38, 15);
            txtOrderedItems.TabIndex = 4;
            txtOrderedItems.Text = "label3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 58);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 5;
            label1.Text = "Your Items :";
            // 
            // OrderReceiptForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 422);
            Controls.Add(label1);
            Controls.Add(txtOrderedItems);
            Controls.Add(lblTotalCost);
            Controls.Add(lblOrderTime);
            Controls.Add(lblOrderDate);
            Controls.Add(lblCustomerName);
            Name = "OrderReceiptForm";
            Text = "OrderReceiptForm";
            Load += OrderReceiptForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCustomerName;
        private Label lblOrderDate;
        private Label lblOrderTime;
        private Label lblTotalCost;
        private Label txtOrderedItems;
        private Label label1;
    }
}