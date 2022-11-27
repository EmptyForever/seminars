Console.Clear();
// Пользователь вводит число N --- Нужно показать все целые числа между N и -N.
// Если число положительное, тогда уменьшаем. Отрицательное - увеличиваем, ноль - выдаём ответ, что "это просто ноль"

 Console.Write("Введите число: ");
string numUser = Console.ReadLine(); // строка, которую вводит пользователь numUser
int num = Convert.ToInt32(numUser); // переводит строку в 32 битную чо-то там, короче в целое число без запятых
 int numMinus = num * (-1);

if (num > 0) // если num положительное
{
    while (num > numMinus)
    {
         Console.Write(num);
         num = num - 1;
    }
}
else if (num < 0) // если num отрицательное
{
    while (num <= numMinus)
    {
         Console.Write(num);
         num = num + 1;
    }
}
else if (num == 0) // если num 0
{
    Console.WriteLine(num);
}
