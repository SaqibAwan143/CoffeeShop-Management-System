﻿namespace CofeeShop.Views
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelMenu = new Panel();
            btnOrder = new Button();
            btnViewMenu = new Button();
            btnAddItem = new Button();
            panelLogo = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panelTitleBar = new Panel();
            button3 = new Button();
            lblTitle = new Label();
            panelDesktopPanel = new Panel();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelTitleBar.SuspendLayout();
            panelDesktopPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(btnOrder);
            panelMenu.Controls.Add(btnViewMenu);
            panelMenu.Controls.Add(btnAddItem);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 508);
            panelMenu.TabIndex = 4;
            // 
            // btnOrder
            // 
            btnOrder.Dock = DockStyle.Top;
            btnOrder.FlatAppearance.BorderSize = 0;
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnOrder.ForeColor = Color.Gainsboro;
            btnOrder.Image = (Image)resources.GetObject("btnOrder.Image");
            btnOrder.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrder.Location = new Point(0, 200);
            btnOrder.Name = "btnOrder";
            btnOrder.Padding = new Padding(12, 0, 0, 0);
            btnOrder.Size = new Size(220, 60);
            btnOrder.TabIndex = 7;
            btnOrder.Text = "  Make Order";
            btnOrder.TextAlign = ContentAlignment.MiddleLeft;
            btnOrder.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click_1;
            // 
            // btnViewMenu
            // 
            btnViewMenu.Dock = DockStyle.Top;
            btnViewMenu.FlatAppearance.BorderSize = 0;
            btnViewMenu.FlatStyle = FlatStyle.Flat;
            btnViewMenu.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewMenu.ForeColor = Color.Gainsboro;
            btnViewMenu.Image = (Image)resources.GetObject("btnViewMenu.Image");
            btnViewMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnViewMenu.Location = new Point(0, 140);
            btnViewMenu.Name = "btnViewMenu";
            btnViewMenu.Padding = new Padding(12, 0, 0, 0);
            btnViewMenu.Size = new Size(220, 60);
            btnViewMenu.TabIndex = 6;
            btnViewMenu.Text = "  View Menu";
            btnViewMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnViewMenu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnViewMenu.UseVisualStyleBackColor = true;
            btnViewMenu.Click += btnViewMenu_Click_1;
            // 
            // btnAddItem
            // 
            btnAddItem.Dock = DockStyle.Top;
            btnAddItem.FlatAppearance.BorderSize = 0;
            btnAddItem.FlatStyle = FlatStyle.Flat;
            btnAddItem.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddItem.ForeColor = Color.Gainsboro;
            btnAddItem.Image = (Image)resources.GetObject("btnAddItem.Image");
            btnAddItem.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddItem.Location = new Point(0, 80);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Padding = new Padding(12, 0, 0, 0);
            btnAddItem.Size = new Size(220, 60);
            btnAddItem.TabIndex = 5;
            btnAddItem.Text = "  Add Item To Menu";
            btnAddItem.TextAlign = ContentAlignment.MiddleLeft;
            btnAddItem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click_1;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(29, 29, 58);
            panelLogo.Controls.Add(label1);
            panelLogo.Controls.Add(pictureBox2);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 80);
            panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(65, 25);
            label1.Name = "label1";
            label1.Size = new Size(133, 26);
            label1.TabIndex = 2;
            label1.Text = "Coffee Shop";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelTitleBar.Controls.Add(button3);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(787, 80);
            panelTitleBar.TabIndex = 5;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Left;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(0, 0);
            button3.Name = "button3";
            button3.Size = new Size(31, 80);
            button3.TabIndex = 1;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(336, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(133, 26);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Coffee Shop";
            // 
            // panelDesktopPanel
            // 
            panelDesktopPanel.Controls.Add(panel1);
            panelDesktopPanel.Dock = DockStyle.Fill;
            panelDesktopPanel.Location = new Point(220, 80);
            panelDesktopPanel.Name = "panelDesktopPanel";
            panelDesktopPanel.Size = new Size(787, 428);
            panelDesktopPanel.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(212, 106);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 106);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(88, 29);
            label2.Name = "label2";
            label2.Size = new Size(245, 54);
            label2.TabIndex = 2;
            label2.Text = "Coffee Shop";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 508);
            Controls.Add(panelDesktopPanel);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            MinimumSize = new Size(850, 450);
            Name = "MainForm";
            Text = "MainForm";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelDesktopPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnViewMenu;
        private Button btnOrder;
        private Panel panelMenu;
        private Panel panelLogo;
        private Button btnAddItem;
        private Button button2;
        private Button button1;
        private Panel panelTitleBar;
        private Label lblTitle;
        private Panel panelDesktopPanel;
        private Button button3;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
    }
}