namespace Dungeons_and_Dragons.Weapons
{
    public class Sword : IWeapon
    {
        public int MinStrength { get; set; }
        public int MinIntelligence { get; set; }
        public int Damage { get; set; }
        public string Name { get; set; }
        public WeaponPrimaryAttr PrimairyAttr { get; set; }

        public Sword()
        {
            this.MinStrength = 4;
            this.MinIntelligence = 1;
            this.Damage = 3;
            this.Name = "Sword";
            this.PrimairyAttr = WeaponPrimaryAttr.Strength;
        }
    }
}