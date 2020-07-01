using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models.SchoolViewModels
{
    public class InstructorIndexData
    {
        internal IEnumerable<object> Instructor;
        private IEnumerable<object> instructors;

        public IEnumerable<Instructor> GetInstructors()
        {
            return Instructor1;
        }

        public void SetInstructors(IEnumerable<Instructor> value)
        {
            instructors = value;
        }

        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Enrollment> Enrollments { get; set; }
        public IEnumerable<object> Instructors { get; internal set; }
        public IEnumerable<Instructor> Instructor1 { get; set; }
    }

    public class Instructor
    {
        public List<CourseAssignment> CourseAssignments { get; internal set; }
        public int ID { get; internal set; }
        public object FirstMidName { get; internal set; }

        public static implicit operator Instructor(Models.Instructor v)
        {
            throw new NotImplementedException();
        }
    }
}