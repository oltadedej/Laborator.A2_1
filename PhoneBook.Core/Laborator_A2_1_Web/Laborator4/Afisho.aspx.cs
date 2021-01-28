using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laborator_A2_1_Web.Laborator4
{
    public partial class Afisho : System.Web.UI.Page
    {
        public int studentId { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var studentid = Request.QueryString["studentId"];
                if (studentid != null)
                {
                    studentId = Convert.ToInt32(studentid);
                    using (University1Entities dbcontext = new University1Entities())
                    {
                        var student = dbcontext.Students.ToList().FirstOrDefault(i => i.StudentId == studentId);
                        if (student != null)
                        {
                            lblName.Text = student.Emer;
                            lblSurname.Text = student.Mbiemer;
                            lblEnrollmentDate.Text = student.EnrollmentDate.ToString("dd/MM/yyyy");
                        }

                        //fill with value course resuts
                        var courses = from course in dbcontext.Courses
                                      join enrollment in dbcontext.Enrollments on course.CourseId equals enrollment.CourseId
                                      join student_ in dbcontext.Students on enrollment.StudentId equals student_.StudentId
                                      where student_.StudentId == studentId
                                      select course;

                        gdvCourse.DataSource = courses.ToList<Course>();
                        gdvCourse.DataBind();

                    }
                }
            }
        }
    }
}