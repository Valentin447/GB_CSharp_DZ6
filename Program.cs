void Task41()
{
    // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
    Console.WriteLine("---------------------------------------------------------");
    Console.WriteLine("|  Введите число и нажмите Enter чтобы продолжить ввод.  |");
    Console.WriteLine("|  Введите букву чтобы завершить ввод.                   |");
    Console.WriteLine("---------------------------------------------------------");
    Positive();

}
void Task43()
{
    // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
    // значения b1, k1, b2 и k2 задаются пользователем.

    Console.Write("Введите b1: ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите k1: ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите b2: ");
    double b2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите k2: ");
    double k2 = Convert.ToDouble(Console.ReadLine());
    if (k1 == k2)
    {
        Console.WriteLine("Прямые не пересекаются.");
    }
    else
    {
        double x = Math.Round((b2 - b1) / (k1 - k2), 3);
        double y = Math.Round(k1 * x + b1, 3);
        Console.WriteLine("Координаты точки пересечения: x = " + x + "  y = " + y);
    }
}

void Positive(int count = 0)
{
    string str = Console.ReadLine();
    if (int.TryParse(str, out int number))
    {
        if (number > 0)
        {
            count++;
        }
        Positive(count);
    }
    else
    {
        Console.WriteLine("Положительных чисел: " + count);
        return;
    }
}


//Task41();
Task43();