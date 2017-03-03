﻿namespace TutorMaster
{
    partial class AdminMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMain));
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tabStudent = new System.Windows.Forms.TabPage();
            this.lvStudent = new System.Windows.Forms.ListView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreateStudent = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tabCommitments = new System.Windows.Forms.TabPage();
            this.tabAppointments = new System.Windows.Forms.TabControl();
            this.tabAccepted = new System.Windows.Forms.TabPage();
            this.cbxAccepted = new System.Windows.Forms.CheckedListBox();
            this.tabPendingTutee = new System.Windows.Forms.TabPage();
            this.cbxPendingTutee = new System.Windows.Forms.CheckedListBox();
            this.tabPendingTutor = new System.Windows.Forms.TabPage();
            this.cbxPendingTutor = new System.Windows.Forms.CheckedListBox();
            this.btnCreateSession = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabAdmin.SuspendLayout();
            this.tabStudent.SuspendLayout();
            this.tabCommitments.SuspendLayout();
            this.tabAppointments.SuspendLayout();
            this.tabAccepted.SuspendLayout();
            this.tabPendingTutee.SuspendLayout();
            this.tabPendingTutor.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.tabStudent);
            this.tabAdmin.Controls.Add(this.tabCommitments);
            this.tabAdmin.Location = new System.Drawing.Point(12, 39);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(625, 373);
            this.tabAdmin.TabIndex = 0;
            // 
            // tabStudent
            // 
            this.tabStudent.Controls.Add(this.lvStudent);
            this.tabStudent.Controls.Add(this.btnDelete);
            this.tabStudent.Controls.Add(this.btnCreateStudent);
            this.tabStudent.Controls.Add(this.btnEdit);
            this.tabStudent.Location = new System.Drawing.Point(4, 22);
            this.tabStudent.Name = "tabStudent";
            this.tabStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudent.Size = new System.Drawing.Size(617, 347);
            this.tabStudent.TabIndex = 0;
            this.tabStudent.Text = "Students";
            this.tabStudent.UseVisualStyleBackColor = true;
            // 
            // lvStudent
            // 
            this.lvStudent.Location = new System.Drawing.Point(6, 7);
            this.lvStudent.Name = "lvStudent";
            this.lvStudent.Size = new System.Drawing.Size(604, 306);
            this.lvStudent.TabIndex = 0;
            this.lvStudent.UseCompatibleStateImageBehavior = false;
            this.lvStudent.View = System.Windows.Forms.View.Details;
            this.lvStudent.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvStudent_ItemChecked);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(279, 318);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Student";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreateStudent
            // 
            this.btnCreateStudent.Location = new System.Drawing.Point(7, 318);
            this.btnCreateStudent.Name = "btnCreateStudent";
            this.btnCreateStudent.Size = new System.Drawing.Size(130, 23);
            this.btnCreateStudent.TabIndex = 2;
            this.btnCreateStudent.Text = "Create New Student";
            this.btnCreateStudent.UseVisualStyleBackColor = true;
            this.btnCreateStudent.Click += new System.EventHandler(this.btnCreateStudent_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(143, 318);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(130, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit Student Account";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tabCommitments
            // 
            this.tabCommitments.Controls.Add(this.tabAppointments);
            this.tabCommitments.Controls.Add(this.btnCreateSession);
            this.tabCommitments.Location = new System.Drawing.Point(4, 22);
            this.tabCommitments.Name = "tabCommitments";
            this.tabCommitments.Padding = new System.Windows.Forms.Padding(3);
            this.tabCommitments.Size = new System.Drawing.Size(617, 347);
            this.tabCommitments.TabIndex = 1;
            this.tabCommitments.Text = "Commitments";
            this.tabCommitments.UseVisualStyleBackColor = true;
            // 
            // tabAppointments
            // 
            this.tabAppointments.Controls.Add(this.tabAccepted);
            this.tabAppointments.Controls.Add(this.tabPendingTutee);
            this.tabAppointments.Controls.Add(this.tabPendingTutor);
            this.tabAppointments.Location = new System.Drawing.Point(7, 7);
            this.tabAppointments.Name = "tabAppointments";
            this.tabAppointments.SelectedIndex = 0;
            this.tabAppointments.Size = new System.Drawing.Size(599, 306);
            this.tabAppointments.TabIndex = 0;
            // 
            // tabAccepted
            // 
            this.tabAccepted.Controls.Add(this.cbxAccepted);
            this.tabAccepted.Location = new System.Drawing.Point(4, 22);
            this.tabAccepted.Name = "tabAccepted";
            this.tabAccepted.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccepted.Size = new System.Drawing.Size(591, 280);
            this.tabAccepted.TabIndex = 0;
            this.tabAccepted.Text = "Accepted";
            this.tabAccepted.UseVisualStyleBackColor = true;
            // 
            // cbxAccepted
            // 
            this.cbxAccepted.FormattingEnabled = true;
            this.cbxAccepted.Location = new System.Drawing.Point(3, 6);
            this.cbxAccepted.Name = "cbxAccepted";
            this.cbxAccepted.Size = new System.Drawing.Size(582, 274);
            this.cbxAccepted.TabIndex = 0;
            // 
            // tabPendingTutee
            // 
            this.tabPendingTutee.Controls.Add(this.cbxPendingTutee);
            this.tabPendingTutee.Location = new System.Drawing.Point(4, 22);
            this.tabPendingTutee.Name = "tabPendingTutee";
            this.tabPendingTutee.Padding = new System.Windows.Forms.Padding(3);
            this.tabPendingTutee.Size = new System.Drawing.Size(591, 280);
            this.tabPendingTutee.TabIndex = 1;
            this.tabPendingTutee.Text = "Pending Tutee";
            this.tabPendingTutee.UseVisualStyleBackColor = true;
            // 
            // cbxPendingTutee
            // 
            this.cbxPendingTutee.FormattingEnabled = true;
            this.cbxPendingTutee.Location = new System.Drawing.Point(3, 3);
            this.cbxPendingTutee.Name = "cbxPendingTutee";
            this.cbxPendingTutee.Size = new System.Drawing.Size(582, 274);
            this.cbxPendingTutee.TabIndex = 0;
            // 
            // tabPendingTutor
            // 
            this.tabPendingTutor.Controls.Add(this.cbxPendingTutor);
            this.tabPendingTutor.Location = new System.Drawing.Point(4, 22);
            this.tabPendingTutor.Name = "tabPendingTutor";
            this.tabPendingTutor.Size = new System.Drawing.Size(591, 280);
            this.tabPendingTutor.TabIndex = 2;
            this.tabPendingTutor.Text = "Pending Tutor";
            this.tabPendingTutor.UseVisualStyleBackColor = true;
            // 
            // cbxPendingTutor
            // 
            this.cbxPendingTutor.FormattingEnabled = true;
            this.cbxPendingTutor.Location = new System.Drawing.Point(0, 3);
            this.cbxPendingTutor.Name = "cbxPendingTutor";
            this.cbxPendingTutor.Size = new System.Drawing.Size(591, 274);
            this.cbxPendingTutor.TabIndex = 0;
            // 
            // btnCreateSession
            // 
            this.btnCreateSession.Location = new System.Drawing.Point(7, 319);
            this.btnCreateSession.Name = "btnCreateSession";
            this.btnCreateSession.Size = new System.Drawing.Size(144, 23);
            this.btnCreateSession.TabIndex = 1;
            this.btnCreateSession.Text = "Create Session";
            this.btnCreateSession.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(479, 10);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(144, 23);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 422);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tabAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminMain";
            this.Text = "AdminMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminMain_FormClosed);
            this.tabAdmin.ResumeLayout(false);
            this.tabStudent.ResumeLayout(false);
            this.tabCommitments.ResumeLayout(false);
            this.tabAppointments.ResumeLayout(false);
            this.tabAccepted.ResumeLayout(false);
            this.tabPendingTutee.ResumeLayout(false);
            this.tabPendingTutor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.TabPage tabStudent;
        private System.Windows.Forms.TabPage tabCommitments;
        private System.Windows.Forms.TabControl tabAppointments;
        private System.Windows.Forms.TabPage tabAccepted;
        private System.Windows.Forms.CheckedListBox cbxAccepted;
        private System.Windows.Forms.TabPage tabPendingTutee;
        private System.Windows.Forms.CheckedListBox cbxPendingTutee;
        private System.Windows.Forms.TabPage tabPendingTutor;
        private System.Windows.Forms.CheckedListBox cbxPendingTutor;
        private System.Windows.Forms.Button btnCreateSession;
        private System.Windows.Forms.Button btnCreateStudent;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ListView lvStudent;
    }
}