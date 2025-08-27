// See https://aka.ms/new-console-template for more information
using ClassRoomNet60;

// Opgave 3 - instans af klasserum og Studerende
Classroom class1 = new Classroom();

class1.ClassName = "3C";
class1.SemesterStart = new DateTime(2025, 8, 26, 9, 10, 00);

class1.StudentList.Add(new Student("Valdemar", 9, 26));
class1.StudentList.Add(new Student("Patrick", 12, 10));
class1.StudentList.Add(new Student("Alberte", 10, 10));
class1.StudentList.Add(new Student("Mikka", 3, 1));
class1.StudentList.Add(new Student("Weslyn", 6, 17));

// Opgave 4 - Udskriv Studerende & fødselsdagssæson

Console.WriteLine(); //Udskriv information om klasserummet
Console.WriteLine($"Classroom {class1.ClassName} has {class1.StudentList.Count} students and term start on {class1.SemesterStart}");

Console.WriteLine(); //Udskriv navnet på de studerende
Console.WriteLine("Students:");
foreach (Student student in class1.StudentList)
{
    Console.WriteLine($"Name: {student.Name}");
}

Console.WriteLine(); //Udskriv gruppering over fødselsdagssæson
Console.WriteLine($"The students birthdays are grouped as follows:");
class1.SeasonSort();


