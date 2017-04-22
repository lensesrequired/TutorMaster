﻿namespace TutorMaster
{
    partial class EditStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditStudentForm));
            this.txtPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.cbxTutee = new System.Windows.Forms.CheckBox();
            this.cbxTutor = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.lblTClasses = new System.Windows.Forms.Label();
            this.tvClasses = new System.Windows.Forms.TreeView();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(29, 209);
            this.txtPhoneNumber.Mask = "(999) 000-0000";
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNumber.TabIndex = 22;
            // 
            // cbxTutee
            // 
            this.cbxTutee.AutoSize = true;
            this.cbxTutee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxTutee.Location = new System.Drawing.Point(32, 299);
            this.cbxTutee.Name = "cbxTutee";
            this.cbxTutee.Size = new System.Drawing.Size(52, 17);
            this.cbxTutee.TabIndex = 34;
            this.cbxTutee.Text = "Tutee";
            this.cbxTutee.UseVisualStyleBackColor = true;
            // 
            // cbxTutor
            // 
            this.cbxTutor.AutoSize = true;
            this.cbxTutor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxTutor.Location = new System.Drawing.Point(32, 275);
            this.cbxTutor.Name = "cbxTutor";
            this.cbxTutor.Size = new System.Drawing.Size(49, 17);
            this.cbxTutor.TabIndex = 33;
            this.cbxTutor.Text = "Tutor";
            this.cbxTutor.UseVisualStyleBackColor = true;
            this.cbxTutor.CheckStateChanged += new System.EventHandler(this.cbxTutor_CheckStateChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Create New Student!";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(222)))), ((int)(((byte)(229)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(56, 351);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 23);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(222)))), ((int)(((byte)(229)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(56, 322);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 23);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "First Name";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(29, 247);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 23;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(29, 167);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 21;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(29, 125);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 20;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(29, 82);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(100, 20);
            this.txtLastname.TabIndex = 19;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(29, 43);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(100, 20);
            this.txtFirstname.TabIndex = 18;
            // 
            // lblTClasses
            // 
            this.lblTClasses.AutoSize = true;
            this.lblTClasses.Location = new System.Drawing.Point(265, 22);
            this.lblTClasses.Name = "lblTClasses";
            this.lblTClasses.Size = new System.Drawing.Size(74, 13);
            this.lblTClasses.TabIndex = 37;
            this.lblTClasses.Text = "Tutor Classes:";
            this.lblTClasses.Visible = false;
            // 
            // tvClasses
            // 
            this.tvClasses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.tvClasses.Location = new System.Drawing.Point(265, 41);
            this.tvClasses.Name = "tvClasses";
            this.tvClasses.Size = new System.Drawing.Size(205, 304);
            this.tvClasses.TabIndex = 36;
            this.tvClasses.Visible = false;
            this.tvClasses.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvClasses_AfterCheck);
            // 
            // imgLogo
            // 
            this.imgLogo.Image = global::TutorMaster.Properties.Resources.WatermarkR2;
            this.imgLogo.Location = new System.Drawing.Point(171, 351);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(69, 66);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 38;
            this.imgLogo.TabStop = false;
            // 
            // EditStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(237, 416);
            this.Controls.Add(this.lblTClasses);
            this.Controls.Add(this.tvClasses);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.cbxTutee);
            this.Controls.Add(this.cbxTutor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.imgLogo);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(71)))), ((int)(((byte)(76)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditStudentForm";
            this.Text = "TutorMaster";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditStudentForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtPhoneNumber;
        private System.Windows.Forms.CheckBox cbxTutee;
        private System.Windows.Forms.CheckBox cbxTutor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label lblTClasses;
        private System.Windows.Forms.TreeView tvClasses;
        private System.Windows.Forms.PictureBox imgLogo;
    }
}