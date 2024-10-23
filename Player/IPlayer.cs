using Dungeons_and_Dragons.Dice;
using Dungeons_and_Dragons.Player.Races;
using Dungeons_and_Dragons.Weapons;

namespace Dungeons_and_Dragons.Player
{
    public interface IPlayer : ICombatUnit
    {
        int Strength { get; set; }
        int Intelligence { get; set; }
        int Health { get; set; }
        IWeapon Weapon { get; set; }
        Race Race { get; set; }

        IWeaponFactory WeaponFactory { get; set; }
        IDice Dice { get; set; }
    }
}