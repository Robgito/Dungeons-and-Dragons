namespace Dungeons_and_Dragons.Dice
{
    public class Dice : IDice
    {
        public int faces { get; set; }

        public Dice(int faces = 6)
        {
            this.faces = faces;
        }

        public int Roll(int amount)
        {
            Random random = new Random();
            int result = 0;

            for (int i = 0; i < amount; i++)
            {
                result += random.Next(1, faces + 1);
            }

            return result;
        }
    }
}