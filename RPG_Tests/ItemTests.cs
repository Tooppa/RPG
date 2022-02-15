using Xunit;
using RPG.Types;
using RPG.Items;

namespace RPG_Tests
{
    public class ItemTests
    {
        public Weapon testAxe = new Weapon()
        {
            Name = "Common axe",
            RequiredLevel = 1,
            Slot = Slot.Weapon,
            Type = WeaponType.Axe,
            Attributes = new WeaponAttributes() { Damage = 7, Speed = 1.1 }
        };
        public Armor testPlateBody = new Armor()
        {
            Name = "Common plate body armor",
            RequiredLevel = 1,
            Slot = Slot.Body,
            Type = ArmorType.Plate,
            Attributes = new PrimaryAttributes() { Strenght = 1 }
        };
        public Weapon testBow = new Weapon()
        {
            Name = "Common bow",
            RequiredLevel = 1,
            Slot = Slot.Weapon,
            Type = WeaponType.Bow,
            Attributes = new WeaponAttributes() { Damage = 12, Speed = 0.8 }
        };
        public Armor testClothHead = new Armor()
        {
            Name = "Common cloth head armor",
            RequiredLevel = 1,
            Slot = Slot.Head,
            Type = ArmorType.Cloth,
            Attributes = new PrimaryAttributes() { Intelligence = 5 }
        };
        [Fact]
        public void ItemEquip_WeaponLevelIsTooHigh_InvalidWeaponException()
        {

        }
        [Fact]
        public void ItemEquip_ArmorLevelIsTooHigh_InvalidArmorException()
        {

        }
        [Fact]
        public void ItemEquip_WeaponTypeIsIncorrect_InvalidWeaponException()
        {

        }
        [Fact]
        public void ItemEquip_ArmorTypeIsIncorrect_InvalidArmorException()
        {

        }
        [Fact]
        public void ItemEquip_WeaponEquippedCorrectly_CorrectSuccesMessage()
        {

        }
        [Fact]
        public void ItemEquip_ArmorEquippedCorrectly_CorrectSuccesMessage()
        {

        }
        [Fact]
        public void Damage_DamageWithoutWeapon_CorrectDamage()
        {

        }
        [Fact]
        public void Damage_DamageWithWeapon_CorrectDamage()
        {

        }
        [Fact]
        public void Damage_DamageWithWeaponAndArmor_CorrectDamage()
        {

        }
    }
}