namespace DumaProject.UI
{
    partial class ViewMeetingComissions
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
            this.dgvMeetings = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationInMinutesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isEndedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isCancelledDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.meetingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblProfile = new System.Windows.Forms.Label();
            this.lblCommission = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeetings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMeetings
            // 
            this.dgvMeetings.AllowUserToAddRows = false;
            this.dgvMeetings.AllowUserToDeleteRows = false;
            this.dgvMeetings.AutoGenerateColumns = false;
            this.dgvMeetings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMeetings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeetings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.venueDataGridViewTextBoxColumn,
            this.durationInMinutesDataGridViewTextBoxColumn,
            this.isEndedDataGridViewCheckBoxColumn,
            this.isCancelledDataGridViewCheckBoxColumn});
            this.dgvMeetings.DataSource = this.meetingBindingSource;
            this.dgvMeetings.Location = new System.Drawing.Point(13, 108);
            this.dgvMeetings.Name = "dgvMeetings";
            this.dgvMeetings.ReadOnly = true;
            this.dgvMeetings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMeetings.Size = new System.Drawing.Size(647, 251);
            this.dgvMeetings.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Start Date";
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
            // isEndedDataGridViewCheckBoxColumn
            // 
            this.isEndedDataGridViewCheckBoxColumn.DataPropertyName = "IsEnded";
            this.isEndedDataGridViewCheckBoxColumn.HeaderText = "IsEnded";
            this.isEndedDataGridViewCheckBoxColumn.Name = "isEndedDataGridViewCheckBoxColumn";
            this.isEndedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isEndedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // isCancelledDataGridViewCheckBoxColumn
            // 
            this.isCancelledDataGridViewCheckBoxColumn.DataPropertyName = "IsCancelled";
            this.isCancelledDataGridViewCheckBoxColumn.HeaderText = "IsCancelled";
            this.isCancelledDataGridViewCheckBoxColumn.Name = "isCancelledDataGridViewCheckBoxColumn";
            this.isCancelledDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isCancelledDataGridViewCheckBoxColumn.Visible = false;
            // 
            // meetingBindingSource
            // 
            this.meetingBindingSource.DataSource = typeof(DumaProject.Core.Entities.Meeting);
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfile.Location = new System.Drawing.Point(36, 56);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(60, 24);
            this.lblProfile.TabIndex = 2;
            this.lblProfile.Text = "label1";
            // 
            // lblCommission
            // 
            this.lblCommission.AutoSize = true;
            this.lblCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommission.Location = new System.Drawing.Point(36, 18);
            this.lblCommission.Name = "lblCommission";
            this.lblCommission.Size = new System.Drawing.Size(60, 24);
            this.lblCommission.TabIndex = 3;
            this.lblCommission.Text = "label1";
            // 
            // ViewMeetingComissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 371);
            this.Controls.Add(this.lblCommission);
            this.Controls.Add(this.lblProfile);
            this.Controls.Add(this.dgvMeetings);
            this.Name = "ViewMeetingComissions";
            this.Text = "ViewMeetingComissions";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewMeetingComissions_FormClosed);
            this.Load += new System.EventHandler(this.ViewMeetingComissions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeetings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMeetings;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationInMinutesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isEndedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isCancelledDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource meetingBindingSource;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Label lblCommission;
    }
}