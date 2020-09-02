using System;

namespace GaryGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Cessna red = new Cessna()
            {
                MainColor = "Red"
            };

            Ram blue = new Ram()
            {
                MainColor = "Blue"
            };

            Zero white = new Zero()
            {
                MainColor = "White"
            };

            Tesla green = new Tesla()
            {
                MainColor = "Green"
            };

            red.Drive();
            red.Turn("downward");
            red.Stop();
            blue.Drive();
            blue.Turn("left");
            blue.Stop();
            white.Drive();
            white.Turn("right");
            white.Stop();
            green.Drive();
            green.Turn("right");
            green.Stop();
        }
    }
}
