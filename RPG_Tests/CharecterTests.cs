using Xunit;
using RPG.Types;
using RPG.Items;
using RPG.Charecters;

namespace RPG_Tests
{
    public class CharecterTests
    {
        [Fact]
        public void NewCharecter_DefaultSettings_LevelShouldBeOne()
        {
            Mage mage = new Mage(); 
            Assert.Equal(1, mage.Level);
        }
        [Fact]
        public void CharecterLevelUp_AfterOneLevelUp_LevelShouldBeTwo()
        {
            Mage mage = new Mage();
            mage.LevelUp();
            Assert.Equal(2, mage.Level);
        }
        [Fact]
        public void NewRanger_DefaultSettings_CheckForRightAttributes()
        {
            Ranger ranger = new Ranger();
            Assert.Equal(1, ranger.BasePrimaryAttributes.Strenght);
            Assert.Equal(1, ranger.BasePrimaryAttributes.Intelligence);
            Assert.Equal(7, ranger.BasePrimaryAttributes.Dexterity);
        }
        [Fact]
        public void NewRogue_DefaultSettings_CheckForRightAttributes()
        {
            Rogue rogue = new Rogue();
            Assert.Equal(2, rogue.BasePrimaryAttributes.Strenght);
            Assert.Equal(1, rogue.BasePrimaryAttributes.Intelligence);
            Assert.Equal(6, rogue.BasePrimaryAttributes.Dexterity);
        }
        [Fact]
        public void NewWarrior_DefaultSettings_CheckForRightAttributes()
        {
            Warrior warrior = new Warrior();
            Assert.Equal(5, warrior.BasePrimaryAttributes.Strenght);
            Assert.Equal(1, warrior.BasePrimaryAttributes.Intelligence);
            Assert.Equal(2, warrior.BasePrimaryAttributes.Dexterity);
        }
        [Fact]
        public void NewMage_DefaultSettings_CheckForRightAttributes()
        {
            Mage mage = new Mage();
            Assert.Equal(1, mage.BasePrimaryAttributes.Strenght);
            Assert.Equal(8, mage.BasePrimaryAttributes.Intelligence);
            Assert.Equal(1, mage.BasePrimaryAttributes.Dexterity);
        }
        [Fact]
        public void NewRanger_AfterOneLevelUp_CheckForRightAttributesAfterLevelUp()
        {
            Ranger ranger = new Ranger();
            ranger.LevelUp();
            Assert.Equal(2, ranger.BasePrimaryAttributes.Strenght);
            Assert.Equal(2, ranger.BasePrimaryAttributes.Intelligence);
            Assert.Equal(12, ranger.BasePrimaryAttributes.Dexterity);
        }
        [Fact]
        public void NewRogue_AfterOneLevelUp_CheckForRightAttributesAfterLevelUp()
        {
            Rogue rogue = new Rogue();
            rogue.LevelUp();
            Assert.Equal(3, rogue.BasePrimaryAttributes.Strenght);
            Assert.Equal(2, rogue.BasePrimaryAttributes.Intelligence);
            Assert.Equal(10, rogue.BasePrimaryAttributes.Dexterity);
        }
        [Fact]
        public void NewWarrior_AfterOneLevelUp_CheckForRightAttributesAfterLevelUp()
        {
            Warrior warrior = new Warrior();
            warrior.LevelUp();
            Assert.Equal(8, warrior.BasePrimaryAttributes.Strenght);
            Assert.Equal(2, warrior.BasePrimaryAttributes.Intelligence);
            Assert.Equal(4, warrior.BasePrimaryAttributes.Dexterity);
        }
        [Fact]
        public void NewMage_AfterOneLevelUp_CheckForRightAttributesAfterLevelUp()
        {
            Mage mage = new Mage();
            mage.LevelUp();
            Assert.Equal(2, mage.BasePrimaryAttributes.Strenght);
            Assert.Equal(13, mage.BasePrimaryAttributes.Intelligence);
            Assert.Equal(2, mage.BasePrimaryAttributes.Dexterity);
        }
    }
}
