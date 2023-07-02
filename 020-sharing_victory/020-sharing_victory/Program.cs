/*
Edit the collection of students from exercise 9, Granding the students.
Create two students with the same grade, that grade should be the highest.
How does your application deal with that? If needed, change the application to allow multiple students to have the highest grade.
Extra points if you can print out their names in alphabetical order.
 */

using _020_sharing_victory.Model;

List<Student> students = new List<Student>()
{
    new Student{Name="Andrew", Grade=8 },
    new Student{Name="Matthew", Grade=5 },
    new Student{Name="Laura", Grade=10 },
    new Student{Name="Lorence", Grade=10 },
    new Student{Name="Lisa", Grade=6 },
    new Student{Name="Jeorge", Grade=8 },
    new Student{Name="Paul", Grade=10 },
    new Student{Name="Corinne", Grade=6 },
    new Student{Name="John", Grade=4 },
    new Student{Name="David", Grade=8 }
};

List<Student> bestStudents = new List<Student>();

int maxGrade = 0;
int sumX = 0;
int n = 0;
double avg = 0;

foreach (Student student in students)
{
    if (student.Grade > maxGrade)
    {
        maxGrade = student.Grade;
    }
    sumX += student.Grade;
    n++;
}

avg = ((double)sumX) / n;

Console.WriteLine($"The average grade is {avg}");
Console.WriteLine();

Console.WriteLine("List of the best student");
foreach (Student student in students)
{
    if (student.Grade == maxGrade)
    {
        bestStudents.Add(student);
    }
}

bestStudents.Sort(SortingFunction);
int SortingFunction(Student x, Student y)
{
    return string.Compare(x.Name, y.Name);
}

foreach (Student student in bestStudents)
{
    Console.WriteLine(student);
}