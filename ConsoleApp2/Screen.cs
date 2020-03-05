using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Screen
    {
        public Screen()
        {
            SizeX = 10;
            SizeY = 4;
        }

        public int SizeX { get; set; }
        public int SizeY { get; set; }
        public Food Food { get; set; }
        public Snake Snake { get; set; }

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

        public void DisplayFood()
        {
            Console.SetCursorPosition(Food.PositionX - 1, Food.PositionY- 1);
            Console.Write("\b");
            Console.Write("*");
            Console.SetCursorPosition(SizeX, SizeY);
        }

        public void DisplaySnakePart()
        {
            Console.SetCursorPosition(Snake.PositionX-1, Snake.PositionY-1);
            Console.Write("\b");
            Console.Write("0");
            Console.SetCursorPosition(SizeX, SizeY);
        }
    }
}
