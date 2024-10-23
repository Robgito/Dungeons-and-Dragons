namespace Dungeons_and_Dragons.Weapons
{
    public class Bow : IWeapon
    {
        public int MinStrength { get; set; }
        public int MinIntelligence { get; set; }
        public int Damage { get; set; }
        public string Name { get; set; }
        public WeaponPrimaryAttr PrimairyAttr { get; set; }

        public Bow()
        {
            this.MinStrength = 2;
            this.MinIntelligence = 7;
            this.Damage = 3;
            this.Name = "Bow";
            this.PrimairyAttr = WeaponPrimaryAttr.Intelligence;
        }
    }
}