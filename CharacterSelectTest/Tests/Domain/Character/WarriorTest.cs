using Microsoft.VisualStudio.TestTools.UnitTesting;
using CharacterSelectTest.Application.Factory;
using CharacterSelectTest.Domain.Enum;
using CharacterSelectTest.Domain.Character;

namespace CharacterSelectTest.Tests.Domain.Character
{
    [TestClass]
    public class WarriorTest
    {
        [TestMethod]

        public void TestWarriorStats()
        {
            Warrior warrior = new("Test Warrior");

            Assert.AreEqual(120, warrior.Health);
            Assert.AreEqual(14, warrior.Strength);
            Assert.AreEqual(6, warrior.Intelligence);
            Assert.AreEqual(8, warrior.Agility);
            Assert.AreEqual(18, warrior.Defense);
            Assert.AreEqual(5, warrior.CriticalChance);
        }

        [TestMethod]
        public void TestWarriorAttack()
        {
            Warrior warrior = new("Test Warrior");

            Assert.AreEqual(42, warrior.Attack());
        }

        [TestMethod]
        public void TestWarriorSpecialAbility()
        {
            Warrior warrior = new("Test Warrior");
            
            Assert.AreEqual(
                "Test Warrior używa Wiru Ostrzy!",
                warrior.UseSpecialAbility());
        }
    }
}
