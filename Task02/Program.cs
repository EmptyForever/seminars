// (1. Напишите программу, которая на вход принимает два
//числа и проверяет, является ли первое число квадратом
//второго.
//a = 25, b = 5 -> да
//a = 2, b = 10 -> нет) 
Console.Clear();
Console.WriteLine("Является ли первое число квадратом второго?");
string strNum1 = Console.ReadLine();
double number1 = Convert.ToInt32(strNum1);

string strNum2 = Console.ReadLine();
double number2 = Convert.ToInt32(strNum2);

double stepen = 0.5;
double result = Math.Pow(number1, stepen);
Console.WriteLine(result);

if (result == number2)
{
    Console.WriteLine($"Число {number1} является квадратом числа {number2}");
} else {
    Console.WriteLine($"Число {number1} не является квадратом числа {number2}");    
}




