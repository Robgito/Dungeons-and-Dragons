namespace Dungeons_and_Dragons.Dice
{
    public interface IDice
    {
        int faces { get; set; }

        int Roll(int amount);
    }
}