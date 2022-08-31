// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16

Console.WriteLine("Enter first integer number");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second integer number");
int b = Convert.ToInt32(Console.ReadLine());
int x = a*Math.Pow(b);
Console.WriteLine(x);

