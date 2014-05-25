namespace DumaProject.UI
{
    partial class AddChangeMeeting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddChangeMeeting));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxVenue = new System.Windows.Forms.TextBox();
            this.dtpEnding = new System.Windows.Forms.DateTimePicker();
            this.dtpBeginning = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnActiveMember = new System.Windows.Forms.Button();
            this.btnInactiveMembers = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbxMeetingMembers = new System.Windows.Forms.ListBox();
            this.memberBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lbxMembers = new System.Windows.Forms.ListBox();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxVenue);
            this.groupBox1.Controls.Add(this.dtpEnding);
            this.groupBox1.Controls.Add(this.dtpBeginning);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // tbxVenue
            // 
            this.tbxVenue.Location = new System.Drawing.Point(66, 46);
            this.tbxVenue.Multiline = true;
            this.tbxVenue.Name = "tbxVenue";
            this.tbxVenue.Size = new System.Drawing.Size(204, 51);
            this.tbxVenue.TabIndex = 7;
            // 
            // dtpEnding
            // 
            this.dtpEnding.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEnding.Location = new System.Drawing.Point(166, 103);
            this.dtpEnding.Name = "dtpEnding";
            this.dtpEnding.ShowUpDown = true;
            this.dtpEnding.Size = new System.Drawing.Size(104, 20);
            this.dtpEnding.TabIndex = 6;
            // 
            // dtpBeginning
            // 
            this.dtpBeginning.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpBeginning.Location = new System.Drawing.Point(66, 103);
            this.dtpBeginning.Name = "dtpBeginning";
            this.dtpBeginning.ShowUpDown = true;
            this.dtpBeginning.Size = new System.Drawing.Size(94, 20);
            this.dtpBeginning.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Duration:";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(66, 20);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(204, 20);
            this.dtpDate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Place:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.lbxMeetingMembers);
            this.groupBox2.Controls.Add(this.lbxMembers);
            this.groupBox2.Location = new System.Drawing.Point(12, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 281);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List of members";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnActiveMember);
            this.panel1.Controls.Add(this.btnInactiveMembers);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(249, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(58, 251);
            this.panel1.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(4, 184);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(51, 37);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnActiveMember
            // 
            this.btnActiveMember.Image = ((System.Drawing.Image)(resources.GetObject("btnActiveMember.Image")));
            this.btnActiveMember.Location = new System.Drawing.Point(3, 59);
            this.btnActiveMember.Name = "btnActiveMember";
            this.btnActiveMember.Size = new System.Drawing.Size(52, 36);
            this.btnActiveMember.TabIndex = 3;
            this.btnActiveMember.UseVisualStyleBackColor = true;
            this.btnActiveMember.Click += new System.EventHandler(this.btnActiveMember_Click);
            // 
            // btnInactiveMembers
            // 
            this.btnInactiveMembers.Image = ((System.Drawing.Image)(resources.GetObject("btnInactiveMembers.Image")));
            this.btnInactiveMembers.Location = new System.Drawing.Point(4, 17);
            this.btnInactiveMembers.Name = "btnInactiveMembers";
            this.btnInactiveMembers.Size = new System.Drawing.Size(51, 36);
            this.btnInactiveMembers.TabIndex = 0;
            this.btnInactiveMembers.UseVisualStyleBackColor = true;
            this.btnInactiveMembers.Click += new System.EventHandler(this.btnInactiveMembers_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(4, 141);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(51, 37);
            this.btnSave.TabIndex = 8;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbxMeetingMembers
            // 
            this.lbxMeetingMembers.DataSource = this.memberBindingSource1;
            this.lbxMeetingMembers.DisplayMember = "NSP";
            this.lbxMeetingMembers.FormattingEnabled = true;
            this.lbxMeetingMembers.Location = new System.Drawing.Point(313, 19);
            this.lbxMeetingMembers.Name = "lbxMeetingMembers";
            this.lbxMeetingMembers.Size = new System.Drawing.Size(245, 251);
            this.lbxMeetingMembers.TabIndex = 1;
            this.lbxMeetingMembers.ValueMember = "Id";
            // 
            // memberBindingSource1
            // 
            this.memberBindingSource1.DataSource = typeof(DumaProject.Core.Entities.Member);
            // 
            // lbxMembers
            // 
            this.lbxMembers.DataSource = this.memberBindingSource;
            this.lbxMembers.DisplayMember = "NSP";
            this.lbxMembers.FormattingEnabled = true;
            this.lbxMembers.Location = new System.Drawing.Point(6, 19);
            this.lbxMembers.Name = "lbxMembers";
            this.lbxMembers.Size = new System.Drawing.Size(237, 251);
            this.lbxMembers.TabIndex = 0;
            this.lbxMembers.ValueMember = "Id";
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataSource = typeof(DumaProject.Core.Entities.Member);
            // 
            // label4
            // 
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(325, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 136);
            this.label4.TabIndex = 8;
            // 
            // AddChangeMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 461);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddChangeMeeting";
            this.Text = "AddChangeMeeting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddChangeMeeting_FormClosing);
            this.Load += new System.EventHandler(this.AddChangeMeeting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEnding;
        private System.Windows.Forms.DateTimePicker dtpBeginning;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnActiveMember;
        private System.Windows.Forms.Button btnInactiveMembers;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox lbxMeetingMembers;
        private System.Windows.Forms.ListBox lbxMembers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxVenue;
        private System.Windows.Forms.BindingSource memberBindingSource1;
        private System.Windows.Forms.BindingSource memberBindingSource;
    }
}