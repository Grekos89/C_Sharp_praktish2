Console.WriteLine("Введите число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 % num2 == 0)
{
    System.Console.WriteLine("кратно");
}
else
{
    System.Console.WriteLine($"не кратно, остаток {num1 % num2}");
}