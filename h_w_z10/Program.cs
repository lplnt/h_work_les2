// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear(); //очистка консоли

Console.WriteLine("Введите трехзначное число: "); //вывод сообщение 
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());

string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("Вторая цифра- "+stringNumber[1]);