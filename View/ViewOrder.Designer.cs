
namespace BookStoreManagement.View
{
    partial class ViewOrder
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataOrder = new System.Windows.Forms.DataGridView();
            this.invoicedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuscontact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grandtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrder)).BeginInit();
            this.panel4.SuspendLayout();
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.dataOrder);
            this.panel3.Location = new System.Drawing.Point(31, 137);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1009, 518);
            this.panel3.TabIndex = 15;
            // 
            // dataOrder
            // 
            this.dataOrder.AllowUserToAddRows = false;
            this.dataOrder.AllowUserToDeleteRows = false;
            this.dataOrder.AllowUserToResizeColumns = false;
            this.dataOrder.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataOrder.BackgroundColor = System.Drawing.Color.White;
            this.dataOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataOrder.ColumnHeadersHeight = 40;
            this.dataOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoicedate,
            this.invoiceid,
            this.cusid,
            this.cusname,
            this.cuscontact,
            this.cusaddress,
            this.grandtotal});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataOrder.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataOrder.EnableHeadersVisualStyles = false;
            this.dataOrder.GridColor = System.Drawing.Color.Tomato;
            this.dataOrder.Location = new System.Drawing.Point(0, 0);
            this.dataOrder.Name = "dataOrder";
            this.dataOrder.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataOrder.RowHeadersVisible = false;
            this.dataOrder.RowHeadersWidth = 51;
            this.dataOrder.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataOrder.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataOrder.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataOrder.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataOrder.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dataOrder.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataOrder.RowTemplate.Height = 35;
            this.dataOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataOrder.Size = new System.Drawing.Size(1009, 518);
            this.dataOrder.TabIndex = 2;
            // 
            // invoicedate
            // 
            this.invoicedate.DataPropertyName = "invoicedate";
            this.invoicedate.HeaderText = "Invoice Date";
            this.invoicedate.MinimumWidth = 6;
            this.invoicedate.Name = "invoicedate";
            this.invoicedate.ReadOnly = true;
            this.invoicedate.Width = 200;
            // 
            // invoiceid
            // 
            this.invoiceid.DataPropertyName = "invoiceid";
            this.invoiceid.HeaderText = "Invoice No";
            this.invoiceid.MinimumWidth = 6;
            this.invoiceid.Name = "invoiceid";
            this.invoiceid.ReadOnly = true;
            this.invoiceid.Width = 150;
            // 
            // cusid
            // 
            this.cusid.DataPropertyName = "cusid";
            this.cusid.HeaderText = "Customer Id";
            this.cusid.MinimumWidth = 6;
            this.cusid.Name = "cusid";
            this.cusid.ReadOnly = true;
            this.cusid.Width = 150;
            // 
            // cusname
            // 
            this.cusname.DataPropertyName = "cusname";
            this.cusname.HeaderText = "Name";
            this.cusname.MinimumWidth = 6;
            this.cusname.Name = "cusname";
            this.cusname.ReadOnly = true;
            this.cusname.Width = 350;
            // 
            // cuscontact
            // 
            this.cuscontact.DataPropertyName = "cuscontact";
            this.cuscontact.HeaderText = "Contact";
            this.cuscontact.MinimumWidth = 6;
            this.cuscontact.Name = "cuscontact";
            this.cuscontact.ReadOnly = true;
            this.cuscontact.Width = 125;
            // 
            // cusaddress
            // 
            this.cusaddress.DataPropertyName = "cusaddress";
            this.cusaddress.HeaderText = "Address";
            this.cusaddress.MinimumWidth = 6;
            this.cusaddress.Name = "cusaddress";
            this.cusaddress.ReadOnly = true;
            this.cusaddress.Width = 350;
            // 
            // grandtotal
            // 
            this.grandtotal.DataPropertyName = "grandtotal";
            this.grandtotal.HeaderText = "Grand Total";
            this.grandtotal.MinimumWidth = 6;
            this.grandtotal.Name = "grandtotal";
            this.grandtotal.ReadOnly = true;
            this.grandtotal.Width = 150;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefresh.BackColor = System.Drawing.Color.Tomato;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(14, 21);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(200, 50);
            this.btnRefresh.TabIndex = 139;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnRefresh);
            this.panel4.Location = new System.Drawing.Point(826, 66);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(228, 71);
            this.panel4.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(357, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 40);
            this.label3.TabIndex = 139;
            this.label3.Text = "Transaction History";
            // 
            // ViewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Name = "ViewOrder";
            this.Size = new System.Drawing.Size(1085, 693);
            this.Load += new System.EventHandler(this.ViewOrder_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataOrder)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.DataGridView dataOrder;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnRefresh;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoicedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuscontact;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusaddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn grandtotal;
        private System.Windows.Forms.Label label3;
    }
}
