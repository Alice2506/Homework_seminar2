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





//int number = 469;
//Console.Write(number / 10 % 10);
