Console.Clear();
Console.WriteLine("Write number1 ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Write number2 ");
int b = int.Parse(Console.ReadLine());

if ((a == b*b) || (b == a*a))
{
    Console.WriteLine("Yes");
}

else
{
    Console.WriteLine("No");
}
