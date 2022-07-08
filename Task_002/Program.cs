Console.WriteLine("Введите номер дня недели:");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 == 1)
{
    Console.WriteLine("Вы выбрали понедельник");
}

if (num1 == 2)
{
    Console.WriteLine("Вы выбрали вторник");
}

if (num1 == 3)
{
    Console.WriteLine("Вы выбрали среду");
}

if (num1 == 4)
{
    Console.WriteLine("Вы выбрали четверг");
}

if (num1 == 5)
{
    Console.WriteLine("Вы выбрали пятницу");
}

if (num1 == 6)
{
    Console.WriteLine("Вы выбрали субботу");
}

if (num1 == 7)
{
    Console.WriteLine("Вы выбрали Воскресенье");
}

if (num1 > 7)
{
    Console.WriteLine("Вы ввели неправильное число");
}
