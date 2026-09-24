using Microsoft.VisualStudio.TestTools.UnitTesting;
using CharacterSelectTest.Application.Factory;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Tests.Domain.Character
{
    [TestClass]
    public class WarriorTest
    {
        [TestMethod]
        public void TestWarriorAttack()
        {
            var character = CharacterFactory.Create(
                CharacterClass.Warrior,
                "Test Warrior");

            Assert.AreEqual(42, character.Attack());
        }

        [TestMethod]
        public void TestWarriorSpecialAbility()
        {
            var character = CharacterFactory.Create(
                CharacterClass.Warrior,
                "Test Warrior");

            Assert.AreEqual(
                "Test Warrior używa Wiru Ostrzy!",
                character.UseSpecialAbility());
        }
    }
}
