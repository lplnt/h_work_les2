// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear(); //очистка консоли
Console.WriteLine("Введите число: "); //вывод сообщение 
int num = Convert.ToInt32(Console.ReadLine()); //присваивание переменной значения через ввод числа
string numText = Convert.ToString(num); //преобразование переменной в строку
if (numText.Length > 2) //условие, если вернувшееся значение больше 2х символов
{
    Console.WriteLine("Третья цифра: " + numText[2]); //вывести второй индекс
}
else 
{
    Console.WriteLine("Третьей цифры нет"); // вывести сообщение
}