﻿/*17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.*/

//получает координату, не равную 0

int GetCoordinate(string message)
{
    int result = 0;
    bool isCorrect = false;

    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result != 0)
            isCorrect = true;
        else
            Console.WriteLine("Введите валидную координату!\n");
    }

    return result;
}

// получает четверть, в которой лежит точка с координатами (x,y)
int GetQuarter(int x, int y)
{
    if(x > 0 && y > 0)
        return 1;
    else if(x < 0 && y > 0)
        return 2;
    else if(x < 0 && y < 0)
        return 3;
    else
        return 4;
}


int x = GetCoordinate("Введите координату Х, не равную 0");
int y = GetCoordinate("Введите координату Y, не равную 0");
int quarter = GetQuarter(x, y);

Console.WriteLine($"Точка с координатами ({x},{y}) лежит в {quarter} четверти");
