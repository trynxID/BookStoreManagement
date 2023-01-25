
namespace BookStoreManagement.View
{
    partial class ViewCheckout
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCheckout));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtPriceTotal = new System.Windows.Forms.TextBox();
            this.txtQuantityBook = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.txtAddressCustomer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchNoInvoice = new System.Windows.Forms.PictureBox();
            this.txtDateInvoice = new System.Windows.Forms.DateTimePicker();
            this.txtPriceBook = new System.Windows.Forms.TextBox();
            this.txtNoInvoice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataCart = new System.Windows.Forms.DataGridView();
            this.invoiceid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContactCustomer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtNameCustomer = new System.Windows.Forms.ComboBox();
            this.txtTitleBook = new System.Windows.Forms.ComboBox();
            this.txtIdBook = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtIdCustomer = new System.Windows.Forms.Label();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.searchNoInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCart)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.Tomato;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(110, 607);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 50);
            this.btnSave.TabIndex = 176;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGrandTotal.BackColor = System.Drawing.Color.White;
            this.txtGrandTotal.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrandTotal.ForeColor = System.Drawing.Color.Black;
            this.txtGrandTotal.Location = new System.Drawing.Point(747, 497);
            this.txtGrandTotal.Multiline = true;
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.Size = new System.Drawing.Size(303, 45);
            this.txtGrandTotal.TabIndex = 189;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemove.BackColor = System.Drawing.Color.Tomato;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(555, 607);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(200, 50);
            this.btnRemove.TabIndex = 178;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(729, 466);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 23);
            this.label4.TabIndex = 188;
            this.label4.Text = "Grand Total :";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.Color.Tomato;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(333, 607);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(200, 50);
            this.btnUpdate.TabIndex = 177;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtPriceTotal
            // 
            this.txtPriceTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPriceTotal.BackColor = System.Drawing.Color.White;
            this.txtPriceTotal.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceTotal.ForeColor = System.Drawing.Color.Black;
            this.txtPriceTotal.Location = new System.Drawing.Point(53, 497);
            this.txtPriceTotal.Multiline = true;
            this.txtPriceTotal.Name = "txtPriceTotal";
            this.txtPriceTotal.Size = new System.Drawing.Size(303, 45);
            this.txtPriceTotal.TabIndex = 191;
            // 
            // txtQuantityBook
            // 
            this.txtQuantityBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuantityBook.BackColor = System.Drawing.Color.White;
            this.txtQuantityBook.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantityBook.ForeColor = System.Drawing.Color.Black;
            this.txtQuantityBook.Location = new System.Drawing.Point(744, 397);
            this.txtQuantityBook.Multiline = true;
            this.txtQuantityBook.Name = "txtQuantityBook";
            this.txtQuantityBook.Size = new System.Drawing.Size(303, 45);
            this.txtQuantityBook.TabIndex = 185;
            this.txtQuantityBook.TextChanged += new System.EventHandler(this.txtQuantityBook_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(35, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 23);
            this.label3.TabIndex = 190;
            this.label3.Text = "Total Price :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(726, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 183;
            this.label2.Text = "Quantity :";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.Tomato;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(581, 492);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(142, 50);
            this.btnDelete.TabIndex = 187;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddToCart.BackColor = System.Drawing.Color.Tomato;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Location = new System.Drawing.Point(399, 492);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(175, 50);
            this.btnAddToCart.TabIndex = 186;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // txtAddressCustomer
            // 
            this.txtAddressCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddressCustomer.BackColor = System.Drawing.Color.White;
            this.txtAddressCustomer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAddressCustomer.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressCustomer.ForeColor = System.Drawing.Color.Black;
            this.txtAddressCustomer.Location = new System.Drawing.Point(744, 286);
            this.txtAddressCustomer.Multiline = true;
            this.txtAddressCustomer.Name = "txtAddressCustomer";
            this.txtAddressCustomer.Size = new System.Drawing.Size(303, 45);
            this.txtAddressCustomer.TabIndex = 175;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(387, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 182;
            this.label1.Text = "Price :";
            // 
            // searchNoInvoice
            // 
            this.searchNoInvoice.Image = ((System.Drawing.Image)(resources.GetObject("searchNoInvoice.Image")));
            this.searchNoInvoice.Location = new System.Drawing.Point(361, 177);
            this.searchNoInvoice.Name = "searchNoInvoice";
            this.searchNoInvoice.Size = new System.Drawing.Size(45, 45);
            this.searchNoInvoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchNoInvoice.TabIndex = 170;
            this.searchNoInvoice.TabStop = false;
            this.searchNoInvoice.Click += new System.EventHandler(this.searchNoInvoice_Click);
            // 
            // txtDateInvoice
            // 
            this.txtDateInvoice.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateInvoice.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDateInvoice.Location = new System.Drawing.Point(53, 80);
            this.txtDateInvoice.Name = "txtDateInvoice";
            this.txtDateInvoice.Size = new System.Drawing.Size(264, 40);
            this.txtDateInvoice.TabIndex = 172;
            // 
            // txtPriceBook
            // 
            this.txtPriceBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPriceBook.BackColor = System.Drawing.Color.White;
            this.txtPriceBook.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceBook.ForeColor = System.Drawing.Color.Black;
            this.txtPriceBook.Location = new System.Drawing.Point(408, 397);
            this.txtPriceBook.Multiline = true;
            this.txtPriceBook.Name = "txtPriceBook";
            this.txtPriceBook.Size = new System.Drawing.Size(303, 45);
            this.txtPriceBook.TabIndex = 184;
            // 
            // txtNoInvoice
            // 
            this.txtNoInvoice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNoInvoice.BackColor = System.Drawing.Color.White;
            this.txtNoInvoice.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoInvoice.ForeColor = System.Drawing.Color.Black;
            this.txtNoInvoice.Location = new System.Drawing.Point(53, 177);
            this.txtNoInvoice.Multiline = true;
            this.txtNoInvoice.Name = "txtNoInvoice";
            this.txtNoInvoice.Size = new System.Drawing.Size(302, 45);
            this.txtNoInvoice.TabIndex = 168;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Tomato;
            this.label6.Location = new System.Drawing.Point(726, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 23);
            this.label6.TabIndex = 169;
            this.label6.Text = "Address :";
            // 
            // dataCart
            // 
            this.dataCart.AllowUserToAddRows = false;
            this.dataCart.AllowUserToDeleteRows = false;
            this.dataCart.AllowUserToResizeColumns = false;
            this.dataCart.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataCart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataCart.BackgroundColor = System.Drawing.Color.White;
            this.dataCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataCart.ColumnHeadersHeight = 40;
            this.dataCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceid,
            this.cusid,
            this.bookid,
            this.name,
            this.price,
            this.quantity,
            this.totalprice});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataCart.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataCart.EnableHeadersVisualStyles = false;
            this.dataCart.GridColor = System.Drawing.Color.Tomato;
            this.dataCart.Location = new System.Drawing.Point(0, 0);
            this.dataCart.Name = "dataCart";
            this.dataCart.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataCart.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataCart.RowHeadersVisible = false;
            this.dataCart.RowHeadersWidth = 51;
            this.dataCart.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataCart.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataCart.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataCart.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataCart.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dataCart.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataCart.RowTemplate.Height = 35;
            this.dataCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataCart.Size = new System.Drawing.Size(626, 201);
            this.dataCart.TabIndex = 2;
            this.dataCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCart_CellClick);
            // 
            // invoiceid
            // 
            this.invoiceid.DataPropertyName = "invoiceid";
            this.invoiceid.HeaderText = "invoceid";
            this.invoiceid.MinimumWidth = 6;
            this.invoiceid.Name = "invoiceid";
            this.invoiceid.ReadOnly = true;
            this.invoiceid.Visible = false;
            this.invoiceid.Width = 125;
            // 
            // cusid
            // 
            this.cusid.DataPropertyName = "cusid";
            this.cusid.HeaderText = "cusid";
            this.cusid.MinimumWidth = 6;
            this.cusid.Name = "cusid";
            this.cusid.ReadOnly = true;
            this.cusid.Visible = false;
            this.cusid.Width = 125;
            // 
            // bookid
            // 
            this.bookid.DataPropertyName = "bookid";
            this.bookid.HeaderText = "bookid";
            this.bookid.MinimumWidth = 6;
            this.bookid.Name = "bookid";
            this.bookid.ReadOnly = true;
            this.bookid.Visible = false;
            this.bookid.Width = 125;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Book Title";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 304;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 110;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // totalprice
            // 
            this.totalprice.DataPropertyName = "totalprice";
            this.totalprice.HeaderText = "Total";
            this.totalprice.Name = "totalprice";
            this.totalprice.ReadOnly = true;
            this.totalprice.Width = 110;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Tomato;
            this.label9.Location = new System.Drawing.Point(35, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 23);
            this.label9.TabIndex = 165;
            this.label9.Text = "Invoice No. :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dataCart);
            this.panel3.Location = new System.Drawing.Point(419, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(628, 203);
            this.panel3.TabIndex = 179;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Tomato;
            this.label10.Location = new System.Drawing.Point(35, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 23);
            this.label10.TabIndex = 164;
            this.label10.Text = "Invoice Date :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Location = new System.Drawing.Point(35, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 23);
            this.label5.TabIndex = 180;
            this.label5.Text = "Book Title :";
            // 
            // txtContactCustomer
            // 
            this.txtContactCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContactCustomer.BackColor = System.Drawing.Color.White;
            this.txtContactCustomer.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactCustomer.ForeColor = System.Drawing.Color.Black;
            this.txtContactCustomer.Location = new System.Drawing.Point(402, 286);
            this.txtContactCustomer.Multiline = true;
            this.txtContactCustomer.Name = "txtContactCustomer";
            this.txtContactCustomer.Size = new System.Drawing.Size(303, 45);
            this.txtContactCustomer.TabIndex = 173;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Tomato;
            this.label7.Location = new System.Drawing.Point(381, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 23);
            this.label7.TabIndex = 171;
            this.label7.Text = "Contact :";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Tomato;
            this.label8.Location = new System.Drawing.Point(35, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 23);
            this.label8.TabIndex = 166;
            this.label8.Text = "Customer Name :";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrint.BackColor = System.Drawing.Color.Tomato;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(775, 607);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(200, 50);
            this.btnPrint.TabIndex = 192;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtNameCustomer
            // 
            this.txtNameCustomer.Font = new System.Drawing.Font("Palatino Linotype", 20F);
            this.txtNameCustomer.FormattingEnabled = true;
            this.txtNameCustomer.Location = new System.Drawing.Point(53, 286);
            this.txtNameCustomer.Name = "txtNameCustomer";
            this.txtNameCustomer.Size = new System.Drawing.Size(303, 44);
            this.txtNameCustomer.TabIndex = 193;
            this.txtNameCustomer.TextChanged += new System.EventHandler(this.txtNameCustomer_TextChanged);
            // 
            // txtTitleBook
            // 
            this.txtTitleBook.Font = new System.Drawing.Font("Palatino Linotype", 20F);
            this.txtTitleBook.FormattingEnabled = true;
            this.txtTitleBook.Location = new System.Drawing.Point(53, 397);
            this.txtTitleBook.Name = "txtTitleBook";
            this.txtTitleBook.Size = new System.Drawing.Size(303, 44);
            this.txtTitleBook.TabIndex = 194;
            this.txtTitleBook.TextChanged += new System.EventHandler(this.txtTitleBook_TextChanged);
            // 
            // txtIdBook
            // 
            this.txtIdBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdBook.AutoSize = true;
            this.txtIdBook.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdBook.ForeColor = System.Drawing.Color.Indigo;
            this.txtIdBook.Location = new System.Drawing.Point(61, 9);
            this.txtIdBook.Name = "txtIdBook";
            this.txtIdBook.Size = new System.Drawing.Size(0, 23);
            this.txtIdBook.TabIndex = 133;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtIdBook);
            this.panel6.Controls.Add(this.txtIdCustomer);
            this.panel6.Location = new System.Drawing.Point(333, 73);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(80, 47);
            this.panel6.TabIndex = 198;
            this.panel6.Visible = false;
            // 
            // txtIdCustomer
            // 
            this.txtIdCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdCustomer.AutoSize = true;
            this.txtIdCustomer.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCustomer.ForeColor = System.Drawing.Color.Indigo;
            this.txtIdCustomer.Location = new System.Drawing.Point(20, 9);
            this.txtIdCustomer.Name = "txtIdCustomer";
            this.txtIdCustomer.Size = new System.Drawing.Size(0, 23);
            this.txtIdCustomer.TabIndex = 132;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this;
            // 
            // ViewCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txtTitleBook);
            this.Controls.Add(this.txtNameCustomer);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtGrandTotal);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtPriceTotal);
            this.Controls.Add(this.txtQuantityBook);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.txtAddressCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchNoInvoice);
            this.Controls.Add(this.txtDateInvoice);
            this.Controls.Add(this.txtPriceBook);
            this.Controls.Add(this.txtNoInvoice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtContactCustomer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Name = "ViewCheckout";
            this.Size = new System.Drawing.Size(1085, 693);
            this.Load += new System.EventHandler(this.ViewCheckout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchNoInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCart)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox searchNoInvoice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.DataGridView dataCart;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPrint;
        public System.Windows.Forms.TextBox txtGrandTotal;
        public System.Windows.Forms.TextBox txtPriceTotal;
        public System.Windows.Forms.TextBox txtQuantityBook;
        public System.Windows.Forms.TextBox txtAddressCustomer;
        public System.Windows.Forms.TextBox txtPriceBook;
        public System.Windows.Forms.TextBox txtNoInvoice;
        public System.Windows.Forms.TextBox txtContactCustomer;
        public System.Windows.Forms.ComboBox txtTitleBook;
        public System.Windows.Forms.ComboBox txtNameCustomer;
        private System.Windows.Forms.Panel panel6;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        public System.Windows.Forms.Label txtIdBook;
        public System.Windows.Forms.Label txtIdCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusid;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalprice;
        public System.Windows.Forms.DateTimePicker txtDateInvoice;
    }
}
