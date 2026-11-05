using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAbsenceManagement
{
    internal class StudentManager
    {
        private Dictionary<int, Student> students = new();
        /// the add student method creation 
        public bool AddStudent(Student student)
        {
            if(student is null)
            {
                throw new ArgumentNullException(nameof(student));
            }
            return students.TryAdd(student.Id, student);    
        }

    }
}
