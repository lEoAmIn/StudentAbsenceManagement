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
Student st = new Student(1, "Ahmed", "Alami");

StudentManager studentManager = new StudentManager();
bool result = studentManager.AddStudent(st);
if (result)
{
    Console.WriteLine("TEST PASSED");
}
else
{
    Console.WriteLine("TEST FAILED");
}
Student st1 = new Student(1, "Amin", "Alam");
bool result1 = studentManager.AddStudent(st1);
if (!result1)
{
    Console.WriteLine("TEST PASSED");
}
else
{
    Console.WriteLine("TEST FAILED");
}

try
{
    // Call AddStudent with null
    studentManager.AddStudent(null!);
    Console.WriteLine("Test 3: FAILED");
}
catch (ArgumentNullException)
{
    Console.WriteLine("Test 3: PASSED");

}

