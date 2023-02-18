//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число");
int firstnamber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int secondnamder = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int thirdnamder = Convert.ToInt32(Console.ReadLine());

int max = firstnamber;

if (max > secondnamder)
{
    if (max > thirdnamder)
    {
        Console.Write("max-");
        Console.WriteLine(firstnamber);
    }
    else
    {
        Console.Write("max-");
        Console.WriteLine(thirdnamder);
    }


}
else
{
    if (secondnamder > thirdnamder)
     {
        Console.Write("max-");
        Console.WriteLine(secondnamder);
     }  
     else
     {
        Console.Write("max-");
        Console.WriteLine(thirdnamder);
     }
}