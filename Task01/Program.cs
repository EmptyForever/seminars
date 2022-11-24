Console.WriteLine("Введите целое число: ");

string strNum = Console.ReadLine();
int number = Convert.ToInt32(strNum);

int square = number*number;

Console.WriteLine("квадрат числа " + number + " = " + square);
Console.WriteLine($"квадрат числа{number} = {square}");
