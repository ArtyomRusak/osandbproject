namespace DumaProject.UI
{
    partial class ViewCommission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCommission));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxPresident = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxProfile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMembers = new System.Windows.Forms.Button();
            this.btnMeetings = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddMeeting = new System.Windows.Forms.Button();
            this.btnEditCommission = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxPresident);
            this.groupBox1.Controls.Add(this.tbxName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxProfile);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 124);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // tbxPresident
            // 
            this.tbxPresident.Enabled = false;
            this.tbxPresident.Location = new System.Drawing.Point(128, 82);
            this.tbxPresident.Name = "tbxPresident";
            this.tbxPresident.ReadOnly = true;
            this.tbxPresident.Size = new System.Drawing.Size(282, 20);
            this.tbxPresident.TabIndex = 4;
            // 
            // tbxName
            // 
            this.tbxName.Enabled = false;
            this.tbxName.Location = new System.Drawing.Point(128, 30);
            this.tbxName.Name = "tbxName";
            this.tbxName.ReadOnly = true;
            this.tbxName.Size = new System.Drawing.Size(282, 20);
            this.tbxName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // tbxProfile
            // 
            this.tbxProfile.Enabled = false;
            this.tbxProfile.Location = new System.Drawing.Point(128, 56);
            this.tbxProfile.Name = "tbxProfile";
            this.tbxProfile.ReadOnly = true;
            this.tbxProfile.Size = new System.Drawing.Size(282, 20);
            this.tbxProfile.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Comission profile:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "President:";
            // 
            // btnMembers
            // 
            this.btnMembers.Image = ((System.Drawing.Image)(resources.GetObject("btnMembers.Image")));
            this.btnMembers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembers.Location = new System.Drawing.Point(155, 151);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(169, 35);
            this.btnMembers.TabIndex = 7;
            this.btnMembers.Text = "Members";
            this.btnMembers.UseVisualStyleBackColor = true;
            // 
            // btnMeetings
            // 
            this.btnMeetings.Image = ((System.Drawing.Image)(resources.GetObject("btnMeetings.Image")));
            this.btnMeetings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMeetings.Location = new System.Drawing.Point(155, 192);
            this.btnMeetings.Name = "btnMeetings";
            this.btnMeetings.Size = new System.Drawing.Size(169, 35);
            this.btnMeetings.TabIndex = 8;
            this.btnMeetings.Text = "Meetings";
            this.btnMeetings.UseVisualStyleBackColor = true;
            this.btnMeetings.Click += new System.EventHandler(this.btnMeetings_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnHistory.Image")));
            this.btnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.Location = new System.Drawing.Point(155, 318);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(169, 35);
            this.btnHistory.TabIndex = 9;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(155, 359);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(169, 35);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnAddMeeting
            // 
            this.btnAddMeeting.Location = new System.Drawing.Point(155, 233);
            this.btnAddMeeting.Name = "btnAddMeeting";
            this.btnAddMeeting.Size = new System.Drawing.Size(169, 34);
            this.btnAddMeeting.TabIndex = 11;
            this.btnAddMeeting.Text = "Add meeting";
            this.btnAddMeeting.UseVisualStyleBackColor = true;
            this.btnAddMeeting.Click += new System.EventHandler(this.btnAddMeeting_Click);
            // 
            // btnEditCommission
            // 
            this.btnEditCommission.Location = new System.Drawing.Point(155, 273);
            this.btnEditCommission.Name = "btnEditCommission";
            this.btnEditCommission.Size = new System.Drawing.Size(169, 39);
            this.btnEditCommission.TabIndex = 12;
            this.btnEditCommission.Text = "Edit commission";
            this.btnEditCommission.UseVisualStyleBackColor = true;
            // 
            // ViewCommission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(456, 416);
            this.Controls.Add(this.btnEditCommission);
            this.Controls.Add(this.btnAddMeeting);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnMeetings);
            this.Controls.Add(this.btnMembers);
            this.Controls.Add(this.groupBox1);
            this.Name = "ViewCommission";
            this.Text = "View comission";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewComission_FormClosing);
            this.Load += new System.EventHandler(this.ViewComission_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxPresident;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxProfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Button btnMeetings;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddMeeting;
        private System.Windows.Forms.Button btnEditCommission;
    }
}