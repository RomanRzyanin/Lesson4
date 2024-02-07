// task2 Создать 2-х мерный массив, состоящий из целых чисел. Вывести на экран "интересные" элементы массива(сумма цифр числа четная).

int[,] CreateTable(int rowCount, int columsCount)
{
    int[,] matrix = new int[rowCount, columsCount];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 1000);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} "); //Интерполяция строк
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateTable(3, 4);
ShowMatrix(matrix);
foreach (int e in matrix)
{
    if(IsInteresting(e) == true)
    {
        Console.WriteLine(e);
    }
}

bool IsInteresting(int value)
{
    int sumOfDigits = GetSumOfDigits(value);
    if (sumOfDigits % 2 == 0)
    {
        return true;
    }
    return false;
}

int GetSumOfDigits(int value)
{
    int sum = 0;
    while (value > 0)
    {
        sum = sum + value % 10;
        value = value / 10;
    }
    return sum;
}