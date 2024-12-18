// For more info see 
// https://learn.microsoft.com/en-us/training/modules/create-c-sharp-methods-return-values/4-exercise-create-methods-return-strings

using System; 

string pangram = "The quick brown fox jumps over the lazy dog";
string palindrome = "racecar"; 
string emordnilap = "desserts";

Console.WriteLine(ReverseWord(pangram));
Console.WriteLine(ReverseWordMethod2(pangram));
Console.WriteLine(ReverseWord(palindrome));
Console.WriteLine(ReverseWord(emordnilap));

Console.WriteLine(ReverseEachWordInSentence(pangram));

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
