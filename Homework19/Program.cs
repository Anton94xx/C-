// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

Console.Write("Введите пятизначное число: ");
string numStr = Console.ReadLine();
int firstNum = 0;
int endNum = numStr.Length - 1;

if (endNum == 4)
{
while (firstNum < endNum && Char.IsDigit(numStr[firstNum]) && Char.IsDigit(numStr[endNum]))
    {
    if (numStr[firstNum] == numStr[endNum])
    {
    firstNum++;
    endNum = endNum - 1;
    }
    else
    {
        Console.WriteLine($"{numStr[firstNum]} != {numStr[endNum]} : число {numStr} не палиндром");
        firstNum = 5;
        }
        }
        if (firstNum == 2) Console.WriteLine($"число {numStr} - палиндром");
        if (firstNum != 2 && firstNum != 5) Console.WriteLine($"{numStr} - не верный ввод");
        }
        else Console.WriteLine("Значение не пятизначное");