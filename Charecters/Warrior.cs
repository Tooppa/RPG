namespace RPG.Charecters
{
    internal class Warrior : Charecter
    {
        Warrior()
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
