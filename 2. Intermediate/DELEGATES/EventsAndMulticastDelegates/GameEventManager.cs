using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndMulticastDelegates
{
    class GameEventManager
    {
        //a new delegate type called GameEvent
        public delegate void GameEvent();

        //create two delegates variables called OnGameStart and OnGameOver
        public static event GameEvent OnGameStart, OnGameOver;

        //a static method to trigger OnGameStart

        public static void TriggerGameStart()
        {
            //check if the OnGameStart event is not empty, meaning that other methods already subscribe
            if(OnGameStart != null)
            {
                //print a simple message
                Console.WriteLine("The game has started....");
                //call the OnGameStart that will trigger all the methods subscribed to this event
                OnGameStart();
            }
        }

        public static void TriggerGameOver()
        {
            //check if the OnGameOver event is not empty, meaning that other methods already subscribe
            if(OnGameOver != null)
            {
                //print simple message
                Console.WriteLine("The game has over....");
                //call on the OnGameOver that will trigger all the methods subscribed to this event
                OnGameOver();
            }
        }



    }
}
