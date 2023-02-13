// Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

string answerA = Console.ReadLine();
int a = Convert.ToInt32(answerA); 
int b = 2;
int c = a % b;
if(c == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}