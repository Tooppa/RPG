namespace RPG.Charecters
{
    internal class Warrior : Charecter
    {
        Warrior()
        {
            BaseStrenght = 5;
            BaseDexterity = 2;
        }

        public override void LevelUp()
        {
            BaseIntelligence += 1;
            BaseDexterity += 2;
            BaseStrenght += 3;
        }
    }
}
