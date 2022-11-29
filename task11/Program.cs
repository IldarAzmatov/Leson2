//программа которая выводит случайное трех значное число и удаляет вторую цифру
// 456-46/782- 72

Random random = new Random();
int number = random.Next(100, 1000);
Console.WriteLine("Random nuber={0} ", number);
int a = number /100;
int c = number % 10;

Console.WriteLine("Ответ" +a +c);
