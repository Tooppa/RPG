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
                if (weapon.Type == WeaponType.Wand || weapon.Type == WeaponType.Staff)
                {
                    this.Weapon = weapon;
                    return "Weapon Success";
                }
                else throw new InvalidWeaponException();
            }
        }

        public override double GetDamage()
        {
            double damage = 1;
            if(Weapon != null && Weapon.Type != WeaponType.Null)
            {
                damage = Weapon.Attributes.Damage * Weapon.Attributes.Speed;
                GetTotalAttributes();
                damage *= (1 + TotalPrimaryAttributes.Intelligence/100.0);
            }
            return damage;
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
