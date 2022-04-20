 using System;

int num=new Random().Next(100,1000);
/*string numS=num.ToString();
Console.WriteLine($"{num}->{numS[1]}");*/
int num2=num%100/10;
Console.WriteLine($"{num}->{num2}");