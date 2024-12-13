// For more information see
// https://learn.microsoft.com/en-us/training/modules/create-c-sharp-methods-parameters/3-exercise-understand-method-scope
using System;
string[] students = {"Jess", "Jerry", "James", "Jenny"};

printStudents(students);
printStudents(new string[] {"Jamie", "Jared"});

void printStudents(string[] students) {
    foreach (var student in students)
    {   
        Console.WriteLine(student); 
    }
}