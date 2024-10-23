namespace Dungeons_and_Dragons.Weapons
{
    public class Club : IWeapon
    {
        public int MinStrength { get; set; }
        public int MinIntelligence { get; set; }
        public int Damage { get; set; }
        public string Name { get; set; }
        public WeaponPrimaryAttr PrimairyAttr { get; set; }

        public Club()
        {
            this.MinStrength = 10;
            this.MinIntelligence = 1;
            this.Damage = 5;
            this.Name = "Club";
            this.PrimairyAttr = WeaponPrimaryAttr.Strength;
        }
    }
}