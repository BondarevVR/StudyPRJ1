using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //тестовая хрень
            Screen screen = new Screen();

            Food food = new Food(screen.SizeX, screen.SizeY);
            screen.Food = food;

            //задаем начальную змею //нулевой член массива является направляющей для движения змеи 
            Snake[] snakes = new Snake[4];
            snakes[0] = new Snake(screen.SizeX / 2, screen.SizeY / 2);
            for (int i = 0; i < snakes.Length-1; i++)
            {
                snakes[i+1] = new Snake(screen.SizeX/2-i, screen.SizeY/2);
            }

            //начало игры
            for (; ; )
            {
                //рисование необходимых частей
                screen.DisplayBorder();
                screen.DisplayFood();
                for(int i = 1; i < snakes.Length; i++)
                {
                    screen.Snake = snakes[i];
                    screen.DisplaySnakePart();
                }
                //поворот и перемещение змеи
                snakes[0].Turn();
                if (snakes[0].PositionX == snakes[1].PositionX && snakes[0].PositionY == snakes[1].PositionY) { }
                else
                {
                    for (int i = snakes.Length - 1; i > 0; i--)
                    {
                        snakes[i].PositionX = snakes[i - 1].PositionX;
                        snakes[i].PositionY = snakes[i - 1].PositionY;
                    }
                }
                //проверка на еду и расширение змеи
                if (snakes[1].PositionX == food.PositionX && snakes[1].PositionY == food.PositionY)
                {
                    Array.Resize(ref snakes, snakes.Length + 1);
                    snakes[snakes.Length - 1] = new Snake(snakes[1].PositionX, snakes[1].PositionY);
                    food.NewPozition();
                    for (int i = 1; i < snakes.Length; i++)
                    {
                        if (snakes[i].PositionX == food.PositionX && snakes[i].PositionY == food.PositionY)
                        {
                            food.NewPozition();
                            i = 1;
                        }
                    }
                }
                Console.Clear();
            }
            
            Console.ReadKey();
        }
    }
}
