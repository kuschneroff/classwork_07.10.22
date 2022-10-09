/* Задача 22: Напишите программу, 
которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4 */


void GetNumb (int number)
{
    Console.Write ($"{number} ->");
    for (int i = 1; i <= number; i++)
    {
        double squere = Math.Pow(i,2);
        Console.Write($"{squere}, ");
    }
}

Console.WriteLine("Введите число: ");
int numb = int.Parse(Console.ReadLine() ??"");
GetNumb(numb);
