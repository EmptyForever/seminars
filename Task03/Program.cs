//Напишите программу, которая будет выдавать название дня недели по заданному номеру.
Console.Clear();
Console.WriteLine("Введите число дня недели, пожалуйста!");
string strNum = Console.ReadLine();
int number = Convert.ToInt32(strNum);

if (number == 1) 
{
    Console.WriteLine("Понедельник");
}
else if (number == 2) 
{
    Console.WriteLine("Вторник");
}
else if (number == 3) 
{
    Console.WriteLine("Среда");
}
else if (number == 4) 
{
    Console.WriteLine("Четверг");
}
else if (number == 5) 
{
    Console.WriteLine("Пятница");
}
else if (number == 6) 
{
    Console.WriteLine("Суббота");
}
else if (number == 7) 
{
    Console.WriteLine("Воскресенье");
}
else {
    Console.Clear();
    Console.WriteLine($"Вы ввели число {number}");
    Console.WriteLine("Не то вы ввели, Товарищ! Дней недели всего 7, напишите число от одного до 7 включительно");
    
string strNum2 = Console.ReadLine();
int number2 = Convert.ToInt32(strNum2);

if (number2 == 1) 
{
    Console.WriteLine("Понедельник");
}
else if (number2 == 2) 
{
    Console.WriteLine("Вторник");
}
else if (number2 == 3) 
{
    Console.WriteLine("Среда");
}
else if (number2 == 4) 
{
    Console.WriteLine("Четверг");
}
else if (number2 == 5) 
{
    Console.WriteLine("Пятница");
}
else if (number2 == 6) 
{
    Console.WriteLine("Суббота");
}
else if (number2 == 7) 
{
    Console.WriteLine("Воскресенье");
}
else {
    Console.WriteLine("Вы не исправимы! До свидания!!!");
}
Console.WriteLine(number2);
}



Console.WriteLine(number);

