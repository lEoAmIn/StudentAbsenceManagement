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
DateTime absenceDate = new DateTime(2026, 11, 5);

Absence absence = new Absence(1, 5, absenceDate, false);

if (absence.Id == 1 &&
    absence.StudentId == 5 &&
    absence.Date == absenceDate &&
    !absence.IsJustified)
{
    Console.WriteLine("Test 1: PASSED");
}
else
{
    Console.WriteLine("Test 1: FAILED");
}
try
{
    Absence invalid = new Absence(
        0, 5, new DateTime(2026, 11, 5), false);

    Console.WriteLine("Test 2: FAILED");
}
catch (ArgumentOutOfRangeException ex)
{
    if (ex.ParamName == "id")
    {
        Console.WriteLine("Test 2: PASSED");
    }
    else
    {
        Console.WriteLine("Test 2: FAILED");
    }
}
try
{
    Absence absence1 = new Absence(3, -7, absenceDate, false);
    Console.WriteLine("Test 3: FAILED");
}
catch (ArgumentOutOfRangeException ex)
{
    if (ex.ParamName == "studentId")
    {
        Console.WriteLine("Test 3: PASSED");
    }
    else
    {
        Console.WriteLine("Test 3: FAILED");
    }
}

try
{
    Absence absence1 = new Absence(1, 5, DateTime.MinValue, false);
    Console.WriteLine("Test 4: FAILED");
}
catch (ArgumentOutOfRangeException ex)
{
    if (ex.ParamName == "date")
    {
        Console.WriteLine("Test 4: PASSED");
    }
    else
    {
        Console.WriteLine("Test 4: FAILED");
    }
}
