﻿// 7.Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает **последнюю** цифру этого числа. 
//     456 -> 6 
//     782 -> 2
//     918 -> 8
Console.WriteLine("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine());
int lastSymb = num % 10;
Console.WriteLine(lastSymb);
