using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndMulticastDelegates
{
    class Player
    {
        public string PlayerName { get; set; }

        public Player(string name)
        {
            this.PlayerName = name;

            //subscribe to OnGameOn and OnGameOver events.
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
            
        }

        //at the start of the game spawn the player
        private void StartGame()
        {
            Console.WriteLine($"Spawning Player with ID : {PlayerName}");
        }

        //when game is lost remove player from the game
        private void GameOver()
        {
            Console.WriteLine($"Removing Player with ID : {PlayerName}");
        }
    }
}
