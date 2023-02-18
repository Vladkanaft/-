//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число");
int firstnamber =  Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int secondnamder = Convert.ToInt32(Console.ReadLine());


if (firstnamber > secondnamder)
{
    Console.Write("min-");
    Console.WriteLine(secondnamder);

    Console.Write("max-");
    Console.Write(firstnamber);
}
else
{
    Console.Write("max-");
    Console.WriteLine(secondnamder);

    Console.Write("min-");
    Console.Write(firstnamber);  
}
