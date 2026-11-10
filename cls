[1mdiff --git a/StudentAbsenceManagement/StudentAbsenceManagement/Program.cs b/StudentAbsenceManagement/StudentAbsenceManagement/Program.cs[m
[1mindex 3de3dd3..41699d9 100644[m
[1m--- a/StudentAbsenceManagement/StudentAbsenceManagement/Program.cs[m
[1m+++ b/StudentAbsenceManagement/StudentAbsenceManagement/Program.cs[m
[36m@@ -108,10 +108,54 @@[m [musing System.Security.Cryptography;[m
 //    Console.WriteLine("TEST passed");[m
 //}[m
 ////////////// Test the GetAllStudent method [m
[31m-StudentManager emptyManager = new();[m
[32m+[m[32m//StudentManager emptyManager = new();[m
 [m
[31m-List<Student> result1 = emptyManager.GetAllStudents();[m
[31m-if (result1.Count == 0)[m
[32m+[m[32m//List<Student> result1 = emptyManager.GetAllStudents();[m
[32m+[m[32m//if (result1.Count == 0)[m
[32m+[m[32m//{[m
[32m+[m[32m//    Console.WriteLine("Test 1: PASSED");[m
[32m+[m[32m//}[m
[32m+[m[32m//else[m
[32m+[m[32m//{[m
[32m+[m[32m//    Console.WriteLine("Test 1: FAILED");[m
[32m+[m[32m//}[m
[32m+[m
[32m+[m[32m//StudentManager manager = new();[m
[32m+[m
[32m+[m[32m//manager.AddStudent(new Student(1, "Ahmed", "Alami"));[m
[32m+[m[32m//manager.AddStudent(new Student(2, "Sara", "Bennani"));[m
[32m+[m[32m//manager.AddStudent(new Student(3, "Youssef", "Idrissi"));[m
[32m+[m
[32m+[m[32m//List<Student> result2 = manager.GetAllStudents();[m
[32m+[m[32m//if (result2.Count ==3 && result2.Any(s => s.Id == 1 && result2.Any(s => s.Id == 2) && result2.Any(s => s.Id == 3)))[m
[32m+[m[32m//{[m
[32m+[m[32m//    Console.WriteLine("Test 2: PASSED");[m
[32m+[m[32m//}[m
[32m+[m[32m//else[m
[32m+[m[32m//{[m
[32m+[m[32m//    Console.WriteLine("Test 2: FAILED");[m
[32m+[m[32m//}[m
[32m+[m
[32m+[m[32m//List<Student> result3 = manager.GetAllStudents();[m
[32m+[m
[32m+[m[32m//result3.Clear();[m
[32m+[m[32m//if (result3.Count == 0 &&[m
[32m+[m[32m//    manager.GetAllStudents().Count == 3)[m
[32m+[m[32m//{[m
[32m+[m[32m//    Console.WriteLine("Test 3: PASSED");[m
[32m+[m[32m//}[m
[32m+[m[32m//else[m
[32m+[m[32m//{[m
[32m+[m[32m//    Console.WriteLine("Test 3: FAILED");[m
[32m+[m[32m//}[m
[32m+[m[32mDateTime absenceDate = new DateTime(2026, 11, 5);[m
[32m+[m
[32m+[m[32mAbsence absence = new Absence(1, 5, absenceDate, false);[m
[32m+[m
[32m+[m[32mif (absence.Id == 1 &&[m
[32m+[m[32m    absence.StudentId == 5 &&[m
[32m+[m[32m    absence.Date == absenceDate &&[m
[32m+[m[32m    !absence.IsJustified)[m
 {[m
     Console.WriteLine("Test 1: PASSED");[m
 }[m
[36m@@ -119,32 +163,54 @@[m [melse[m
 {[m
     Console.WriteLine("Test 1: FAILED");[m
 }[m
[32m+[m[32mtry[m
[32m+[m[32m{[m
[32m+[m[32m    Absence invalid = new Absence([m
[32m+[m[32m        0, 5, new DateTime(2026, 11, 5), false);[m
 [m
[31m-StudentManager manager = new();[m
[31m-[m
[31m-manager.AddStudent(new Student(1, "Ahmed", "Alami"));[m
[31m-manager.AddStudent(new Student(2, "Sara", "Bennani"));[m
[31m-manager.AddStudent(new Student(3, "Youssef", "Idrissi"));[m
[31m-[m
[31m-List<Student> result2 = manager.GetAllStudents();[m
[31m-if (result2.Count ==3 && result2.Any(s => s.Id == 1 && result2.Any(s => s.Id == 2) && result2.Any(s => s.Id == 3)))[m
[32m+[m[32m    Console.WriteLine("Test 2: FAILED");[m
[32m+[m[32m}[m
[32m+[m[32mcatch (ArgumentOutOfRangeException ex)[m
 {[m
[31m-    Console.WriteLine("Test 2: PASSED");[m
[32m+[m[32m    if (ex.ParamName == "id")[m
[32m+[m[32m    {[m
[32m+[m[32m        Console.WriteLine("Test 2: PASSED");[m
[32m+[m[32m    }[m
[32m+[m[32m    else[m
[32m+[m[32m    {[m
[32m+[m[32m        Console.WriteLine("Test 2: FAILED");[m
[32m+[m[32m    }[m
 }[m
[31m-else[m
[32m+[m[32mtry[m
 {[m
[31m-    Console.WriteLine("Test 2: FAILED");[m
[32m+[m[32m    Absence absence1 = new Absence(3, -7, absenceDate, false);[m
[32m+[m[32m    Console.WriteLine("Test 3: FAILED");[m
[32m+[m[32m}[m
[32m+[m[32mcatch (ArgumentOutOfRangeException ex)[m
[32m+[m[32m{[m
[32m+[m[32m    if (ex.ParamName == "studentId")[m
[32m+[m[32m    {[m
[32m+[m[32m        Console.WriteLine("Test 3: PASSED");[m
[32m+[m[32m    }[m
[32m+[m[32m    else[m
[32m+[m[32m    {[m
[32m+[m[32m        Console.WriteLine("Test 3: FAILED");[m
[32m+[m[32m    }[m
 }[m
 [m
[31m-List<Student> result3 = manager.GetAllStudents();[m
[31m-[m
[31m-result3.Clear();[m
[31m-if (result3.Count == 0 &&[m
[31m-    manager.GetAllStudents().Count == 3)[m
[32m+[m[32mtry[m
 {[m
[31m-    Console.WriteLine("Test 3: PASSED");[m
[32m+[m[32m    Absence absence1 = new Absence(1, 5, DateTime.MinValue, false);[m
[32m+[m[32m    Console.WriteLine("Test 4: FAILED");[m
 }[m
[31m-else[m
[32m+[m[32mcatch (ArgumentOutOfRangeException ex)[m
 {[m
[31m-    Console.WriteLine("Test 3: FAILED");[m
[31m-}[m
\ No newline at end of file[m
[32m+[m[32m    if (ex.ParamName == "date")[m
[32m+[m[32m    {[m
[32m+[m[32m        Console.WriteLine("Test 4: PASSED");[m
[32m+[m[32m    }[m
[32m+[m[32m    else[m
[32m+[m[32m    {[m
[32m+[m[32m        Console.WriteLine("Test 4: FAILED");[m
[32m+[m[32m    }[m
[32m+[m[32m}[m
