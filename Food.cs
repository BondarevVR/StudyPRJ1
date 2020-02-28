using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Food
    {
        Random rand = new Random();
        public Food(int ScreenSizeX, int ScreenSizeY)
        {
            Foodx = rand.Next(1, ScreenSizeX - 1); 
            Foody = rand.Next(1, ScreenSizeY - 1);
        }

        public int  Foodx { get; set; }
        public int Foody { get; set; }
    }
}
