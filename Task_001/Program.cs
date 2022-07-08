Console.WriteLine("Введите первое целое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число:");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2 * num2)
{
    Console.WriteLine("Первое число является квадратом второго");
}

else
{
    Console.Write("Первое число не является квадратом второго");
    
}
