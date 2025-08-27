// See https://aka.ms/new-console-template for more information
using ClassRoomNet60;

// Opgave 3
Classroom class1 = new Classroom();

class1.ClassName = "3C";
class1.SemesterStart = new DateTime(2025, 8, 26);
class1.StudentList.Add(new Student("Valdemar", 9, 26));
class1.StudentList.Add(new Student("Patrick", 12, 10));
class1.StudentList.Add(new Student("Alberte", 10, 10));

// Opgave 4
Console.WriteLine($"Klassenavn: {class1.ClassName} har opstartsdato: {class1.SemesterStart}");

foreach (Student student in class1.StudentList)
{
    Console.WriteLine($"Student navn: {student.Name}");
}



