// For more info see 
// https://learn.microsoft.com/en-us/training/modules/create-c-sharp-methods-return-values/4-exercise-create-methods-return-strings

using System; 

string pangram = "The quick brown fox jumps over the lazy dog";
string palindrome = "racecar"; 
string emordnilap = "desserts";

string[] testWords = ["racecar", "talented", "deified", "tent", "tenet", "Do geese see God"];

Console.WriteLine("\nHere are words and phrases reversed");
// Console.WriteLine(ReverseWord(pangram));
Console.WriteLine(ReverseWordMethod2(pangram));
Console.WriteLine(ReverseWord(palindrome));
Console.WriteLine(ReverseWord(emordnilap));

Console.WriteLine("\nHere is each word reversed while maintaning it's place in the sentence.");
Console.WriteLine(ReverseEachWordInSentence(pangram));

Console.WriteLine("\nHere is a test for palindromes words:");
foreach (string word in testWords) {
    string? isNot = IsPalindrome(word) ? null : "NOT ";    
    Console.WriteLine($"The word '{word}' is {isNot}a palindrome.");
}

Console.WriteLine("\nHere is a test for palindromes phrases:");
foreach (string word in testWords) {
    string? isNot = IsPalindromeMethod2(word) ? null : "NOT ";    
    Console.WriteLine($"The phrase '{word}' is {isNot}a palindrome.");
}


bool IsPalindrome(string word) {
    word = word.ToLower();
    string reversedWord = ReverseWord(word);
    return word == reversedWord;
}

bool IsPalindromeMethod2(string word) {

    word = word.Replace(" ",string.Empty).ToLower();
    int startChar = 0; 
    int endChar = word.Length -1;

    while (startChar < endChar) {   // loop though each character on either side of word and compare is they are equal
        if (word[startChar] != word[endChar]) { // if characters are not the same then return false
            return false;
        }
        startChar++;    // increment starting char
        endChar--;      // decrement ending char
    }
    return true;
}

string ReverseEachWordInSentence(string intput) {
    string result = "";
    string[] words = intput.Split(" ");
    
    foreach (string word in words){
        result += ReverseWord(word)+ " ";
    }
    return result;
}

string ReverseWord(string word) 
{
    char[] charArray = new char[word.Length];
    for (int i = 0; i < word.Length; i++) {
        charArray[i] = word[word.Length-i-1];
    }
    string result = new string (charArray);
    return result;
}

string ReverseWordMethod2(string word) {
    string result = "";
    for (int i = word.Length - 1; i >= 0; i--) {
        result += word[i]; 
    }
    return result;
}
