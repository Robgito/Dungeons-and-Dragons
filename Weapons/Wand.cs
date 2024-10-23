namespace Dungeons_and_Dragons.Weapons
{
    public class Wand : IWeapon
    {
        public int MinStrength { get; set; }
        public int MinIntelligence { get; set; }
        public int Damage { get; set; }
        public string Name { get; set; }
        public WeaponPrimaryAttr PrimairyAttr { get; set; }

        public Wand()
        {
            this.MinStrength = 1;
            this.MinIntelligence = 12;
            this.Damage = 5;
            this.Name = "Wand";
            this.PrimairyAttr = WeaponPrimaryAttr.Intelligence;
        }
    }
}