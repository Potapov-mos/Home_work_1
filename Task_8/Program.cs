//                          Задача 8:

//  Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int counter = 1;
// while (counter <= number)
// {
//     Console.Write($"{counter} ");
//     counter++;
// }

int counter = 1;
bool not = true;

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

while (counter <= number)
{
    if (counter % 2 != 1)
    {
        Console.Write($"{counter} ");
        not = false;
    }
    counter++;
}
if (not)
{
    Console.WriteLine("Введите натуральное число! ");
}
