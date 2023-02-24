﻿// Задача 19
// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if ((number < 10000) || (number > 99999))
    {
        Console.WriteLine("Введено не пятизначное число");
        return;
    }
else if ((number % 10 == number / 10000) && (number / 10 % 10 == number / 1000 % 10))
    {
        Console.WriteLine("Число является палиндромом");
    }   
else
    {
        Console.WriteLine("Число НЕ является палиндромом");
    }