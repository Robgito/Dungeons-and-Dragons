using Dungeons_and_Dragons.Dice;
using Dungeons_and_Dragons.Enemies;
using Dungeons_and_Dragons.Logger;
using Dungeons_and_Dragons.Player;
using Dungeons_and_Dragons.Weapons;
using Microsoft.Extensions.DependencyInjection;

namespace Dungeons_and_Dragons
{
    internal class StartupConfig
    {
        public ServiceCollection RegisterServices()
        {
            var services = new ServiceCollection();

            services.AddScoped<Ilogger, ConsoleLogger>();
            services.AddScoped<IPlayerFactory, PlayerFactory>();
            services.AddScoped<IDice, Dice.Dice>();
            services.AddScoped<IWeaponFactory, WeaponFactory>();
            services.AddScoped<IEnemyFactory, EnemyFactory>();
            services.AddSingleton<IGameLogic, GameLogic>();

            return services;
        }
    }
}