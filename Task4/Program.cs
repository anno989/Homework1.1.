// //Задание 3 
// Console.WriteLine ("Введите число  ");
// int a = int.Parse(Console.ReadLine());

// if (a % 2 == 0)
// {
//   Console.WriteLine ($"Число {a} четное");
// }  
// else
// {
//  Console.WriteLine ($"Число {a} нечетное");   
// }

//Задание 4
Console.WriteLine ("Введите число:  ");
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

