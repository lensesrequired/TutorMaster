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
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();

            setupStudentLV();
            setupFacultyLV();
            setupClassLV();
            setupDepartmentBoxes();
            disableButtons();
        }

        private void setupStudentLV() //This is what populates the box of students
        {
            lvStudent.CheckBoxes = true;
            lvStudent.Columns.Add("     Username", 110);// This first block of commands sets up the top row.
            lvStudent.Columns.Add("Last Name", 100);
            lvStudent.Columns.Add("First Name", 100);
            lvStudent.Columns.Add("Tutor", 50);
            lvStudent.Columns.Add("Tutee", 50);
            lvStudent.Columns.Add("Email", 100);
            lvStudent.Columns.Add("Phone Number", 100);

            TutorMasterDBEntities4 db = new TutorMasterDBEntities4(); //create a new indirect entity
            var students = from c in db.Students select c; // c is arbitay thing to pull. from var in tabletopullfrom select 
            
            List<Student> stus = new List<Student>();
            stus = students.ToList();

            foreach(Student stu in stus)
            {
                string tutee = "No";
                string tutor = "Yes";
                var user = (from row in db.Users where row.ID == stu.ID select row).First();
                if ((bool)stu.Tutee)
                    tutee = "Yes";
                else
                    tutee = "No";
                if ((bool)stu.Tutor)
                    tutor = "Yes";
                else
                    tutor = "No";
                lvStudent.Items.Add(new ListViewItem(new string[] { user.Username, user.LastName, user.FirstName, tutor, tutee, user.Email, user.PhoneNumber }));
            }

            
        }

        private void setupFacultyLV() //This is what populates the box of students
        {
            lvFaculty.CheckBoxes = true;
            lvFaculty.Columns.Add("     Username", 105);// This first block of commands sets up the top row.
            lvFaculty.Columns.Add("Last Name", 100);
            lvFaculty.Columns.Add("First Name", 100);
            lvFaculty.Columns.Add("Department", 100);

            TutorMasterDBEntities4 db = new TutorMasterDBEntities4(); //create a new indirect entity
            var facultys = from c in db.Faculties select c; // c is arbitay thing to pull. from var in tabletopullfrom select  
            List<Faculty> fs = new List<Faculty>();
            fs = facultys.ToList();

            foreach (Faculty f in fs)
            {
                var user = (from row in db.Users where row.ID == f.ID select row).First();
  
                lvFaculty.Items.Add(new ListViewItem(new string[] { user.Username, user.LastName, user.FirstName, f.Department }));
            }
        }

        private void setupClassLV() //This is what populates the box of students
        {
            lvClass.CheckBoxes = true;
            lvClass.Columns.Add("     Class Code", 100);// This first block of commands sets up the top row.
            lvClass.Columns.Add("Class Name", 150);
            lvClass.Columns.Add("Department", 100);

            TutorMasterDBEntities4 db = new TutorMasterDBEntities4(); //create a new indirect entity
            var classes = from c in db.Classes select c; // c is arbitay thing to pull. from var in tabletopullfrom select  
            List<Class> cs = new List<Class>();
            cs = classes.ToList();

            foreach (Class c in cs)
            {
                lvClass.Items.Add(new ListViewItem(new string[] { c.ClassCode, c.ClassName, c.Department }));
            }
        }

        private void setupDepartmentBoxes()
        {
            TutorMasterDBEntities4 db = new TutorMasterDBEntities4();

        }

        private void disableButtons()
        {
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
        }

        private void btnCreateStudent_Click(object sender, EventArgs e)
        {
            CreateStudent g = new CreateStudent();
            g.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login g = new Login(); //Are we going to create problems by create new loginb boxes on top of the hidden ones we already have?
            g.Show();
            this.Close();
        }

        private void AdminMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //System.Windows.Forms.Application.Exit();
        }

        private void lvStudent_ItemChecked(object sender, ItemCheckedEventArgs e) //This function determines when certain buttons should be activated or deativated
        {
            int itemsChecked = lvStudent.CheckedItems.Count; // .CheckedItems.Count tells how many things in the list box are clicked
            if (itemsChecked == 1)
            {
                btnEdit.Enabled = true;
            }
            else
            {
                btnEdit.Enabled = false;
            }
            if (itemsChecked > 0)
            {
                btnDelete.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            TutorMasterDBEntities4 db = new TutorMasterDBEntities4();
            string username = lvStudent.CheckedItems[0].Text.ToString();
            int studentID = (from row in db.Users where row.Username == username select row.ID).First();
            EditStudentForm g = new EditStudentForm(studentID);
            g.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TutorMasterDBEntities4 db = new TutorMasterDBEntities4();
            int stuNum = lvStudent.CheckedItems.Count;
            for (int i = 0; i < stuNum; i++)
            {
                string username = lvStudent.CheckedItems[i].SubItems[0].Text;
                User delU = (from row in db.Users where row.Username == username select row).First();
                db.Users.DeleteObject(delU);
                db.SaveChanges();
            }

            lvStudent.Clear();
            setupStudentLV();
        }

        private void lvStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvFaculty_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            int itemsChecked = lvFaculty.CheckedItems.Count; // .CheckedItems.Count tells how many things in the list box are clicked
            if (itemsChecked == 1)
            {
                btnFacultyEdit.Enabled = true;
            }
            else
            {
                btnFacultyEdit.Enabled = false;
            }
            if (itemsChecked > 0)
            {
                btnFacultyDelete.Enabled = true;
            }
            else
            {
                btnFacultyDelete.Enabled = false;
            }
        }

        private void lvClass_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            int itemsChecked = lvClass.CheckedItems.Count; // .CheckedItems.Count tells how many things in the list box are clicked
            if (itemsChecked == 1)
            {
                btnClassEdit.Enabled = true;
            }
            else
            {
                btnClassEdit.Enabled = false;
            }
            if (itemsChecked > 0)
            {
                btnClassDelete.Enabled = true;
            }
            else
            {
                btnClassDelete.Enabled = false;
            }
        }
    }
}
