using RPG.Execptions;
using RPG.Items;
using RPG.Types;

namespace RPG.Charecters
{
    public class Mage : Charecter
    {
        public Mage()
        {
            BasePrimaryAttributes.Dexterity = 1;
            BasePrimaryAttributes.Intelligence = 8;
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
                if (armor.Type == ArmorType.Cloth)
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
                if (weapon.Type == WeaponType.Wand || weapon.Type == WeaponType.Staff)
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
            BasePrimaryAttributes.Dexterity += 1;
            BasePrimaryAttributes.Intelligence += 5;
            BasePrimaryAttributes.Strenght += 1;
        }
    }
}
