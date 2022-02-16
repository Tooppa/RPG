using RPG.Execptions;
using RPG.Items;
using RPG.Types;

namespace RPG.Charecters
{
    public class Rogue : Charecter
    {
        public Rogue()
        {
            BasePrimaryAttributes.Dexterity = 6;
            BasePrimaryAttributes.Intelligence = 1;
            BasePrimaryAttributes.Strenght = 2;
        }

        public override string EquipArmor(Armor armor)
        {
            if (armor.RequiredLevel > Level)
            {
                throw new InvalidArmorException();
            }
            else
            {
                if (armor.Type == ArmorType.Mail || armor.Type == ArmorType.Leather)
                {
                    Items[armor.Slot] = armor;
                    return "Armor Success";
                }
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
                if (weapon.Type == WeaponType.Dagger || weapon.Type == WeaponType.Sword)
                {
                    Items[weapon.Slot] = weapon;
                    return "Weapon Success";
                }
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
            BasePrimaryAttributes.Dexterity += 4;
            BasePrimaryAttributes.Intelligence += 1;
            BasePrimaryAttributes.Strenght += 1;
        }
    }
}
