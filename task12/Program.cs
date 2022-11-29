// показывает кратность друг другу

Console.WriteLine("Введите два числа ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a % b == 0)
    Console.WriteLine("Кратно");
else
{
    //Console.Write("Не кратно, остаток ");
    Console.WriteLine($"Не кратно, остаток " + a % b);
}

