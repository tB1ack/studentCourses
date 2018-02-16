using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void assignment1Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a List of Courses (add three example Courses ...
             * make up the details).  Each Course should have at least two
             * Students enrolled in them.  Use Object and Collection
             * Initializers.  Then, iterate through each Course and print
             * out the Course's details and the Students that are enrolled in
             * each Course.
             */

            resultLabel.Text = "";

            List<Course> course = new List<Course>()
            {
                new Course{CourseId=1, Name="MTH 251", Students= new List<Student>() {
                    new Student() {StudentId = 1, Name = "Frank"},
                    new Student() {StudentId = 2, Name = "Jim"}}},
                new Course{CourseId=2, Name="CS 160", Students= new List<Student>() {
                    new Student() {StudentId = 3, Name = "Sam"},
                    new Student() {StudentId = 1, Name = "Frank"}}},
                new Course{CourseId=3, Name="CIS 150", Students= new List<Student>() {
                    new Student() {StudentId = 3, Name = "Sam"},
                    new Student() {StudentId = 2, Name = "Jim"}}}
            };

            foreach (var eachCourse in course)
            {
                resultLabel.Text += String.Format("<br>&nbsp;<br />Course - <br />Name: {0}<br />ID: {1}<br />Students: <br />",
                    eachCourse.Name, eachCourse.CourseId);
                foreach (Student courseStudents in eachCourse.Students)
                {
                    resultLabel.Text += String.Format("&nbsp;&nbsp;&nbsp;&nbsp;{0} <br />", courseStudents.Name);
                }
            }
        }

        protected void assignment2Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a Dictionary of Students (add three example Students
             * ... make up the details).  Use the StudentId as the 
             * key.  Each student must be enrolled in two Courses.  Use
             * Object and Collection Initializers.  Then, iterate through
             * each student and print out to the web page each Student's
             * info and the Courses the Student is enrolled in.
             */

            resultLabel.Text = "";

            Dictionary<int, Student> students = new Dictionary<int, Student>()
            {
                {1, new Student {StudentId = 1, Name = "Frank", Courses = new List<Course> {
                    new Course() { CourseId = 1, Name = "MTH 251" },
                    new Course() { CourseId = 2, Name = "CS 160"} } }
                },
                { 2, new Student { StudentId = 2, Name = "Jim", Courses = new List<Course> {
                    new Course() { CourseId = 1, Name = "MTH 251" },
                    new Course() { CourseId = 3, Name = "CIS 150"} } }
                },
                { 3, new Student { StudentId = 3, Name = "Sam", Courses = new List<Course> {
                    new Course() { CourseId = 3, Name = "CIS 150" },
                    new Course() { CourseId = 2, Name = "CS 160"} } }
                },
            };

            foreach (var eachStudent in students)
            {
                resultLabel.Text += String.Format("<br>&nbsp;<br />Student - <br />Name: {0}<br />ID: {1}<br />Courses: <br />",
                    eachStudent.Value.Name, eachStudent.Value.StudentId);
                foreach (var studentCourse in eachStudent.Value.Courses)
                {
                    resultLabel.Text += String.Format("&nbsp;&nbsp;&nbsp;&nbsp;{0} <br />", studentCourse.Name);
                }
            }
        }

        protected void assignment3Button_Click(object sender, EventArgs e)
        {
            /*
             * We need to keep track of each Student's grade (0 to 100) in a 
             * particular Course.  This means at a minimum, you'll need to add 
             * another class, and depending on your implementation, you will 
             * probably need to modify the existing classes to accommodate this 
             * new requirement.  Give each Student a grade in each Course they
             * are enrolled in (make up the data).  Then, for each student, 
             * print out each Course they are enrolled in and their grade.
             */

            resultLabel.Text = "";

            List<Student> students = new List<Student>() {
                new Student() {StudentId = 1, Name= "Frank", Courses= new List<Course>() {
                    new Course {Grade = new Grade(){grade = 96 }, CourseId = 1, Name = "MTH 251" },
                    new Course {Grade = new Grade(){grade = 87 }, CourseId = 2, Name = "CS 160" } } },
                new Student() {StudentId = 2, Name= "Jim", Courses= new List<Course>() {
                    new Course {Grade = new Grade(){grade = 84 }, CourseId = 1, Name = "MTH 251" },
                    new Course {Grade = new Grade(){grade = 98 }, CourseId = 3, Name = "CIS 150" } } },
                new Student() {StudentId = 3, Name= "Sam", Courses= new List<Course>() {
                    new Course {Grade = new Grade(){grade = 78 }, CourseId = 3, Name = "CIS 150" },
                    new Course {Grade = new Grade(){grade = 85 }, CourseId = 2, Name = "CS 160" } } }

            };

            foreach (var student in students)
            {
                resultLabel.Text += String.Format("<p/><br/>Student:<br/>Name: {0}<br/>StudentID: {1}", student.Name, student.StudentId);

                foreach (var course in student.Courses)
                {
                    resultLabel.Text += String.Format("<br/>Enrolled In: {0} - Grade: {1}", course.Name, course.Grade.grade);
                }
            }           
        }
    }
}