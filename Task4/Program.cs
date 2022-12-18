// //Задание 4
// Console.WriteLine ("Введите число:  ");
// int a = int.Parse(Console.ReadLine()!);
// while (a <= 0)
// {
//     Console.WriteLine("Введите положительное число ");
//     a = int.Parse(Console.ReadLine()!);
// }
// for (int i = 1; i <= a; i++)
// {
//     if (i % 2 == 0)
//     {
//         Console.Write(i + " ");
//     }
// }

  
Console.WriteLine ("Введите число:  ");
int a = int.Parse(Console.ReadLine()!);
if (a <= 0)
{
    for (int i = a; i <= 1; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write(i + " ");
        }
    }   
}
else 
{
    for (int i = 1; i <= a; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write(i + " ");
        }
    }
}

