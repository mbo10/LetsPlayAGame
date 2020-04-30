using System;

namespace LetsPlayAGame
{
    public class Program
    {
        public static void DisplayInitialiseMessage()
        {
            Console.WriteLine("Initialising game");
        }

        public static void DisplayTerminateMessage()
        {
            Console.WriteLine("Terminating game");
        }

        static void Main(string[] args)
        {
            var game = new Game(1);
            game.SetInitialise(new Action(DisplayInitialiseMessage));
            game.SetTerminate(new Action(DisplayTerminateMessage));
            game.Add(new GameComponent());
            game.Add(new DrwableGameComponent(0, 0));
            game.Run();
            Console.ReadLine();
        }
    }
}
