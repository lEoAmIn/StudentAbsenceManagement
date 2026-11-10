
using Xunit;
using StudentAbsenceManagement;
namespace StudentAbsenceManagement.Tests;
using System.Reflection.Metadata.Ecma335;


public class AbsenceManagerTests
{
    [Fact]
    public void GetAbsencesByStudent_WhenStudentHasThreeAbsences_ReturnsThree()
    {
        // Arrange
        StudentManager studentManager = new StudentManager();
        studentManager.AddStudent(new Student(10, "hani", "ahmed"));
        studentManager.AddStudent(new Student(12, "jalii", "chakir"));
        studentManager.AddStudent(new Student(13, "rami", "khalid"));
        studentManager.AddStudent(new Student(14, "hasani", "aziz"));
        AbsenceManager absenceManager = new AbsenceManager(studentManager);
        absenceManager.RecordAbsence(new Absence(1, 10, new DateTime(2026,11,03), false));
        absenceManager.RecordAbsence(new Absence(2, 10, new DateTime(2026,11,04), true));
        absenceManager.RecordAbsence(new Absence(3, 10, new DateTime(2026-11-06), false));
        absenceManager.RecordAbsence(new Absence(4, 12, new DateTime (2026-11-06), true));

        // Act
        List<Absence> list = absenceManager.GetAbsencesByStudent(10);
        
        // Assert
        Assert.Equal(3, list.Count);
    }
    [Fact]
    public void GetAbsenceById_WhenIdExists_ReturnsCorrectAbsence()
    {
        // Arrange
        StudentManager studentManager = new StudentManager();
        studentManager.AddStudent(new Student(1, "Ahmed", "Ali"));

        AbsenceManager absenceManager = new AbsenceManager(studentManager);

        Absence expected = new Absence(
            10,
            1,
            new DateTime(2026, 11, 7),
            false);

        absenceManager.RecordAbsence(expected);

        // Act
        Absence? result = absenceManager.GetAbsenceById(10);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(10, result.Id);
        Assert.Equal(1, result.StudentId);
        Assert.Same(expected, result);

    }
    [Fact]
    public void GetAbsenceById_WhenIdDoesNotExist_ReturnsNull()
    {
        // Arrange
        StudentManager studentManager = new StudentManager();
        studentManager.AddStudent(new Student(1, "Ahmed", "Ali"));

        AbsenceManager absenceManager = new AbsenceManager(studentManager);

        absenceManager.RecordAbsence(
            new Absence(10, 1, new DateTime(2026, 11, 7), false));

        // Act
        Absence? result = absenceManager.GetAbsenceById(999);
        // Assert
        Assert.Null(result);
    }
}