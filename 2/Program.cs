// из трехзначного числа удаляет вторую цифру 456 -> 46

Console.Clear();

int num = new Random().Next(100, 1000);

int a1 = num / 100;
int a2 = num % 10;

Console.WriteLine(num);

int result = a1 * 10 + a2;


Console.WriteLine(result);