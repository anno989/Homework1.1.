﻿Console.WriteLine ("Введите число:  ");
int a = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= a; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
    Console.ReadLine(    
    );
}  

