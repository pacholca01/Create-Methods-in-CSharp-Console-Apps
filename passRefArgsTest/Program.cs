// For more info see 
// https://learn.microsoft.com/en-us/training/modules/create-c-sharp-methods-parameters/4-exercise-use-value-reference-type-parameters

using System;

int a = 2; 
int b = 3;
int c = 0; 

Multiply(a, b, c);
Console.WriteLine($"Global Scope: {a} times {b} is equal to {c}"); // Values passed by arg to local scope are not able to have their variables updated in the global scope

void Multiply(int first, int second, int third) {
    third = first * second;
    Console.WriteLine($"Local Scope: {first} times {second} is equal to {third}"); 
}

int[] intArray = {1,2,3,4,5};

PrintArray(intArray);
ClearArray(intArray); Console.WriteLine();
PrintArray(intArray); Console.WriteLine();

void PrintArray(int[] array) {
    foreach (int i in array) {
        Console.Write(i);
    }
}

void ClearArray(int[] array) {
    for (int i = 0; i < array.Length; i++) {
        array[i] = 0; // Arrays that are passed by reference are able to have their global variable updated within the local scope
    }  
}

string immutableReferenceStatus = "Healthy";

Console.WriteLine($"Start: {immutableReferenceStatus}");
// SetHealth(immutableReferenceStatus, false);
SetHealth(false);
Console.WriteLine($"End: {immutableReferenceStatus}");

// void SetHealth(string immutableReferenceStatus, bool isHealthy) { // This method passes the arg and does not allow for updating the global variable passed by reference. 
void SetHealth(bool isHealthy) {
    immutableReferenceStatus = (isHealthy ? "Healthy" : "Unhealthy");
    Console.WriteLine($"Mid: {immutableReferenceStatus}");
}
