// See https://aka.ms/new-console-template for more information
Console.WriteLine("Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве");

//Input first digital
Console.WriteLine("Введите первое число:");
System.Console.Write("x:");
string input = Console.ReadLine();
float xa = float.Parse(input);

System.Console.Write("y:");
input = Console.ReadLine();
float ya = float.Parse(input);

System.Console.Write("z:");
input = Console.ReadLine();
float za = float.Parse(input);

//Input second digital
Console.WriteLine("Введите второе число:");
System.Console.Write("x:");
input = Console.ReadLine();
float xb = float.Parse(input);

System.Console.Write("y:");
input = Console.ReadLine();
float yb = float.Parse(input);

System.Console.Write("z:");
input = Console.ReadLine();
float zb = float.Parse(input);

//Вычисление расстояния
double spase = Math.Sqrt((xa-xb)*(xa-xb)+(ya-yb)*(ya-yb)+(za-zb)*(za-zb));
spase = Math.Round(spase,2);

//Вывод результата
System.Console.Write("Расстояние между точками: ");
System.Console.WriteLine(spase);