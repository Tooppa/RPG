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
        public override void LevelUp()
        {
            Level += 1;
            BasePrimaryAttributes.Dexterity += 1;
            BasePrimaryAttributes.Intelligence += 5;
            BasePrimaryAttributes.Strenght += 1;
        }
    }
}
