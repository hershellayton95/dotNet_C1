/*
Create a data collection that holds 10 students.
The Student class should contain a Name and Grade.
Write a program that calculates the average grade, as well as print out the student with the highest grade.
 */


using _019_grading_the_students.Model;

List<Student> students = new List<Student>()
{
    new Student{Name="Andrew", Grade=8 },
    new Student{Name="Matthew", Grade=5 },
    new Student{Name="Laura", Grade=10 },
    new Student{Name="Lorence", Grade=3 },
    new Student{Name="Lisa", Grade=6 },
    new Student{Name="Jeorge", Grade=8 },
    new Student{Name="Paul", Grade=10 },
    new Student{Name="Corinne", Grade=6 },
    new Student{Name="John", Grade=4 },
    new Student{Name="David", Grade=8 }
};

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

avg = ((double) sumX) / n;

Console.WriteLine($"The average grade is {avg}");
Console.WriteLine();

Console.WriteLine("List of the best student");
foreach (Student student in students)
{
    if(student.Grade == maxGrade)
    {
        Console.WriteLine(student);
    }
}

