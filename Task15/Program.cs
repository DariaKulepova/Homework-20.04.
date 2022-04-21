using System;

int num=new Random().Next(1,8);
if((num==6)||(num==7))
{
    Console.WriteLine($"{num}->Yes");
}
else
{
   Console.WriteLine($"{num}->No");
} 
