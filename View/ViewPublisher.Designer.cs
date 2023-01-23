
namespace BookStoreManagement.View
{
    partial class ViewPublisher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPublisher));
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataPublisher = new System.Windows.Forms.DataGridView();
            this.pubid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pubname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtIdPublisher = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNamePublisher = new System.Windows.Forms.TextBox();
            this.searchPubId = new System.Windows.Forms.PictureBox();
            this.searchPubName = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPublisher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPubId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPubName)).BeginInit();
            this.SuspendLayout();
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
            this.btnRemove.TabIndex = 137;
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
            this.btnEdit.TabIndex = 136;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.dataPublisher);
            this.panel1.Location = new System.Drawing.Point(54, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 437);
            this.panel1.TabIndex = 138;
            // 
            // dataPublisher
            // 
            this.dataPublisher.AllowUserToAddRows = false;
            this.dataPublisher.AllowUserToDeleteRows = false;
            this.dataPublisher.AllowUserToResizeColumns = false;
            this.dataPublisher.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataPublisher.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataPublisher.BackgroundColor = System.Drawing.Color.White;
            this.dataPublisher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPublisher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataPublisher.ColumnHeadersHeight = 40;
            this.dataPublisher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pubid,
            this.pubname});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataPublisher.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataPublisher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPublisher.EnableHeadersVisualStyles = false;
            this.dataPublisher.GridColor = System.Drawing.Color.White;
            this.dataPublisher.Location = new System.Drawing.Point(0, 0);
            this.dataPublisher.Name = "dataPublisher";
            this.dataPublisher.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPublisher.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataPublisher.RowHeadersVisible = false;
            this.dataPublisher.RowHeadersWidth = 51;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dataPublisher.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataPublisher.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataPublisher.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataPublisher.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataPublisher.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataPublisher.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dataPublisher.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataPublisher.RowTemplate.Height = 35;
            this.dataPublisher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPublisher.Size = new System.Drawing.Size(982, 437);
            this.dataPublisher.TabIndex = 1;
            this.dataPublisher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPublisher_CellClick);
            // 
            // pubid
            // 
            this.pubid.DataPropertyName = "pubid";
            this.pubid.HeaderText = "Publisher Id";
            this.pubid.MinimumWidth = 6;
            this.pubid.Name = "pubid";
            this.pubid.ReadOnly = true;
            this.pubid.Width = 200;
            // 
            // pubname
            // 
            this.pubname.DataPropertyName = "pubname";
            this.pubname.HeaderText = "Publisher Name";
            this.pubname.MinimumWidth = 6;
            this.pubname.Name = "pubname";
            this.pubname.ReadOnly = true;
            this.pubname.Width = 780;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(582, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 23);
            this.label3.TabIndex = 129;
            this.label3.Text = "Publisher Name :";
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
            this.btnSave.TabIndex = 135;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtIdPublisher
            // 
            this.txtIdPublisher.BackColor = System.Drawing.Color.White;
            this.txtIdPublisher.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPublisher.ForeColor = System.Drawing.Color.Black;
            this.txtIdPublisher.Location = new System.Drawing.Point(131, 67);
            this.txtIdPublisher.Multiline = true;
            this.txtIdPublisher.Name = "txtIdPublisher";
            this.txtIdPublisher.Size = new System.Drawing.Size(341, 45);
            this.txtIdPublisher.TabIndex = 132;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(127, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 130;
            this.label2.Text = "Publisher ID  :";
            // 
            // txtNamePublisher
            // 
            this.txtNamePublisher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNamePublisher.BackColor = System.Drawing.Color.White;
            this.txtNamePublisher.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNamePublisher.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamePublisher.ForeColor = System.Drawing.Color.Black;
            this.txtNamePublisher.Location = new System.Drawing.Point(586, 67);
            this.txtNamePublisher.Multiline = true;
            this.txtNamePublisher.Name = "txtNamePublisher";
            this.txtNamePublisher.Size = new System.Drawing.Size(341, 45);
            this.txtNamePublisher.TabIndex = 131;
            // 
            // searchPubId
            // 
            this.searchPubId.Image = ((System.Drawing.Image)(resources.GetObject("searchPubId.Image")));
            this.searchPubId.Location = new System.Drawing.Point(478, 67);
            this.searchPubId.Name = "searchPubId";
            this.searchPubId.Size = new System.Drawing.Size(45, 45);
            this.searchPubId.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchPubId.TabIndex = 134;
            this.searchPubId.TabStop = false;
            this.searchPubId.Click += new System.EventHandler(this.searchPubId_Click);
            // 
            // searchPubName
            // 
            this.searchPubName.Image = ((System.Drawing.Image)(resources.GetObject("searchPubName.Image")));
            this.searchPubName.Location = new System.Drawing.Point(933, 67);
            this.searchPubName.Name = "searchPubName";
            this.searchPubName.Size = new System.Drawing.Size(45, 45);
            this.searchPubName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchPubName.TabIndex = 133;
            this.searchPubName.TabStop = false;
            this.searchPubName.Click += new System.EventHandler(this.searchPubName_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ViewPublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtIdPublisher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNamePublisher);
            this.Controls.Add(this.searchPubId);
            this.Controls.Add(this.searchPubName);
            this.Name = "ViewPublisher";
            this.Size = new System.Drawing.Size(1089, 693);
            this.Load += new System.EventHandler(this.ViewPublisher_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPublisher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPubId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPubName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dataPublisher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.TextBox txtIdPublisher;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtNamePublisher;
        private System.Windows.Forms.PictureBox searchPubId;
        private System.Windows.Forms.PictureBox searchPubName;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pubid;
        private System.Windows.Forms.DataGridViewTextBoxColumn pubname;
    }
}
