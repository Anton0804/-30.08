// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        // Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 3}, ");
            else Console.Write($"{matrix[i, j], 3} ");
        }
        // Console.WriteLine("]");
        Console.WriteLine();
    }
}

int SumMidleMatrix(int[,] matrix)
{
    int result = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j) result += matrix[i, j];
        }
    }
    return result;
}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2D);
int sumResult = SumMidleMatrix(array2D);
Console.WriteLine();
Console.WriteLine($"Сумма элементов, находящихся на главной диагонали = {sumResult}");



// int DiagonalSumMatrix(int[,] matrix)                         Короткое решение
// {
//     int diagnalSumMatrix = default;
//     int oversize = 0;
//     if (matrix.GetLength(0) > matrix.GetLength(1)) oversize = 1;
//     for (int i = 0; i < matrix.GetLength(oversize); i++)
//     {

//         diagnalSumMatrix += matrix[i, i];

//     }
//     return diagnalSumMatrix;
// }

// bool restart = true;
// while (restart)
// {
//     Console.Clear();

//     Random randomizer = new Random();
//     int randomRows = randomizer.Next(2, 6),
//         randomColumns = randomizer.Next(2, 6);

//     int[,] array2D = CreateMatrixRndInt(randomRows, randomColumns);
//     PrintMatrix(array2D);
//     Console.WriteLine("-------------------------------------------------------------");
//     int result = DiagonalSumMatrix(array2D);
//     Console.WriteLine($"Сумма элементов главной диагонали = {result}");

//     Console.Write("Ещё раз? \n'Enter' - Да. Что-то другое - Выход.");
//     restart = Console.ReadKey().Key == ConsoleKey.Enter;
// }
