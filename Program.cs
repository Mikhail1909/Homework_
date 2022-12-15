// Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());

// string PrintNumber (int start, int end)
// {
//     if (end == start)
//     {
//         return end.ToString();

//     }
//     return (start + ", " + PrintNumber(start - 1, end)); 

// }

// Console.WriteLine(PrintNumber(a, 1));

// ______________________________________________________________________________

// Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int b = Convert.ToInt32(Console.ReadLine());

// string PrintNumber (int start, int end)
// {
//     int sum = 0;
//     if (end == start)
//     {
//         return start.ToString();

//     }

//     if (start > end)
//     {
//         return "Ввели некоректные числа";

//     }
//     else
//     {
//        for ( int i = start; i <= end; i++)
//        {
//            sum += i;
//        }
//        return sum.ToString();
//     }
// }

// Console.WriteLine(PrintNumber(a, b));

// ______________________________________________________________________

// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

