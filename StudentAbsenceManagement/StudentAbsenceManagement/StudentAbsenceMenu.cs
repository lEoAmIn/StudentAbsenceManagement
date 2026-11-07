namespace StudentAbsenceManagement
{
    internal class StudentAbsenceMenu
    {
        private readonly StudentManager studentManager;
        private readonly AbsenceManager absenceManager;
        public StudentAbsenceMenu(StudentManager studentManager, AbsenceManager absenceManager)
        {
            if (studentManager is null) throw new ArgumentNullException(nameof(studentManager));
            this.studentManager = studentManager;
            if (absenceManager is null) throw new ArgumentNullException(nameof(absenceManager));
            this.absenceManager = absenceManager;
        }


        public void Run()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n===== STUDENT ABSENCE MANAGEMENT =====");
                Console.WriteLine("1. Add a student");
                Console.WriteLine("2. Display all students");
                Console.WriteLine("3. Record an absence");
                Console.WriteLine("0. Exit");
                Console.Write("Choose an option: ");

                string? input = Console.ReadLine();

                if (!int.TryParse(input, out int choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }
                switch (choice)
                {
                    case 0:
                        running = false;
                        Console.WriteLine("Goodbye!");
                        break;

                    case 1:
                        AddStudent();
                        break;

                    case 2:
                        DisplayStudents();

                        break;

                    case 3:
                        RecordAbsence();
                        break;
                    default:
                        Console.WriteLine("Unknown menu option.");
                        break;
                }
            }
        
        }
        private void AddStudent()
        {
            Console.Write("Enter student ID: ");
            if (!int.TryParse(Console.ReadLine(), out int studentId)
                || studentId <= 0)
            {
                Console.WriteLine("Invalid student ID.");
                return;
            }

            Console.Write("Enter first name: ");
            string? firstName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(firstName))
            {
                Console.WriteLine("First name cannot be empty.");
                return;
            }

            Console.Write("Enter last name: ");
            string? lastName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(lastName))
            {
                Console.WriteLine("Last name cannot be empty.");
                return;
            }

            try
            {
                Student student = new Student(
                    studentId, firstName, lastName);

                if (studentManager.AddStudent(student))
                    Console.WriteLine("Student added successfully.");
                else
                    Console.WriteLine("A student with this ID already exists.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        private void DisplayStudents()
        {
            List<Student> students = studentManager.GetAllStudents();

            if (students.Count == 0)
            {
                Console.WriteLine("No students found.");
                return;
            }

            Console.WriteLine("\n===== STUDENT LIST =====");

            foreach (Student student in students)
            {
                Console.WriteLine(
                    $"ID: {student.Id} | " +
                    $"Name: {student.FirstName} {student.LastName}");
            }
        }
        private void RecordAbsence()
        {
            Console.Write("Enter absence ID: ");
            if (!int.TryParse(Console.ReadLine(), out int absenceId)
                || absenceId <= 0)
            {
                Console.WriteLine("Invalid absence ID.");
                return;
            }

            Console.Write("Enter student ID: ");
            if (!int.TryParse(Console.ReadLine(), out int absentStudentId)
                || absentStudentId <= 0)
            {
                Console.WriteLine("Invalid student ID.");
                return;
            }

            if (studentManager.FindStudent(absentStudentId) is null)
            {
                Console.WriteLine("Student not found.");
                return;
            }

            Console.Write("Enter absence date (yyyy-MM-dd): ");
            string? dateInput = Console.ReadLine();

            if (!DateTime.TryParseExact(
                dateInput,
                "yyyy-MM-dd",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None,
                out DateTime absenceDate))
            {
                Console.WriteLine("Invalid date. Use yyyy-MM-dd.");
                return;
            }

            try
            {
                Absence absence = new Absence(
                    absenceId,
                    absentStudentId,
                    absenceDate,
                    false);

                if (absenceManager.RecordAbsence(absence))
                    Console.WriteLine("Absence recorded successfully.");
                else
                    Console.WriteLine(
                        "Unable to record absence. Check for a duplicate ID.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
