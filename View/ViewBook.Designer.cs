
namespace BookStoreManagement.View
{
    partial class ViewBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBook));
            this.dataBook = new System.Windows.Forms.DataGridView();
            this.bookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookWriter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCategoryBook = new System.Windows.Forms.ComboBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.bookIdSearch = new System.Windows.Forms.PictureBox();
            this.bookTitleSearch = new System.Windows.Forms.PictureBox();
            this.txtWriterBook = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuantityBook = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPriceBook = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitleBook = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdBook = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPublicationBook = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPublisherBook = new System.Windows.Forms.ComboBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookIdSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTitleSearch)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataBook
            // 
            this.dataBook.AllowUserToAddRows = false;
            this.dataBook.AllowUserToDeleteRows = false;
            this.dataBook.AllowUserToResizeColumns = false;
            this.dataBook.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataBook.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataBook.BackgroundColor = System.Drawing.Color.White;
            this.dataBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataBook.ColumnHeadersHeight = 40;
            this.dataBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookId,
            this.bookTitle,
            this.bookprice,
            this.bookWriter,
            this.bookQuantity,
            this.bookCategory,
            this.bookYear,
            this.bookPublisher});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataBook.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataBook.EnableHeadersVisualStyles = false;
            this.dataBook.GridColor = System.Drawing.Color.Tomato;
            this.dataBook.Location = new System.Drawing.Point(0, 0);
            this.dataBook.Name = "dataBook";
            this.dataBook.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataBook.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataBook.RowHeadersVisible = false;
            this.dataBook.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataBook.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataBook.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataBook.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataBook.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataBook.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataBook.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dataBook.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataBook.RowTemplate.Height = 35;
            this.dataBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataBook.Size = new System.Drawing.Size(1001, 254);
            this.dataBook.TabIndex = 2;
            this.dataBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBook_CellClick);
            // 
            // bookId
            // 
            this.bookId.DataPropertyName = "bookId";
            this.bookId.HeaderText = "Book Id";
            this.bookId.MinimumWidth = 6;
            this.bookId.Name = "bookId";
            this.bookId.ReadOnly = true;
            this.bookId.Width = 80;
            // 
            // bookTitle
            // 
            this.bookTitle.DataPropertyName = "name";
            this.bookTitle.HeaderText = "Book Title";
            this.bookTitle.MinimumWidth = 6;
            this.bookTitle.Name = "bookTitle";
            this.bookTitle.ReadOnly = true;
            this.bookTitle.Width = 300;
            // 
            // bookprice
            // 
            this.bookprice.DataPropertyName = "price";
            this.bookprice.HeaderText = "Price";
            this.bookprice.MinimumWidth = 6;
            this.bookprice.Name = "bookprice";
            this.bookprice.ReadOnly = true;
            this.bookprice.Width = 70;
            // 
            // bookWriter
            // 
            this.bookWriter.DataPropertyName = "writer";
            this.bookWriter.HeaderText = "Writer";
            this.bookWriter.MinimumWidth = 6;
            this.bookWriter.Name = "bookWriter";
            this.bookWriter.ReadOnly = true;
            this.bookWriter.Width = 200;
            // 
            // bookQuantity
            // 
            this.bookQuantity.DataPropertyName = "quantity";
            this.bookQuantity.HeaderText = "Quantity";
            this.bookQuantity.MinimumWidth = 6;
            this.bookQuantity.Name = "bookQuantity";
            this.bookQuantity.ReadOnly = true;
            // 
            // bookCategory
            // 
            this.bookCategory.DataPropertyName = "category";
            this.bookCategory.HeaderText = "Category";
            this.bookCategory.MinimumWidth = 6;
            this.bookCategory.Name = "bookCategory";
            this.bookCategory.ReadOnly = true;
            this.bookCategory.Width = 200;
            // 
            // bookYear
            // 
            this.bookYear.DataPropertyName = "publication_year";
            this.bookYear.HeaderText = "Pub. Year";
            this.bookYear.Name = "bookYear";
            this.bookYear.ReadOnly = true;
            // 
            // bookPublisher
            // 
            this.bookPublisher.DataPropertyName = "publisher";
            this.bookPublisher.HeaderText = "Publisher";
            this.bookPublisher.Name = "bookPublisher";
            this.bookPublisher.ReadOnly = true;
            this.bookPublisher.Width = 150;
            // 
            // txtCategoryBook
            // 
            this.txtCategoryBook.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Bold);
            this.txtCategoryBook.FormattingEnabled = true;
            this.txtCategoryBook.ItemHeight = 37;
            this.txtCategoryBook.Location = new System.Drawing.Point(509, 246);
            this.txtCategoryBook.Name = "txtCategoryBook";
            this.txtCategoryBook.Size = new System.Drawing.Size(341, 45);
            this.txtCategoryBook.TabIndex = 8;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemove.BackColor = System.Drawing.Color.Tomato;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(866, 318);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(167, 50);
            this.btnRemove.TabIndex = 177;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.BackColor = System.Drawing.Color.Tomato;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(866, 262);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(167, 50);
            this.btnEdit.TabIndex = 176;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.Tomato;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(866, 206);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(167, 50);
            this.btnSave.TabIndex = 175;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // bookIdSearch
            // 
            this.bookIdSearch.Image = ((System.Drawing.Image)(resources.GetObject("bookIdSearch.Image")));
            this.bookIdSearch.Location = new System.Drawing.Point(428, 62);
            this.bookIdSearch.Name = "bookIdSearch";
            this.bookIdSearch.Size = new System.Drawing.Size(45, 45);
            this.bookIdSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bookIdSearch.TabIndex = 174;
            this.bookIdSearch.TabStop = false;
            this.bookIdSearch.Click += new System.EventHandler(this.bookIdSearch_Click);
            // 
            // bookTitleSearch
            // 
            this.bookTitleSearch.Image = ((System.Drawing.Image)(resources.GetObject("bookTitleSearch.Image")));
            this.bookTitleSearch.Location = new System.Drawing.Point(866, 62);
            this.bookTitleSearch.Name = "bookTitleSearch";
            this.bookTitleSearch.Size = new System.Drawing.Size(45, 45);
            this.bookTitleSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bookTitleSearch.TabIndex = 173;
            this.bookTitleSearch.TabStop = false;
            this.bookTitleSearch.Click += new System.EventHandler(this.bookTitleSearch_Click);
            // 
            // txtWriterBook
            // 
            this.txtWriterBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtWriterBook.BackColor = System.Drawing.Color.White;
            this.txtWriterBook.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtWriterBook.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWriterBook.ForeColor = System.Drawing.Color.Black;
            this.txtWriterBook.Location = new System.Drawing.Point(509, 150);
            this.txtWriterBook.Multiline = true;
            this.txtWriterBook.Name = "txtWriterBook";
            this.txtWriterBook.Size = new System.Drawing.Size(341, 45);
            this.txtWriterBook.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Location = new System.Drawing.Point(491, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 23);
            this.label5.TabIndex = 170;
            this.label5.Text = "Category :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Tomato;
            this.label6.Location = new System.Drawing.Point(491, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 23);
            this.label6.TabIndex = 171;
            this.label6.Text = "Writer  :";
            // 
            // txtQuantityBook
            // 
            this.txtQuantityBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuantityBook.BackColor = System.Drawing.Color.White;
            this.txtQuantityBook.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantityBook.ForeColor = System.Drawing.Color.Black;
            this.txtQuantityBook.Location = new System.Drawing.Point(75, 246);
            this.txtQuantityBook.Multiline = true;
            this.txtQuantityBook.Name = "txtQuantityBook";
            this.txtQuantityBook.Size = new System.Drawing.Size(341, 45);
            this.txtQuantityBook.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(57, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 166;
            this.label1.Text = "Price :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(57, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 23);
            this.label4.TabIndex = 167;
            this.label4.Text = "Quantity :";
            // 
            // txtPriceBook
            // 
            this.txtPriceBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPriceBook.BackColor = System.Drawing.Color.White;
            this.txtPriceBook.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceBook.ForeColor = System.Drawing.Color.Black;
            this.txtPriceBook.Location = new System.Drawing.Point(75, 155);
            this.txtPriceBook.Multiline = true;
            this.txtPriceBook.Name = "txtPriceBook";
            this.txtPriceBook.Size = new System.Drawing.Size(341, 45);
            this.txtPriceBook.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(491, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 23);
            this.label3.TabIndex = 162;
            this.label3.Text = "Title :";
            // 
            // txtTitleBook
            // 
            this.txtTitleBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTitleBook.BackColor = System.Drawing.Color.White;
            this.txtTitleBook.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTitleBook.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitleBook.ForeColor = System.Drawing.Color.Black;
            this.txtTitleBook.Location = new System.Drawing.Point(509, 62);
            this.txtTitleBook.Multiline = true;
            this.txtTitleBook.Name = "txtTitleBook";
            this.txtTitleBook.Size = new System.Drawing.Size(341, 45);
            this.txtTitleBook.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(57, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 163;
            this.label2.Text = "Book ID :";
            // 
            // txtIdBook
            // 
            this.txtIdBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdBook.BackColor = System.Drawing.Color.White;
            this.txtIdBook.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdBook.ForeColor = System.Drawing.Color.Black;
            this.txtIdBook.Location = new System.Drawing.Point(75, 62);
            this.txtIdBook.Multiline = true;
            this.txtIdBook.Name = "txtIdBook";
            this.txtIdBook.Size = new System.Drawing.Size(341, 45);
            this.txtIdBook.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.dataBook);
            this.panel1.Location = new System.Drawing.Point(44, 407);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 254);
            this.panel1.TabIndex = 161;
            // 
            // txtPublicationBook
            // 
            this.txtPublicationBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPublicationBook.BackColor = System.Drawing.Color.White;
            this.txtPublicationBook.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublicationBook.ForeColor = System.Drawing.Color.Black;
            this.txtPublicationBook.Location = new System.Drawing.Point(75, 339);
            this.txtPublicationBook.Multiline = true;
            this.txtPublicationBook.Name = "txtPublicationBook";
            this.txtPublicationBook.Size = new System.Drawing.Size(341, 45);
            this.txtPublicationBook.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Tomato;
            this.label7.Location = new System.Drawing.Point(57, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 23);
            this.label7.TabIndex = 179;
            this.label7.Text = "Publication Year :";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Tomato;
            this.label8.Location = new System.Drawing.Point(491, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 23);
            this.label8.TabIndex = 181;
            this.label8.Text = "Publisher :";
            // 
            // txtPublisherBook
            // 
            this.txtPublisherBook.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Bold);
            this.txtPublisherBook.FormattingEnabled = true;
            this.txtPublisherBook.ItemHeight = 37;
            this.txtPublisherBook.Location = new System.Drawing.Point(509, 339);
            this.txtPublisherBook.Name = "txtPublisherBook";
            this.txtPublisherBook.Size = new System.Drawing.Size(341, 45);
            this.txtPublisherBook.TabIndex = 182;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.BackColor = System.Drawing.Color.Tomato;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(866, 150);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(167, 50);
            this.btnClear.TabIndex = 183;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ViewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtPublisherBook);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPublicationBook);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCategoryBook);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.bookIdSearch);
            this.Controls.Add(this.bookTitleSearch);
            this.Controls.Add(this.txtWriterBook);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQuantityBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPriceBook);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitleBook);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdBook);
            this.Controls.Add(this.panel1);
            this.Name = "ViewBook";
            this.Size = new System.Drawing.Size(1089, 693);
            this.Load += new System.EventHandler(this.ViewProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookIdSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTitleSearch)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox bookIdSearch;
        private System.Windows.Forms.PictureBox bookTitleSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dataBook;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public System.Windows.Forms.ComboBox txtCategoryBook;
        public System.Windows.Forms.TextBox txtWriterBook;
        public System.Windows.Forms.TextBox txtQuantityBook;
        public System.Windows.Forms.TextBox txtPriceBook;
        public System.Windows.Forms.TextBox txtTitleBook;
        public System.Windows.Forms.TextBox txtIdBook;
        public System.Windows.Forms.TextBox txtPublicationBook;
        public System.Windows.Forms.ComboBox txtPublisherBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookWriter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookPublisher;
        private System.Windows.Forms.Button btnClear;
    }
}
