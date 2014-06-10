namespace DumaProject.UI
{
    partial class AddChangeComission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddChangeComission));
            this.cmbxPresident = new System.Windows.Forms.ComboBox();
            this.memberBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbxProfile = new System.Windows.Forms.ComboBox();
            this.profileCommissionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnActiveMember = new System.Windows.Forms.Button();
            this.btnInactiveMember = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbxCommissionMembers = new System.Windows.Forms.ListBox();
            this.memberBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lbxMembers = new System.Windows.Forms.ListBox();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileCommissionBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbxPresident
            // 
            this.cmbxPresident.DataSource = this.memberBindingSource2;
            this.cmbxPresident.DisplayMember = "NSP";
            this.cmbxPresident.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxPresident.FormattingEnabled = true;
            this.cmbxPresident.Location = new System.Drawing.Point(128, 82);
            this.cmbxPresident.Name = "cmbxPresident";
            this.cmbxPresident.Size = new System.Drawing.Size(174, 21);
            this.cmbxPresident.TabIndex = 4;
            this.cmbxPresident.ValueMember = "Id";
            // 
            // memberBindingSource2
            // 
            this.memberBindingSource2.DataSource = typeof(DumaProject.Core.Entities.Member);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(128, 30);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(174, 20);
            this.tbxName.TabIndex = 2;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbxProfile);
            this.groupBox1.Controls.Add(this.tbxName);
            this.groupBox1.Controls.Add(this.cmbxPresident);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(15, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 123);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // cmbxProfile
            // 
            this.cmbxProfile.DataSource = this.profileCommissionBindingSource;
            this.cmbxProfile.DisplayMember = "Description";
            this.cmbxProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxProfile.FormattingEnabled = true;
            this.cmbxProfile.Location = new System.Drawing.Point(128, 55);
            this.cmbxProfile.Name = "cmbxProfile";
            this.cmbxProfile.Size = new System.Drawing.Size(174, 21);
            this.cmbxProfile.TabIndex = 5;
            this.cmbxProfile.ValueMember = "Id";
            // 
            // profileCommissionBindingSource
            // 
            this.profileCommissionBindingSource.DataSource = typeof(DumaProject.Core.Entities.ProfileCommission);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbxCommissionMembers);
            this.groupBox2.Controls.Add(this.lbxMembers);
            this.groupBox2.Location = new System.Drawing.Point(329, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 273);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List of members";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnActiveMember);
            this.panel1.Controls.Add(this.btnInactiveMember);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(451, 288);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 52);
            this.panel1.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(175, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(51, 36);
            this.btnExit.TabIndex = 9;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnActiveMember
            // 
            this.btnActiveMember.Image = ((System.Drawing.Image)(resources.GetObject("btnActiveMember.Image")));
            this.btnActiveMember.Location = new System.Drawing.Point(117, 7);
            this.btnActiveMember.Name = "btnActiveMember";
            this.btnActiveMember.Size = new System.Drawing.Size(52, 36);
            this.btnActiveMember.TabIndex = 3;
            this.btnActiveMember.UseVisualStyleBackColor = true;
            this.btnActiveMember.Click += new System.EventHandler(this.btnActiveMember_Click);
            // 
            // btnInactiveMember
            // 
            this.btnInactiveMember.Image = ((System.Drawing.Image)(resources.GetObject("btnInactiveMember.Image")));
            this.btnInactiveMember.Location = new System.Drawing.Point(60, 7);
            this.btnInactiveMember.Name = "btnInactiveMember";
            this.btnInactiveMember.Size = new System.Drawing.Size(51, 37);
            this.btnInactiveMember.TabIndex = 0;
            this.btnInactiveMember.UseVisualStyleBackColor = true;
            this.btnInactiveMember.Click += new System.EventHandler(this.btnInactiveMember_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(3, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(51, 37);
            this.btnSave.TabIndex = 8;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbxCommissionMembers
            // 
            this.lbxCommissionMembers.DataSource = this.memberBindingSource1;
            this.lbxCommissionMembers.DisplayMember = "NSP";
            this.lbxCommissionMembers.FormattingEnabled = true;
            this.lbxCommissionMembers.Location = new System.Drawing.Point(239, 19);
            this.lbxCommissionMembers.Name = "lbxCommissionMembers";
            this.lbxCommissionMembers.Size = new System.Drawing.Size(213, 238);
            this.lbxCommissionMembers.TabIndex = 0;
            this.lbxCommissionMembers.ValueMember = "Id";
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
            this.lbxMembers.Location = new System.Drawing.Point(16, 19);
            this.lbxMembers.Name = "lbxMembers";
            this.lbxMembers.Size = new System.Drawing.Size(217, 238);
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
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 201);
            this.label4.TabIndex = 7;
            // 
            // AddChangeComission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(806, 348);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "AddChangeComission";
            this.Text = "Add comission";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddChangeComission_FormClosing);
            this.Load += new System.EventHandler(this.AddChangeComission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileCommissionBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbxPresident;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnActiveMember;
        private System.Windows.Forms.Button btnInactiveMember;
        private System.Windows.Forms.ListBox lbxCommissionMembers;
        private System.Windows.Forms.ListBox lbxMembers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cmbxProfile;
        private System.Windows.Forms.BindingSource profileCommissionBindingSource;
        private System.Windows.Forms.BindingSource memberBindingSource1;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private System.Windows.Forms.BindingSource memberBindingSource2;
    }
}