// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.Clear();
Console.Write("Введите номер четверти (1-4) ");
Console.Write(":");
int quart = Convert.ToInt32(Console.ReadLine());

string Quarter(int quart1)
{
    if (quart1 == 1) return "xc > 0 && yc > 0";
    if (quart1 == 2) return "xc < 0 && yc > 0";
    if (quart1 == 3) return "xc < 0 && yc < 0";
    if (quart1 == 4) return "xc > 0 && yc < 0";
    return "Введен некорректный номер четверти";
}

string result = Quarter(quart);
Console.WriteLine(result);
