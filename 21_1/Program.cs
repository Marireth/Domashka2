// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");

int Number = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Второй цифрой числа {Number} является {Number / 10 % 10} ");
System.Console.WriteLine();
