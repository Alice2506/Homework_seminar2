// Как создать новую функцию:
// void, int, bool, string ... и т.д.
/*
void WriteTwo()
{
Console.WriteLine(2);
}
void WriteHello(string name)
{
Console.WriteLine("Hello, " + name);
}
string HelloToWord(string name)
{
return "Hello, " + name;
}
WriteTwo();
string word = HelloToWord("Vlad");
Console.WriteLine(word + " Как дела?"); 
*/

//int[] numbers = new int[10];
//int[] a = {56, 67, 97, 0, 56, 9, 43};
//Console.WriteLine(a[4]);

int[] CreateArrayNumber(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1,100);
    }
    return array;
}
void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
int[] numbers = CreateArrayNumber(10);
WriteArray(numbers);