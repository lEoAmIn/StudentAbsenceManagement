namespace StudentAbsenceManagement
{
    internal class Student
    { /// start of the student class 
        public int Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public Student(int id, string firstName, string lastName)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(id), "ID must be positive.");
            }
            Id = id;
            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentException("First name cannot be empty.", nameof(firstName));
            }
            FirstName = firstName;
            if (string.IsNullOrWhiteSpace(lastName))
            {
                throw new ArgumentException("First name cannot be empty.", nameof(lastName));
            }
            LastName = lastName;
        }/// end of constructor 
    }// end of student class 


}
