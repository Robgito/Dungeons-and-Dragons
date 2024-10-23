using Dungeons_and_Dragons.Player;
using Microsoft.Extensions.DependencyInjection;

namespace Dungeons_and_Dragons
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IPlayer player = null;
            ServiceCollection services = new ServiceCollection();
            StartupConfig config = new StartupConfig();
            services = config.RegisterServices();
            ServiceProvider serviceProvider = services.BuildServiceProvider();

            IGameLogic gameLogic = serviceProvider.GetService<IGameLogic>();

            gameLogic.WelcomeMessage();

            player = gameLogic.ChooseRace();

            gameLogic.PrintPlayerStats(player);

            gameLogic.Encounter(player);

            gameLogic.GameOver();
        }
    }
}