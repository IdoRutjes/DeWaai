﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Validation;

namespace DeWaaiBeheer
{
    public partial class frmHome : Form
    {
        private DatabaseMethods db = new DatabaseMethods();

        public frmHome()
        {
            InitializeComponent();
            myAccountToolStripMenuItem.Text = ("Mijn account");
            logoutToolStripMenuItem.Text = ("Uitloggen");
            nameToolStripMenuItem.Text = ("Admin");
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        /// <summary>
        /// Gets the my account form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void myAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.account.ShowDialog();
        }

        /// <summary>
        /// Logs out from user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }

        #region SideMenu buttons
        private void btnCourses_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCoursesPage frmCourse = new frmCoursesPage();
            frmCourse.Show();
            
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Close();
            frmUsersPage frmUser = new frmUsersPage();
            frmUser.Show();
        }

        private void btnInstructors_Click(object sender, EventArgs e)
        {
            this.Close();
            frmInstructorsPage frmInstructor = new frmInstructorsPage();
            frmInstructor.Show();
        }

        private void btnReviews_Click(object sender, EventArgs e)
        {
            this.Close();
            frmReviews reviews = new frmReviews();
            reviews.Show();
        }

        private void btnRegistrations_Click(object sender, EventArgs e)
        {
            this.Close();
            frmTenders tenders = new frmTenders();
            tenders.Show();
        }

        private void btnFleets_Click(object sender, EventArgs e)
        {
            this.Close();
            VlotenPage frmFleets = new VlotenPage();
            frmFleets.Show();
        }
        #endregion

        private void frmHome_Load(object sender, EventArgs e)
        {
            Users user = new Users();

            BindingSource registrations = new BindingSource { DataSource = db.getUsersByRegistration() };
            lstUsers.DataSource = registrations;

            lblNewUserDate.Text = DateTime.Now.ToShortDateString();
            lblNewTenderDate.Text = DateTime.Now.ToShortDateString();

            
            //user.NewUserDate = Convert.ToDateTime(lblNewUserDate.Text);
            //if (user.NewUserDate < DateTime.Now)
            //{
            //    lblPreviousUserDate.Text = Convert.ToString(user.NewUserDate.ToShortDateString());
            //    lblNewUserDate.Text = DateTime.Now.ToShortDateString();
            //}

        }

        private void btnTenders_Click(object sender, EventArgs e)
        {
            this.Close();
            frmTenders frm = new frmTenders();
            frm.Show();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            //int ID = Convert.ToInt32(lstUsers.SelectedValue);
            //Registrations registration = db.GetRegistrationsByID(ID);
            //registration.Accepted = 1;
            //db.SaveChanges();
        }
    }
}
