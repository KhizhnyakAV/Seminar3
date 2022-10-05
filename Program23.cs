// See https://aka.ms/new-console-template for more information
Console.WriteLine("Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. Введите число");

string input = Console.ReadLine();
int N = int.Parse(input);
int cube;

for (int i=1; i<=N ; i++)
{cube = i*i*i;
    System.Console.Write($"{cube}  ");};