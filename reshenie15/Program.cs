//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
//является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Write("Enter number of the day of the week: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number >= 1 && number <= 5)
{
    System.Console.WriteLine($"День недели {number} не является выходным");
} 

else if(number == 6)
{
    System.Console.WriteLine($"День недели {number} является выходным");
}
else if(number == 7)
{
System.Console.WriteLine($"День недели {number} является выходным");
}
else
{
    System.Console.WriteLine("Bad number");
}