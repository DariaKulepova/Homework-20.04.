
using System;

Console.WriteLine("Input number");
int num=Convert.ToInt32(Console.ReadLine());
string numS=num.ToString();
if(num>=100)
{
Console.WriteLine($"{num}->{numS[2]}");
}
else
{
    Console.WriteLine("Третьей цифры не существует");
}

