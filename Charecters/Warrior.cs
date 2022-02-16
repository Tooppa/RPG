using RPG.Execptions;
using RPG.Items;
using RPG.Types;

namespace RPG.Charecters
{
    public class Warrior : Charecter
    {
        public Warrior()
        {
            BasePrimaryAttributes.Dexterity = 2;
            BasePrimaryAttributes.Intelligence = 1;
            BasePrimaryAttributes.Strenght = 5;
        }

        public override string EquipArmor(Armor armor)
        {
            if (armor.RequiredLevel > Level)
            {
                throw new InvalidArmorException();
            }
            else
            {
                if (armor.Type == ArmorType.Mail || armor.Type == ArmorType.Plate)
                    return "Success";
                else throw new InvalidArmorException();
            }
        }
        public override string EquipWeapon(Weapon weapon)
        {
            if (weapon.RequiredLevel > Level)
            {
                throw new InvalidWeaponException();
            }
            else
            {
                if (weapon.Type == WeaponType.Axe || weapon.Type == WeaponType.Hammer || weapon.Type == WeaponType.Sword)
                    return "Success";
                else throw new InvalidWeaponException();
            }
        }

        public override double GetDamage()
        {
            throw new NotImplementedException();
        }

        public override void LevelUp()
        {
            Level += 1;
            BasePrimaryAttributes.Dexterity += 2;
            BasePrimaryAttributes.Intelligence += 1;
            BasePrimaryAttributes.Strenght += 3;
        }
    }
}
