using BotInterface.Game;

namespace BotInterface.Bot
{
    public interface IBot
    {
        Move MakeMove(Gamestate gamestate);
    }
}