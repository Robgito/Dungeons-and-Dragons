﻿using Dungeons_and_Dragons.Dice;
using Dungeons_and_Dragons.Logger;
using Dungeons_and_Dragons.Weapons;

namespace Dungeons_and_Dragons.Player.Races
{
    public class Elf : IPlayer
    {
        public Elf(IWeaponFactory weaponFactory, Ilogger logger, IDice dice)
        {
            Logger = logger;
            WeaponFactory = weaponFactory;
            Weapon = weaponFactory.Create(WeaponType.Bow);
            Dice = dice;
            Strength = dice.Roll(1);
            Intelligence = dice.Roll(3);
            Health = dice.Roll(2);
            Race = Race.Elf;
        }

        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Health { get; set; }
        public IWeapon Weapon { get; set; }
        public Ilogger Logger { get; set; }
        public IWeaponFactory WeaponFactory { get; set; }
        public IDice Dice { get; set; }
        public Race Race { get; set; }

        public int Attack()
        {
            int damage = 0;

            switch (Weapon.PrimairyAttr)
            {
                case WeaponPrimaryAttr.Strength:
                    damage = Weapon.Damage * this.Strength;
                    break;

                case WeaponPrimaryAttr.Intelligence:
                    damage = Weapon.Damage * this.Intelligence;
                    break;
            }
            Logger.PrintMessage($"You attack for {damage} damage!");
            return damage;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
    }
}