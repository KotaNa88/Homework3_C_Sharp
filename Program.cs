//Task 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void Fun (int number)
// {
//     int i = 1;
//     while (i <= number)
//     {
//         Console.WriteLine($"{i} -> {i*i*i} ");
//         i++;
//     }
// }
// Fun(5);

//Task 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double FindDistance (double xa, double ya, double za, double xb, double yb, double zb)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb -ya, 2) + Math.Pow(zb - za, 2)), 3);
// } 
// Console.WriteLine("Input coordinate X to A:");
// double xa = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate Y to A:");
// double ya = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate Z to A:");
// double za = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate X to B:");
// double xb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate Y to B:");
// double yb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate Z to B:");
// double zb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"Distance beetwen point A with coordinate ({xa}, {ya}), {za} and point B with coordinate ({xb}, {yb}, {zb}) -> {FindDistance(xa, ya, za, xb, yb, zb)}");

//Task 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("input num");
// int num = Convert.ToInt32(Console.ReadLine());

// int a = num / 10000;
// int b = num % 10000 / 1000;
// int c = num / 10 % 10;
// int d = num % 10;

// if (a == d && b ==c)
// {   
//     Console.WriteLine($"Number {num} -> Palindrome");
// }
// else
// Console.WriteLine($"Number {num} ->is not Palindrome");
