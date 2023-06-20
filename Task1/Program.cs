//Программа которая проверяет является ли второе число квадратом первого 
Console.WriteLine("Введите число №1 => "); //Вывод приглашения на экран
string inputedString1 = Console.ReadLine(); // Ввод пользователя (строка)
Console.WriteLine("Введите число №2 => "); //Вывод приглашения на экран
string inputedString2 = Console.ReadLine();
int numberB = Convert.ToInt32(inputedString2); //Преобразование строки
int numberA = Convert.ToInt32(inputedString1); //Преобразование строки в число

//Console.WriteLine($"Квадрат числа {number} равен {square}"); //Вывод результата

if (numberB == numberA * numberA)
{
    Console.WriteLine($"Число {numberB} является квадратом числа {numberA}");
}
else
{
    Console.WriteLine($"Число {numberB} не является квадратом числа {numberA}");
}