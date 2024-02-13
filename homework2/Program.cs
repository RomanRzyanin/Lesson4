//task1  Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

// string GetStringFromArray(char[,] array)
// {
//     string str  = string.Empty;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             str = str + array[i, j];
//         }
        
//     }
//     return str;
// }
// char[,] matrix = {{'a', 'b', 'c', '7'}, {'d', 'e', 'f', '6'}};
// //string res = GetStringFromArray(matrix);
// Console.Write($"Строка: {GetStringFromArray(matrix)}");


//task2  Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.

// Console.Clear();
// Console.Write("Enter the string:");
// string str = Console.ReadLine()!;
// str = str.ToLower()!;
// Console.Write($"Lowercase string:{str}");

//task3 Задайте произвольную строку. Выясните, является ли она палиндромом.

// bool ChekForPalindrome(string s)
// {
//     for (int i = 0; i < s.Length / 2; i++)
//     {   
//         int j = s.Length - 1; 
//         if (s[i] != s[j - i])
//         {
//             return false;
//         }
//     }
//     return true;
// }

// void PrintCheckPalindrome (string s)
// {
//     bool b = ChekForPalindrome(s);
//     if (b == true)  Console.Write($"The string ({s}) is a palindrome.");
//     else            Console.Write($"The string ({s}) isn't a palindrome.");
// }
// Console.Clear();
// Console.Write("Enter the text:");
// string str = Console.ReadLine()!;
// str = str.ToLower();
// PrintCheckPalindrome(str);

//task4 Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, в которой слова расположены в обратном порядке. В полученной строке слова должны быть также разделены пробелами.

string ReverseStringWords(string s)
{
    string reverseStr = string.Empty;
    string word = string.Empty;

    for (int i = s.Length - 1; i >= 0; i--)
    {
        if (s[i] != ' ')
        {
            word = s[i] + word;
        }
        else
        {
            reverseStr += word + " ";
            word = "";
        }
    }
    reverseStr += word;
    return reverseStr;
}

Console.Clear();
Console.Write("Enter the text: ");
string str = Console.ReadLine()!;
Console.Write(ReverseStringWords(str));

// task4 v.2

// string ReverseStringWords(string str)
// {
//     string[] words = str.Split(' ');

//     Array.Reverse(words);

//     return string.Join(" ", words);
// }

// Console.Clear();
// Console.Write("Enter the text: ");
// string str = Console.ReadLine()!;
// Console.Write(ReverseStringWords(str));

