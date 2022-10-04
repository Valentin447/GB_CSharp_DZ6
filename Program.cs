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
    
}

void Positive(int count = 0){
    string str = Console.ReadLine();
    if(int.TryParse(str, out int number))
    {
        if(number > 0)
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
Task41();
//Task43();