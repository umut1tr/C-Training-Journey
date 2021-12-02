using System;

namespace EventsAndMulticastDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            AudioSystem audioSystem = new AudioSystem();

            RenderingEngine renderingEngine = new RenderingEngine();

            Player player1 = new Player("SteelCow");
            Player player2 = new Player("DoggoSilva");
            Player player3 = new Player("DragonDog");

            GameEventManager.TriggerGameStart();

            Console.WriteLine("Game is Running..... Press any key to end the game.");

            //pause
            Console.Read();

            //trigger the GameOver event

            GameEventManager.TriggerGameOver();
        }
    }
}
