// Задача 10
Console.WriteLine("Введите число от 100 до 999");    
void GetSecond(){
int number = int.Parse(Console.ReadLine()); 
Console.WriteLine(number);
    if (number > 99 && number < 1000)
    {
      Console.Write(number / 10 % 10);  
    } 
    else
    {
      Console.WriteLine("Введенное число не является трехзначным");
    }
}   
GetSecond();

// Задача 13
Console.WriteLine("Введите число ");
void GetThird()
{
  int number = int.Parse(Console.ReadLine());
if (number > 99 && number < 1000)
  {
    Console.Write(number % 10);  
  } 
  else
  {
    if (number > 999 && number < 10000)
    {
      Console.Write(number /10 % 10);
    }
    else
    {
      if (number > 9999 && number < 100000)
      {
        Console.Write(number / 100 % 10);
      }
      else
      {
        Console.WriteLine("Введенное число не имеет третьей цифры в составе");
      }
    }
  }
}
//GetThird();






