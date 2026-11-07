using StudentAbsenceManagement;
using System.Security.Cryptography;


//try
//{
//    Student s1 = new Student(1, "Ahmed", "Alami");
//    Console.WriteLine(s1.Id);
//    Console.WriteLine(s1.LastName);
//    Console.WriteLine(s1.FirstName);
//}
//catch (ArgumentException ex)
//{
//    Console.WriteLine($"{ex.GetType().Name}: {ex.Message}");
//}

//try
//{
//    Student s2 = new Student(0, "Ahmed", "Alami");
//}
//catch (ArgumentException ex)
//{
//        Console.WriteLine($"{ex.GetType().Name}: {ex.Message}");
//}
//try
//{
//    Student s3 = new Student(2, "", "Alami");
//}
//catch (ArgumentException ex)
//{
//    Console.WriteLine($"{ex.GetType().Name}: {ex.Message}");
//}
//try
//{
//    Student s4 = new Student(3, "Ahmed", "   ");
//}
//catch (ArgumentException ex)
//{
//    Console.WriteLine($"{ex.GetType().Name}: {ex.Message}");
//}

/// test of add method from StudentManager class 
//Student st = new Student(1, "Ahmed", "Alami");

//StudentManager studentManager = new StudentManager();
//bool result = studentManager.AddStudent(st);
//if (result)
//{
//    Console.WriteLine("TEST PASSED");
//}
//else
//{
//    Console.WriteLine("TEST FAILED");
//}
//Student st1 = new Student(1, "Amin", "Alam");
//bool result1 = studentManager.AddStudent(st1);
//if (!result1)
//{
//    Console.WriteLine("TEST PASSED");
//}
//else
//{
//    Console.WriteLine("TEST FAILED");
//}

//try
//{
//    // Call AddStudent with null
//    studentManager.AddStudent(null!);
//    Console.WriteLine("Test 3: FAILED");
//}
//catch (ArgumentNullException)
//{
//    Console.WriteLine("Test 3: PASSED");

//}

///// test the find method 
//StudentManager manager = new StudentManager();
//manager.AddStudent(new Student(1, "Ahemed", "warish"));
//manager.AddStudent(new Student(2, "Amin", "srif"));
//manager.AddStudent(new Student(3, "Sara", "darif"));
//manager.AddStudent(new Student(4, "Ali", "alami"));

//Student? result = manager.FindStudent(1);

//if (result is not null && result.Id == 1)
//{
//    // TEST PASSED
//    Console.WriteLine("TEST PASSED");

//}
//else
//{
//    // TEST FAILED
//    Console.WriteLine("TEST FAILED");
//}

//Student? result1 = manager.FindStudent(99);

//if (result is not null && result.Id == 99)
//{
//    Console.WriteLine("TEST Failed");

//}
//else
//{
//    Console.WriteLine("TEST passed");
//}
////////////// Test the GetAllStudent method 
//StudentManager emptyManager = new();

//List<Student> result1 = emptyManager.GetAllStudents();
//if (result1.Count == 0)
//{
//    Console.WriteLine("Test 1: PASSED");
//}
//else
//{
//    Console.WriteLine("Test 1: FAILED");
//}

//StudentManager manager = new();

//manager.AddStudent(new Student(1, "Ahmed", "Alami"));
//manager.AddStudent(new Student(2, "Sara", "Bennani"));
//manager.AddStudent(new Student(3, "Youssef", "Idrissi"));

//List<Student> result2 = manager.GetAllStudents();
//if (result2.Count ==3 && result2.Any(s => s.Id == 1 && result2.Any(s => s.Id == 2) && result2.Any(s => s.Id == 3)))
//{
//    Console.WriteLine("Test 2: PASSED");
//}
//else
//{
//    Console.WriteLine("Test 2: FAILED");
//}

//List<Student> result3 = manager.GetAllStudents();

//result3.Clear();
//if (result3.Count == 0 &&
//    manager.GetAllStudents().Count == 3)
//{
//    Console.WriteLine("Test 3: PASSED");
//}
//else
//{
//    Console.WriteLine("Test 3: FAILED");
//}
//DateTime absenceDate = new DateTime(2026, 11, 5);

//Absence absence = new Absence(1, 5, absenceDate, false);

//if (absence.Id == 1 &&
//    absence.StudentId == 5 &&
//    absence.Date == absenceDate &&
//    !absence.IsJustified)
//{
//    Console.WriteLine("Test 1: PASSED");
//}
//else
//{
//    Console.WriteLine("Test 1: FAILED");
//}
//try
//{
//    Absence invalid = new Absence(
//        0, 5, new DateTime(2026, 11, 5), false);

