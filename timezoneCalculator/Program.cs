using System;
using System.Globalization;
using System.IO.Compression;


// Timezone cac
// https://learn.microsoft.com/en-us/training/modules/write-first-c-sharp-method/4-exercise-create-reusable-methods

int[] times = {800, 1200, 1600, 2000};
int diff = 0;

Console.WriteLine("Enter Current GMT");
int currentGMT = Convert.ToInt32(Console.ReadLine());
if (Math.Abs(currentGMT) > 12) { // https://learn.microsoft.com/en-us/dotnet/api/system.math.abs?view=net-9.0
    Console.WriteLine("Invalid GMT");
} 

Console.WriteLine("Current Medicine Schedule:");
DisplayTimes();

Console.WriteLine("\nEnter new GMT:");
int newGMT = Convert.ToInt32(Console.ReadLine());
if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12) // https://learn.microsoft.com/en-us/dotnet/api/system.math.abs?view=net-9.0
{ 
    Console.WriteLine("Invalid GMT");
} 
// Do both GMTs hav ethe same positive/negative sign? 
else if (newGMT <= 0 && currentGMT <=0 || newGMT >= 0 && currentGMT >= 0) 
{
    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
    AdjustTimes();
}
// Are both GMTs having opposite positive/negative signs? 
else 
{
    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    AdjustTimes();
}

Console.WriteLine("New Medicine Schedule:");
DisplayTimes();


void DisplayTimes() {
    foreach (int val in times)
    {
        string strTime = val.ToString();
        int len = strTime.Length;

        if (len >= 3) {
            strTime = strTime.Insert(len - 2, ":");
        } else if (len == 2) {
            strTime = strTime.Insert(0, "0:");
        } else {
            strTime = strTime.Insert(0, "0:0");
        }
        Console.WriteLine($"{strTime}");
    }
}

void AdjustTimes() {
    // Adjust the time by adding the difference, keeping the value within 24 hours. 
    for (int i = 0; i < times.Length; i++) {
        times[i] = ((times[i] + diff)) % 2400;
    }
}
// Format and display medicine times



/*
// Exercise Create you r first method 
int[] a = {1,2,3,4,5};

Console.WriteLine("Before calling methods.\n");
SayHello();
Console.WriteLine("\nContents of array 'int':");
PrintArray();
Console.WriteLine("\nAfter calling methods.");
Console.WriteLine("\nWriting new random numbers:");
DisplayRandomNumbers();

void DisplayRandomNumbers()
{
    Random random = new Random();
    for (int i = 0; i < 5; i++)
    {
        Console.Write($"{random.Next(1, 100)} ");
    }
    Console.WriteLine();
}

// Method names should be Pascal case
void PrintArray()
{
    foreach (int v in a)
    {
        Console.WriteLine($"{v}");
    }
}

// Method names should be Pascal case
void SayHello()
{
    // See https://aka.ms/new-console-template for more information
    Console.WriteLine("Hello, World!"); 
}

// When choosing a method name, it's important to keep the name concise and make it clear what task the method performs. Method names should be Pascal case and generally shouldn't start with digits. Names for parameters should describe what kind of information the parameter represents. Consider the following method signatures: 
//
//    void ShowData(string a, int b, int c);
//    void DisplayDate(string month, int day, int year);
//
// The second method describes what kind of data is displayed and provides descriptive names for parameters.
// Now that you have the basics down, you're ready to begin writing your own methods!

*/