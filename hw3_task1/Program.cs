// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// метод принимает на ввод какое-то число
int Prompt(string massage) 
{
    Console.Write(massage);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

// метод проверяет число, чтобы оно было ровно 5 цифрам
bool ValidateNum(int num) 
{
    // num = Prompt("Введите пятизначное число: ");
    if (num < 10000 || num > 100000) 
    {
        Console.WriteLine("Вы ввели неправильное число!");
        return false;
    } 
    return true;
}

//метод проверки на полидромность
int number = Prompt("Введите пятизначное число: ");
if (ValidateNum(number))
{
    Console.WriteLine("Число правильное! Переходим к выполнению программы: ");
    for (int i = 0; i < number - 1 - i; i++)
    {
        if(number[i] == number[])
    }
}



