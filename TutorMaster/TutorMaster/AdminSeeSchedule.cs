﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TutorMaster
{
    public partial class AdminSeeSchedule : Form
    {
        //private bool open;
        private int id;

        public AdminSeeSchedule(int accID)
        {
            id = accID;
            TutorMasterDBEntities4 db = new TutorMasterDBEntities4();                                             //open database
            bool tutor = (bool)(from row in db.Students where row.ID == id select row.Tutor).First();             //get if they are a tutee and/or tutor
            bool tutee = (bool)(from row in db.Students where row.ID == id select row.Tutee).First();
            InitializeComponent();
            populateColumns(tutor, tutee);                                                                        //initialize the columns of listviews approriately
            DateTime start = DateTime.Now;
            //loadAvail(start);                                                                                     //load availability starting from today
            loadAppointments(false);                                                                              //load the appointments
            disableButtons();                                                                                     //disable necessary buttons
            //open = true;

            lblNameTitle.Text = (from row in db.Users where row.ID == id select row.FirstName + " " + row.LastName).First() + "'s Schedule";
        }

        //setup ListViews
        private void populateColumns(bool tutor, bool tutee)
        {
            lvOpen.CheckBoxes = true;
            lvOpen.Columns.Add("Start Time", 175);
            lvOpen.Columns.Add("End Time", 175);
            lvOpen.Columns.Add("Weekly", 75);

            lvFinalized.CheckBoxes = true;
            lvFinalized.Columns.Add("Start Time", 90);
            lvFinalized.Columns.Add("End Time", 90);
            lvFinalized.Columns.Add("Class", 70);
            lvFinalized.Columns.Add("Location", 105);
            lvFinalized.Columns.Add("Open", 50);
            lvFinalized.Columns.Add("Tutoring", 75);
            lvFinalized.Columns.Add("Weekly", 75);
            lvFinalized.Columns.Add("Partner", 115);
            lvFinalized.Columns.Add("PartnerID", 0);

            if (tutor)
            {
                lvPendingTutor.CheckBoxes = true;
                lvPendingTutor.Columns.Add("Start Time", 90);
                lvPendingTutor.Columns.Add("End Time", 90);
                lvPendingTutor.Columns.Add("Class", 70);
                lvPendingTutor.Columns.Add("Location", 105);
                lvPendingTutor.Columns.Add("Open", 50);
                lvPendingTutor.Columns.Add("Tutoring", 75);
                lvPendingTutor.Columns.Add("Weekly", 75);
                lvPendingTutor.Columns.Add("Partner", 115);
                lvPendingTutor.Columns.Add("PartnerID", 0);

                lvTutor.CheckBoxes = true;
                lvTutor.Columns.Add("Start Time", 90);
                lvTutor.Columns.Add("End Time", 90);
                lvTutor.Columns.Add("Class", 70);
                lvTutor.Columns.Add("Location", 105);
                lvTutor.Columns.Add("Open", 50);
                lvTutor.Columns.Add("Tutoring", 75);
                lvTutor.Columns.Add("Weekly", 75);
                lvTutor.Columns.Add("Partner", 115);
                lvTutor.Columns.Add("PartnerID", 0);
            }
            else
            {
                tabControl1.TabPages.Remove(tabPendingTutor);
            }

            if (tutee)
            {
                lvPendingTutee.CheckBoxes = true;
                lvPendingTutee.Columns.Add("Start Time", 90);
                lvPendingTutee.Columns.Add("End Time", 90);
                lvPendingTutee.Columns.Add("Class", 70);
                lvPendingTutee.Columns.Add("Location", 105);
                lvPendingTutee.Columns.Add("Open", 50);
                lvPendingTutee.Columns.Add("Tutoring", 75);
                lvPendingTutee.Columns.Add("Weekly", 75);
                lvPendingTutee.Columns.Add("Partner", 115);
                lvPendingTutee.Columns.Add("PartnerID", 0);

                lvTutee.CheckBoxes = true;
                lvTutee.Columns.Add("Start Time", 90);
                lvTutee.Columns.Add("End Time", 90);
                lvTutee.Columns.Add("Class", 70);
                lvTutee.Columns.Add("Location", 105);
                lvTutee.Columns.Add("Open", 50);
                lvTutee.Columns.Add("Tutoring", 75);
                lvTutee.Columns.Add("Weekly", 75);
                lvTutee.Columns.Add("Partner", 115);
                lvTutee.Columns.Add("PartnerID", 0);
            }
            else
            {
                tabControl1.TabPages.Remove(tabPendingTutee);
            }

        }

        private void disableButtons()
        {
            btnCancelFinalized.Enabled = false;
            btnCancelFinalized.BackColor = System.Drawing.Color.FromArgb(193, 200, 204);
            btnAcceptAddLoc.Enabled = false;
            btnAcceptAddLoc.BackColor = System.Drawing.Color.FromArgb(193, 200, 204);
            btnRejectTutor.Enabled = false;
            btnRejectTutor.BackColor = System.Drawing.Color.FromArgb(193, 200, 204);
            btnFinalize.Enabled = false;
            btnFinalize.BackColor = System.Drawing.Color.FromArgb(193, 200, 204);
            btnRejectTutee.Enabled = false;
            btnRejectTutee.BackColor = System.Drawing.Color.FromArgb(193, 200, 204);
        }

        private void loadAppointments(bool reject)
        {
            TutorMasterDBEntities4 db = new TutorMasterDBEntities4();                                                //open Database
            int num = db.StudentCommitments.Count();                                                                 //see if there are any student committments at all
            if (num > 0)
            {


                List<Commitment> cmtList = (from stucmt in db.StudentCommitments
                                            where stucmt.ID == id
                                            join cmt in db.Commitments on stucmt.CmtID equals cmt.CmtID
                                            select cmt).ToList();                                                   //get all of the student commitments for this student that is signed in

                SortsAndSearches.QuickSort(ref cmtList, cmtList.Count());                                                            //sort their list using QuickSort

                if (cmtList.Count > 0)
                {                                                                                                   //initialize carries to the first commitment
                    TutorMaster.Commitment initialCommit = cmtList[0];
                    string startTime = Convert.ToDateTime(cmtList[0].StartTime).ToString();
                    string endTime = Convert.ToDateTime(cmtList[0].StartTime).AddMinutes(15).ToString();
                    int numCmts = cmtList.Count;

                    for (int i = 0; i < numCmts - 1; i++)
                    {
                        DateTime currentCommitDate = Convert.ToDateTime(cmtList[i].StartTime);                      //get datetime of commitment we are on in loop
                        DateTime nextCommitDate = Convert.ToDateTime(cmtList[i + 1].StartTime);                     //get datetime of commitment ahead of it

                        //if the two commits are distinct besides time and current commit is within week of start time
                        if (!Commits.sameCategory(cmtList[i], cmtList[i + 1]) || currentCommitDate.AddMinutes(15) != nextCommitDate)
                        {
                            endTime = endTime = Convert.ToDateTime(cmtList[i].StartTime).AddMinutes(15).ToString();                                               //update endtime and add what we have so far
                            addToAppointments(initialCommit, startTime, endTime);                                   //add the chunk of time to our listviews

                            //initialize carries to be the next commitment and begin scanning for that
                            startTime = Convert.ToDateTime(cmtList[i + 1].StartTime).ToString();
                            endTime = Convert.ToDateTime(cmtList[i + 1].StartTime).AddMinutes(15).ToString();
                            initialCommit = cmtList[i + 1];
                        }

                    }
                    endTime = Convert.ToDateTime(cmtList[cmtList.Count() - 1].StartTime).AddMinutes(15).ToString();
                    addToAppointments(initialCommit, startTime, endTime);
                }
            }

        }

        private void addToAppointments(TutorMaster.Commitment commit, string startTime, string endTime)
        {
            TutorMasterDBEntities4 db = new TutorMasterDBEntities4();

            string partner = "";
            string open = getYesNo((bool)commit.Open);
            string tutoring = getYesNo((bool)commit.Tutoring);
            string weekly = getYesNo((bool)commit.Weekly);

            if (commit.ID == -1)
            {
                partner = "None";
            }
            else
            {
                var partnerData = (from row in db.Users where row.ID == commit.ID select row).First();
                partner = partnerData.FirstName + " " + partnerData.LastName;
            }

            ListViewItem item = new ListViewItem(new string[] { startTime, endTime, commit.Class, commit.Location, 
                    commit.Open.ToString(), commit.Tutoring.ToString(), commit.Weekly.ToString(), partner, commit.ID.ToString() });
            if (Commits.isAccepted(commit))                                                                                                                //if commit accepted, add to accepted listview
            {
                lvFinalized.Items.Add(item);
            }
            else if (Commits.waitingForLocation(commit))                                                                                                 //if waiting for location to be proposed
            {                                                                                                                                    //add to pending tutor listview
                lvPendingTutor.Items.Add(item);
            }
            else if (Commits.waitingForTutee(commit))                                                                                                    //if tutor waiting for tutee to respond to location
            {                                                                                                                                    //add to pending tutee listview
                lvTutor.Items.Add(item);
            }
            else if (Commits.waitingForLocationApproval(commit))                                                                                         //if waiting for location approval
            {                                                                                                                                    //add to pending tutee listview
                lvPendingTutee.Items.Add(item);
            }
            else if (Commits.waitingForTutor(commit))                                                                                                    //if waiting for tutor to respond to appointment
            {                                                                                                                                    //add to tutee listview
                lvTutee.Items.Add(item);
            }
            else
            {
                lvOpen.Items.Add(item);
            }

        }

        private string getYesNo(bool b)
        {
            string yesno = "";
            if (b)
            {
                yesno = "Yes";
            }
            else
            {
                yesno = "No";
            }

            return yesno;
        }

        private void btnAcceptAddLoc_Click(object sender, EventArgs e)
        {
            TutorMasterDBEntities4 db = new TutorMasterDBEntities4();
            List<string> commits = new List<string>();

            if (lvPendingTutor.CheckedItems.Count > 0)
            {
                for (int i = 0; i < lvPendingTutor.CheckedItems.Count; i++)
                {
                    commits.Add(lvPendingTutor.CheckedItems[i].SubItems[0].Text.ToString() + "," + lvPendingTutor.CheckedItems[i].SubItems[1].Text.ToString() + "," + Convert.ToString(lvPendingTutor.CheckedItems[i].SubItems[8].Text));
                }

                ProposeLocationForm g = new ProposeLocationForm(id, commits, true);
                g.Show();
            }
            else
            {
                List<Commitment> tuteeCmtList = (from stucmt in db.StudentCommitments
                                                 where stucmt.ID == id
                                                 join cmt in db.Commitments on stucmt.CmtID equals cmt.CmtID
                                                 select cmt).ToList();

                for (int i = 0; i < lvTutor.CheckedItems.Count; i++)
                {
                    DateTime startDate = DateTimeMethods.getListViewTime(lvTutor.CheckedItems[i].SubItems[0].Text);
                    DateTime endDate = DateTimeMethods.getListViewTime(lvTutor.CheckedItems[i].SubItems[1].Text);

                    for (int c = 0; c < tuteeCmtList.Count(); c++)
                    {
                        if (DateTime.Compare(startDate, Convert.ToDateTime(tuteeCmtList[c].StartTime)) <= 0 && DateTime.Compare(endDate, Convert.ToDateTime(tuteeCmtList[c].StartTime)) > 0)
                        {
                            tuteeCmtList[c].Location = tuteeCmtList[c].Location.Substring(0, tuteeCmtList[c].Location.Length - 1);
                            db.SaveChanges();
                        }
                    }

                    int partnerID = Convert.ToInt32(lvTutor.CheckedItems[i].SubItems[8].Text);

                    List<Commitment> tutorCmtList = (from stucmt in db.StudentCommitments
                                                     where stucmt.ID == partnerID
                                                     join cmt in db.Commitments on stucmt.CmtID equals cmt.CmtID
                                                     select cmt).ToList();

                    for (int m = 0; m < tutorCmtList.Count(); m++)
                    {
                        if (DateTime.Compare(startDate, Convert.ToDateTime(tutorCmtList[m].StartTime)) <= 0 && DateTime.Compare(endDate, Convert.ToDateTime(tutorCmtList[m].StartTime)) > 0)
                        {
                            tutorCmtList[m].Location = tutorCmtList[m].Location.Substring(0, tutorCmtList[m].Location.Length - 1);
                            db.SaveChanges();
                        }
                    }
                }
            }
            resetListViews(false);
        }

        private void btnRejectTutor_Click(object sender, EventArgs e)
        {
            TutorMasterDBEntities4 db = new TutorMasterDBEntities4();
            List<string> commits = new List<string>();

           
            for (int i = 0; i < lvPendingTutor.CheckedItems.Count; i++)
            {
                commits.Add(lvPendingTutor.CheckedItems[i].SubItems[0].Text.ToString() + "," + lvPendingTutor.CheckedItems[i].SubItems[1].Text.ToString() + "," + lvPendingTutor.CheckedItems[i].SubItems[8].Text.ToString());
            }

            for (int n = 0; n < lvTutor.CheckedItems.Count; n++)
            {
                commits.Add(lvTutor.CheckedItems[n].SubItems[0].Text.ToString() + "," + lvTutor.CheckedItems[n].SubItems[1].Text.ToString() + "," + lvTutor.CheckedItems[n].SubItems[8].Text.ToString());
            }

            List<Commitment> tutorCmtList = (from stucmt in db.StudentCommitments
                                             where stucmt.ID == id
                                             join cmt in db.Commitments on stucmt.CmtID equals cmt.CmtID
                                             select cmt).ToList();

            for (int f = 0; f < commits.Count(); f++)
            {
                DateTime startDate = DateTimeMethods.getStartTime(commits[f]);
                DateTime endDate = DateTimeMethods.getEndTime(commits[f]);

                for (int c = 0; c < tutorCmtList.Count(); c++)
                {
                    if (DateTime.Compare(startDate, Convert.ToDateTime(tutorCmtList[c].StartTime)) <= 0 && DateTime.Compare(endDate, Convert.ToDateTime(tutorCmtList[c].StartTime)) > 0)
                    {
                        tutorCmtList[c].Weekly = false;
                        tutorCmtList[c].Tutoring = false;
                        tutorCmtList[c].Class = "-";
                        tutorCmtList[c].Location = "-";
                        tutorCmtList[c].Open = true;
                        tutorCmtList[c].ID = -1;
                        db.SaveChanges();
                    }
                }

                int partnerID = Convert.ToInt32(commits[f].Split(',')[2]);

                List<Commitment> tuteeCmtList = (from stucmt in db.StudentCommitments
                                                 where stucmt.ID == partnerID
                                                 join cmt in db.Commitments on stucmt.CmtID equals cmt.CmtID
                                                 select cmt).ToList();

                for (int m = 0; m < tuteeCmtList.Count(); m++)
                {
                    if (DateTime.Compare(startDate, Convert.ToDateTime(tuteeCmtList[m].StartTime)) <= 0 && DateTime.Compare(endDate, Convert.ToDateTime(tuteeCmtList[m].StartTime)) > 0)
                    {
                        tuteeCmtList[m].Weekly = false;
                        tuteeCmtList[m].Tutoring = false;
                        tuteeCmtList[m].Class = "@";
                        tuteeCmtList[m].Location = "-";
                        tuteeCmtList[m].Open = true;
                        tuteeCmtList[m].ID = -1;
                        db.SaveChanges();
                    }
                }
            }
            DateTime start = DateTime.Now;
            resetListViews(false);
        }

        private void btnCancelFinalized_Click(object sender, EventArgs e)
        {
            TutorMasterDBEntities4 db = new TutorMasterDBEntities4();
            List<string> commits = new List<string>();

            for (int i = 0; i < lvFinalized.CheckedItems.Count; i++)
            {
                commits.Add(lvFinalized.CheckedItems[i].SubItems[0].Text.ToString() + "," + lvFinalized.CheckedItems[i].SubItems[1].Text.ToString() + "," + lvFinalized.CheckedItems[i].SubItems[8].Text.ToString());
            }


            List<Commitment> stdCmtList = (from stucmt in db.StudentCommitments
                                           where stucmt.ID == id
                                           join cmt in db.Commitments on stucmt.CmtID equals cmt.CmtID
                                           select cmt).ToList();

            for (int f = 0; f < commits.Count(); f++)
            {
                DateTime startDate = DateTimeMethods.getStartTime(commits[f]);
                DateTime endDate = DateTimeMethods.getEndTime(commits[f]);

                for (int c = 0; c < stdCmtList.Count(); c++)
                {
                    if (DateTime.Compare(startDate, Convert.ToDateTime(stdCmtList[c].StartTime)) <= 0 && DateTime.Compare(endDate, Convert.ToDateTime(stdCmtList[c].StartTime)) > 0)
                    {
                        stdCmtList[c].Weekly = false;
                        stdCmtList[c].Tutoring = false;
                        stdCmtList[c].Class = "-";
                        stdCmtList[c].Location = "-";
                        stdCmtList[c].Open = true;
                        stdCmtList[c].ID = -1;
                        db.SaveChanges();
                    }
                }

                int partnerID = Convert.ToInt32(commits[f].Split(',')[2]);

                List<Commitment> partnerCmtList = (from stucmt in db.StudentCommitments
                                                   where stucmt.ID == partnerID
                                                   join cmt in db.Commitments on stucmt.CmtID equals cmt.CmtID
                                                   select cmt).ToList();

                for (int m = 0; m < partnerCmtList.Count(); m++)
                {
                    if (DateTime.Compare(startDate, Convert.ToDateTime(partnerCmtList[m].StartTime)) <= 0 && DateTime.Compare(endDate, Convert.ToDateTime(partnerCmtList[m].StartTime)) > 0)
                    {
                        partnerCmtList[m].Weekly = false;
                        partnerCmtList[m].Tutoring = false;
                        partnerCmtList[m].Class = "@";
                        partnerCmtList[m].Location = "-";
                        partnerCmtList[m].Open = true;
                        partnerCmtList[m].ID = -1;
                        db.SaveChanges();
                    }
                }
            }

            DateTime start = DateTime.Now;
            lvTutor.Items.Clear();
            lvPendingTutor.Items.Clear();
            lvFinalized.Items.Clear();
            lvPendingTutee.Items.Clear();
            lvTutee.Items.Clear();
            lvOpen.Items.Clear();

            loadAppointments(true);
        }

        private void btnRejectTutee_Click(object sender, EventArgs e)
        {
            TutorMasterDBEntities4 db = new TutorMasterDBEntities4();
            List<string> commits = new List<string>();

            for (int i = 0; i < lvPendingTutee.CheckedItems.Count; i++)
            {
                commits.Add(lvPendingTutee.CheckedItems[i].SubItems[0].Text.ToString() + "," + lvPendingTutee.CheckedItems[i].SubItems[1].Text.ToString() + "," + lvPendingTutee.CheckedItems[i].SubItems[8].Text.ToString());
            }

            for (int n = 0; n < lvTutee.CheckedItems.Count; n++)
            {
                commits.Add(lvTutee.CheckedItems[n].SubItems[0].Text.ToString() + "," + lvTutee.CheckedItems[n].SubItems[1].Text.ToString() + "," + lvTutee.CheckedItems[n].SubItems[8].Text.ToString());
            }


            List<Commitment> tuteeCmtList = (from stucmt in db.StudentCommitments
                                             where stucmt.ID == id
                                             join cmt in db.Commitments on stucmt.CmtID equals cmt.CmtID
                                             select cmt).ToList();

            for (int f = 0; f < commits.Count(); f++)
            {
                DateTime startDate = DateTimeMethods.getStartTime(commits[f]);
                DateTime endDate = DateTimeMethods.getEndTime(commits[f]);

                for (int c = 0; c < tuteeCmtList.Count(); c++)
                {
                    if (DateTime.Compare(startDate, Convert.ToDateTime(tuteeCmtList[c].StartTime)) <= 0 && DateTime.Compare(endDate, Convert.ToDateTime(tuteeCmtList[c].StartTime)) > 0)
                    {
                        tuteeCmtList[c].Weekly = false;
                        tuteeCmtList[c].Tutoring = false;
                        tuteeCmtList[c].Class = "-";
                        tuteeCmtList[c].Location = "-";
                        tuteeCmtList[c].Open = true;
                        tuteeCmtList[c].ID = -1;
                        db.SaveChanges();
                    }
                }

                int partnerID = Convert.ToInt32(commits[f].Split(',')[2]);

                List<Commitment> tutorCmtList = (from stucmt in db.StudentCommitments
                                                 where stucmt.ID == partnerID
                                                 join cmt in db.Commitments on stucmt.CmtID equals cmt.CmtID
                                                 select cmt).ToList();

                for (int m = 0; m < tutorCmtList.Count(); m++)
                {
                    if (DateTime.Compare(startDate, Convert.ToDateTime(tutorCmtList[m].StartTime)) <= 0 && DateTime.Compare(endDate, Convert.ToDateTime(tutorCmtList[m].StartTime)) > 0)
                    {
                        tutorCmtList[m].Weekly = false;
                        tutorCmtList[m].Tutoring = false;
                        tutorCmtList[m].Class = "@";
                        tutorCmtList[m].Location = "-";
                        tutorCmtList[m].Open = true;
                        tutorCmtList[m].ID = -1;
                        db.SaveChanges();
                    }
                }
            }
            DateTime start = DateTime.Now;
            resetListViews(false);
        }

        private void btnFinalize_Click(object sender, EventArgs e)
        {
            TutorMasterDBEntities4 db = new TutorMasterDBEntities4();

            List<Commitment> tuteeCmtList = (from stucmt in db.StudentCommitments
                                             where stucmt.ID == id
                                             join cmt in db.Commitments on stucmt.CmtID equals cmt.CmtID
                                             select cmt).ToList();

            if (lvPendingTutee.CheckedItems.Count > 0)
            {
                for (int i = 0; i < lvPendingTutee.CheckedItems.Count; i++)
                {
                    DateTime startDate = DateTimeMethods.getListViewTime(lvPendingTutee.CheckedItems[i].SubItems[0].Text);
                    DateTime endDate = DateTimeMethods.getListViewTime(lvPendingTutee.CheckedItems[i].SubItems[1].Text);

                    for (int c = 0; c < tuteeCmtList.Count(); c++)
                    {
                        if (DateTime.Compare(startDate, Convert.ToDateTime(tuteeCmtList[c].StartTime)) <= 0 && DateTime.Compare(endDate, Convert.ToDateTime(tuteeCmtList[c].StartTime)) > 0)
                        {
                            tuteeCmtList[c].Location = tuteeCmtList[c].Location.Substring(0, tuteeCmtList[c].Location.Length - 1);
                            db.SaveChanges();
                        }
                    }

                    int partnerID = Convert.ToInt32(lvPendingTutee.CheckedItems[i].SubItems[8].Text);

                    List<Commitment> tutorCmtList = (from stucmt in db.StudentCommitments
                                                     where stucmt.ID == partnerID
                                                     join cmt in db.Commitments on stucmt.CmtID equals cmt.CmtID
                                                     select cmt).ToList();

                    for (int m = 0; m < tutorCmtList.Count(); m++)
                    {
                        if (DateTime.Compare(startDate, Convert.ToDateTime(tutorCmtList[m].StartTime)) <= 0 && DateTime.Compare(endDate, Convert.ToDateTime(tutorCmtList[m].StartTime)) > 0)
                        {
                            tutorCmtList[m].Location = tutorCmtList[m].Location.Substring(0, tutorCmtList[m].Location.Length - 1);
                            db.SaveChanges();
                        }
                    }
                }
            }
            else
            {
                List<string> commits = new List<string>();
                for (int i = 0; i < lvTutee.CheckedItems.Count; i++)
                {
                    commits.Add(lvTutee.CheckedItems[i].SubItems[0].Text.ToString() + "," + lvTutee.CheckedItems[i].SubItems[1].Text.ToString() + "," + Convert.ToString(lvTutee.CheckedItems[i].SubItems[8].Text));
                }

                ProposeLocationForm g = new ProposeLocationForm(id, commits, true);
                g.Show();
            }

            resetListViews(false);
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAddAvailability_Click(object sender, EventArgs e)
        {
            AddAvailability g = new AddAvailability(id);
            g.Show();
            
        }

        private void btnCreateAppointment_Click(object sender, EventArgs e)
        {
            TutorMasterDBEntities4 db = new TutorMasterDBEntities4();                                             //open database
            bool tutor = (bool)(from row in db.Students where row.ID == id select row.Tutor).First();             //get if they are a tutee and/or tutor
            bool tutee = (bool)(from row in db.Students where row.ID == id select row.Tutee).First();
            if (tutor && tutee)
            {
                TutorOrTuteeForm g = new TutorOrTuteeForm(id);
                g.Show();
            }
            else if (tutor)
            {
                AdminCreateAppointmentForm g = new AdminCreateAppointmentForm(id, true);
                g.Show();
                this.Close();
            }
            else if(tutee)
            {
                AdminCreateAppointmentForm g = new AdminCreateAppointmentForm(id, false);
                g.Show();
                this.Close();
            }
        }

        private void lvOpen_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (lvOpen.CheckedItems.Count > 0)
            {
                btnAddAvailability.Enabled = false;
                btnAddAvailability.BackColor = System.Drawing.Color.FromArgb(193, 200, 204);
                btnCreateAppointment.Enabled = false;
                btnCreateAppointment.BackColor = System.Drawing.Color.FromArgb(193, 200, 204);
                btnRemoveAvailability.Enabled = true;
                btnRemoveAvailability.BackColor = System.Drawing.Color.FromArgb(226, 226, 226);
            }
            else
            {
                btnAddAvailability.Enabled = true;
                btnCreateAppointment.Enabled = true;
                btnRemoveAvailability.Enabled = false;
            }
        }

        //when an item is checked in the listview finalized, enable or disable the cancel button depending on the checked item count
        private void lvFinalized_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            int itemsChecked = lvFinalized.CheckedItems.Count; //CheckedItems.Count tells how many things in the list box are clicked
            if (itemsChecked > 0)
            {
                btnCancelFinalized.Enabled = true;
                btnCancelFinalized.BackColor = System.Drawing.Color.FromArgb(226, 226, 226);
            }
            else
            {
                btnCancelFinalized.Enabled = false;
                btnCancelFinalized.BackColor = System.Drawing.Color.FromArgb(193, 200, 204);
            }
        }

        private void lvPendingTutor_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            int numPendingTutor = lvPendingTutor.CheckedItems.Count;
            int numTutor = lvTutor.CheckedItems.Count;
            if (numPendingTutor > 0 && numTutor > 0)                                   //if both lv PendingTutor and lvTutor have something checked, only reject should be on
            {
                btnAcceptAddLoc.Enabled = false;
                btnAcceptAddLoc.BackColor = System.Drawing.Color.FromArgb(193, 200, 204);
                btnRejectTutor.Enabled = true;
                btnRejectTutor.BackColor = System.Drawing.Color.FromArgb(226, 226, 226);
            }
            else if (numPendingTutor > 0 && numTutor == 0)                             //if PendingTutor has something checked by tutor doesn't then both buttons should be on
            {
                btnAcceptAddLoc.Enabled = true;
                btnAcceptAddLoc.BackColor = System.Drawing.Color.FromArgb(226, 226, 226);
                btnRejectTutor.Enabled = true;
                btnRejectTutor.BackColor = System.Drawing.Color.FromArgb(226, 226, 226);
            }
            else if (numTutor > 0 && numPendingTutor == 0)                             //if tutor has something checked but pendingTutor does not, only reject should be on
            {
                btnAcceptAddLoc.Enabled = false;
                btnAcceptAddLoc.BackColor = System.Drawing.Color.FromArgb(193, 200, 204);
                btnRejectTutor.Enabled = true;
                btnRejectTutor.BackColor = System.Drawing.Color.FromArgb(226, 226, 226);
            }
            else                                                                       //if neither of them have anything checked, then both buttons should be disabled
            {
                btnAcceptAddLoc.Enabled = false;
                btnAcceptAddLoc.BackColor = System.Drawing.Color.FromArgb(193, 200, 204);
                btnRejectTutor.Enabled = false;
                btnRejectTutor.BackColor = System.Drawing.Color.FromArgb(193, 200, 204);
            }
        }

        private void lvTutor_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            int numPendingTutor = lvPendingTutor.CheckedItems.Count;
            int numTutor = lvTutor.CheckedItems.Count;
            if (numPendingTutor > 0 && numTutor > 0)                                   //if both lv PendingTutor and lvTutor have something checked, only reject should be on
            {
                btnAcceptAddLoc.Enabled = false;
                btnAcceptAddLoc.BackColor = System.Drawing.Color.FromArgb(193, 200, 204);
                btnRejectTutor.Enabled = true;
                btnRejectTutor.BackColor = System.Drawing.Color.FromArgb(226, 226, 226);
            }
            else if (numPendingTutor > 0 && numTutor == 0)                             //if PendingTutor has something checked by tutor doesn't then both buttons should be on
            {
                btnAcceptAddLoc.Enabled = true;
                btnAcceptAddLoc.BackColor = System.Drawing.Color.FromArgb(226, 226, 226);
                btnRejectTutor.Enabled = true;
                btnRejectTutor.BackColor = System.Drawing.Color.FromArgb(226, 226, 226);
            }
            else if (numTutor > 0 && numPendingTutor == 0)                             //if tutor has something checked but pendingTutor does not, only reject should be on
            {
                btnAcceptAddLoc.Enabled = false;
                btnAcceptAddLoc.BackColor = System.Drawing.Color.FromArgb(193, 200, 204);
                btnRejectTutor.Enabled = true;
                btnRejectTutor.BackColor = System.Drawing.Color.FromArgb(226, 226, 226);
            }
            else                                                                       //if neither of them have anything checked, then both buttons should be disabled
            {
                btnAcceptAddLoc.Enabled = false;
                btnAcceptAddLoc.BackColor = System.Drawing.Color.FromArgb(193, 200, 204);
                btnRejectTutor.Enabled = false;
                btnRejectTutor.BackColor = System.Drawing.Color.FromArgb(193, 200, 204);
            }
        }

        private void lvTutee_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            int numPendingTutee = lvPendingTutee.CheckedItems.Count;
            int numTutee = lvTutee.CheckedItems.Count;
            if (numPendingTutee > 0 && numTutee > 0)                                   //if both lv PendingTutee and lvTutee have something checked, only reject should be on
            {
                btnFinalize.Enabled = false;
                btnFinalize.BackColor = System.Drawing.Color.FromArgb(193, 200, 204);
                btnRejectTutee.Enabled = true;
                btnRejectTutee.BackColor = System.Drawing.Color.FromArgb(226, 226, 226);
            }
            else if (numPendingTutee > 0 && numTutee == 0)                             //if PendingTutee has something checked by tutee doesn't then both buttons should be on
            {
                btnFinalize.Enabled = true;
                btnFinalize.BackColor = System.Drawing.Color.FromArgb(226, 226, 226);
                btnRejectTutee.Enabled = true;
                btnRejectTutee.BackColor = System.Drawing.Color.FromArgb(226, 226, 226);
            }
            else if (numTutee > 0 && numPendingTutee == 0)                             //if tutee has something checked but pendingTutee does not, only reject should be on
            {
                btnFinalize.Enabled = false;
                btnFinalize.BackColor = System.Drawing.Color.FromArgb(193, 200, 204);
                btnRejectTutee.Enabled = true;
                btnRejectTutee.BackColor = System.Drawing.Color.FromArgb(226, 226, 226);
            }
            else                                                                       //if neither of them have anything checked, then both buttons should be disabled
            {
                btnFinalize.Enabled = false;
                btnFinalize.BackColor = System.Drawing.Color.FromArgb(193, 200, 204);
                btnRejectTutee.Enabled = false;
                btnRejectTutee.BackColor = System.Drawing.Color.FromArgb(193, 200, 204);
            }
        }

        private void lvPendingTutee_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            int numPendingTutee = lvPendingTutee.CheckedItems.Count;
            int numTutee = lvTutee.CheckedItems.Count;
            if (numPendingTutee > 0 && numTutee > 0)                                   //if both lv PendingTutee and lvTutee have something checked, only reject should be on
            {
                btnFinalize.Enabled = false;
                btnFinalize.BackColor = System.Drawing.Color.FromArgb(193, 200, 204);
                btnRejectTutee.Enabled = true;
                btnRejectTutee.BackColor = System.Drawing.Color.FromArgb(226, 226, 226);
            }
            else if (numPendingTutee > 0 && numTutee == 0)                             //if PendingTutee has something checked by tutee doesn't then both buttons should be on
            {
                btnFinalize.Enabled = true;
                btnFinalize.BackColor = System.Drawing.Color.FromArgb(226, 226, 226);
                btnRejectTutee.Enabled = true;
                btnRejectTutee.BackColor = System.Drawing.Color.FromArgb(226, 226, 226);
            }
            else if (numTutee > 0 && numPendingTutee == 0)                             //if tutee has something checked but pendingTutee does not, only reject should be on
            {
                btnFinalize.Enabled = false;
                btnFinalize.BackColor = System.Drawing.Color.FromArgb(193, 200, 204);
                btnRejectTutee.Enabled = true;
                btnRejectTutee.BackColor = System.Drawing.Color.FromArgb(226, 226, 226);
            }
            else                                                                       //if neither of them have anything checked, then both buttons should be disabled
            {
                btnFinalize.Enabled = false;
                btnFinalize.BackColor = System.Drawing.Color.FromArgb(193, 200, 204);
                btnRejectTutee.Enabled = false;
                btnRejectTutee.BackColor = System.Drawing.Color.FromArgb(193, 200, 204);
            }
        }

        private void removeTimeBlocks(bool week)
        {
            setPreviousWeekliesToFalse();                                //set the previous weeklies to false
            if (week)
            {
                DialogResult choice = MessageBox.Show("Would you like to delete the weekly time slots until the end of the semester?", "Delete weekly timeslot?", MessageBoxButtons.YesNo);
                if (choice == DialogResult.Yes)
                {
                    deleteAvail(true);
                }
                else if (choice == DialogResult.No)
                {
                    deleteAvail(false);
                }
            }
            else
            {
                deleteAvail(false);
            }

            for (int c = 0; c < lvOpen.CheckedItems.Count; c++)     //remove all of the selected time slots from the listview
            {
                lvOpen.CheckedItems[c].Remove();
                c--;
            }
        }

        private void setPreviousWeekliesToFalse()
        {
            TutorMasterDBEntities4 db = new TutorMasterDBEntities4();                                         //connect to the database

            List<Commitment> cmtList = (from stucmt in db.StudentCommitments                                  //get the commit list of the signed in student
                                        where stucmt.ID == id
                                        join cmt in db.Commitments on stucmt.CmtID equals cmt.CmtID
                                        select cmt).ToList();

            List<DateTime> searchList = new List<DateTime>();                                                 //initialize search list

            SortsAndSearches.QuickSort(ref cmtList, cmtList.Count());

            searchList = getStartTimes();                                                                     //get the startTimes from the listview

            for (int i = 0; i < cmtList.Count(); i++)                                                         //for each commitment in the commit list
            {
                if (DateTimeMethods.weeklyAndFound(cmtList[i], searchList))                                                   //if the commitment is in the search list and weekly
                {
                    DateTime startSemes = new DateTime(2017, 1, 1, 0, 0, 0);
                    DateTime weekBack = Convert.ToDateTime(cmtList[i].StartTime).AddDays(-7);                 //go a week back in time
                    
                    while (DateTime.Compare(startSemes, weekBack) <= 0)                                       //perform a binary search here
                    {
                        bool found = false;
                        int first = 0;
                        int last = cmtList.Count() - 1;
                        while (first <= last && !found)
                        {
                            int midpoint = (first + last) / 2;
                            if (DateTimeMethods.sameTime(cmtList[midpoint], weekBack))                                        //if you find the weekBack date time
                            {
                                if (cmtList[midpoint].Open == true)                                           //if the commitment is open
                                {
                                    cmtList[midpoint].Weekly = false;                                         //set its weekly to false
                                    db.SaveChanges();                                                         //save the changes to the database
                                }
                                found = true;
                            }
                            else
                            {
                                if (DateTimeMethods.weekBackEarlier(weekBack, cmtList[midpoint]))                                    //if weekback is earlier, search first half of list
                                {
                                    last = midpoint - 1;
                                }
                                else                                                                          //else, search the second half of the list
                                {
                                    first = midpoint + 1;
                                }
                            }
                        }
                        weekBack = weekBack.AddDays(-7);                                                      //go a week back in time
                    }
                }
            }
        }

        private void deleteAvail(bool week)
        {
            TutorMasterDBEntities4 db = new TutorMasterDBEntities4();                                        //connect to the database

            List<Commitment> cmtList = (from stucmt in db.StudentCommitments                                 //get the student's commitments
                                        where stucmt.ID == id
                                        join cmt in db.Commitments on stucmt.CmtID equals cmt.CmtID
                                        select cmt).ToList();

            SortsAndSearches.QuickSort(ref cmtList, cmtList.Count());                                                         //sort the list by DateTime

            List<DateTime> searchList = new List<DateTime>();

            searchList = getStartTimes();                                                                    //get the starttimes from the listview                                  

            if (week)
            {
                for (int i = 0; i < cmtList.Count(); i++)
                {
                    if (SortsAndSearches.BinarySearch(searchList, Convert.ToDateTime(cmtList[i].StartTime)))
                    {
                        if (cmtList[i].Weekly == true)
                        {//ask the user if they want to delete the weekly commitment through the end of the semester
                            DateTime endSemes = new DateTime(2017, 5, 1, 0, 0, 0);                            //get end of semester
                            DateTime weekForward = Convert.ToDateTime(cmtList[i].StartTime).AddDays(7);       //go a week forward
                            while (DateTimeMethods.endOfSemesIsLater(endSemes, weekForward))                                  //if the end of the semester is later than our commitment start Time
                            {                                                                                 //run a binary search
                                bool found = false;
                                int first = 0;
                                int last = cmtList.Count() - 1;
                                while (first <= last && !found)
                                {
                                    int midpoint = (first + last) / 2;
                                    if (DateTimeMethods.sameTime(cmtList[midpoint], weekForward))                             //if commitment time and weekforward time are the same
                                    {
                                        if (cmtList[midpoint].Open == true)                                   //and if the midpoint commitment is open
                                        {
                                            db.Commitments.DeleteObject(cmtList[midpoint]);                   //delete the commitment from the database
                                            cmtList.Remove(cmtList[midpoint]);                                //remove it from the commit list as well
                                            db.SaveChanges();
                                        }
                                        found = true;                                                         //say we found what we were looking for
                                        break;                                                                //break out of the search
                                    }
                                    else
                                    {
                                        if (DateTimeMethods.forwardEarlierThanStart(weekForward, cmtList[midpoint]))
                                        {
                                            last = midpoint - 1;
                                        }
                                        else
                                        {
                                            first = midpoint + 1;
                                        }
                                    }
                                }
                                weekForward = weekForward.AddDays(7);
                            }
                        }

                        searchList.Remove(Convert.ToDateTime(cmtList[i].StartTime));
                        db.Commitments.DeleteObject(cmtList[i]);
                        i--;
                        db.SaveChanges();
                    }
                }
                MessageBox.Show("The checked 15 minute time blocks have been removed from your availability until the end of the semster.");
            }
            else
            {
                for (int i = 0; i < cmtList.Count(); i++)
                {
                    if (SortsAndSearches.BinarySearch(searchList, Convert.ToDateTime(cmtList[i].StartTime)))
                    {
                        searchList.Remove(Convert.ToDateTime(cmtList[i].StartTime));
                        db.Commitments.DeleteObject(cmtList[i]);
                        i--;
                        db.SaveChanges();
                    }
                }
                MessageBox.Show("Only the checked 15 minute time blocks have been removed from your availability.");
            }
        }

        private List<DateTime> getStartTimes()
        {//the purpose of this function is to get the starttimes from the checked items of the listviews
            List<string> removeList = new List<string>();

            for (int n = 0; n < lvOpen.CheckedItems.Count; n++)                             //go through each of the checked items
            {
                removeList.Add(lvOpen.CheckedItems[n].SubItems[0].Text.ToString() + "," + lvOpen.CheckedItems[n].SubItems[1].Text.ToString());
            }

            List<DateTime> resultList = new List<DateTime>();

            for (int i = 0; i < removeList.Count(); i++)
            {
                DateTime startTime = DateTimeMethods.getDate(removeList[i].Split(',')[0]);                 //get the start time
                DateTime endTime = DateTimeMethods.getDate(removeList[i].Split(',')[1]);                   //get the end time
                while (DateTimeMethods.startEarlierThanEnd(startTime, endTime))                            //if the start time is before the end time, add the strings to the listviews
                {
                    resultList.Add(startTime);
                    startTime = startTime.AddMinutes(15);                                  //add the next 15 minute time block
                }
            }
            return resultList;                                                                 //return the desired list
        }

        private void btnRemoveAvailability_MouseHover(object sender, EventArgs e)
        {
            if(lvOpen.CheckedItems.Count == 1)
            {
                lblRemove.Text = "Choose which 15 minute time blocks to delete";
            }
            else if (lvOpen.CheckedItems.Count > 1)
            {
                lblRemove.Text = "Delete entire time blocks";
            }
        }

        private void btnRemoveAvailability_MouseLeave(object sender, EventArgs e)
        {
            lblRemove.Text = "";
        }

        private void btnRemoveAvailability_Click(object sender, EventArgs e)
        {
            if (lvOpen.CheckedItems.Count == 1)
            {
                string startTime = lvOpen.CheckedItems[0].SubItems[0].Text.ToString();
                string endTime = lvOpen.CheckedItems[0].SubItems[1].Text.ToString();
                string weekly = lvOpen.CheckedItems[0].SubItems[2].Text.ToString();

                List<string> removeList = new List<string>();
                removeList.Add(startTime + "," + endTime + "," + weekly);

                RemoveAvailForm g = new RemoveAvailForm(id, removeList);
                g.Show();
            }
            else if (lvOpen.CheckedItems.Count > 1)
            {
                bool weeklyChoice = checkChecked();
                if (weeklyChoice)
                {

                    removeTimeBlocks(true);
                }
                else
                {
                    removeTimeBlocks(false);
                }
            }
            resetListViews(false);
        }

        private bool checkChecked()
        {
            for (int i = 0; i < lvOpen.CheckedItems.Count; i++)
            {
                if (lvOpen.CheckedItems[i].SubItems[2].Text.ToString() == "True")
                {
                    return true;
                }
            }
            return false;
        }

        private void resetListViews(bool reject)
        {
            lvOpen.Items.Clear();
            lvTutor.Items.Clear();
            lvTutee.Items.Clear();
            lvPendingTutee.Items.Clear();
            lvPendingTutor.Items.Clear();
            lvFinalized.Items.Clear();
            loadAppointments(reject);
        }

        private void AdminSeeSchedule_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void AdminSeeSchedule_Load(object sender, EventArgs e)
        {

        }
    }
    
}
