﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Enter number 1: ");
int number1 = int.Parse(Console.ReadLine());


Console.Write("Enter number 2: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 > number2) 
    Console.WriteLine("number 1 больше number2");
       else if (number1 < number2) 
    Console.WriteLine("number2 больше number1");
else
    Console.WriteLine("number1 равно number2");

