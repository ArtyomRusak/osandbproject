namespace DumaProject.UI
{
    partial class ViewComissionMembers
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
            this.dgvComissionMembers = new System.Windows.Forms.DataGridView();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComissionMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvComissionMembers
            // 
            this.dgvComissionMembers.AllowUserToAddRows = false;
            this.dgvComissionMembers.AllowUserToDeleteRows = false;
            this.dgvComissionMembers.AutoGenerateColumns = false;
            this.dgvComissionMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComissionMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComissionMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.patronymicDataGridViewTextBoxColumn,
            this.passportDataDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.nSPDataGridViewTextBoxColumn});
            this.dgvComissionMembers.DataSource = this.memberBindingSource;
            this.dgvComissionMembers.Location = new System.Drawing.Point(12, 12);
            this.dgvComissionMembers.Name = "dgvComissionMembers";
            this.dgvComissionMembers.ReadOnly = true;
            this.dgvComissionMembers.Size = new System.Drawing.Size(708, 360);
            this.dgvComissionMembers.TabIndex = 0;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataSource = typeof(DumaProject.Core.Entities.Member);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // patronymicDataGridViewTextBoxColumn
            // 
            this.patronymicDataGridViewTextBoxColumn.DataPropertyName = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.HeaderText = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
            // 
            // passportDataDataGridViewTextBoxColumn
            // 
            this.passportDataDataGridViewTextBoxColumn.DataPropertyName = "PassportData";
            this.passportDataDataGridViewTextBoxColumn.HeaderText = "PassportData";
            this.passportDataDataGridViewTextBoxColumn.Name = "passportDataDataGridViewTextBoxColumn";
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            // 
            // nSPDataGridViewTextBoxColumn
            // 
            this.nSPDataGridViewTextBoxColumn.DataPropertyName = "NSP";
            this.nSPDataGridViewTextBoxColumn.HeaderText = "NSP";
            this.nSPDataGridViewTextBoxColumn.Name = "nSPDataGridViewTextBoxColumn";
            this.nSPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ViewComissionMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 387);
            this.Controls.Add(this.dgvComissionMembers);
            this.Name = "ViewComissionMembers";
            this.Text = "ViewComissionMembers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewComissionMembers_FormClosing);
            this.Load += new System.EventHandler(this.ViewComissionMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComissionMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComissionMembers;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource memberBindingSource;
    }
}