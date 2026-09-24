using CharacterSelectTest.Application.Factory;
using CharacterSelectTest.Domain.Character;
using CharacterSelectTest.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSelectTest.Tests.Domain.Character
{
    [TestClass]
    public class RogueTest
    {
        [TestMethod]
        public void TestRogueStats()
        {
            Rogue rogue = new("Test Rogue");

            Assert.AreEqual(95, rogue.Health);
            Assert.AreEqual(9, rogue.Strength);
            Assert.AreEqual(8, rogue.Intelligence);
            Assert.AreEqual(15, rogue.Agility);
            Assert.AreEqual(7, rogue.Defense);
            Assert.AreEqual(25, rogue.CriticalChance);
        }

        [TestMethod]
        public void TestRogueAttack()
        {
            Rogue rogue = new("Test Rogue");

            Assert.AreEqual(45, rogue.Attack());
        }

        [TestMethod]
        public void TestRogueSpecialAbility()
        {
            Rogue rogue = new("Test Rogue");
            Assert.AreEqual("Test Rogue wykonuje Zasadzkę!", rogue.UseSpecialAbility());
        }
    }
}
