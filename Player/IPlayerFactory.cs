using Dungeons_and_Dragons.Dice;
using Dungeons_and_Dragons.Logger;
using Dungeons_and_Dragons.Player.Races;
using Dungeons_and_Dragons.Weapons;

namespace Dungeons_and_Dragons.Player
{
    public interface IPlayerFactory
    {
        IPlayer Create(Race raceType);

        Ilogger Logger { get; set; }
        IWeaponFactory WeaponFactory { get; set; }
        IDice Dice { get; set; }
    }
}