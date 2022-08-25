//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру 
//этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

System.Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());

if(((number / 100) > 0) && ((number / 1000) < 1) )
{
    int secondNumber = (number/10) % 10;
    System.Console.WriteLine( "Second number : "+ secondNumber);
}

else
{
    System.Console.WriteLine("Bad number");
}
