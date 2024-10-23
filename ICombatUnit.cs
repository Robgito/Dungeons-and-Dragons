using Dungeons_and_Dragons.Logger;

namespace Dungeons_and_Dragons
{
    public interface ICombatUnit
    {
        int Attack();

        void TakeDamage(int damage);

        Ilogger Logger { get; set; }
    }
}