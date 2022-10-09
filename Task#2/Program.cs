/*Задача 18: Напишите программу, 
которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).
*/

int GetQuoter(string message)
{
    int result = 0;
    bool isCorrect = false;

    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result != 0 && result <= 4)
            isCorrect = true;
        else
            Console.WriteLine("Введите валидную четверть!\n");
    }

    return result;
}

void NumberOfQuoter(int numb)
{
    if (numb == 1)
        Console.WriteLine("X от 0 до + бесконечность, Y от 0 до + бесконечность");
    if (numb == 2)
        Console.WriteLine("X от 0 до - бесконечность, Y от 0 до + бесконечность");
    if (numb == 3)
        Console.WriteLine("X от 0 до - бесконечность, Y от 0 до - бесконечность");
    if (numb == 4)
        Console.WriteLine("X от 0 до + бесконечность, Y от 0 до - бесконечность");    
}

int x = GetQuoter("Введите номер четверти ");

NumberOfQuoter(x);
