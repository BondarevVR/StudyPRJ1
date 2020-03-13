using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Screen
    {
        public Screen()
        {
            SizeX = 40;
            SizeY = 10;
        }

        public int SizeX { get; set; }
        public int SizeY { get; set; }

        //рисуем границы
        
        public void DisplayBorder()
        {
            for (int i = 1; i <= SizeY; i++)
            {
                for (int j = 1; j <= SizeX; j++)
                {
                    if (i != SizeY && j != SizeX)
                    {
                        Console.Write(" ");
                    }
                    if (i == SizeY && j != SizeX)
                    {
                        Console.Write("_");
                    }
                    if (j == SizeX)
                    {
                        Console.Write("|");
                        Console.WriteLine();
                    }
                }
            }
        }

        public void DisplayFood(Food food)
        {
            Console.SetCursorPosition(food.PositionX, food.PositionY- 1);
            Console.Write("\b");
            Console.Write("*");
            Console.SetCursorPosition(SizeX, SizeY);
        }

        public void DisplaySnakePart(Snake snakePart)
        {
            Console.SetCursorPosition(snakePart.PositionX, snakePart.PositionY-1);
            Console.Write("\b");
            Console.Write("0");
            Console.SetCursorPosition(SizeX, SizeY);
        }

        public void DisplayScore(int Score)
        {
            Console.WriteLine("Score is {0}", Score);
        }
    }
}
