namespace RPG.Charecters
{
    internal class Mage : Charecter
    {
        Mage()
        {
            BaseIntelligence = 8;
        }
        public override void LevelUp()
        {
            BaseIntelligence += 5;
            BaseDexterity += 1;
            BaseStrenght += 1;
        }
    }
}
