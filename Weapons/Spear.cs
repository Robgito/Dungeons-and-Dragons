namespace Dungeons_and_Dragons.Weapons
{
    public class Spear : IWeapon
    {
        public int MinStrength { get; set; }
        public int MinIntelligence { get; set; }
        public int Damage { get; set; }
        public string Name { get; set; }
        public WeaponPrimaryAttr PrimairyAttr { get; set; }

        public Spear()
        {
            this.MinStrength = 5;
            this.MinIntelligence = 5;
            this.Damage = 4;
            this.Name = "Spear";
            this.PrimairyAttr = WeaponPrimaryAttr.Strength;
        }
    }
}