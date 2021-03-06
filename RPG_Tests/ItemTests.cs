using Xunit;
using RPG.Types;
using RPG.Items;
using RPG.Charecters;
using System;
using RPG.Execptions;

namespace RPG_Tests
{
    public class ItemTests
    {
        [Fact]
        public void ItemEquip_WeaponLevelIsTooHigh_InvalidWeaponException()
        {
            Warrior warrior = new Warrior();
            Weapon testAxe = new Weapon()
            {
                Name = "Common axe",
                RequiredLevel = 2,
                Slot = Slot.Weapon,
                Type = WeaponType.Axe,
                Attributes = new WeaponAttributes() { Damage = 7, Speed = 1.1 }
            };
            Assert.Throws<InvalidWeaponException>(() =>
            {
                warrior.EquipWeapon(testAxe);
            });
        }



        [Fact]
        public void ItemEquip_ArmorLevelIsTooHigh_InvalidArmorException()
        {
            Warrior warrior = new Warrior();
            Armor testPlateBody = new Armor()
            {
                Name = "Common plate body armor",
                RequiredLevel = 2,
                Slot = Slot.Body,
                Type = ArmorType.Plate,
                Attributes = new PrimaryAttributes() { Strenght = 1 }
            };
            Assert.Throws<InvalidArmorException>(() =>
            {
                warrior.EquipArmor(testPlateBody);
            });
        }
        [Fact]
        public void ItemEquip_WeaponTypeIsIncorrect_InvalidWeaponException()
        {
            Warrior warrior = new Warrior();
            Weapon testBow = new Weapon()
            {
                Name = "Common bow",
                RequiredLevel = 1,
                Slot = Slot.Weapon,
                Type = WeaponType.Bow,
                Attributes = new WeaponAttributes() { Damage = 12, Speed = 0.8 }
            };
            Assert.Throws<InvalidWeaponException>(() =>
            {
                warrior.EquipWeapon(testBow);
            });
        }
        [Fact]
        public void ItemEquip_ArmorTypeIsIncorrect_InvalidArmorException()
        {
            Warrior warrior = new Warrior();
            Armor testClothHead = new Armor()
            {
                Name = "Common cloth head armor",
                RequiredLevel = 1,
                Slot = Slot.Head,
                Type = ArmorType.Cloth,
                Attributes = new PrimaryAttributes() { Intelligence = 5 }
            };
            Assert.Throws<InvalidArmorException>(() =>
            {
                warrior.EquipArmor(testClothHead);
            });
        }
        [Fact]
        public void ItemEquip_WeaponEquippedCorrectly_CorrectSuccesMessage()
        {
            Warrior warrior = new Warrior();
            Weapon testAxe = new Weapon()
            {
                Name = "Common axe",
                RequiredLevel = 1,
                Slot = Slot.Weapon,
                Type = WeaponType.Axe,
                Attributes = new WeaponAttributes() { Damage = 7, Speed = 1.1 }
            };
            Assert.Equal("Weapon Success", warrior.EquipWeapon(testAxe));
        }
        [Fact]
        public void ItemEquip_ArmorEquippedCorrectly_CorrectSuccesMessage()
        {
            Warrior warrior = new Warrior();
            Armor testPlateBody = new Armor()
            {
                Name = "Common plate body armor",
                RequiredLevel = 1,
                Slot = Slot.Body,
                Type = ArmorType.Plate,
                Attributes = new PrimaryAttributes() { Strenght = 1 }
            };
            Assert.Equal("Armor Success", warrior.EquipArmor(testPlateBody));
        }
        [Fact]
        public void Damage_DamageWithoutWeapon_CorrectDamage()
        {
            Warrior warrior = new Warrior();
            double expected = (1 * (1 + (5 / 100)));
            Assert.Equal(expected,warrior.GetDamage());
        }
        [Fact]
        public void Damage_DamageWithWeapon_CorrectDamage()
        {
            Warrior warrior = new Warrior();
            Weapon testAxe = new Weapon()
            {
                Name = "Common axe",
                RequiredLevel = 1,
                Slot = Slot.Weapon,
                Type = WeaponType.Axe,
                Attributes = new WeaponAttributes() { Damage = 7, Speed = 1.1 }
            };
            warrior.EquipWeapon(testAxe);
            double expected = ((7 * 1.1)*(1 + (5 / 100.0)));
            Assert.Equal(expected,warrior.GetDamage());
        }
        [Fact]
        public void Damage_DamageWithWeaponAndArmor_CorrectDamage()
        {
            Warrior warrior = new Warrior();
            Weapon testAxe = new Weapon()
            {
                Name = "Common axe",
                RequiredLevel = 1,
                Slot = Slot.Weapon,
                Type = WeaponType.Axe,
                Attributes = new WeaponAttributes() { Damage = 7, Speed = 1.1 }
            };
            warrior.EquipWeapon(testAxe);
            Armor testPlateBody = new Armor()
            {
                Name = "Common plate body armor",
                RequiredLevel = 1,
                Slot = Slot.Body,
                Type = ArmorType.Plate,
                Attributes = new PrimaryAttributes() { Strenght = 1 }
            };
            warrior.EquipArmor(testPlateBody);
            double expected = ((7 * 1.1) * (1 + ((5 + 1) / 100.0)));
            Assert.Equal(expected,warrior.GetDamage());
        }
    }
}