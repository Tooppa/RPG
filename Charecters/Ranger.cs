using RPG.Execptions;
using RPG.Items;
using RPG.Types;

namespace RPG.Charecters
{
    public class Ranger : Charecter
    {
        public Ranger()
        {
            BasePrimaryAttributes.Dexterity = 7;
            BasePrimaryAttributes.Intelligence = 1;
            BasePrimaryAttributes.Strenght = 1;
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
                if (weapon.Type == WeaponType.Bow)
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
            BasePrimaryAttributes.Dexterity += 5;
            BasePrimaryAttributes.Intelligence += 1;
            BasePrimaryAttributes.Strenght += 1;
        }
    }
}
