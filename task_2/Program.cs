// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7, min = 5
// a = 2 b = 10 -> max = 10, min = 2
// a = -9 b = -3 -> max = -3, min = -9

string answerA = Console.ReadLine();
int a = Convert.ToInt32(answerA); 

string answerB = Console.ReadLine();
int b = Convert.ToInt32(answerB); 

int max = 0;
int min = 0;

if( a > b ) 
{
    max = a; min = b;
}
else
{
    max = b; min = a;
}
Console.Write("Max=");
Console.WriteLine(max);
Console.Write("Min=",min);
Console.WriteLine(min);