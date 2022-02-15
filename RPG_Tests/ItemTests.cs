using Xunit;
using RPG.Types;
using RPG.Items;

namespace RPG_Tests
{
    public class ItemTests
    {
        [Fact]
        public void Test1()
        {
            Weapon testAxe = new Weapon()
            {
                Name = "Common axe",
                RequiredLevel = 1,
                Slot = Slot.Weapon,
                Type = WeaponType.Axe,
                Attributes = new WeaponAttributes() { Damage = 7, Speed = 1.1 }
            };
            Armor testPlateBody = new Armor()
            {
                Name = "Common plate body armor",
                RequiredLevel = 1,
                Slot = Slot.Body,
                Type = ArmorType.Plate,
                Attributes = new PrimaryAttributes() { Strenght = 1 }
            };
            Weapon testBow = new Weapon()
            {
                Name = "Common bow",
                RequiredLevel = 1,
                Slot = Slot.Weapon,
                Type = WeaponType.Bow,
                Attributes = new WeaponAttributes() { Damage = 12, Speed = 0.8 }
            };
            Armor testClothHead = new Armor()
            {
                Name = "Common cloth head armor",
                RequiredLevel = 1,
                Slot = Slot.Head,
                Type = ArmorType.Cloth,
                Attributes = new PrimaryAttributes() { Intelligence = 5 }
            };
        }
    }
}