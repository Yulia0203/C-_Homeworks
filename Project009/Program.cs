﻿//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125


    Console.WriteLine("Введите число N");
    int n = int.Parse(Console.ReadLine());
    for (int i = 1; i <= n; i++)
    Console.WriteLine("{0}^{0}^{0} = {2}", i, i*i, i*i*i);

