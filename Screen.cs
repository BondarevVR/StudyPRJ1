using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Screen
    {
        public Screen()
        {
            ScreenSizeX = 40;
            ScreenSizeY = 10;
        }

        public int ScreenSizeX { get; set; }
        public int ScreenSizeY { get; set; }
        public Food Food { get; set; }
        public Snake Snake { get; set; }

        //рисуем границы

        public void DisplayBorder()
        {
            for (int i = 1; i <= ScreenSizeY; i++)
            {
                for (int j = 1; j <= ScreenSizeX; j++)
                {
                    if (i != ScreenSizeY)
                    {
                        Console.Write(" ");
                    }
                    if (i == ScreenSizeY)
                    {
                        Console.Write("_");
                    }
                    if (j == ScreenSizeX)
                    {
                        Console.Write("|");
                        Console.WriteLine();
                    }
                }
            }
        }

        public void DisplayFood()
        {
            Console.SetCursorPosition(Food.Foodx-1, Food.Foody-1);
            Console.Write("\b");
            Console.Write("*");
            Console.SetCursorPosition(ScreenSizeX, ScreenSizeY);
        }

        public void DisplaySnakePart()
        {
            Console.SetCursorPosition(Snake.SnakeX-1, Snake.SnakeY-1);
            Console.Write("\b");
            Console.Write("o");
            Console.SetCursorPosition(ScreenSizeX, ScreenSizeY);
        }
    }
}
