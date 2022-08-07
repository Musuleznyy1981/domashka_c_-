// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Задача 8 Написать программу,которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


Console.Clear();

Console.Write("Введите число: ");
int number_A = Convert.ToInt32(Console.ReadLine());
if (number_A % 10 == 0)

    Console.WriteLine("Число чётное");
