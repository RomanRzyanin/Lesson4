// task3

string GetLetters (string s)
{
    string letters = "";
    foreach (char e in s)
    {
        if (char.IsAsciiLetter(e) == true)
        {
            letters = letters + e;
        }
    }
    return letters;
}
Console.WriteLine("Введите строку:");
string str = Console.ReadLine()!;
string result = GetLetters(str);
Console.WriteLine(result);