//homework

//Считать строк из букв и цифр, выбрать цифры и сформировать массив.

string GetNumbers(string n)
{
    string numbers = "";
    foreach (char e in n)
    {
        if (char.IsAsciiDigit(e) == true) //char.IsDigit
        {
            numbers = numbers + e;
        }
    }
    return numbers;
}

int[] GetArray(string s)
{
    int number = Convert.ToInt32(s);
    int length = s.Length;
    int[] array = new int[length];
    for ( int i = length - 1; i >= 0; i--)
    {   
        
        array[i] = number % 10;
        number = number / 10;  
    }
    return array;
}

Console.Clear();
Console.Write("Введите строку:   ");
string str = Console.ReadLine()!;
string result = GetNumbers(str);
Console.WriteLine($"Цифры из введеной строки: {result}");
Console.WriteLine($"Массив из чисел строки: [ {string.Join("; ", GetArray(result))} ]");