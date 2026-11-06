using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAbsenceManagement
{
    internal class AbsenceManager
    {
        private readonly StudentManager studentManager;
        private readonly Dictionary<int,Absence> absences = new Dictionary<int,Absence>();
        public AbsenceManager(StudentManager studentManager)
        {
            if (studentManager is null)
                throw new ArgumentNullException(nameof(studentManager));
            this.studentManager = studentManager;
        }
        public bool RecordAbsence(Absence absence)
        {
            if (absence is null) throw new ArgumentNullException(nameof(absence)) ;

            if ((studentManager.FindStudent(absence.StudentId)) is null) { 
                    return false;
            }
            return absences.TryAdd(absence.Id, absence);
        }
        public List<Absence> GetAbsencesByStudent(int studentId)
        {
            return absences.Values.Where( a => a.StudentId == studentId).ToList();
        }
        public Absence? GetAbsenceById(int id)
        {
             absences.TryGetValue(id,out Absence? absence);
            return absence;
        }
    }
}
