// случайное число от 10 до 99 и показывает наибольшее число 

Console.Clear();

int num = new Random().Next(10,100);
int a1 = num/10;
int a2 = num%10;

int max = a1;
if (a2>max) max = a2;


Console.WriteLine(num);

Console.WriteLine(max);
