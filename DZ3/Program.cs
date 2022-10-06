// Задача 3: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет. Не использовать строки для расчета.
// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6
// адаптировал код под разные запросы (не только третья цифра)

Console.Clear();

Console.WriteLine("Введите любое целое число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите порядковый номер цифры, которую надо вывести на экран");
int count = Convert.ToInt32(Console.ReadLine());

int NumLength(int num) // считаем сколько цифр в числе
{
    int index = 1;
    while (num > 10)
    {
        num = num / 10;
        index++;
    }
    return index;
}

int numLength = NumLength(a);

if (numLength >= count)
{
    int index = 0;
    
    while (numLength > (count + index))
    { 
        a = a / 10;
        index ++;
    }
    a = a % 10;
    Console.WriteLine($"{count}-я цифра {a}");
}
else Console.WriteLine($"{count}-й цифры нет!");



