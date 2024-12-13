// For more information see
// https://learn.microsoft.com/en-us/training/modules/create-c-sharp-methods-parameters/3-exercise-understand-method-scope
using System;

double pi = 3.14159;

Console.WriteLine("Enter the radius of a circle, as an integer:");
int radius = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Circle with radius {radius}");
calculateArea(radius);
calculateCircumfirmence(radius);

void calculateArea(int radius) {
    double area = pi * (radius * radius);
    Console.WriteLine($"Area = {area}");
}

void calculateCircumfirmence(int radius) {
    double circumference = 2 * pi * radius;
    Console.WriteLine($"Circumference = {circumference}");
}
/* 
// Test of variable scope:
string[] students = {"Jess", "Jerry", "James", "Jenny"};

printStudents(students);
printStudents(new string[] {"Jamie", "Jared"});

void printStudents(string[] students) {
    foreach (var student in students)
    {   
        Console.WriteLine(student); 
    }
}
*/

