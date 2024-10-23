namespace Dungeons_and_Dragons.Weapons
{
    public class Dagger : IWeapon
    {
        public int MinStrength { get; set; }
        public int MinIntelligence { get; set; }
        public int Damage { get; set; }
        public string Name { get; set; }
        public WeaponPrimaryAttr PrimairyAttr { get; set; }

        public Dagger()
        {
            this.MinStrength = 1;
            this.MinIntelligence = 1;
            this.Damage = 2;
            this.Name = "Dagger";
            this.PrimairyAttr = WeaponPrimaryAttr.Strength;
        }
    }
}