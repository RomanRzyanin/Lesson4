// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.
// Матрица - прямоугольная таблица, размер: m на n
// int[,] CreateMatrix(int rows, int cols)
// {
//     int[,] matrix = new int[rows, cols];
//     Random rnd = new Random();
//     for (int i = 0; i < rows; i++) // rows = matr.GetLength(0), стр
//     {
//         // j, m, k
//         for (int j = 0; j < cols; j++) // cols = matr.GetLength(1), столбцы
//         {
//             matrix[i, j] = rnd.Next(101); // [0, 100]
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++) // rows = matr.GetLength(0), стр
//     {
//         // j, m, k
//         for (int j = 0; j < matr.GetLength(1); j++) // cols = matr.GetLength(1), столбцы
//         {
//             Console.Write($"{matr[i, j]}\t"); // "\t" = 4 пробела
//         } // Попали в 0 строку, проверили все столбцы
//         Console.WriteLine();
//     }
// }

// void SquareElements(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++) // rows = matr.GetLength(0), стр
//     {
//         // j, m, k
//         for (int j = 0; j < matr.GetLength(1); j++) // cols = matr.GetLength(1), столбцы
//         {
//             if (i % 2 == 0 && j % 2 == 0) // && - "И"
//             {
//                 matr[i, j] *= matr[i, j]; //matr[i, j] = matr[i, j] * matr[i, j];
//             }
//         }
//     }
// }

// Console.Write("Введите количество строчек: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество cтолбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] result = CreateMatrix(rows, columns);
// PrintMatrix(result); // Матрица ДО
// Console.WriteLine("Результат:");
// SquareElements(result); // Матрица result изменилась
// PrintMatrix(result); // Матрица ПОСЛЕ


// int[,] CreateMatrix(int rows, int cols)
// {
//     int[,] matrix = new int[rows, cols];
//     Random rnd = new Random();
//     for (int i = 0; i < rows; i++) // rows = matr.GetLength(0), стр
//     {
//         // j, m, k
//         for (int j = 0; j < cols; j++) // cols = matr.GetLength(1), столбцы
//         {
//             matrix[i, j] = rnd.Next(101); // [0, 100]
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++) // rows = matr.GetLength(0), стр
//     {
//         // j, m, k
//         for (int j = 0; j < matr.GetLength(1); j++) // cols = matr.GetLength(1), столбцы
//         {
//             Console.Write($"{matr[i, j]}\t"); // "\t" = 4 пробела
//         } // Попали в 0 строку, проверили все столбцы
//         Console.WriteLine();
//     }
// }

// int GetSumEqualIndexes(int[,] matr)
// {
//     int sum = 0;
//     for (int i = 0; i < matr.GetLength(0); i++) // rows = matr.GetLength(0), стр
//     {
//         // j, m, k
//         for (int j = 0; j < matr.GetLength(1); j++) // cols = matr.GetLength(1), столбцы
//         {
//             if (i == j)
//             {
//                 sum += matr[i, j];// sum = sum + matr[i, j];
//             }
//         }
//     }
//     return sum;
// }


// Console.Write("Введите количество строчек: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество cтолбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] result = CreateMatrix(rows, columns);
// PrintMatrix(result); // Матрица ДО
// Console.WriteLine($"Результат: {GetSumEqualIndexes(result)}");

// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива. 


int[,] CreateMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++) // rows = matr.GetLength(0), стр
    {
        // j, m, k
        for (int j = 0; j < cols; j++) // cols = matr.GetLength(1), столбцы
        {
            matrix[i, j] = rnd.Next(101); // [0, 100]
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // rows = matr.GetLength(0), стр
    {
        // j, m, k
        for (int j = 0; j < matr.GetLength(1); j++) // cols = matr.GetLength(1), столбцы
        {
            Console.Write($"{matr[i, j]}\t"); // "\t" = 4 пробела
        } // Попали в 0 строку, проверили все столбцы
        Console.WriteLine();
    }
}

double[] GetArrayWithMeans(int[,] matr)
{
    double[] means = new double[matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++) // rows = matr.GetLength(0), стр
    {
        double currentSum = 0;
        for (int j = 0; j < matr.GetLength(1); j++) // cols = matr.GetLength(1), столбцы
        {
            currentSum += matr[i, j];
        }
        double currentMean = Math.Round(currentSum / matr.GetLength(1), 2);
        // 1.234 => Math.Round(1.234, 2) => 1.23
        means[i] = currentMean;
    }
    return means;
}

Console.Write("Введите количество строчек: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество cтолбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] result = CreateMatrix(rows, columns);
PrintMatrix(result); // Матрица 
double[] means = GetArrayWithMeans(result);
Console.WriteLine($"Результат: [ {string.Join("; ", means)} ] ");