namespace RPG.Charecters
{
    internal class Rogue : Charecter
    {
        Rogue()
        {
            BasePrimaryAttributes.Dexterity = 6;
            BasePrimaryAttributes.Intelligence = 1;
            BasePrimaryAttributes.Strenght = 2;
        }
        public override void LevelUp()
        {
        }
    }
}
