﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeWaaiBeheer
{
    public partial class frmNewCourse : Form
    {
        private DatabaseMethods db = new DatabaseMethods();
        private BindingSource courses;
        private Courses course;

        public frmNewCourse()
        {
            InitializeComponent();
            course = new Courses();
            courses = new BindingSource();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            string date = dtpDate.Value.ToShortDateString();
            string name = txtName.Text;

            if (!String.IsNullOrEmpty(txtName.Text) && !String.IsNullOrEmpty(txtDescription.Text) && !String.IsNullOrEmpty(txtPrice.Text) && !String.IsNullOrEmpty(txtAmount.Text))
            {
                if (name != course.Name)
                {
                    course.Name = txtName.Text;
                    course.Description = txtDescription.Text;
                    course.Date = date;
                    course.Color = "ok";
                    course.Price = Convert.ToInt32(txtPrice.Text);
                    course.Amount = Convert.ToInt32(txtAmount.Text);
                    course.Created = DateTime.Now;
                    course.Status = 1;

                    db.AddCourse(course);
                    db.SaveChanges();
                    Program.courses.updateListbox();

                    MessageBox.Show("Cursus is succesvol toegevoegd!");

                    this.Close();
                    frmCoursesPage page = new frmCoursesPage();
                    page.Show();


                }
                else
                {
                    MessageBox.Show("Deze cursus bestaat al!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("U heeft een aantal verplichte velden niet ingevuld!");
            }

        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
           NumberOnly(sender, e);
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
           NumberOnly(sender, e);
        }

        public void NumberOnly(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime pickedDate = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day);
            pickedDate.ToShortDateString();

            if(pickedDate.Month >= 10 || pickedDate.Month < 4 && pickedDate.DayOfWeek != DayOfWeek.Monday)
            {
                MessageBox.Show("Tussen 1 oktober en 1 april kunt u geen cursus selecteren & u kunt alleen een cursus op maandag boeken!!");
            }      
        }
    }
}
