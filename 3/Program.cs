Console.Clear();
Console.WriteLine("Write number1 ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Write number2 ");
int number2 = int.Parse(Console.ReadLine());

int d = number1%number2;

   if (d == 0)
    {
        Console.WriteLine("Кратно");
    }

    else 
    {
        Console.WriteLine($"Не кратно, остаток {d},");
    }