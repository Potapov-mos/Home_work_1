//                          Задача 8:

//  Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


int counter = 1;
bool negative = true;

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

while (counter <= number)
{
    if (counter % 2 != 1)
    {
        Console.Write($"{counter} ");
        negative = false;
    }
    counter++;
}
if (negative)
    if (number <= 0)
    {
        Console.WriteLine("Введите положительное число от 1!");
    }
if (number == 1)
{
    Console.WriteLine("В числе 1 нет четных чисел!");
}