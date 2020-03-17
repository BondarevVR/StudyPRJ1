using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //тестовая хрень
            Screen screen = new Screen();

            Food food = new Food(screen.SizeX, screen.SizeY);

            //задаем начальную змею //нулевой член массива является направляющей для движения змеи 
            List<Snake> snakeParts = new List<Snake>(4);
            snakeParts.Insert(0, new Snake(screen.SizeX / 2, screen.SizeY / 2, screen.SizeX, screen.SizeY)); 
            for (int i = 1; i < snakeParts.Capacity; i++)
            {
                snakeParts.Insert(i, new Snake(screen.SizeX/2-(i-1), screen.SizeY/2, screen.SizeX, screen.SizeY));
            }

            bool loose = false;
            int Score = 0;

            //начало игры
            for (; ; )
            {
                //рисование необходимых частей
                screen.DisplayBorder();
                screen.DisplayFood(food);
                screen.DisplayScore(Score);
                for(int i = 1; i < snakeParts.Count; i++)
                {
                    screen.DisplaySnakePart(snakeParts[i]);
                }
                //поворот 
                snakeParts[0].Turn();
                //проверка на самосьедение
                for (int i = 2; i < snakeParts.Count; i++)
                {
                    if (snakeParts[0].CheckTouch(snakeParts[i]))
                    {
                        loose = true;
                    }
                }
                if (snakeParts[0].CheckTouch(screen))
                {
                    loose = true;
                }
                //и перемещение змеи
                if (snakeParts[0].CheckTouch(snakeParts[1])) { }
                else
                {
                    for (int i = snakeParts.Count - 1; i > 0; i--)
                    {
                        snakeParts[i].SetPosition(snakeParts[i - 1]);
                    }
                }

                //проверка на еду и расширение змеи
                if (snakeParts[0].CheckTouch(food))
                {
                    Score++;
                    snakeParts.Add(new Snake(snakeParts[2].PositionX, snakeParts[2].PositionY, screen.SizeX, screen.SizeY));
                    food.NewPozition();
                    for (int i = 1; i < snakeParts.Count; i++)
                    {
                        if (snakeParts[i].CheckTouch(food))
                        {
                            food.NewPozition();
                            i = 1;
                        }
                    }
                }
               
                if (loose)
                {
                    break;
                }
                Console.Clear();
            }
            Console.Clear();
            Console.WriteLine("looser");
            Console.ReadKey();
        }
    }
}
