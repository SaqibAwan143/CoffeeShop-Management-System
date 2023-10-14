namespace CofeeShop.Views
{
    partial class OrderForm
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
            btnAddToOrder = new Button();
            btnRemoveFromOrder = new Button();
            btnFinalizeOrder = new Button();
            btnCancelOrder = new Button();
            lblTotalCost = new Label();
            textBoxQuantity = new TextBox();
            listViewOrder = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            listViewMenu = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            label2 = new Label();
            label3 = new Label();
            textBoxCustomerName = new TextBox();
            label1 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnAddToOrder
            // 
            btnAddToOrder.Location = new Point(10, 112);
            btnAddToOrder.Name = "btnAddToOrder";
            btnAddToOrder.Size = new Size(115, 22);
            btnAddToOrder.TabIndex = 0;
            btnAddToOrder.Text = "Add To Order";
            btnAddToOrder.UseVisualStyleBackColor = true;
            btnAddToOrder.Click += btnAddToOrder_Click;
            // 
            // btnRemoveFromOrder
            // 
            btnRemoveFromOrder.Location = new Point(149, 112);
            btnRemoveFromOrder.Name = "btnRemoveFromOrder";
            btnRemoveFromOrder.Size = new Size(145, 22);
            btnRemoveFromOrder.TabIndex = 1;
            btnRemoveFromOrder.Text = "Remove From Order";
            btnRemoveFromOrder.UseVisualStyleBackColor = true;
            btnRemoveFromOrder.Click += btnRemoveFromOrder_Click;
            // 
            // btnFinalizeOrder
            // 
            btnFinalizeOrder.Location = new Point(149, 152);
            btnFinalizeOrder.Name = "btnFinalizeOrder";
            btnFinalizeOrder.Size = new Size(145, 22);
            btnFinalizeOrder.TabIndex = 2;
            btnFinalizeOrder.Text = "Finalize Order";
            btnFinalizeOrder.UseVisualStyleBackColor = true;
            btnFinalizeOrder.Click += btnFinalizeOrder_Click;
            // 
            // btnCancelOrder
            // 
            btnCancelOrder.Location = new Point(10, 152);
            btnCancelOrder.Name = "btnCancelOrder";
            btnCancelOrder.Size = new Size(115, 22);
            btnCancelOrder.TabIndex = 3;
            btnCancelOrder.Text = "Cancel Order";
            btnCancelOrder.UseVisualStyleBackColor = true;
            btnCancelOrder.Click += btnCancelOrder_Click;
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Location = new Point(10, 201);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(91, 15);
            lblTotalCost.TabIndex = 4;
            lblTotalCost.Text = "Total Price : $0.0";
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Location = new Point(110, 71);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(184, 23);
            textBoxQuantity.TabIndex = 5;
            textBoxQuantity.Text = "0";
            // 
            // listViewOrder
            // 
            listViewOrder.AllowColumnReorder = true;
            listViewOrder.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader3, columnHeader2, columnHeader4, columnHeader9 });
            listViewOrder.FullRowSelect = true;
            listViewOrder.GridLines = true;
            listViewOrder.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewOrder.Location = new Point(356, 252);
            listViewOrder.MultiSelect = false;
            listViewOrder.Name = "listViewOrder";
            listViewOrder.Size = new Size(356, 201);
            listViewOrder.TabIndex = 6;
            listViewOrder.UseCompatibleStateImageBehavior = false;
            listViewOrder.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 1;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Name";
            columnHeader3.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Category";
            columnHeader2.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Cost";
            columnHeader4.Width = 50;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Quantity";
            columnHeader9.Width = 80;
            // 
            // listViewMenu
            // 
            listViewMenu.AllowColumnReorder = true;
            listViewMenu.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            listViewMenu.FullRowSelect = true;
            listViewMenu.GridLines = true;
            listViewMenu.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewMenu.Location = new Point(356, 30);
            listViewMenu.MultiSelect = false;
            listViewMenu.Name = "listViewMenu";
            listViewMenu.Size = new Size(356, 166);
            listViewMenu.TabIndex = 7;
            listViewMenu.UseCompatibleStateImageBehavior = false;
            listViewMenu.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "ID";
            columnHeader5.Width = 1;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Name";
            columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Category";
            columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Cost";
            columnHeader8.Width = 100;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(356, 8);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 8;
            label2.Text = "Menu :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(356, 234);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 9;
            label3.Text = "Order : ";
            // 
            // textBoxCustomerName
            // 
            textBoxCustomerName.Location = new Point(110, 30);
            textBoxCustomerName.Name = "textBoxCustomerName";
            textBoxCustomerName.Size = new Size(184, 23);
            textBoxCustomerName.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 33);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 11;
            label1.Text = "Customer Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 74);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 12;
            label4.Text = "Quantity";
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 464);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(textBoxCustomerName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listViewMenu);
            Controls.Add(listViewOrder);
            Controls.Add(textBoxQuantity);
            Controls.Add(lblTotalCost);
            Controls.Add(btnCancelOrder);
            Controls.Add(btnFinalizeOrder);
            Controls.Add(btnRemoveFromOrder);
            Controls.Add(btnAddToOrder);
            Name = "OrderForm";
            Text = "OrderForm";
            Load += OrderForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddToOrder;
        private Button btnRemoveFromOrder;
        private Button btnFinalizeOrder;
        private Button btnCancelOrder;
        private Label lblTotalCost;
        private TextBox textBoxQuantity;
        private ListView listViewOrder;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader4;
        private ListView listViewMenu;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private Label label2;
        private Label label3;
        private TextBox textBoxCustomerName;
        private ColumnHeader columnHeader9;
        private Label label1;
        private Label label4;
    }
}