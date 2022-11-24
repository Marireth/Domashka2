//Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int Numbers = Convert.ToInt32(Console.ReadLine());
string NumbersText = Convert.ToString(Numbers);
if (NumbersText.Length > 2)
{
Console.WriteLine("Третья цифра: " + NumbersText[2]);
}
else
{
  Console.WriteLine("Третьей цифры нет");
}