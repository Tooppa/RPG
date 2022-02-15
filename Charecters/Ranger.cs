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
        public override void LevelUp()
        {
            Level += 1;
            BasePrimaryAttributes.Dexterity += 5;
            BasePrimaryAttributes.Intelligence += 1;
            BasePrimaryAttributes.Strenght += 1;
        }
    }
}
