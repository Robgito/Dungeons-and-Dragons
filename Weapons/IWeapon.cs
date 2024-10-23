namespace Dungeons_and_Dragons.Weapons
{
    public interface IWeapon
    {
        int MinStrength { get; set; }
        int MinIntelligence { get; set; }
        int Damage { get; set; }
        string Name { get; set; }
        WeaponPrimaryAttr PrimairyAttr { get; set; }
    }
}