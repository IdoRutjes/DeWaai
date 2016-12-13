﻿using System.Collections.ObjectModel;
using System.Data.Entity.Validation;
using System.Linq;

namespace DeWaaiBeheer
{
    public class DatabaseMethods
    {
        private EntityFramework ef = new EntityFramework();

        #region User Methods

        /// <summary>
        /// Method to get all users
        /// </summary>
        /// <returns></returns>
        public ObservableCollection<Users> getUsers()
        {
            return new ObservableCollection<Users>(ef.Users);
        }

       

        /// <summary>
        /// Method that gets users of a specific course
        /// </summary>
        /// <returns>Returns a list users of a course</returns>
        public object getUsersByCourse()
        {
            var result = (from x in ef.Registrations                         
                          join cd in ef.Users
                          on x.UserID equals cd.ID
                          join xd in ef.Courses
                          on x.CourseID equals xd.ID
                          select cd.Firstname).Distinct().ToList();

            return result;
        }

        /// <summary>
        /// Method that sets users into database
        /// </summary>
        /// <param name="user">Parameter of user</param>
        public void AddUser(Users user)
        {
            ef.Users.Add(user);
        }
     
        /// <summary>
        /// Method that removes a user of the database table
        /// </summary>
        /// <param name="userId">Parameter of userId</param>
        public void RemoveUser(int userId)
        {
            ef.Users.Remove(getUsers().First(x => x.ID == userId));
        }
        #endregion

        #region Savechanges
        /// <summary>
        /// Method who saves something into database
        /// </summary>
        public void SaveChanges()
        {
            try
            {
                ef.SaveChanges();
            }
            catch (DbEntityValidationException dbex)
            {
                throw dbex;
            }
          
        }
        #endregion

        #region Courses Methods

        /// <summary>
        /// Method that gets courses
        /// </summary>
        /// <returns>Returns a list users of a course</returns>
        public object getCourse()
        {
            var result = (from x in ef.Registrations
                          join xd in ef.Courses
                          on x.CourseID equals xd.ID
                          select xd.Name).Distinct().ToList();

            return result;
        }

        public ObservableCollection<Courses> getCourses()
        {
            return new ObservableCollection<Courses>(ef.Courses);
        }

        public ObservableCollection<Courses> GetCoursesbyID(int courseID)
        {
            return new ObservableCollection<Courses>(ef.Courses.Where(x => x.ID == courseID));
        }

        public void AddCourse(Courses course)
        {
            ef.Courses.Add(course);
        }

        public void RemoveCourse(int courseid)
        {
            ef.Courses.Remove(getCourses().First(x => x.ID == courseid));
        }
        #endregion

        #region Fleet Methods
        public ObservableCollection<Fleet> getFleet()
        {
            return new ObservableCollection<Fleet>(ef.Fleet);
        }

        public void AddFleet(Fleet fleet)
        {
            ef.Fleet.Add(fleet);
        }

        public void RemoveFleet(int fleetid)
        {
            ef.Fleet.Remove(getFleet().First(x => x.ID == fleetid));
        }

        //public ObservableCollection<Types> getUniqueBoats()
        //{
        //    var result = (from bt in ef.Types
        //                  where bt.Name 
        //                  select bt.Name).Distinct();
        //    return new ObservableCollection<Types>(result);
        //}
        #endregion

        #region BoatTypes
        public ObservableCollection<Types> GetBoatTypes()
        {
            return new ObservableCollection<Types>(ef.Types);
        }

        public void AddBoatType(Types types)
        {
            ef.Types.Add(types);
        }

        public void RemoveBoatType(int typeid)
        {
            ef.Types.Remove(GetBoatTypes().First(x => x.ID == typeid));
        }
        #endregion

        #region Instructors Methods
        public ObservableCollection<Instructors> GetInstructors()
        {
            return new ObservableCollection<Instructors>(ef.Instructors);
        }
        #endregion
    }
}
