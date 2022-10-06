// Задача 1: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. Не использовать строки для расчета.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Clear();
Start:
Console.WriteLine("Введите трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());

if ((99 < a) && (a < 1000))
{
    int b = a / 10 % 10;
    Console.WriteLine($"Вторая цифра в числе {a} будет {b}");
}
else Console.WriteLine($"Число {a} не является трехзначным");
Console.WriteLine();
goto Start;