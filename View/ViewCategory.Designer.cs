
namespace BookStoreManagement.View
{
    partial class ViewCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCategory));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataCategory = new System.Windows.Forms.DataGridView();
            this.catid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtIdCategory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameCategory = new System.Windows.Forms.TextBox();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.searchCatId = new System.Windows.Forms.PictureBox();
            this.searchCatName = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchCatId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchCatName)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemove.BackColor = System.Drawing.Color.Tomato;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(683, 147);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(154, 50);
            this.btnRemove.TabIndex = 127;
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
            this.btnEdit.Location = new System.Drawing.Point(502, 147);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(154, 50);
            this.btnEdit.TabIndex = 126;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.dataCategory);
            this.panel1.Location = new System.Drawing.Point(54, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 437);
            this.panel1.TabIndex = 128;
            // 
            // dataCategory
            // 
            this.dataCategory.AllowUserToAddRows = false;
            this.dataCategory.AllowUserToDeleteRows = false;
            this.dataCategory.AllowUserToResizeColumns = false;
            this.dataCategory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataCategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataCategory.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataCategory.ColumnHeadersHeight = 40;
            this.dataCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.catid,
            this.catname});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataCategory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataCategory.EnableHeadersVisualStyles = false;
            this.dataCategory.GridColor = System.Drawing.Color.White;
            this.dataCategory.Location = new System.Drawing.Point(0, 0);
            this.dataCategory.Name = "dataCategory";
            this.dataCategory.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataCategory.RowHeadersVisible = false;
            this.dataCategory.RowHeadersWidth = 51;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dataCategory.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataCategory.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataCategory.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataCategory.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataCategory.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataCategory.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dataCategory.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataCategory.RowTemplate.Height = 35;
            this.dataCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataCategory.Size = new System.Drawing.Size(982, 437);
            this.dataCategory.TabIndex = 1;
            this.dataCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCategory_CellClick);
            // 
            // catid
            // 
            this.catid.DataPropertyName = "catid";
            this.catid.HeaderText = "Categorie Id";
            this.catid.MinimumWidth = 6;
            this.catid.Name = "catid";
            this.catid.ReadOnly = true;
            this.catid.Width = 200;
            // 
            // catname
            // 
            this.catname.DataPropertyName = "catname";
            this.catname.HeaderText = "Categorie Book";
            this.catname.MinimumWidth = 6;
            this.catname.Name = "catname";
            this.catname.ReadOnly = true;
            this.catname.Width = 300;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(582, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 23);
            this.label3.TabIndex = 119;
            this.label3.Text = "Categorie Book :";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.Tomato;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(324, 147);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(154, 50);
            this.btnSave.TabIndex = 125;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtIdCategory
            // 
            this.txtIdCategory.BackColor = System.Drawing.Color.White;
            this.txtIdCategory.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCategory.ForeColor = System.Drawing.Color.Black;
            this.txtIdCategory.Location = new System.Drawing.Point(131, 67);
            this.txtIdCategory.Multiline = true;
            this.txtIdCategory.Name = "txtIdCategory";
            this.txtIdCategory.Size = new System.Drawing.Size(341, 45);
            this.txtIdCategory.TabIndex = 122;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(159, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 23);
            this.label2.TabIndex = 120;
            this.label2.Text = "Categorie ID  :";
            // 
            // txtNameCategory
            // 
            this.txtNameCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNameCategory.BackColor = System.Drawing.Color.White;
            this.txtNameCategory.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNameCategory.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameCategory.ForeColor = System.Drawing.Color.Black;
            this.txtNameCategory.Location = new System.Drawing.Point(586, 67);
            this.txtNameCategory.Multiline = true;
            this.txtNameCategory.Name = "txtNameCategory";
            this.txtNameCategory.Size = new System.Drawing.Size(341, 45);
            this.txtNameCategory.TabIndex = 121;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this;
            // 
            // searchCatId
            // 
            this.searchCatId.Image = ((System.Drawing.Image)(resources.GetObject("searchCatId.Image")));
            this.searchCatId.Location = new System.Drawing.Point(478, 67);
            this.searchCatId.Name = "searchCatId";
            this.searchCatId.Size = new System.Drawing.Size(45, 45);
            this.searchCatId.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchCatId.TabIndex = 124;
            this.searchCatId.TabStop = false;
            this.searchCatId.Click += new System.EventHandler(this.searchCatId_Click);
            // 
            // searchCatName
            // 
            this.searchCatName.Image = ((System.Drawing.Image)(resources.GetObject("searchCatName.Image")));
            this.searchCatName.Location = new System.Drawing.Point(933, 67);
            this.searchCatName.Name = "searchCatName";
            this.searchCatName.Size = new System.Drawing.Size(45, 45);
            this.searchCatName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchCatName.TabIndex = 123;
            this.searchCatName.TabStop = false;
            this.searchCatName.Click += new System.EventHandler(this.searchCatName_Click);
            // 
            // ViewCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtIdCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNameCategory);
            this.Controls.Add(this.searchCatId);
            this.Controls.Add(this.searchCatName);
            this.Name = "ViewCategory";
            this.Size = new System.Drawing.Size(1089, 693);
            this.Load += new System.EventHandler(this.ViewCategory_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchCatId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchCatName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dataCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn catid;
        private System.Windows.Forms.DataGridViewTextBoxColumn catname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox searchCatId;
        private System.Windows.Forms.PictureBox searchCatName;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        public System.Windows.Forms.TextBox txtIdCategory;
        public System.Windows.Forms.TextBox txtNameCategory;
    }
}
