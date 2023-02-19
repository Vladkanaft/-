// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int x = number % 2;
 Console.WriteLine(x);
if (x == 0)
{
    Console.Write(number);

    Console.WriteLine(" четное число");
}
else
{
    Console.WriteLine("ERROR");
}
  