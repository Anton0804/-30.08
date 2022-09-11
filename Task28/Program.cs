// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int MultNumbers(int num)
{
if (num != 0)
{
if (num < 0) num = -num;
int sum = 1; // 0 или default - это 0 для int
for (int i = 1; i <= num; i++)
{
// sum = sum + i;
sum *= i;
}
return sum;
}
return 1;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


int multNumbers = MultNumbers(number);
Console.WriteLine($"{number}! = {multNumbers}");
