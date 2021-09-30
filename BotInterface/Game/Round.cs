namespace BotInterface.Game
{
    public class Round
    {
        private Move p1;
        private Move p2;

        public Move GetP1()
        {
            return p1;
        }

        public void SetP1(Move p1)
        {
            this.p1 = p1;
        }

        public Move GetP2()
        {
            return p2;
        }

        public void SetP2(Move p2)
        {
            this.p2 = p2;
        }
    }
}