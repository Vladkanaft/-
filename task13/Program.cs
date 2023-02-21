//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите трехзначное число");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 99 && n < 1000)
{
    int n1 = n % 10;
    Console.WriteLine(n1);
}
else 
    if (n < -99 && n > -1000)
{   
    int n2 = -n % 10;
    Console.WriteLine(-n2);
}       
    else
     Console.WriteLine("Число не является техзначным");


