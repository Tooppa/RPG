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

        public override void LevelUp()
        {
        }
    }
}
