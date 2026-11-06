using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAbsenceManagement
{
    internal class Absence
    {
        public int Id { get; }
        public int StudentId { get; }
        public DateTime Date { get; }
        public bool IsJustified { get; }
        public Absence(int id, int studentId, DateTime date, bool isJustified)
        {
            if (id <= 0) {
                 throw new ArgumentOutOfRangeException(nameof(id), "Absence ID must be positive.");
            }
            Id = id;
            if (studentId <= 0) {
                throw new ArgumentOutOfRangeException(nameof(studentId), "Student ID must be positive.");
            }
            StudentId = studentId;
            if(date == DateTime.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(date), "Student ID must be positive.");
            }
            Date = date;
            IsJustified = isJustified;
        }

    }
}
