// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Номер четверти");
int quarter = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Quarter(quarter));

string Quarter(int quart)
{
    if (quart == 1) return "x > 0 y > 0";
    if (quart == 2) return "x < 0 y > 0";
    if (quart == 3) return "x < 0 y < 0";
    if (quart == 4) return "x > 0 y < 0";
    return "Неверный номер четверти";
}