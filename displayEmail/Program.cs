// For more info see
// https://learn.microsoft.com/en-us/training/modules/create-c-sharp-methods-parameters/6-exercise-challenge-email-addresses

/*
Display email addresses

Your challenge is to create a method that displays the correct email address for both internal and external employees. You're given lists of internal and external employee names. An employee's email address consists of their username and company domain name.

The username format is the first two characters of the employee first name, followed by their last name. For example, an employee named "Robert Bavin" would have the username "robavin". 
The domain for internal employees is "contoso.com".

In this challenge, you're given some starting code. You must decide how to create and call a method to display email addresses.

In the code you start with, there are two arrays for internal and external employees. Remember, the domain for internal employees is "contoso.com" and the username for all employees is the first two characters of their first name, followed by their full last name.

Your challenge is to create a method that will display the email address of internal and external employees. The method should include an optional parameter for the domain name of external employees.
*/
using System; 

string[,] corporate = {
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =  {
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string internalDomain = "contoso.com";
string externalDomain = "hayworth.com";

DisplayEmailAddress(list: corporate, domain: internalDomain); 
DisplayEmailAddress(list: external, domain: externalDomain); 


void DisplayEmailAddress(string[,] list, string domain) {
    string username = "";
    for (int i = 0; i < list.GetLength(0); i++) { //An example of GetLength is GetLength(0), which returns the number of elements in the first dimension of the Array.
        username = list[i,0].Substring(0,2).ToLower() + list[i,1].ToLower(); 
        Console.WriteLine($"{username}@{domain}");
    }
}
