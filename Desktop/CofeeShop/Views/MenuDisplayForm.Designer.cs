namespace CofeeShop.Views
{
    partial class MenuDisplayForm
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
            comboBoxCategory = new ComboBox();
            btnViewDetails = new Button();
            btnClear = new Button();
            btnSearch = new Button();
            listViewMenu = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            SuspendLayout();
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Items.AddRange(new object[] { "Coffee", "Tea", "Pastry" });
            comboBoxCategory.Location = new Point(532, 11);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(146, 23);
            comboBoxCategory.TabIndex = 1;
            // 
            // btnViewDetails
            // 
            btnViewDetails.Location = new Point(346, 208);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(88, 22);
            btnViewDetails.TabIndex = 2;
            btnViewDetails.Text = "View Details";
            btnViewDetails.UseVisualStyleBackColor = true;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(450, 208);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(66, 22);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(612, 39);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(66, 22);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // listViewMenu
            // 
            listViewMenu.AllowColumnReorder = true;
            listViewMenu.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader3, columnHeader2, columnHeader4 });
            listViewMenu.FullRowSelect = true;
            listViewMenu.GridLines = true;
            listViewMenu.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewMenu.Location = new Point(10, 11);
            listViewMenu.MultiSelect = false;
            listViewMenu.Name = "listViewMenu";
            listViewMenu.Size = new Size(505, 176);
            listViewMenu.TabIndex = 0;
            listViewMenu.UseCompatibleStateImageBehavior = false;
            listViewMenu.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 1;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Name";
            columnHeader3.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Category";
            columnHeader2.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Cost";
            columnHeader4.Width = 150;
            // 
            // MenuDisplayForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 422);
            Controls.Add(btnSearch);
            Controls.Add(btnClear);
            Controls.Add(btnViewDetails);
            Controls.Add(comboBoxCategory);
            Controls.Add(listViewMenu);
            Name = "MenuDisplayForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuDisplayForm";
            Load += MenuDisplayForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private ComboBox comboBoxCategory;
        private Button btnViewDetails;
        private Button btnClear;
        private Button btnSearch;
        private ListView listViewMenu;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}