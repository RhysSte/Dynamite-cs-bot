namespace BotInterface.Game
{
    public class Gamestate
    {
        private Round[] rounds;

        public Round[] GetRounds()
        {
            return rounds;
        }

        public void SetRounds(Round[] rounds)
        {
            this.rounds = rounds;
        }
    }
}