﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Таблица кубов чисел от 1 до " + N + ":");
        for (int i = 1; i <= N; i++) {
            Console.WriteLine(i + "^3 = " + (i * i * i));
        }