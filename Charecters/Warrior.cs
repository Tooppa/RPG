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
                if (weapon.Type == WeaponType.Axe || weapon.Type == WeaponType.Hammer || weapon.Type == WeaponType.Sword)
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
                damage *= (1 + TotalPrimaryAttributes.Strenght/100.0);
            }
            return damage;
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
