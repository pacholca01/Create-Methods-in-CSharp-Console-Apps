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
*/
using System;

string phrase = "255.255.255.255";
string[] bytes = phrase.Split('.');
int i = 0;
bool isByte1Valid = false;
bool isByte2Valid = false;
bool isByte3Valid = false;
bool isByte4Valid = false;


foreach (string bytePart in bytes)
{
    Console.WriteLine(bytePart);
    int byteInt = Convert.ToInt32(bytePart);
    if ( byteInt >= 1 && byteInt <= 255 && !bytePart.StartsWith("0") ) {    
        switch (i) 
        {
            case 0 : isByte1Valid = true; break;
            case 1 : isByte2Valid = true; break;
            case 2 : isByte3Valid = true; break;
            case 3 : isByte4Valid = true; break;
        }
    } else {
        switch (i) 
        {
            case 0 : Console.WriteLine("First byte is errorneous"); break;
            case 1 : Console.WriteLine("Second byte is errorneous"); break;
            case 2 : Console.WriteLine("Thrid byte is errorneous"); break;
            case 3 : Console.WriteLine("Fourth byte is errorneous"); break;
        }
    }
    i++; 
    
}

bool IsIPV4 = (i == 4) ? true : false; 


Console.WriteLine($"This IPv4 address consists of 4 numbers: {IsIPV4}");
Console.WriteLine( $"Byte 1 is valid: {isByte1Valid}" );
Console.WriteLine( $"Byte 2 is valid: {isByte2Valid}" );
Console.WriteLine( $"Byte 3 is valid: {isByte3Valid}" );
Console.WriteLine( $"Byte 4 is valid: {isByte4Valid}" );







