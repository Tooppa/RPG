namespace RPG.Charecters
{
    internal class Ranger : Charecter
    {
        Ranger()
        {
            BaseDexterity = 7;
        }
        public override void LevelUp()
        {
            BaseIntelligence += 1;
            BaseDexterity += 5;
            BaseStrenght += 1;
        }
    }
}
