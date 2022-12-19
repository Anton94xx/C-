// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//if (number1 > number2)
//{
//    Console.WriteLine("Первое число" + number1 + "больше чем второе" + number2);
//}
//else
//{
//    Console.WriteLine("Второе число" + number2 + "больше чем первое" + number1);
//}

Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine("Первое число больше чем второе. Ответ:" + number1);
}
else
{
    Console.WriteLine("Второе число больше чем первое. Ответ:" + number2);
}