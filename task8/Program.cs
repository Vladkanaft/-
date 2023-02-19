//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int i = 1;
Console.WriteLine("Введите число");
int numder = Convert.ToInt32(Console.ReadLine());

while (i <= numder)
{
    int x = i % 2;
    if (x == 0)
    {
        Console.Write(i);
        Console.WriteLine(" четное число");
    }
    i++;
}
