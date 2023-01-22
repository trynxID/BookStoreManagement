

namespace BookStoreManagement.View
{
    partial class ViewHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewHome));
            this.panelKonten = new System.Windows.Forms.Panel();
            this.btn_sellers = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btn_Help = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.viewCategory = new BookStoreManagement.View.ViewCategory();
            this.viewCheckout = new BookStoreManagement.View.ViewCheckout();
            this.viewCustomer = new BookStoreManagement.View.ViewCustomer();
            this.viewEmployee = new BookStoreManagement.View.ViewEmployee();
            this.viewOrder = new BookStoreManagement.View.ViewOrder();
            this.viewProduct = new BookStoreManagement.View.ViewProduct();
            this.viewDashboard = new BookStoreManagement.View.ViewDashboard();
            this.panelKonten.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelKonten
            // 
            this.panelKonten.Controls.Add(this.viewCheckout);
            this.panelKonten.Controls.Add(this.viewCustomer);
            this.panelKonten.Controls.Add(this.viewEmployee);
            this.panelKonten.Controls.Add(this.viewOrder);
            this.panelKonten.Controls.Add(this.viewProduct);
            this.panelKonten.Controls.Add(this.viewDashboard);
            this.panelKonten.Controls.Add(this.viewCategory);
            this.panelKonten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKonten.Location = new System.Drawing.Point(271, 65);
            this.panelKonten.Name = "panelKonten";
            this.panelKonten.Size = new System.Drawing.Size(1085, 693);
            this.panelKonten.TabIndex = 29;
            // 
            // btn_sellers
            // 
            this.btn_sellers.FlatAppearance.BorderSize = 0;
            this.btn_sellers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sellers.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sellers.ForeColor = System.Drawing.Color.White;
            this.btn_sellers.Image = ((System.Drawing.Image)(resources.GetObject("btn_sellers.Image")));
            this.btn_sellers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sellers.Location = new System.Drawing.Point(13, 504);
            this.btn_sellers.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sellers.Name = "btn_sellers";
            this.btn_sellers.Size = new System.Drawing.Size(251, 50);
            this.btn_sellers.TabIndex = 21;
            this.btn_sellers.Text = "   Employee";
            this.btn_sellers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sellers.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btn_sellers);
            this.panel1.Controls.Add(this.btnCheckout);
            this.panel1.Controls.Add(this.btnOrders);
            this.panel1.Controls.Add(this.btnCustomers);
            this.panel1.Controls.Add(this.btnProducts);
            this.panel1.Controls.Add(this.btnCategories);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.btn_Help);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 693);
            this.panel1.TabIndex = 25;
            // 
            // btnCheckout
            // 
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckout.Image")));
            this.btnCheckout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckout.Location = new System.Drawing.Point(13, 434);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(251, 50);
            this.btnCheckout.TabIndex = 20;
            this.btnCheckout.Text = "   Checkout";
            this.btnCheckout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.ForeColor = System.Drawing.Color.White;
            this.btnOrders.Image = ((System.Drawing.Image)(resources.GetObject("btnOrders.Image")));
            this.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.Location = new System.Drawing.Point(16, 363);
            this.btnOrders.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(251, 50);
            this.btnOrders.TabIndex = 19;
            this.btnOrders.Text = "   Orders";
            this.btnOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomers.Image")));
            this.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.Location = new System.Drawing.Point(16, 293);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(251, 50);
            this.btnCustomers.TabIndex = 18;
            this.btnCustomers.Text = "   Customers";
            this.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.White;
            this.btnProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnProducts.Image")));
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Location = new System.Drawing.Point(16, 223);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(4);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(251, 50);
            this.btnProducts.TabIndex = 17;
            this.btnProducts.Text = "   Products";
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.FlatAppearance.BorderSize = 0;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategories.ForeColor = System.Drawing.Color.White;
            this.btnCategories.Image = ((System.Drawing.Image)(resources.GetObject("btnCategories.Image")));
            this.btnCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategories.Location = new System.Drawing.Point(16, 153);
            this.btnCategories.Margin = new System.Windows.Forms.Padding(4);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(251, 50);
            this.btnCategories.TabIndex = 16;
            this.btnCategories.Text = "   Categories";
            this.btnCategories.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategories.UseVisualStyleBackColor = true;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(264, 66);
            this.panel3.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(109, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 44);
            this.label2.TabIndex = 15;
            this.label2.Text = "Book Store \r\nManagement ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(16, 637);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(251, 50);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(16, 83);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(251, 50);
            this.btnDashboard.TabIndex = 11;
            this.btnDashboard.Text = "   Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.White;
            this.SidePanel.Location = new System.Drawing.Point(0, 83);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(4);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(13, 50);
            this.SidePanel.TabIndex = 4;
            // 
            // btn_Help
            // 
            this.btn_Help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Help.FlatAppearance.BorderSize = 0;
            this.btn_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Help.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Help.ForeColor = System.Drawing.Color.White;
            this.btn_Help.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Help.Location = new System.Drawing.Point(4, 647);
            this.btn_Help.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(48, 42);
            this.btn_Help.TabIndex = 4;
            this.btn_Help.Text = "?";
            this.btn_Help.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Help.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1356, 65);
            this.panel2.TabIndex = 26;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1294, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Book Store Management System ";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1356, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 758);
            this.panel5.TabIndex = 28;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 758);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1366, 10);
            this.panel4.TabIndex = 27;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this;
            // 
            // viewCategory
            // 
            this.viewCategory.BackColor = System.Drawing.Color.White;
            this.viewCategory.Location = new System.Drawing.Point(0, 0);
            this.viewCategory.Name = "viewCategory";
            this.viewCategory.Size = new System.Drawing.Size(1085, 691);
            this.viewCategory.TabIndex = 1;
            // 
            // viewCheckout
            // 
            this.viewCheckout.Location = new System.Drawing.Point(0, 0);
            this.viewCheckout.Name = "viewCheckout";
            this.viewCheckout.Size = new System.Drawing.Size(1085, 693);
            this.viewCheckout.TabIndex = 2;
            // 
            // viewCustomer
            // 
            this.viewCustomer.Location = new System.Drawing.Point(0, 0);
            this.viewCustomer.Name = "viewCustomer";
            this.viewCustomer.Size = new System.Drawing.Size(150, 150);
            this.viewCustomer.TabIndex = 3;
            // 
            // viewEmployee
            // 
            this.viewEmployee.Location = new System.Drawing.Point(0, 0);
            this.viewEmployee.Name = "viewEmployee";
            this.viewEmployee.Size = new System.Drawing.Size(150, 150);
            this.viewEmployee.TabIndex = 4;
            // 
            // viewOrder
            // 
            this.viewOrder.Location = new System.Drawing.Point(0, 0);
            this.viewOrder.Name = "viewOrder";
            this.viewOrder.Size = new System.Drawing.Size(150, 150);
            this.viewOrder.TabIndex = 5;
            // 
            // viewProduct
            // 
            this.viewProduct.Location = new System.Drawing.Point(0, 0);
            this.viewProduct.Name = "viewProduct";
            this.viewProduct.Size = new System.Drawing.Size(150, 150);
            this.viewProduct.TabIndex = 6;
            // 
            // viewDashboard
            // 
            this.viewDashboard.BackColor = System.Drawing.Color.White;
            this.viewDashboard.Location = new System.Drawing.Point(0, 0);
            this.viewDashboard.Name = "viewDashboard";
            this.viewDashboard.Size = new System.Drawing.Size(1085, 693);
            this.viewDashboard.TabIndex = 0;
            // 
            // ViewHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panelKonten);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewHome";
            this.Load += new System.EventHandler(this.ViewHome_Load);
            this.panelKonten.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelKonten;
        public System.Windows.Forms.Button btn_sellers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private ViewDashboard viewDashboard;
        private ViewCategory viewCategory;
        private ViewCheckout viewCheckout;
        private ViewCustomer viewCustomer;
        private ViewEmployee viewEmployee;
        private ViewOrder viewOrder;
        private ViewProduct viewProduct;
    }
}