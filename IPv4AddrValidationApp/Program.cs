// See https://learn.microsoft.com/en-us/training/modules/write-first-c-sharp-method/5-exercise-build-code-with-methods
// for more information
/* 
Suppose you're a candidate in a coding interview. The interviewer wants you to write a program that checks whether an IPv4 address is valid or invalid. You're given the following rules:

    A valid IPv4 address consists of four numbers separated by dots
    Each number must not contain leading zeroes
    Each number must range from 0 to 255

1.1.1.1 and 255.255.255.255 are examples of valid IP addresses.

The IPv4 address is provided as a string. You can assume that it only consists of digits and dots (there are no letters in the string provided).

if ipAddress consists of 4 numbers
and if each ipAddress number has no leading zeroes
and if each ipAddress number is in range 0 - 255

then ipAddress is valid
else ipAddress is invalid

*/
using System;

string phrase = "1.1.1.1";
string[] bytes = phrase.Split('.');

foreach (string bytePart in bytes)
{
    int i = 1; 
    int byteInt = Convert.ToInt32(bytePart);
    if (byteInt >= 1 && byteInt <= 255) {
        // Console.WriteLine("Valid");
    } else {
        switch (i) 
        {
            case 1 : Console.WriteLine("First byte is errorneous"); break;
            case 2 : Console.WriteLine("Second byte is errorneous"); break;
            case 3 : Console.WriteLine("Thrid byte is errorneous"); break;
            case 4 : Console.WriteLine("Fourth byte is errorneous"); break;
        }
    }
    i++; 
    
}









