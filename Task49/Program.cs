// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.


// int SumMidleMatrix(int[,] matrix)                   Пример решения
// {
//     int result = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i == j) result += matrix[i, j];
//         }
//     }
//     return result;
// }


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

void SquareEvenElems(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) matrix[i, j] *= matrix[i, j];
        }
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2D);
SquareEvenElems(array2D);
Console.WriteLine();
PrintMatrix(array2D);

// int[,] ChangeMatrixRndInt(int[,] array)                          Вариант 2
// {
//     for (int i = 0; i < array.GetLength(0); i += 2)
//     {
//         for (int j = 0; j < array.GetLength(1); j += 2)
//         {
//             array[i, j] *= array[i, j];
//         }
//     }
//     return array;
// }



