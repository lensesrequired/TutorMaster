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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter in both a username and password.");
            }

            else if (isValidUser(username, password))
            {
                string accType = getAccType(username);
                int accID = getID(username);
                lblErrMsg.Text = accType + accID.ToString();
                switch (accType)
                {
                    case "Student":
                        //send ID to student form
                        StudentMain a = new StudentMain(accID);
                        a.Show();
                        this.Hide();
                        break;
                    case "Faculty":
                        //send ID to faculty form
                        FacultyMain g = new FacultyMain(accID);
                        
                        g.Show();
                        this.Hide();
                        break;
                    default:        //Admin account
                    //open admin form (shouldn't need ID?)
                        AdminMain f = new AdminMain();
                        f.Show();
                        this.Hide();
                        break;
                }
            }
            else
            {
                lblErrMsg.Text = "Invalid Username or Password. Try again.";
            }
        }

        private bool isValidUser(string username, string password)
        {
            TutorMasterDBEntities3 db = new TutorMasterDBEntities3();

            bool found = false;
            if (db.Users.Any(u => u.Username == username))
            {
                string pw = (from row in db.Users where row.Username == username select row.Password).Single();
                if (password == pw)
                {
                    found = true;
                }
            }

            return (found);
        }

        private string getAccType(string username)
        {
            TutorMasterDBEntities3 db = new TutorMasterDBEntities3();

            string accType = (from row in db.Users where row.Username == username select row.AccountType).Single();

            return (accType);
        }

        private int getID(string username)
        {
            TutorMasterDBEntities3 db = new TutorMasterDBEntities3();

            int accID = (from row in db.Users where row.Username == username select row.ID).First();

            return accID;
        }

        

        private void clearErrMsg(object sender, EventArgs e)
        {
            lblErrMsg.Text = "";
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }



    }
}
