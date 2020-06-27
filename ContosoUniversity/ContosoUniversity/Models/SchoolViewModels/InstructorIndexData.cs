﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models.SchoolViewModels
{
    public class InstructorIndexData
    {
        public IEnumerable<Instructor> Instructors { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Enrollment> Enrollments { get; set; }
    }

    public class Instructor
    {
        public List<CourseAssignment> CourseAssignments { get; internal set; }
        public int ID { get; internal set; }

        public static implicit operator Instructor(Models.Instructor v)
        {
            throw new NotImplementedException();
        }
    }
}