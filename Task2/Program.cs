// // Задание 1
// Console.WriteLine ("Введите первое число  ");
// int a = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите второе число ");
// int b = int.Parse(Console.ReadLine()!);

// if (a > b)
// {
//   Console.WriteLine ("max =" + a);
//    Console.WriteLine ("min =" + b);
// }
// else if (a == b)
// {
//   Console.WriteLine ("max = min = " +a);
// }  
// else
// {
//  Console.WriteLine ("max =" + b);
//    Console.WriteLine ("min =" + a);   
// }


// Задание 2
Console.WriteLine ("Введите первое число  ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число ");
int c = int.Parse(Console.ReadLine()!);

if (a >= b && a >= c)
{
  Console.WriteLine ("max =" + a);
}
else if (b >= a && b>= c)
{
  Console.WriteLine ("max =" + b);
}  
else
{
 Console.WriteLine ("max =" + c);   
}
