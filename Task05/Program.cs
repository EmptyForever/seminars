Console.Clear();

Console.Write("Введите число: ");
string numUser = Console.ReadLine();
int num = Convert.ToInt32(numUser);

int lust = num % 10; // % - выдаёт значение (остаток от деления) в данном случае при делении на 10 остаток от 456 - число 6
int first = num / 100; // так как деление целочисленное, то при делении остаток отбрасывается. 456/100=4,56 в программировании будет равно просто 4
Console.WriteLine($"Последняя цифра: {lust}");
Console.WriteLine($"Первая цифра: {first}");