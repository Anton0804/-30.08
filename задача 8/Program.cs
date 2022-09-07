Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (num <= 2)
{
    Console.WriteLine("Введите другое число ");
    num = Convert.ToInt32(Console.ReadLine());
}
while (count < num)
{
    if (count % 2 == 0)
    {
        Console.Write($"{count}, ");
        count = count + 2;
    }
    else if (count % 2 == 1)
    {
        count = count + 1;
    }
}