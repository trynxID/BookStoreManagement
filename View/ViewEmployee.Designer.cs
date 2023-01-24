
namespace BookStoreManagement.View
{
    partial class ViewEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEmployee));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.employeeIdSearch = new System.Windows.Forms.PictureBox();
            this.dataEmployee = new System.Windows.Forms.DataGridView();
            this.empid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empuname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empfname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emppassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empcontact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPasswordEmployee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContactEmployee = new System.Windows.Forms.TextBox();
            this.txtUsernameEmployee = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFullnameEmployee = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.employeeNameSearch = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmailEmployee = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdEmployee = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.employeeIdSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeNameSearch)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // employeeIdSearch
            // 
            this.employeeIdSearch.Image = ((System.Drawing.Image)(resources.GetObject("employeeIdSearch.Image")));
            this.employeeIdSearch.Location = new System.Drawing.Point(409, 67);
            this.employeeIdSearch.Name = "employeeIdSearch";
            this.employeeIdSearch.Size = new System.Drawing.Size(45, 45);
            this.employeeIdSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.employeeIdSearch.TabIndex = 111;
            this.employeeIdSearch.TabStop = false;
            this.employeeIdSearch.Click += new System.EventHandler(this.employeeIdSearch_Click);
            // 
            // dataEmployee
            // 
            this.dataEmployee.AllowUserToAddRows = false;
            this.dataEmployee.AllowUserToDeleteRows = false;
            this.dataEmployee.AllowUserToResizeColumns = false;
            this.dataEmployee.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataEmployee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataEmployee.BackgroundColor = System.Drawing.Color.White;
            this.dataEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataEmployee.ColumnHeadersHeight = 40;
            this.dataEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empid,
            this.empuname,
            this.empfname,
            this.emppassword,
            this.empcontact,
            this.empemail});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataEmployee.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataEmployee.EnableHeadersVisualStyles = false;
            this.dataEmployee.GridColor = System.Drawing.Color.White;
            this.dataEmployee.Location = new System.Drawing.Point(0, 0);
            this.dataEmployee.Name = "dataEmployee";
            this.dataEmployee.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataEmployee.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataEmployee.RowHeadersVisible = false;
            this.dataEmployee.RowHeadersWidth = 51;
            this.dataEmployee.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataEmployee.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataEmployee.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataEmployee.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataEmployee.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dataEmployee.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataEmployee.RowTemplate.Height = 35;
            this.dataEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataEmployee.Size = new System.Drawing.Size(1002, 351);
            this.dataEmployee.TabIndex = 2;
            this.dataEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEmployee_CellClick);
            // 
            // empid
            // 
            this.empid.DataPropertyName = "empid";
            this.empid.HeaderText = "Employee ID";
            this.empid.Name = "empid";
            this.empid.ReadOnly = true;
            this.empid.Width = 115;
            // 
            // empuname
            // 
            this.empuname.DataPropertyName = "empuname";
            this.empuname.HeaderText = "Username";
            this.empuname.MinimumWidth = 6;
            this.empuname.Name = "empuname";
            this.empuname.ReadOnly = true;
            // 
            // empfname
            // 
            this.empfname.DataPropertyName = "empfname";
            this.empfname.HeaderText = "Name";
            this.empfname.MinimumWidth = 6;
            this.empfname.Name = "empfname";
            this.empfname.ReadOnly = true;
            this.empfname.Width = 300;
            // 
            // emppassword
            // 
            this.emppassword.DataPropertyName = "emppassword";
            this.emppassword.HeaderText = "Password";
            this.emppassword.MinimumWidth = 6;
            this.emppassword.Name = "emppassword";
            this.emppassword.ReadOnly = true;
            // 
            // empcontact
            // 
            this.empcontact.DataPropertyName = "empcontact";
            this.empcontact.HeaderText = "No HP";
            this.empcontact.MinimumWidth = 6;
            this.empcontact.Name = "empcontact";
            this.empcontact.ReadOnly = true;
            this.empcontact.Width = 120;
            // 
            // empemail
            // 
            this.empemail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.empemail.DataPropertyName = "empemail";
            this.empemail.HeaderText = "Email";
            this.empemail.MinimumWidth = 250;
            this.empemail.Name = "empemail";
            this.empemail.ReadOnly = true;
            this.empemail.Width = 250;
            // 
            // txtPasswordEmployee
            // 
            this.txtPasswordEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPasswordEmployee.BackColor = System.Drawing.Color.White;
            this.txtPasswordEmployee.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordEmployee.ForeColor = System.Drawing.Color.Black;
            this.txtPasswordEmployee.Location = new System.Drawing.Point(484, 155);
            this.txtPasswordEmployee.Multiline = true;
            this.txtPasswordEmployee.Name = "txtPasswordEmployee";
            this.txtPasswordEmployee.Size = new System.Drawing.Size(341, 45);
            this.txtPasswordEmployee.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(49, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 102;
            this.label1.Text = "No HP :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(466, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 23);
            this.label4.TabIndex = 103;
            this.label4.Text = "Password :";
            // 
            // txtContactEmployee
            // 
            this.txtContactEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContactEmployee.BackColor = System.Drawing.Color.White;
            this.txtContactEmployee.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactEmployee.ForeColor = System.Drawing.Color.Black;
            this.txtContactEmployee.Location = new System.Drawing.Point(62, 243);
            this.txtContactEmployee.Multiline = true;
            this.txtContactEmployee.Name = "txtContactEmployee";
            this.txtContactEmployee.Size = new System.Drawing.Size(341, 45);
            this.txtContactEmployee.TabIndex = 5;
            // 
            // txtUsernameEmployee
            // 
            this.txtUsernameEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsernameEmployee.BackColor = System.Drawing.Color.White;
            this.txtUsernameEmployee.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameEmployee.ForeColor = System.Drawing.Color.Black;
            this.txtUsernameEmployee.Location = new System.Drawing.Point(484, 67);
            this.txtUsernameEmployee.Multiline = true;
            this.txtUsernameEmployee.Name = "txtUsernameEmployee";
            this.txtUsernameEmployee.Size = new System.Drawing.Size(341, 45);
            this.txtUsernameEmployee.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(44, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 23);
            this.label3.TabIndex = 98;
            this.label3.Text = "Full Name :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(466, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 23);
            this.label2.TabIndex = 99;
            this.label2.Text = "Username :";
            // 
            // txtFullnameEmployee
            // 
            this.txtFullnameEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFullnameEmployee.BackColor = System.Drawing.Color.White;
            this.txtFullnameEmployee.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFullnameEmployee.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullnameEmployee.ForeColor = System.Drawing.Color.Black;
            this.txtFullnameEmployee.Location = new System.Drawing.Point(62, 155);
            this.txtFullnameEmployee.Multiline = true;
            this.txtFullnameEmployee.Name = "txtFullnameEmployee";
            this.txtFullnameEmployee.Size = new System.Drawing.Size(341, 45);
            this.txtFullnameEmployee.TabIndex = 3;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemove.BackColor = System.Drawing.Color.Tomato;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(850, 238);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(163, 50);
            this.btnRemove.TabIndex = 9;
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
            this.btnEdit.Location = new System.Drawing.Point(850, 182);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(163, 50);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // employeeNameSearch
            // 
            this.employeeNameSearch.Image = ((System.Drawing.Image)(resources.GetObject("employeeNameSearch.Image")));
            this.employeeNameSearch.Location = new System.Drawing.Point(831, 67);
            this.employeeNameSearch.Name = "employeeNameSearch";
            this.employeeNameSearch.Size = new System.Drawing.Size(45, 45);
            this.employeeNameSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.employeeNameSearch.TabIndex = 110;
            this.employeeNameSearch.TabStop = false;
            this.employeeNameSearch.Click += new System.EventHandler(this.employeeNameSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.Tomato;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(850, 126);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(163, 50);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.dataEmployee);
            this.panel1.Location = new System.Drawing.Point(41, 305);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 351);
            this.panel1.TabIndex = 106;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Location = new System.Drawing.Point(471, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 23);
            this.label5.TabIndex = 113;
            this.label5.Text = "Email :";
            // 
            // txtEmailEmployee
            // 
            this.txtEmailEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmailEmployee.BackColor = System.Drawing.Color.White;
            this.txtEmailEmployee.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailEmployee.ForeColor = System.Drawing.Color.Black;
            this.txtEmailEmployee.Location = new System.Drawing.Point(484, 243);
            this.txtEmailEmployee.Multiline = true;
            this.txtEmailEmployee.Name = "txtEmailEmployee";
            this.txtEmailEmployee.Size = new System.Drawing.Size(341, 45);
            this.txtEmailEmployee.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Tomato;
            this.label6.Location = new System.Drawing.Point(44, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 23);
            this.label6.TabIndex = 112;
            this.label6.Text = "Employee ID :";
            // 
            // txtIdEmployee
            // 
            this.txtIdEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdEmployee.BackColor = System.Drawing.Color.White;
            this.txtIdEmployee.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdEmployee.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEmployee.ForeColor = System.Drawing.Color.Black;
            this.txtIdEmployee.Location = new System.Drawing.Point(62, 67);
            this.txtIdEmployee.Multiline = true;
            this.txtIdEmployee.Name = "txtIdEmployee";
            this.txtIdEmployee.Size = new System.Drawing.Size(341, 45);
            this.txtIdEmployee.TabIndex = 1;
            // 
            // ViewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmailEmployee);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIdEmployee);
            this.Controls.Add(this.employeeIdSearch);
            this.Controls.Add(this.txtPasswordEmployee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtContactEmployee);
            this.Controls.Add(this.txtUsernameEmployee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFullnameEmployee);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.employeeNameSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Name = "ViewEmployee";
            this.Size = new System.Drawing.Size(1085, 693);
            this.Load += new System.EventHandler(this.ViewEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeIdSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeNameSearch)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox employeeIdSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.PictureBox employeeNameSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dataEmployee;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtPasswordEmployee;
        public System.Windows.Forms.TextBox txtContactEmployee;
        public System.Windows.Forms.TextBox txtUsernameEmployee;
        public System.Windows.Forms.TextBox txtFullnameEmployee;
        public System.Windows.Forms.TextBox txtEmailEmployee;
        public System.Windows.Forms.TextBox txtIdEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn empid;
        private System.Windows.Forms.DataGridViewTextBoxColumn empuname;
        private System.Windows.Forms.DataGridViewTextBoxColumn empfname;
        private System.Windows.Forms.DataGridViewTextBoxColumn emppassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn empcontact;
        private System.Windows.Forms.DataGridViewTextBoxColumn empemail;
    }
}
