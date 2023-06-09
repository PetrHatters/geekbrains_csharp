/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/ 
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int counter = 1;
while (counter <= num)
{ 
    if (counter % 2 != 0)
    {
        counter++;
    }
    else
    {
        Console.Write($"{counter}, ");
        counter=counter+2;
    } 
}