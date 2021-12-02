using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndMulticastDelegates
{
    class AudioSystem
    {

        public AudioSystem()
        {
            //subscribe to the OnGameStart on OnGameOver events.
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;

        }



        private void StartGame()
        {
            Console.WriteLine("Audio System Started");
            Console.WriteLine("Playing Audio...");
        }

        //when the game is over, we want to stop our rendering engine
        private void GameOver()
        {
            Console.WriteLine("Audio System Stopped");
        }
    }
}
