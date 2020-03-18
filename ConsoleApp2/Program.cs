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
            List<SnakePart> snakeParts = new List<SnakePart>(4);
            SnakeHead head = new SnakeHead(screen.SizeX / 2, screen.SizeY / 2, screen.SizeX, screen.SizeY);
            snakeParts.Insert(0, head); 
            for (int i = 1; i < snakeParts.Capacity; i++)
            {
                snakeParts.Insert(i, new SnakePart(screen.SizeX/2-(i-1), screen.SizeY/2, screen.SizeX, screen.SizeY));
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
                head.Turn();
                //проверка на самосьедение
                for (int i = 2; i < snakeParts.Count; i++)
                {
                    if (head.CheckTouch(snakeParts[i]))
                    {
                        loose = true;
                    }
                }
                if (head.CheckTouch(screen))
                {
                    loose = true;
                }
                //и перемещение змеи
                if (head.CheckTouch(snakeParts[1])) { }
                else
                {
                    for (int i = snakeParts.Count - 1; i > 0; i--)
                    {
                        snakeParts[i].SetPosition(snakeParts[i - 1]);
                    }
                }

                //проверка на еду и расширение змеи
                if (head.CheckTouch(food))
                {
                    Score++;
                    snakeParts.Add(new SnakePart(snakeParts[2].PositionX, snakeParts[2].PositionY, screen.SizeX, screen.SizeY));
                    food.NewPozition();
                    for (int i = 1; i < snakeParts.Count; i++)
                    {
                        if (head.CheckTouch(food))
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
