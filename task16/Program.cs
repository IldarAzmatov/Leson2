// евляется ли число квадратом другого числа.  Знак или  ||

Console.WriteLine("Введите два числа ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a == b * b || b == a * a)
    Console.WriteLine("Да");
else
{
    Console.WriteLine("Нет");
}
