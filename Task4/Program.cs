//Задание 4 (вариант решения 1 - без отрицательных чисел)
 Console.WriteLine ("Введите число:  ");
 int a = int.Parse(Console.ReadLine()!);
 while (a <= 0)
 {
     Console.WriteLine("Введите положительное число ");
     a = int.Parse(Console.ReadLine()!);
 }
 for (int i = 1; i <= a; i++)
 {
     if (i % 2 == 0)
     {
         Console.Write(i + " ");
     }
}

// //Задание 4 (вариант решения 2 - c отрицательными числами)  
// Console.WriteLine ("Введите число:  ");
// int a = int.Parse(Console.ReadLine()!);
// if (a <= 0)
// {
//     for (int i = a; i <= 1; i++)
//     {
//         if (i % 2 == 0)
//         {
//             Console.Write(i + " ");
//         }
//     }   
// }
// else 
// {
//     for (int i = 1; i <= a; i++)
//     {
//         if (i % 2 == 0)
//         {
//             Console.Write(i + " ");
//         }
//     }
// }

