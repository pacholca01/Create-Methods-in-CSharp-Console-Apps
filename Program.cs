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

/*
When choosing a method name, it's important to keep the name concise and make it clear what task the method performs. Method names should be Pascal case and generally shouldn't start with digits. Names for parameters should describe what kind of information the parameter represents. Consider the following method signatures:
c#

    void ShowData(string a, int b, int c);
    void DisplayDate(string month, int day, int year);

The second method describes what kind of data is displayed and provides descriptive names for parameters.
Now that you have the basics down, you're ready to begin writing your own methods!

*/