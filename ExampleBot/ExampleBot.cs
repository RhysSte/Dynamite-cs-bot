using BotInterface.Bot;
using BotInterface.Game;
using System;

namespace ExampleBot
{
    public class ExampleBot : IBot
    {
        private int dynCounter = 100;

        public Move MakeMove(Gamestate gamestate)
        {
            Random rnd = new Random();
            if (dynCounter > 0)
            {
                Move[] values = {Move.R, Move.P, Move.S, Move.D};
                var move = (Move)values[rnd.Next(values.Length)];

                if (move == Move.D)
                {
                    dynCounter--;
                }
                return move;
            }
            else
            {
                Move[] values = {Move.R, Move.P, Move.S};
                var move = (Move)values[rnd.Next(values.Length)];
                return move;
            }
        }
    }
}