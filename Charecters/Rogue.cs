namespace RPG.Charecters
{
    internal class Rogue : Charecter
    {
        Rogue()
        {
            BaseStrenght = 2;
            BaseDexterity = 6;
        }
        public override void LevelUp()
        {
            BaseIntelligence += 1;
            BaseDexterity += 4;
            BaseStrenght += 1;
        }
    }
}
