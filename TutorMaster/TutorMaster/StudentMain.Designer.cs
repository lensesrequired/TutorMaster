﻿namespace TutorMaster
{
    partial class StudentMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentMain));
            this.weekStartDateTime = new System.Windows.Forms.DateTimePicker();
            this.cbxWeekly = new System.Windows.Forms.CheckBox();
            this.dayTabs = new System.Windows.Forms.TabControl();
            this.tabSunday = new System.Windows.Forms.TabPage();
            this.lblSunday = new System.Windows.Forms.Label();
            this.lvSunday = new System.Windows.Forms.ListView();
            this.tabMonday = new System.Windows.Forms.TabPage();
            this.lblMonday = new System.Windows.Forms.Label();
            this.lvMonday = new System.Windows.Forms.ListView();
            this.tabTuesday = new System.Windows.Forms.TabPage();
            this.lblTuesday = new System.Windows.Forms.Label();
            this.lvTuesday = new System.Windows.Forms.ListView();
            this.tabWednesday = new System.Windows.Forms.TabPage();
            this.lblWednesday = new System.Windows.Forms.Label();
            this.lvWednesday = new System.Windows.Forms.ListView();
            this.tabThursday = new System.Windows.Forms.TabPage();
            this.lblThursday = new System.Windows.Forms.Label();
            this.lvThursday = new System.Windows.Forms.ListView();
            this.tabFriday = new System.Windows.Forms.TabPage();
            this.lblFriday = new System.Windows.Forms.Label();
            this.lvFriday = new System.Windows.Forms.ListView();
            this.tabSaturday = new System.Windows.Forms.TabPage();
            this.lblSaturday = new System.Windows.Forms.Label();
            this.lvSaturday = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddOpenBlock = new System.Windows.Forms.Button();
            this.combEndAmPm = new System.Windows.Forms.ComboBox();
            this.combEndMinute = new System.Windows.Forms.ComboBox();
            this.combEndHour = new System.Windows.Forms.ComboBox();
            this.combStartAmPm = new System.Windows.Forms.ComboBox();
            this.combStartMinute = new System.Windows.Forms.ComboBox();
            this.combStartHour = new System.Windows.Forms.ComboBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnMakeRequest = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSchedule = new System.Windows.Forms.TabPage();
            this.dayEndDateTime = new System.Windows.Forms.DateTimePicker();
            this.dayStartDateTime = new System.Windows.Forms.DateTimePicker();
            this.tabAppointments = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabAccepted = new System.Windows.Forms.TabPage();
            this.btnDeselect1 = new System.Windows.Forms.Button();
            this.btnCancelFinalized = new System.Windows.Forms.Button();
            this.lvFinalized = new System.Windows.Forms.ListView();
            this.tabPendingTutor = new System.Windows.Forms.TabPage();
            this.btnDeselect2 = new System.Windows.Forms.Button();
            this.btnRejectTutor = new System.Windows.Forms.Button();
            this.btnAcceptAddLoc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lvPendingTutor = new System.Windows.Forms.ListView();
            this.lvTutor = new System.Windows.Forms.ListView();
            this.tabPendingTutee = new System.Windows.Forms.TabPage();
            this.btnDeselect3 = new System.Windows.Forms.Button();
            this.btnRejectTutee = new System.Windows.Forms.Button();
            this.btnFinalize = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lvTutee = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.lvPendingTutee = new System.Windows.Forms.ListView();
            this.label10 = new System.Windows.Forms.Label();
            this.dayTabs.SuspendLayout();
            this.tabSunday.SuspendLayout();
            this.tabMonday.SuspendLayout();
            this.tabTuesday.SuspendLayout();
            this.tabWednesday.SuspendLayout();
            this.tabThursday.SuspendLayout();
            this.tabFriday.SuspendLayout();
            this.tabSaturday.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabSchedule.SuspendLayout();
            this.tabAppointments.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabAccepted.SuspendLayout();
            this.tabPendingTutor.SuspendLayout();
            this.tabPendingTutee.SuspendLayout();
            this.SuspendLayout();
            // 
            // weekStartDateTime
            // 
            this.weekStartDateTime.Location = new System.Drawing.Point(733, 59);
            this.weekStartDateTime.MaxDate = new System.DateTime(2017, 4, 30, 0, 0, 0, 0);
            this.weekStartDateTime.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.weekStartDateTime.Name = "weekStartDateTime";
            this.weekStartDateTime.Size = new System.Drawing.Size(200, 20);
            this.weekStartDateTime.TabIndex = 13;
            this.weekStartDateTime.Value = new System.DateTime(2017, 3, 23, 0, 0, 0, 0);
            this.weekStartDateTime.CloseUp += new System.EventHandler(this.weekStartDateTime_ValueChanged);
            // 
            // cbxWeekly
            // 
            this.cbxWeekly.AutoSize = true;
            this.cbxWeekly.Location = new System.Drawing.Point(505, 330);
            this.cbxWeekly.Name = "cbxWeekly";
            this.cbxWeekly.Size = new System.Drawing.Size(62, 17);
            this.cbxWeekly.TabIndex = 12;
            this.cbxWeekly.Text = "Weekly";
            this.cbxWeekly.UseVisualStyleBackColor = true;
            // 
            // dayTabs
            // 
            this.dayTabs.Controls.Add(this.tabSunday);
            this.dayTabs.Controls.Add(this.tabMonday);
            this.dayTabs.Controls.Add(this.tabTuesday);
            this.dayTabs.Controls.Add(this.tabWednesday);
            this.dayTabs.Controls.Add(this.tabThursday);
            this.dayTabs.Controls.Add(this.tabFriday);
            this.dayTabs.Controls.Add(this.tabSaturday);
            this.dayTabs.Location = new System.Drawing.Point(3, 6);
            this.dayTabs.Name = "dayTabs";
            this.dayTabs.SelectedIndex = 0;
            this.dayTabs.Size = new System.Drawing.Size(685, 316);
            this.dayTabs.TabIndex = 9;
            // 
            // tabSunday
            // 
            this.tabSunday.Controls.Add(this.lblSunday);
            this.tabSunday.Controls.Add(this.lvSunday);
            this.tabSunday.Location = new System.Drawing.Point(4, 22);
            this.tabSunday.Name = "tabSunday";
            this.tabSunday.Padding = new System.Windows.Forms.Padding(3);
            this.tabSunday.Size = new System.Drawing.Size(677, 290);
            this.tabSunday.TabIndex = 0;
            this.tabSunday.Text = "Sunday";
            this.tabSunday.UseVisualStyleBackColor = true;
            // 
            // lblSunday
            // 
            this.lblSunday.AutoSize = true;
            this.lblSunday.Location = new System.Drawing.Point(6, 3);
            this.lblSunday.Name = "lblSunday";
            this.lblSunday.Size = new System.Drawing.Size(35, 13);
            this.lblSunday.TabIndex = 14;
            this.lblSunday.Text = "label3";
            // 
            // lvSunday
            // 
            this.lvSunday.Location = new System.Drawing.Point(0, 19);
            this.lvSunday.Name = "lvSunday";
            this.lvSunday.Size = new System.Drawing.Size(677, 271);
            this.lvSunday.TabIndex = 0;
            this.lvSunday.UseCompatibleStateImageBehavior = false;
            this.lvSunday.View = System.Windows.Forms.View.Details;
            // 
            // tabMonday
            // 
            this.tabMonday.Controls.Add(this.lblMonday);
            this.tabMonday.Controls.Add(this.lvMonday);
            this.tabMonday.Location = new System.Drawing.Point(4, 22);
            this.tabMonday.Name = "tabMonday";
            this.tabMonday.Padding = new System.Windows.Forms.Padding(3);
            this.tabMonday.Size = new System.Drawing.Size(677, 290);
            this.tabMonday.TabIndex = 1;
            this.tabMonday.Text = "Monday";
            this.tabMonday.UseVisualStyleBackColor = true;
            // 
            // lblMonday
            // 
            this.lblMonday.AutoSize = true;
            this.lblMonday.Location = new System.Drawing.Point(6, 3);
            this.lblMonday.Name = "lblMonday";
            this.lblMonday.Size = new System.Drawing.Size(35, 13);
            this.lblMonday.TabIndex = 2;
            this.lblMonday.Text = "label4";
            // 
            // lvMonday
            // 
            this.lvMonday.Location = new System.Drawing.Point(0, 19);
            this.lvMonday.Name = "lvMonday";
            this.lvMonday.Size = new System.Drawing.Size(677, 271);
            this.lvMonday.TabIndex = 1;
            this.lvMonday.UseCompatibleStateImageBehavior = false;
            this.lvMonday.View = System.Windows.Forms.View.Details;
            // 
            // tabTuesday
            // 
            this.tabTuesday.Controls.Add(this.lblTuesday);
            this.tabTuesday.Controls.Add(this.lvTuesday);
            this.tabTuesday.Location = new System.Drawing.Point(4, 22);
            this.tabTuesday.Name = "tabTuesday";
            this.tabTuesday.Size = new System.Drawing.Size(677, 290);
            this.tabTuesday.TabIndex = 2;
            this.tabTuesday.Text = "Tuesday";
            this.tabTuesday.UseVisualStyleBackColor = true;
            // 
            // lblTuesday
            // 
            this.lblTuesday.AutoSize = true;
            this.lblTuesday.Location = new System.Drawing.Point(6, 3);
            this.lblTuesday.Name = "lblTuesday";
            this.lblTuesday.Size = new System.Drawing.Size(35, 13);
            this.lblTuesday.TabIndex = 2;
            this.lblTuesday.Text = "label5";
            // 
            // lvTuesday
            // 
            this.lvTuesday.Location = new System.Drawing.Point(0, 19);
            this.lvTuesday.Name = "lvTuesday";
            this.lvTuesday.Size = new System.Drawing.Size(677, 271);
            this.lvTuesday.TabIndex = 1;
            this.lvTuesday.UseCompatibleStateImageBehavior = false;
            this.lvTuesday.View = System.Windows.Forms.View.Details;
            // 
            // tabWednesday
            // 
            this.tabWednesday.Controls.Add(this.lblWednesday);
            this.tabWednesday.Controls.Add(this.lvWednesday);
            this.tabWednesday.Location = new System.Drawing.Point(4, 22);
            this.tabWednesday.Name = "tabWednesday";
            this.tabWednesday.Size = new System.Drawing.Size(677, 290);
            this.tabWednesday.TabIndex = 3;
            this.tabWednesday.Text = "Wednesday";
            this.tabWednesday.UseVisualStyleBackColor = true;
            // 
            // lblWednesday
            // 
            this.lblWednesday.AutoSize = true;
            this.lblWednesday.Location = new System.Drawing.Point(6, 3);
            this.lblWednesday.Name = "lblWednesday";
            this.lblWednesday.Size = new System.Drawing.Size(35, 13);
            this.lblWednesday.TabIndex = 2;
            this.lblWednesday.Text = "label6";
            // 
            // lvWednesday
            // 
            this.lvWednesday.Location = new System.Drawing.Point(0, 19);
            this.lvWednesday.Name = "lvWednesday";
            this.lvWednesday.Size = new System.Drawing.Size(677, 271);
            this.lvWednesday.TabIndex = 1;
            this.lvWednesday.UseCompatibleStateImageBehavior = false;
            this.lvWednesday.View = System.Windows.Forms.View.Details;
            // 
            // tabThursday
            // 
            this.tabThursday.Controls.Add(this.lblThursday);
            this.tabThursday.Controls.Add(this.lvThursday);
            this.tabThursday.Location = new System.Drawing.Point(4, 22);
            this.tabThursday.Name = "tabThursday";
            this.tabThursday.Size = new System.Drawing.Size(677, 290);
            this.tabThursday.TabIndex = 4;
            this.tabThursday.Text = "Thursday";
            this.tabThursday.UseVisualStyleBackColor = true;
            // 
            // lblThursday
            // 
            this.lblThursday.AutoSize = true;
            this.lblThursday.Location = new System.Drawing.Point(6, 3);
            this.lblThursday.Name = "lblThursday";
            this.lblThursday.Size = new System.Drawing.Size(35, 13);
            this.lblThursday.TabIndex = 2;
            this.lblThursday.Text = "label7";
            // 
            // lvThursday
            // 
            this.lvThursday.Location = new System.Drawing.Point(0, 19);
            this.lvThursday.Name = "lvThursday";
            this.lvThursday.Size = new System.Drawing.Size(677, 271);
            this.lvThursday.TabIndex = 1;
            this.lvThursday.UseCompatibleStateImageBehavior = false;
            this.lvThursday.View = System.Windows.Forms.View.Details;
            // 
            // tabFriday
            // 
            this.tabFriday.Controls.Add(this.lblFriday);
            this.tabFriday.Controls.Add(this.lvFriday);
            this.tabFriday.Location = new System.Drawing.Point(4, 22);
            this.tabFriday.Name = "tabFriday";
            this.tabFriday.Size = new System.Drawing.Size(677, 290);
            this.tabFriday.TabIndex = 5;
            this.tabFriday.Text = "Friday";
            this.tabFriday.UseVisualStyleBackColor = true;
            // 
            // lblFriday
            // 
            this.lblFriday.AutoSize = true;
            this.lblFriday.Location = new System.Drawing.Point(6, 3);
            this.lblFriday.Name = "lblFriday";
            this.lblFriday.Size = new System.Drawing.Size(35, 13);
            this.lblFriday.TabIndex = 2;
            this.lblFriday.Text = "label8";
            // 
            // lvFriday
            // 
            this.lvFriday.Location = new System.Drawing.Point(0, 19);
            this.lvFriday.Name = "lvFriday";
            this.lvFriday.Size = new System.Drawing.Size(677, 271);
            this.lvFriday.TabIndex = 1;
            this.lvFriday.UseCompatibleStateImageBehavior = false;
            this.lvFriday.View = System.Windows.Forms.View.Details;
            // 
            // tabSaturday
            // 
            this.tabSaturday.Controls.Add(this.lblSaturday);
            this.tabSaturday.Controls.Add(this.lvSaturday);
            this.tabSaturday.Location = new System.Drawing.Point(4, 22);
            this.tabSaturday.Name = "tabSaturday";
            this.tabSaturday.Size = new System.Drawing.Size(677, 290);
            this.tabSaturday.TabIndex = 6;
            this.tabSaturday.Text = "Saturday";
            this.tabSaturday.UseVisualStyleBackColor = true;
            // 
            // lblSaturday
            // 
            this.lblSaturday.AutoSize = true;
            this.lblSaturday.Location = new System.Drawing.Point(6, 3);
            this.lblSaturday.Name = "lblSaturday";
            this.lblSaturday.Size = new System.Drawing.Size(35, 13);
            this.lblSaturday.TabIndex = 2;
            this.lblSaturday.Text = "label9";
            // 
            // lvSaturday
            // 
            this.lvSaturday.Location = new System.Drawing.Point(0, 19);
            this.lvSaturday.Name = "lvSaturday";
            this.lvSaturday.Size = new System.Drawing.Size(677, 271);
            this.lvSaturday.TabIndex = 1;
            this.lvSaturday.UseCompatibleStateImageBehavior = false;
            this.lvSaturday.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Availability End Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Availability Start Time:";
            // 
            // btnAddOpenBlock
            // 
            this.btnAddOpenBlock.Location = new System.Drawing.Point(505, 351);
            this.btnAddOpenBlock.Name = "btnAddOpenBlock";
            this.btnAddOpenBlock.Size = new System.Drawing.Size(105, 23);
            this.btnAddOpenBlock.TabIndex = 6;
            this.btnAddOpenBlock.Text = "Add Availability";
            this.btnAddOpenBlock.UseVisualStyleBackColor = true;
            this.btnAddOpenBlock.Click += new System.EventHandler(this.btnAddOpenBlock_Click);
            // 
            // combEndAmPm
            // 
            this.combEndAmPm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combEndAmPm.FormattingEnabled = true;
            this.combEndAmPm.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.combEndAmPm.Location = new System.Drawing.Point(435, 355);
            this.combEndAmPm.Name = "combEndAmPm";
            this.combEndAmPm.Size = new System.Drawing.Size(50, 21);
            this.combEndAmPm.TabIndex = 5;
            // 
            // combEndMinute
            // 
            this.combEndMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combEndMinute.FormattingEnabled = true;
            this.combEndMinute.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.combEndMinute.Location = new System.Drawing.Point(380, 355);
            this.combEndMinute.Name = "combEndMinute";
            this.combEndMinute.Size = new System.Drawing.Size(49, 21);
            this.combEndMinute.TabIndex = 4;
            // 
            // combEndHour
            // 
            this.combEndHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combEndHour.FormattingEnabled = true;
            this.combEndHour.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.combEndHour.Location = new System.Drawing.Point(330, 355);
            this.combEndHour.Name = "combEndHour";
            this.combEndHour.Size = new System.Drawing.Size(44, 21);
            this.combEndHour.TabIndex = 3;
            // 
            // combStartAmPm
            // 
            this.combStartAmPm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combStartAmPm.FormattingEnabled = true;
            this.combStartAmPm.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.combStartAmPm.Location = new System.Drawing.Point(435, 328);
            this.combStartAmPm.Name = "combStartAmPm";
            this.combStartAmPm.Size = new System.Drawing.Size(50, 21);
            this.combStartAmPm.TabIndex = 2;
            // 
            // combStartMinute
            // 
            this.combStartMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combStartMinute.FormattingEnabled = true;
            this.combStartMinute.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.combStartMinute.Location = new System.Drawing.Point(380, 328);
            this.combStartMinute.Name = "combStartMinute";
            this.combStartMinute.Size = new System.Drawing.Size(49, 21);
            this.combStartMinute.TabIndex = 1;
            // 
            // combStartHour
            // 
            this.combStartHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combStartHour.FormattingEnabled = true;
            this.combStartHour.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.combStartHour.Location = new System.Drawing.Point(330, 328);
            this.combStartHour.Name = "combStartHour";
            this.combStartHour.Size = new System.Drawing.Size(44, 21);
            this.combStartHour.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(736, 85);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(197, 23);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnMakeRequest
            // 
            this.btnMakeRequest.Location = new System.Drawing.Point(736, 114);
            this.btnMakeRequest.Name = "btnMakeRequest";
            this.btnMakeRequest.Size = new System.Drawing.Size(197, 23);
            this.btnMakeRequest.TabIndex = 2;
            this.btnMakeRequest.Text = "Make Request";
            this.btnMakeRequest.UseVisualStyleBackColor = true;
            this.btnMakeRequest.Click += new System.EventHandler(this.btnMakeRequest_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSchedule);
            this.tabControl1.Controls.Add(this.tabAppointments);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(715, 419);
            this.tabControl1.TabIndex = 14;
            // 
            // tabSchedule
            // 
            this.tabSchedule.Controls.Add(this.dayEndDateTime);
            this.tabSchedule.Controls.Add(this.dayStartDateTime);
            this.tabSchedule.Controls.Add(this.dayTabs);
            this.tabSchedule.Controls.Add(this.combStartMinute);
            this.tabSchedule.Controls.Add(this.combStartAmPm);
            this.tabSchedule.Controls.Add(this.btnAddOpenBlock);
            this.tabSchedule.Controls.Add(this.combStartHour);
            this.tabSchedule.Controls.Add(this.combEndAmPm);
            this.tabSchedule.Controls.Add(this.combEndMinute);
            this.tabSchedule.Controls.Add(this.cbxWeekly);
            this.tabSchedule.Controls.Add(this.combEndHour);
            this.tabSchedule.Controls.Add(this.label2);
            this.tabSchedule.Controls.Add(this.label1);
            this.tabSchedule.Location = new System.Drawing.Point(4, 22);
            this.tabSchedule.Name = "tabSchedule";
            this.tabSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tabSchedule.Size = new System.Drawing.Size(707, 393);
            this.tabSchedule.TabIndex = 1;
            this.tabSchedule.Text = "Schedule";
            this.tabSchedule.UseVisualStyleBackColor = true;
            // 
            // dayEndDateTime
            // 
            this.dayEndDateTime.Location = new System.Drawing.Point(124, 356);
            this.dayEndDateTime.MaxDate = new System.DateTime(2017, 4, 30, 0, 0, 0, 0);
            this.dayEndDateTime.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dayEndDateTime.Name = "dayEndDateTime";
            this.dayEndDateTime.Size = new System.Drawing.Size(200, 20);
            this.dayEndDateTime.TabIndex = 14;
            this.dayEndDateTime.Value = new System.DateTime(2017, 3, 23, 0, 0, 0, 0);
            // 
            // dayStartDateTime
            // 
            this.dayStartDateTime.Location = new System.Drawing.Point(124, 329);
            this.dayStartDateTime.MaxDate = new System.DateTime(2017, 4, 30, 0, 0, 0, 0);
            this.dayStartDateTime.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dayStartDateTime.Name = "dayStartDateTime";
            this.dayStartDateTime.Size = new System.Drawing.Size(200, 20);
            this.dayStartDateTime.TabIndex = 13;
            this.dayStartDateTime.Value = new System.DateTime(2017, 3, 23, 0, 0, 0, 0);
            // 
            // tabAppointments
            // 
            this.tabAppointments.Controls.Add(this.tabControl2);
            this.tabAppointments.Location = new System.Drawing.Point(4, 22);
            this.tabAppointments.Name = "tabAppointments";
            this.tabAppointments.Size = new System.Drawing.Size(707, 393);
            this.tabAppointments.TabIndex = 2;
            this.tabAppointments.Text = "Appointments";
            this.tabAppointments.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabAccepted);
            this.tabControl2.Controls.Add(this.tabPendingTutor);
            this.tabControl2.Controls.Add(this.tabPendingTutee);
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(707, 393);
            this.tabControl2.TabIndex = 0;
            this.tabControl2.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.btnDeselect1_Click);
            // 
            // tabAccepted
            // 
            this.tabAccepted.Controls.Add(this.btnDeselect1);
            this.tabAccepted.Controls.Add(this.btnCancelFinalized);
            this.tabAccepted.Controls.Add(this.lvFinalized);
            this.tabAccepted.Location = new System.Drawing.Point(4, 22);
            this.tabAccepted.Name = "tabAccepted";
            this.tabAccepted.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccepted.Size = new System.Drawing.Size(699, 367);
            this.tabAccepted.TabIndex = 0;
            this.tabAccepted.Text = "Finalized Appointments";
            this.tabAccepted.UseVisualStyleBackColor = true;
            // 
            // btnDeselect1
            // 
            this.btnDeselect1.Location = new System.Drawing.Point(592, 336);
            this.btnDeselect1.Name = "btnDeselect1";
            this.btnDeselect1.Size = new System.Drawing.Size(101, 23);
            this.btnDeselect1.TabIndex = 18;
            this.btnDeselect1.Text = "Deselect All";
            this.btnDeselect1.UseVisualStyleBackColor = true;
            this.btnDeselect1.Click += new System.EventHandler(this.btnDeselect1_Click);
            // 
            // btnCancelFinalized
            // 
            this.btnCancelFinalized.Location = new System.Drawing.Point(6, 336);
            this.btnCancelFinalized.Name = "btnCancelFinalized";
            this.btnCancelFinalized.Size = new System.Drawing.Size(177, 23);
            this.btnCancelFinalized.TabIndex = 17;
            this.btnCancelFinalized.Text = "Cancel Appointment(s)";
            this.btnCancelFinalized.UseVisualStyleBackColor = true;
            this.btnCancelFinalized.Click += new System.EventHandler(this.btnCancelFinalized_Click);
            // 
            // lvFinalized
            // 
            this.lvFinalized.Location = new System.Drawing.Point(0, 0);
            this.lvFinalized.Name = "lvFinalized";
            this.lvFinalized.Size = new System.Drawing.Size(699, 330);
            this.lvFinalized.TabIndex = 16;
            this.lvFinalized.UseCompatibleStateImageBehavior = false;
            this.lvFinalized.View = System.Windows.Forms.View.Details;
            this.lvFinalized.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lvFinalized_ColumnWidthChanging);
            this.lvFinalized.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvFinalized_ItemChecked);
            // 
            // tabPendingTutor
            // 
            this.tabPendingTutor.Controls.Add(this.btnDeselect2);
            this.tabPendingTutor.Controls.Add(this.btnRejectTutor);
            this.tabPendingTutor.Controls.Add(this.btnAcceptAddLoc);
            this.tabPendingTutor.Controls.Add(this.label4);
            this.tabPendingTutor.Controls.Add(this.label3);
            this.tabPendingTutor.Controls.Add(this.lvPendingTutor);
            this.tabPendingTutor.Controls.Add(this.lvTutor);
            this.tabPendingTutor.Location = new System.Drawing.Point(4, 22);
            this.tabPendingTutor.Name = "tabPendingTutor";
            this.tabPendingTutor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPendingTutor.Size = new System.Drawing.Size(699, 367);
            this.tabPendingTutor.TabIndex = 1;
            this.tabPendingTutor.Text = "Pending Tutoring Appointments";
            this.tabPendingTutor.UseVisualStyleBackColor = true;
            // 
            // btnDeselect2
            // 
            this.btnDeselect2.Location = new System.Drawing.Point(592, 336);
            this.btnDeselect2.Name = "btnDeselect2";
            this.btnDeselect2.Size = new System.Drawing.Size(101, 23);
            this.btnDeselect2.TabIndex = 23;
            this.btnDeselect2.Text = "Deselect All";
            this.btnDeselect2.UseVisualStyleBackColor = true;
            this.btnDeselect2.Click += new System.EventHandler(this.btnDeselect1_Click);
            // 
            // btnRejectTutor
            // 
            this.btnRejectTutor.Location = new System.Drawing.Point(189, 336);
            this.btnRejectTutor.Name = "btnRejectTutor";
            this.btnRejectTutor.Size = new System.Drawing.Size(177, 23);
            this.btnRejectTutor.TabIndex = 22;
            this.btnRejectTutor.Text = "Reject/Delete Appointment(s)";
            this.btnRejectTutor.UseVisualStyleBackColor = true;
            this.btnRejectTutor.Click += new System.EventHandler(this.btnRejectTutor_Click);
            // 
            // btnAcceptAddLoc
            // 
            this.btnAcceptAddLoc.Location = new System.Drawing.Point(6, 336);
            this.btnAcceptAddLoc.Name = "btnAcceptAddLoc";
            this.btnAcceptAddLoc.Size = new System.Drawing.Size(177, 23);
            this.btnAcceptAddLoc.TabIndex = 21;
            this.btnAcceptAddLoc.Text = "Accept/Add Location";
            this.btnAcceptAddLoc.UseVisualStyleBackColor = true;
            this.btnAcceptAddLoc.Click += new System.EventHandler(this.btnAcceptAddLoc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Appointments waiting on the Tutee\'s Approval";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Appointments waiting for your approval and location proposal";
            // 
            // lvPendingTutor
            // 
            this.lvPendingTutor.Location = new System.Drawing.Point(0, 24);
            this.lvPendingTutor.Name = "lvPendingTutor";
            this.lvPendingTutor.Size = new System.Drawing.Size(699, 140);
            this.lvPendingTutor.TabIndex = 18;
            this.lvPendingTutor.UseCompatibleStateImageBehavior = false;
            this.lvPendingTutor.View = System.Windows.Forms.View.Details;
            this.lvPendingTutor.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lvPendingTutor_ColumnWidthChanging);
            this.lvPendingTutor.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvTutor_ItemChecked);
            // 
            // lvTutor
            // 
            this.lvTutor.Location = new System.Drawing.Point(0, 190);
            this.lvTutor.Name = "lvTutor";
            this.lvTutor.Size = new System.Drawing.Size(699, 140);
            this.lvTutor.TabIndex = 17;
            this.lvTutor.UseCompatibleStateImageBehavior = false;
            this.lvTutor.View = System.Windows.Forms.View.Details;
            this.lvTutor.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lvTutor_ColumnWidthChanging);
            this.lvTutor.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvTutor_ItemChecked);
            // 
            // tabPendingTutee
            // 
            this.tabPendingTutee.Controls.Add(this.btnDeselect3);
            this.tabPendingTutee.Controls.Add(this.btnRejectTutee);
            this.tabPendingTutee.Controls.Add(this.btnFinalize);
            this.tabPendingTutee.Controls.Add(this.label5);
            this.tabPendingTutee.Controls.Add(this.lvTutee);
            this.tabPendingTutee.Controls.Add(this.label6);
            this.tabPendingTutee.Controls.Add(this.lvPendingTutee);
            this.tabPendingTutee.Location = new System.Drawing.Point(4, 22);
            this.tabPendingTutee.Name = "tabPendingTutee";
            this.tabPendingTutee.Size = new System.Drawing.Size(699, 367);
            this.tabPendingTutee.TabIndex = 2;
            this.tabPendingTutee.Text = "Pending Tutee Appointments";
            this.tabPendingTutee.UseVisualStyleBackColor = true;
            // 
            // btnDeselect3
            // 
            this.btnDeselect3.Location = new System.Drawing.Point(592, 336);
            this.btnDeselect3.Name = "btnDeselect3";
            this.btnDeselect3.Size = new System.Drawing.Size(101, 23);
            this.btnDeselect3.TabIndex = 26;
            this.btnDeselect3.Text = "Deselect All";
            this.btnDeselect3.UseVisualStyleBackColor = true;
            this.btnDeselect3.Click += new System.EventHandler(this.btnDeselect1_Click);
            // 
            // btnRejectTutee
            // 
            this.btnRejectTutee.Location = new System.Drawing.Point(189, 336);
            this.btnRejectTutee.Name = "btnRejectTutee";
            this.btnRejectTutee.Size = new System.Drawing.Size(177, 23);
            this.btnRejectTutee.TabIndex = 25;
            this.btnRejectTutee.Text = "Reject/Delete Appointment(s)";
            this.btnRejectTutee.UseVisualStyleBackColor = true;
            // 
            // btnFinalize
            // 
            this.btnFinalize.Location = new System.Drawing.Point(6, 336);
            this.btnFinalize.Name = "btnFinalize";
            this.btnFinalize.Size = new System.Drawing.Size(177, 23);
            this.btnFinalize.TabIndex = 24;
            this.btnFinalize.Text = "Accept Appointment(s)";
            this.btnFinalize.UseVisualStyleBackColor = true;
            this.btnFinalize.Click += new System.EventHandler(this.btnFinalize_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Appointments waiting on tutor approval";
            // 
            // lvTutee
            // 
            this.lvTutee.Location = new System.Drawing.Point(0, 24);
            this.lvTutee.Name = "lvTutee";
            this.lvTutee.Size = new System.Drawing.Size(699, 140);
            this.lvTutee.TabIndex = 22;
            this.lvTutee.UseCompatibleStateImageBehavior = false;
            this.lvTutee.View = System.Windows.Forms.View.Details;
            this.lvTutee.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lvTutee_ColumnWidthChanging);
            this.lvTutee.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lvTutee_ItemCheck);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Appointments waiting for your approval";
            // 
            // lvPendingTutee
            // 
            this.lvPendingTutee.Location = new System.Drawing.Point(0, 190);
            this.lvPendingTutee.Name = "lvPendingTutee";
            this.lvPendingTutee.Size = new System.Drawing.Size(699, 140);
            this.lvPendingTutee.TabIndex = 18;
            this.lvPendingTutee.UseCompatibleStateImageBehavior = false;
            this.lvPendingTutee.View = System.Windows.Forms.View.Details;
            this.lvPendingTutee.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lvPendingTutee_ColumnWidthChanging);
            this.lvPendingTutee.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lvTutee_ItemCheck);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(733, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Date to load schedule a week out from";
            // 
            // StudentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 441);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.weekStartDateTime);
            this.Controls.Add(this.btnMakeRequest);
            this.Controls.Add(this.btnLogout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentMain";
            this.Text = "StudentMain";
            this.dayTabs.ResumeLayout(false);
            this.tabSunday.ResumeLayout(false);
            this.tabSunday.PerformLayout();
            this.tabMonday.ResumeLayout(false);
            this.tabMonday.PerformLayout();
            this.tabTuesday.ResumeLayout(false);
            this.tabTuesday.PerformLayout();
            this.tabWednesday.ResumeLayout(false);
            this.tabWednesday.PerformLayout();
            this.tabThursday.ResumeLayout(false);
            this.tabThursday.PerformLayout();
            this.tabFriday.ResumeLayout(false);
            this.tabFriday.PerformLayout();
            this.tabSaturday.ResumeLayout(false);
            this.tabSaturday.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabSchedule.ResumeLayout(false);
            this.tabSchedule.PerformLayout();
            this.tabAppointments.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabAccepted.ResumeLayout(false);
            this.tabPendingTutor.ResumeLayout(false);
            this.tabPendingTutor.PerformLayout();
            this.tabPendingTutee.ResumeLayout(false);
            this.tabPendingTutee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnMakeRequest;
        private System.Windows.Forms.Button btnAddOpenBlock;
        private System.Windows.Forms.ComboBox combEndAmPm;
        private System.Windows.Forms.ComboBox combEndMinute;
        private System.Windows.Forms.ComboBox combEndHour;
        private System.Windows.Forms.ComboBox combStartAmPm;
        private System.Windows.Forms.ComboBox combStartMinute;
        private System.Windows.Forms.ComboBox combStartHour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl dayTabs;
        private System.Windows.Forms.TabPage tabSunday;
        private System.Windows.Forms.TabPage tabMonday;
        private System.Windows.Forms.TabPage tabTuesday;
        private System.Windows.Forms.TabPage tabWednesday;
        private System.Windows.Forms.TabPage tabThursday;
        private System.Windows.Forms.TabPage tabFriday;
        private System.Windows.Forms.TabPage tabSaturday;
        private System.Windows.Forms.ListView lvSunday;
        private System.Windows.Forms.ListView lvMonday;
        private System.Windows.Forms.ListView lvTuesday;
        private System.Windows.Forms.ListView lvWednesday;
        private System.Windows.Forms.ListView lvThursday;
        private System.Windows.Forms.ListView lvFriday;
        private System.Windows.Forms.ListView lvSaturday;
        private System.Windows.Forms.CheckBox cbxWeekly;
        private System.Windows.Forms.DateTimePicker weekStartDateTime;
        private System.Windows.Forms.Label lblSunday;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSchedule;
        private System.Windows.Forms.TabPage tabAppointments;
        private System.Windows.Forms.TabPage tabPendingTutee;
        private System.Windows.Forms.TabPage tabPendingTutor;
        private System.Windows.Forms.TabPage tabAccepted;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.Label lblMonday;
        private System.Windows.Forms.Label lblTuesday;
        private System.Windows.Forms.Label lblWednesday;
        private System.Windows.Forms.Label lblThursday;
        private System.Windows.Forms.Label lblFriday;
        private System.Windows.Forms.Label lblSaturday;
        private System.Windows.Forms.DateTimePicker dayEndDateTime;
        private System.Windows.Forms.DateTimePicker dayStartDateTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView lvFinalized;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvPendingTutor;
        private System.Windows.Forms.ListView lvTutor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lvPendingTutee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvTutee;
        private System.Windows.Forms.Button btnCancelFinalized;
        private System.Windows.Forms.Button btnDeselect1;
        private System.Windows.Forms.Button btnDeselect2;
        private System.Windows.Forms.Button btnRejectTutor;
        private System.Windows.Forms.Button btnAcceptAddLoc;
        private System.Windows.Forms.Button btnDeselect3;
        private System.Windows.Forms.Button btnRejectTutee;
        private System.Windows.Forms.Button btnFinalize;
    }
}