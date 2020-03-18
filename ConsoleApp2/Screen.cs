using System;
using System.Collections.Generic;
using System.Text;
 
namespace ConsoleApp2
{
    class Screen
    {
        private const int sizeX = 40;
        private const int sizeY = 10;
        public int SizeX { get { return sizeX; } }
        public int SizeY { get { return sizeY; } }

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

        public void DisplaySnakePart(SnakePart snakePart)
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
