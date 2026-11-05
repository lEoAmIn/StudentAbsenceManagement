using StudentAbsenceManagement;


try
{
    Student s1 = new Student(1, "Ahmed", "Alami");
    Console.WriteLine(s1.Id);
    Console.WriteLine(s1.LastName);
    Console.WriteLine(s1.FirstName);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"{ex.GetType().Name}: {ex.Message}");
}

try
{
    Student s2 = new Student(0, "Ahmed", "Alami");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"{ex.GetType().Name}: {ex.Message}");
}
try
{
    Student s3 = new Student(2, "", "Alami");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"{ex.GetType().Name}: {ex.Message}");
}
try
{
    Student s4 = new Student(3, "Ahmed", "   ");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"{ex.GetType().Name}: {ex.Message}");
}
