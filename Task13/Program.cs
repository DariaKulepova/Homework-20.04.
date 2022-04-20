
 /*using System;
num=new Random().Next(100,1000);
/*Console.WriteLine("Input number");
int num=Convert.ToInt32(Console.ReadLine());*/
/*string numS=num.ToString();
Console.WriteLine($"{num[2]}");*/
/*if(num>=100)
{
    
}
else
{
    Console.WriteLine("Третьего числа нет");
}*/

using System;

Console.WriteLine("Input number");
int num=int.Parse(Console.ReadLine());
string numS=num.ToString();
if(num>=100)
{
Console.WriteLine($"{num}->{numS[2]}");
}
else
{
    Console.WriteLine("Третьей цифры не существует");
}
