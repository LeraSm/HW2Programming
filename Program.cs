Console.WriteLine("Hello, World!");

Console.Clear();

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int threeDigitalnumber = new Random().Next(100, 1000);
int secondnumber = threeDigitalnumber / 10 % 10;
Console.WriteLine($"second number {threeDigitalnumber} -> {secondnumber}");
