//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число");
int n = Convert.ToInt32(Console.ReadLine());
int z = n % 100;
Console.WriteLine(z);
int n1 = z / 10;
Console.WriteLine(n1);