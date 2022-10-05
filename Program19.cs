// See https://aka.ms/new-console-template for more information
Console.WriteLine("Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Введите пятизначное число:");

string input = Console.ReadLine();
char one = input[0];
char two = input[1];
char four = input[3];
char five = input[4];

if (input.Length == 5)
{
    if ((one == five) & (two == four)) 
    { System.Console.WriteLine("Да"); } 
    else System.Console.WriteLine("Нет");
}
else System.Console.WriteLine("Введенное число не является пятизначным");