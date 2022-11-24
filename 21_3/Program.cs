// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.WriteLine ("Введите цифрой день недели: ");
int dayofweek = int.Parse (Console.ReadLine());
if (dayofweek == 6 || dayofweek == 7) 
   {
    Console.WriteLine ("Выходной день");
   }
else if (dayofweek <= 5) 
   {
 Console.WriteLine ("Будний день");
   }
else if (dayofweek > 7) 
   {
    Console.WriteLine ("В неделе 7 дней");
   }	