//    Console.WriteLine("Test 2: FAILED");
//}
//catch (ArgumentOutOfRangeException ex)
//{
//    if (ex.ParamName == "id")
//    {
//        Console.WriteLine("Test 2: PASSED");
//    }
//    else
//    {
//        Console.WriteLine("Test 2: FAILED");
//    }
//}
//try
//{
//    Absence absence1 = new Absence(3, -7, absenceDate, false);
//    Console.WriteLine("Test 3: FAILED");
//}
//catch (ArgumentOutOfRangeException ex)
//{
//    if (ex.ParamName == "studentId")
//    {
//        Console.WriteLine("Test 3: PASSED");
//    }
//    else
//    {
//        Console.WriteLine("Test 3: FAILED");
//    }
//}

//try
//{
//    Absence absence1 = new Absence(1, 5, DateTime.MinValue, false);
//    Console.WriteLine("Test 4: FAILED");
//}
//catch (ArgumentOutOfRangeException ex)
//{
//    if (ex.ParamName == "date")
//    {
//        Console.WriteLine("Test 4: PASSED");
//    }
//    else
//    {
//        Console.WriteLine("Test 4: FAILED");
//    }
//}

//StudentManager studentManager = new StudentManager();

//studentManager.AddStudent(
//    new Student(1, "Ahmed", "Alami"));

//AbsenceManager absenceManager =
//    new AbsenceManager(studentManager);

//Absence absence = new Absence(
//    10, 1, new DateTime(2026, 11, 5), false);
//bool result = absenceManager.RecordAbsence(absence);

//if (result)
//{
//    Console.WriteLine("Test 1: PASSED");
//}
//else
//{
//    Console.WriteLine("Test 1: FAILED");
//}
//Absence invalidAbsence = new Absence(11, 999, new DateTime(2026, 11, 5), false);
//result = absenceManager.RecordAbsence(invalidAbsence);

//if (!result)
//{
//    Console.WriteLine("Test 2: PASSED");
//}
//else
//{
//    Console.WriteLine("Test 2: FAILED");
//}
//Absence idAbsence = new Absence(10, 1, new DateTime(2026, 11, 5), true);
//result = absenceManager.RecordAbsence(idAbsence);

//if (!result)
//{
//    Console.WriteLine("Test 3: PASSED");
//}
//else
//{
//    Console.WriteLine("Test 3: FAILED");
//}
//try
//{
//    absenceManager.RecordAbsence(null!);

//    Console.WriteLine("Test 4: FAILED");
//}
//catch (ArgumentNullException ex)
//{
//    if (ex.ParamName == "absence")
//    {
//        Console.WriteLine("Test 4: PASSED");
//    }
//    else
//    {
//        Console.WriteLine("Test 4: FAILED");
//    }
//}

StudentManager studentManager = new StudentManager();

studentManager.AddStudent(new Student(4, "Ahmed", "Alami"));
studentManager.AddStudent(new Student(2, "Sara", "Bennani"));
studentManager.AddStudent(new Student(3, "Youssef", "Amrani"));

AbsenceManager absenceManager = new AbsenceManager(studentManager);

//absenceManager.RecordAbsence(
//    new Absence(10, 1, new DateTime(2026, 11, 1), false));

//absenceManager.RecordAbsence(
//    new Absence(11, 2, new DateTime(2026, 11, 2), false));

//absenceManager.RecordAbsence(
//    new Absence(12, 1, new DateTime(2026, 11, 3), true));

absenceManager.RecordAbsence(
    new Absence(10, 2, new DateTime(2026, 11, 4), false));
//List<Absence> result = absenceManager.GetAbsencesByStudent(1);

//if (result.Count !=0 && result.Any(a => a.Id == 10) && result.Any(a => a.Id == 12))
//{
//    Console.WriteLine("Test 1: PASSED");
//}
//else
//{
//    Console.WriteLine("Test 1: FAILED");
//}
//Absence? result1 = absenceManager.GetAbsenceById(999);
//if ((result1 is  null) )
//{
//    Console.WriteLine("Test 1: PASSED");
//}
//else
//{
//    Console.WriteLine("Test 1: FAILED");
//}
StudentAbsenceMenu menu = new StudentAbsenceMenu(studentManager, absenceManager);
menu.Run();
//bool result = absenceManager.JustifyAbsence(10);
//result = absenceManager.JustifyAbsence(10);
//Absence? absence = absenceManager.GetAbsenceById(10);

//if (!result && absence is not null && absence.IsJustified)
//{
//    Console.WriteLine("Test 1: PASSED");
//}
//else
//{
//    Console.WriteLine("Test 1: FAILED");
//}
//result = absenceManager.JustifyAbsence(999);
//absence = absenceManager.GetAbsenceById(999);

//if (!result && absence is  null )
//{
//    Console.WriteLine("Test 1: PASSED");
//}
//else
//{
//    Console.WriteLine("Test 1: FAILED");
//}
//absence = absenceManager.GetAbsenceById(10);
//Console.WriteLine(absence.IsJustified);