
namespace BookStoreManagement.View
{
    partial class ViewCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCustomer));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cusaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuscontact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCustomer = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.customerIdSearch = new System.Windows.Forms.PictureBox();
            this.customerNameSearch = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtContactCustomer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddressCustomer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameCustomer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdCustomer = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerIdSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerNameSearch)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // cusaddress
            // 
            this.cusaddress.DataPropertyName = "cusaddress";
            this.cusaddress.HeaderText = "Address";
            this.cusaddress.MinimumWidth = 6;
            this.cusaddress.Name = "cusaddress";
            this.cusaddress.ReadOnly = true;
            this.cusaddress.Width = 300;
            // 
            // cuscontact
            // 
            this.cuscontact.DataPropertyName = "cuscontact";
            this.cuscontact.HeaderText = "Contact";
            this.cuscontact.MinimumWidth = 6;
            this.cuscontact.Name = "cuscontact";
            this.cuscontact.ReadOnly = true;
            this.cuscontact.Width = 200;
            // 
            // cusname
            // 
            this.cusname.DataPropertyName = "cusname";
            this.cusname.HeaderText = "Customer Name";
            this.cusname.MinimumWidth = 6;
            this.cusname.Name = "cusname";
            this.cusname.ReadOnly = true;
            this.cusname.Width = 300;
            // 
            // cusid
            // 
            this.cusid.DataPropertyName = "cusid";
            this.cusid.HeaderText = "Customer Id";
            this.cusid.MinimumWidth = 6;
            this.cusid.Name = "cusid";
            this.cusid.ReadOnly = true;
            this.cusid.Width = 200;
            // 
            // dataCustomer
            // 
            this.dataCustomer.AllowUserToAddRows = false;
            this.dataCustomer.AllowUserToDeleteRows = false;
            this.dataCustomer.AllowUserToResizeColumns = false;
            this.dataCustomer.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dataCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataCustomer.ColumnHeadersHeight = 40;
            this.dataCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cusid,
            this.cusname,
            this.cuscontact,
            this.cusaddress});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataCustomer.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataCustomer.EnableHeadersVisualStyles = false;
            this.dataCustomer.GridColor = System.Drawing.Color.Tomato;
            this.dataCustomer.Location = new System.Drawing.Point(0, 0);
            this.dataCustomer.Name = "dataCustomer";
            this.dataCustomer.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataCustomer.RowHeadersVisible = false;
            this.dataCustomer.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Tomato;
            this.dataCustomer.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataCustomer.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataCustomer.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataCustomer.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dataCustomer.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataCustomer.RowTemplate.Height = 35;
            this.dataCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataCustomer.Size = new System.Drawing.Size(990, 433);
            this.dataCustomer.TabIndex = 2;
            this.dataCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCustomer_CellClick);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemove.BackColor = System.Drawing.Color.Tomato;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(878, 157);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(154, 50);
            this.btnRemove.TabIndex = 149;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // customerIdSearch
            // 
            this.customerIdSearch.Image = ((System.Drawing.Image)(resources.GetObject("customerIdSearch.Image")));
            this.customerIdSearch.Location = new System.Drawing.Point(428, 67);
            this.customerIdSearch.Name = "customerIdSearch";
            this.customerIdSearch.Size = new System.Drawing.Size(45, 45);
            this.customerIdSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customerIdSearch.TabIndex = 148;
            this.customerIdSearch.TabStop = false;
            this.customerIdSearch.Click += new System.EventHandler(this.customerIdSearch_Click);
            // 
            // customerNameSearch
            // 
            this.customerNameSearch.Image = ((System.Drawing.Image)(resources.GetObject("customerNameSearch.Image")));
            this.customerNameSearch.Location = new System.Drawing.Point(428, 160);
            this.customerNameSearch.Name = "customerNameSearch";
            this.customerNameSearch.Size = new System.Drawing.Size(45, 45);
            this.customerNameSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customerNameSearch.TabIndex = 147;
            this.customerNameSearch.TabStop = false;
            this.customerNameSearch.Click += new System.EventHandler(this.customerNameSearch_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.BackColor = System.Drawing.Color.Tomato;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(878, 101);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(154, 50);
            this.btnEdit.TabIndex = 146;
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
            this.btnSave.Location = new System.Drawing.Point(878, 45);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(154, 50);
            this.btnSave.TabIndex = 145;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtContactCustomer
            // 
            this.txtContactCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContactCustomer.BackColor = System.Drawing.Color.White;
            this.txtContactCustomer.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactCustomer.ForeColor = System.Drawing.Color.Black;
            this.txtContactCustomer.Location = new System.Drawing.Point(511, 67);
            this.txtContactCustomer.Multiline = true;
            this.txtContactCustomer.Name = "txtContactCustomer";
            this.txtContactCustomer.Size = new System.Drawing.Size(341, 45);
            this.txtContactCustomer.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(493, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 141;
            this.label1.Text = "Address :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(493, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 142;
            this.label4.Text = "Contact :";
            // 
            // txtAddressCustomer
            // 
            this.txtAddressCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddressCustomer.BackColor = System.Drawing.Color.White;
            this.txtAddressCustomer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAddressCustomer.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressCustomer.ForeColor = System.Drawing.Color.Black;
            this.txtAddressCustomer.Location = new System.Drawing.Point(511, 160);
            this.txtAddressCustomer.Multiline = true;
            this.txtAddressCustomer.Name = "txtAddressCustomer";
            this.txtAddressCustomer.Size = new System.Drawing.Size(341, 45);
            this.txtAddressCustomer.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(57, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 23);
            this.label3.TabIndex = 137;
            this.label3.Text = "Customer Name :";
            // 
            // txtNameCustomer
            // 
            this.txtNameCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNameCustomer.BackColor = System.Drawing.Color.White;
            this.txtNameCustomer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNameCustomer.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameCustomer.ForeColor = System.Drawing.Color.Black;
            this.txtNameCustomer.Location = new System.Drawing.Point(75, 160);
            this.txtNameCustomer.Multiline = true;
            this.txtNameCustomer.Name = "txtNameCustomer";
            this.txtNameCustomer.Size = new System.Drawing.Size(341, 45);
            this.txtNameCustomer.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(57, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 138;
            this.label2.Text = "Customer ID :";
            // 
            // txtIdCustomer
            // 
            this.txtIdCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdCustomer.BackColor = System.Drawing.Color.White;
            this.txtIdCustomer.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCustomer.ForeColor = System.Drawing.Color.Black;
            this.txtIdCustomer.Location = new System.Drawing.Point(75, 67);
            this.txtIdCustomer.Multiline = true;
            this.txtIdCustomer.Name = "txtIdCustomer";
            this.txtIdCustomer.Size = new System.Drawing.Size(341, 45);
            this.txtIdCustomer.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.dataCustomer);
            this.panel1.Location = new System.Drawing.Point(47, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 433);
            this.panel1.TabIndex = 136;
            // 
            // ViewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.customerIdSearch);
            this.Controls.Add(this.customerNameSearch);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtContactCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAddressCustomer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNameCustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdCustomer);
            this.Controls.Add(this.panel1);
            this.Name = "ViewCustomer";
            this.Size = new System.Drawing.Size(1085, 693);
            this.Load += new System.EventHandler(this.ViewCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerIdSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerNameSearch)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.PictureBox customerIdSearch;
        private System.Windows.Forms.PictureBox customerNameSearch;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dataCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuscontact;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusaddress;
        public System.Windows.Forms.TextBox txtContactCustomer;
        public System.Windows.Forms.TextBox txtAddressCustomer;
        public System.Windows.Forms.TextBox txtNameCustomer;
        public System.Windows.Forms.TextBox txtIdCustomer;
    }
}
