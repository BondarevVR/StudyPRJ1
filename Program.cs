using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //тестовая хрень
            Screen screen = new Screen();
            Food f = new Food(screen.ScreenSizeX, screen.ScreenSizeY);
            screen.Food = f;
            Snake s = new Snake(screen.ScreenSizeX/2, screen.ScreenSizeY/2);
            screen.Snake = s;

            screen.DisplayBorder();
            screen.DisplayFood();
            screen.DisplaySnakePart();

            
            Console.ReadKey();
        }
    }
}
