// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N

// Console.WriteLine("введите число:");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 0)
// {
//     Num(num);
// }
// else{
//     Console.WriteLine("error");
// }
// void Num(int n1)
// {
//     int count = 1;
//     while(count < n1);
//     {
//         Console.WriteLine ($"{count} {count * count}");
//         count++;
//     }
// }

System.Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    Numb(number);
}
else
{
    System.Console.WriteLine("error");
}

void Numb(int n1)
{
    int counter = 1;
    while(counter <= n1)
    {
        Console.WriteLine($"{counter} {counter * counter}");
        counter++;
    }
}
