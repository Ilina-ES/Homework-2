//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

System.Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());

while ((number / 100) > 0)
{
    number = number / 10;
    
}


if(((number / 100) > 0) && ((number / 1000) < 1) )
{
    int lastNumber = number % 10;
    System.Console.WriteLine( "Last number : "+ lastNumber);
}

else
{
    System.Console.WriteLine("третьей цифры нет");
}