using RPG.Items;

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

        public override void EquipItem(Item item)
        {
            throw new NotImplementedException();
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
