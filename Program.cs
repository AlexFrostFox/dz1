﻿// Для проверки работы нужной программы нужно выделить код и нажать сочетание кнопок "Ctrl+/",
// далее ввести команду "dotnet run" в терминале

//=======================================================================================

// Задача 2: Напишите программу, которая на вход принимает два числа
//  и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Решение:

// Console.Write("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine()); // считываем первое число
// Console.Write("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine()); // считываем второе число
//     if (number1 > number2) // проверяем, какое число больше
//     {
//     Console.WriteLine($"Большее число: {number1}, меньшее число: {number2}");
//     }
//     else if (number2 > number1) // проверяем, какое число больше
//     {
//     Console.WriteLine($"Большее число: {number2}, меньшее число: {number1}");
//     }
//     else // если числа равны
//     {
//     Console.WriteLine("Введенные числа равны");
//     }

//================================================================================

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine()); // считываем первое число
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine()); // считываем второе число
Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine()); // считываем третье число
int max = result;
    if (number1 < number2 > number3) //число 2 больше остальных
    {
        result = number2 = Console.WriteLine($"Максимальное число: {max}")
    }
    else if (number2 < number1 > number3) //число 1 больше остальных
    {
        result = number1 = Console.WriteLine($"Максимальное число: {max}")
    }
    else if (number2 < number3 > number1) //число 3 больше остальных
    {
        result = number3 = Console.WriteLine($"Максимальное число: {max}")
    }
    else // если числа равны
    {
        Console.WriteLine("Введенные числа равны");
    }
    