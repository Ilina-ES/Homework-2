//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

System.Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());

if(((number / 100) > 0) && ((number / 1000) < 1)) 
    {
    int thirdNumber = number % 10;  
    System.Console.WriteLine( "third number : "+ thirdNumber);
    }
else if ((number / 1000) > 1)
    {
        while((number / 1000) > 1)
        {
            number = number / 10;
        }
    int thirdNumber = number % 10;  
    System.Console.WriteLine( "third number : "+ thirdNumber);

    }

else
{
    System.Console.WriteLine("третьей цифры нет");
}