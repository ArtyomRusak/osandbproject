namespace DumaProject.UI
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnMainEmployee = new System.Windows.Forms.ToolStripSplitButton();
            this.btnAddEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.editEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnViewCommissions = new System.Windows.Forms.ToolStripSplitButton();
            this.btnAddComission = new System.Windows.Forms.ToolStripMenuItem();
            this.editComissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteComissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.btnViewMeetings = new System.Windows.Forms.ToolStripSplitButton();
            this.btnEditMeeting = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMeetingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.dgvCommissions = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presidentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commissionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvMeetings = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationInMinutesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meetingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommissions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commissionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeetings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMembers
            // 
            this.dgvMembers.AllowUserToAddRows = false;
            this.dgvMembers.AllowUserToDeleteRows = false;
            this.dgvMembers.AutoGenerateColumns = false;
            this.dgvMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.patronymicDataGridViewTextBoxColumn,
            this.passportDataDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn});
            this.dgvMembers.DataSource = this.memberBindingSource;
            this.dgvMembers.Location = new System.Drawing.Point(12, 34);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.ReadOnly = true;
            this.dgvMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMembers.Size = new System.Drawing.Size(686, 395);
            this.dgvMembers.TabIndex = 0;
            this.dgvMembers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChooseMember);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patronymicDataGridViewTextBoxColumn
            // 
            this.patronymicDataGridViewTextBoxColumn.DataPropertyName = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.HeaderText = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
            this.patronymicDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passportDataDataGridViewTextBoxColumn
            // 
            this.passportDataDataGridViewTextBoxColumn.DataPropertyName = "PassportData";
            this.passportDataDataGridViewTextBoxColumn.HeaderText = "PassportData";
            this.passportDataDataGridViewTextBoxColumn.Name = "passportDataDataGridViewTextBoxColumn";
            this.passportDataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataSource = typeof(DumaProject.Core.Entities.Member);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMainEmployee,
            this.toolStripSeparator2,
            this.btnViewCommissions,
            this.toolStripSeparator9,
            this.btnViewMeetings,
            this.toolStripSeparator10,
            this.toolStripButton1,
            this.toolStripSeparator6,
            this.toolStripLabel4,
            this.toolStripComboBox1,
            this.toolStripTextBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(710, 31);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnMainEmployee
            // 
            this.btnMainEmployee.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddEmployee,
            this.editEmployeeToolStripMenuItem,
            this.btnDeleteEmployee});
            this.btnMainEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnMainEmployee.Image")));
            this.btnMainEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMainEmployee.Name = "btnMainEmployee";
            this.btnMainEmployee.Size = new System.Drawing.Size(98, 28);
            this.btnMainEmployee.Text = "Employees";
            this.btnMainEmployee.ButtonClick += new System.EventHandler(this.ViewAllEmployees);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEmployee.Image")));
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(170, 30);
            this.btnAddEmployee.Text = "Add employee";
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // editEmployeeToolStripMenuItem
            // 
            this.editEmployeeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editEmployeeToolStripMenuItem.Image")));
            this.editEmployeeToolStripMenuItem.Name = "editEmployeeToolStripMenuItem";
            this.editEmployeeToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.editEmployeeToolStripMenuItem.Text = "Edit employee";
            this.editEmployeeToolStripMenuItem.Click += new System.EventHandler(this.editEmployeeToolStripMenuItem_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteEmployee.Image")));
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(170, 30);
            this.btnDeleteEmployee.Text = "Remove employee";
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // btnViewCommissions
            // 
            this.btnViewCommissions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddComission,
            this.editComissionToolStripMenuItem,
            this.deleteComissionToolStripMenuItem});
            this.btnViewCommissions.Image = ((System.Drawing.Image)(resources.GetObject("btnViewCommissions.Image")));
            this.btnViewCommissions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnViewCommissions.Name = "btnViewCommissions";
            this.btnViewCommissions.Size = new System.Drawing.Size(99, 28);
            this.btnViewCommissions.Text = "Comissions";
            this.btnViewCommissions.ButtonClick += new System.EventHandler(this.btnViewCommissions_ButtonClick);
            // 
            // btnAddComission
            // 
            this.btnAddComission.Image = ((System.Drawing.Image)(resources.GetObject("btnAddComission.Image")));
            this.btnAddComission.Name = "btnAddComission";
            this.btnAddComission.Size = new System.Drawing.Size(162, 30);
            this.btnAddComission.Text = "Add comission";
            this.btnAddComission.Click += new System.EventHandler(this.btnAddComission_Click);
            // 
            // editComissionToolStripMenuItem
            // 
            this.editComissionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editComissionToolStripMenuItem.Image")));
            this.editComissionToolStripMenuItem.Name = "editComissionToolStripMenuItem";
            this.editComissionToolStripMenuItem.Size = new System.Drawing.Size(162, 30);
            this.editComissionToolStripMenuItem.Text = "Edit comission";
            this.editComissionToolStripMenuItem.Click += new System.EventHandler(this.editComissionToolStripMenuItem_Click);
            // 
            // deleteComissionToolStripMenuItem
            // 
            this.deleteComissionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteComissionToolStripMenuItem.Image")));
            this.deleteComissionToolStripMenuItem.Name = "deleteComissionToolStripMenuItem";
            this.deleteComissionToolStripMenuItem.Size = new System.Drawing.Size(162, 30);
            this.deleteComissionToolStripMenuItem.Text = "Delete comission";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 31);
            // 
            // btnViewMeetings
            // 
            this.btnViewMeetings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEditMeeting,
            this.deleteMeetingToolStripMenuItem});
            this.btnViewMeetings.Image = ((System.Drawing.Image)(resources.GetObject("btnViewMeetings.Image")));
            this.btnViewMeetings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnViewMeetings.Name = "btnViewMeetings";
            this.btnViewMeetings.Size = new System.Drawing.Size(90, 28);
            this.btnViewMeetings.Text = "Meetings";
            this.btnViewMeetings.ButtonClick += new System.EventHandler(this.btnViewMeetings_ButtonClick);
            // 
            // btnEditMeeting
            // 
            this.btnEditMeeting.Image = ((System.Drawing.Image)(resources.GetObject("btnEditMeeting.Image")));
            this.btnEditMeeting.Name = "btnEditMeeting";
            this.btnEditMeeting.Size = new System.Drawing.Size(153, 30);
            this.btnEditMeeting.Text = "Edit meeting";
            this.btnEditMeeting.Click += new System.EventHandler(this.btnEditMeeting_Click);
            // 
            // deleteMeetingToolStripMenuItem
            // 
            this.deleteMeetingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteMeetingToolStripMenuItem.Image")));
            this.deleteMeetingToolStripMenuItem.Name = "deleteMeetingToolStripMenuItem";
            this.deleteMeetingToolStripMenuItem.Size = new System.Drawing.Size(153, 30);
            this.deleteMeetingToolStripMenuItem.Text = "Delete meeting";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(57, 28);
            this.toolStripButton1.Text = "Help";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel4.Image")));
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(68, 28);
            this.toolStripLabel4.Text = "Search:";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(135, 31);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(125, 31);
            this.toolStripTextBox1.Tag = "";
            // 
            // dgvCommissions
            // 
            this.dgvCommissions.AllowUserToAddRows = false;
            this.dgvCommissions.AllowUserToDeleteRows = false;
            this.dgvCommissions.AutoGenerateColumns = false;
            this.dgvCommissions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCommissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommissions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.profileDataGridViewTextBoxColumn,
            this.presidentDataGridViewTextBoxColumn});
            this.dgvCommissions.DataSource = this.commissionBindingSource;
            this.dgvCommissions.Location = new System.Drawing.Point(12, 34);
            this.dgvCommissions.Name = "dgvCommissions";
            this.dgvCommissions.ReadOnly = true;
            this.dgvCommissions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCommissions.Size = new System.Drawing.Size(686, 395);
            this.dgvCommissions.TabIndex = 14;
            this.dgvCommissions.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCommissions_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // profileDataGridViewTextBoxColumn
            // 
            this.profileDataGridViewTextBoxColumn.DataPropertyName = "Profile";
            this.profileDataGridViewTextBoxColumn.HeaderText = "Profile";
            this.profileDataGridViewTextBoxColumn.Name = "profileDataGridViewTextBoxColumn";
            this.profileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // presidentDataGridViewTextBoxColumn
            // 
            this.presidentDataGridViewTextBoxColumn.DataPropertyName = "President";
            this.presidentDataGridViewTextBoxColumn.HeaderText = "President";
            this.presidentDataGridViewTextBoxColumn.Name = "presidentDataGridViewTextBoxColumn";
            this.presidentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commissionBindingSource
            // 
            this.commissionBindingSource.DataSource = typeof(DumaProject.Core.Entities.Commission);
            // 
            // dgvMeetings
            // 
            this.dgvMeetings.AllowUserToAddRows = false;
            this.dgvMeetings.AllowUserToDeleteRows = false;
            this.dgvMeetings.AutoGenerateColumns = false;
            this.dgvMeetings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMeetings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeetings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.dateDataGridViewTextBoxColumn,
            this.venueDataGridViewTextBoxColumn,
            this.durationInMinutesDataGridViewTextBoxColumn,
            this.commissionDataGridViewTextBoxColumn});
            this.dgvMeetings.DataSource = this.meetingBindingSource;
            this.dgvMeetings.Location = new System.Drawing.Point(12, 34);
            this.dgvMeetings.Name = "dgvMeetings";
            this.dgvMeetings.ReadOnly = true;
            this.dgvMeetings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMeetings.Size = new System.Drawing.Size(686, 395);
            this.dgvMeetings.TabIndex = 15;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idDataGridViewTextBoxColumn2.Visible = false;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // venueDataGridViewTextBoxColumn
            // 
            this.venueDataGridViewTextBoxColumn.DataPropertyName = "Venue";
            this.venueDataGridViewTextBoxColumn.HeaderText = "Venue";
            this.venueDataGridViewTextBoxColumn.Name = "venueDataGridViewTextBoxColumn";
            this.venueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // durationInMinutesDataGridViewTextBoxColumn
            // 
            this.durationInMinutesDataGridViewTextBoxColumn.DataPropertyName = "DurationInMinutes";
            this.durationInMinutesDataGridViewTextBoxColumn.HeaderText = "DurationInMinutes";
            this.durationInMinutesDataGridViewTextBoxColumn.Name = "durationInMinutesDataGridViewTextBoxColumn";
            this.durationInMinutesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commissionDataGridViewTextBoxColumn
            // 
            this.commissionDataGridViewTextBoxColumn.DataPropertyName = "Commission";
            this.commissionDataGridViewTextBoxColumn.HeaderText = "Commission";
            this.commissionDataGridViewTextBoxColumn.Name = "commissionDataGridViewTextBoxColumn";
            this.commissionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // meetingBindingSource
            // 
            this.meetingBindingSource.DataSource = typeof(DumaProject.Core.Entities.Meeting);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(710, 441);
            this.Controls.Add(this.dgvMeetings);
            this.Controls.Add(this.dgvCommissions);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvMembers);
            this.Name = "MainMenu";
            this.Text = "State Duma";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommissions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commissionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeetings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripSplitButton btnMainEmployee;
        private System.Windows.Forms.ToolStripMenuItem btnAddEmployee;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteEmployee;
        private System.Windows.Forms.ToolStripSplitButton btnViewCommissions;
        private System.Windows.Forms.ToolStripMenuItem btnAddComission;
        private System.Windows.Forms.ToolStripMenuItem deleteComissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton btnViewMeetings;
        private System.Windows.Forms.ToolStripMenuItem deleteMeetingToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem editEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editComissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnEditMeeting;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvCommissions;
        private System.Windows.Forms.BindingSource commissionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn profileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presidentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvMeetings;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationInMinutesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource meetingBindingSource;
    }
}

