// See https://aka.ms/new-console-template for more information
using ClassRoomNet60;

Student Student1 = new Student("Valdemar", 9, 26);
Student Student2 = new Student("Alberte", 5, 15);
Student Student3 = new Student("Mikka", 6, 8);
Student Student4 = new Student("Patrick", 10, 12);

List<Student> students = new List<Student>();
students.Add(Student1);
students.Add(Student2);
students.Add(Student3);
students.Add(Student4);

foreach (var student in students)
{
    Console.WriteLine(student.Name);
}

//Classroom Class1 = new Classroom("3D", );