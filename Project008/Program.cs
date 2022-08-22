﻿//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите пятизначное число:");
string str = Console.ReadLine();
int a = 0;
for (int i = 0; i < str.Length / 2; i++)
{
    if (str.Substring(i, 1) != (str.Substring(str.Length - 1 - i, 1)))
        {
            Console.WriteLine("Число {0} не является палиндромом", str);
            break;
        }
    else
    a = 1;
}
if (a == 1) Console.WriteLine("Число {0} является палиндромом", str);
