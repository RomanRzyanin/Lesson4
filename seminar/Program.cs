// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива. 
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

// string GetStringFromCharArray(char[] array)
// {
//     string result = string.Empty; // ""
//     foreach (char symbol in array)
//     // symbol = 'a', symbol = 'b', symbol = 'c', symbol = 'd'
//     {
//         result = result + symbol;
//         // res = "" + 'a', res = "a"
//         // res = "a" + 'b', res = "ab"
//         // res = "ab" + 'c', res = "abc"
//         // res = "abc" + 'd', res = "abcd"
//     }
//     return result;
// }

// char[] chars = { '1', 'd', '!', '2', 'f' };
// Console.WriteLine($"Массив: [ {string.Join("; ", chars)} ]");
// string res = GetStringFromCharArray(chars);
// Console.WriteLine(res);

// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]

// char[] ConvertStringToCharArray (string str)
// {
//     char[] chars = new char[str.Length];
//     // "hi" -> [,]
//     // "hi" -> [str[0], str[1]]
//     for (int i = 0; i < str.Length; i++)
//     {
//         chars[i] = str[i]; 
//         // chars = [], str = "hi"
//         // chars[0] = str[0]; chars = ['h',]
//         // chars[1] = str[1]; chars = ['h','i']
//     }
//     return chars;
// }

// string str = "Hello world";
// Console.WriteLine($"Строка: {str}");
// char[] chars = ConvertStringToCharArray(str);
// Console.WriteLine($"Массив: [ {string.Join("; ", chars)} ]");

// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

int GetVowelsCount(string str)
{
    // str = “hello” , 'h'
    string vowels = "aoueyi"; // Гласные буквы в англ
    int vowelsCount = 0; // Количество гласных
    foreach (char symbol in str) // Получаю каждую букву
    {
        // "aa", symbol = "a", symbol = "a"
        // 'e' == a, o, u, e, y, i
        {
            foreach (char vowel in vowels) // Получил гласные
            {
                if (symbol == vowel)
                {
                    vowelsCount++; // Нашли гласную
                    break; // Если нашли гласную, идем к след.символу строчки
                }
            }
        }
    }
    if (str[0] == 'y')
        {
            vowelsCount--;
        }
    return vowelsCount;
}
Console.Clear();
Console.Write("Введите строчку: ");
string inputString = Console.ReadLine()!;
inputString = inputString.ToLower()!; // "HI" -> "hi"
// ToUpper(): "hi" -> "HI"
Console.WriteLine($"В строке: {inputString} : {GetVowelsCount(inputString)} гласных");
