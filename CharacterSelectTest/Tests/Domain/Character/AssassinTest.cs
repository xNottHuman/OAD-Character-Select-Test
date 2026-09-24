using CharacterSelectTest.Application.Factory;
using CharacterSelectTest.Domain.Character;
using CharacterSelectTest.Domain.Entity;
using CharacterSelectTest.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSelectTest.Tests.Domain.Character
{
    [TestClass]
    public class AssassinTest
    {
        [TestMethod]
        public void TestAssassinStats()
        {
            Assassin assassin = new("Test Assassin");

            Assert.AreEqual(70, assassin.Health);
            Assert.AreEqual(12, assassin.Strength);
            Assert.AreEqual(12, assassin.Intelligence);
            Assert.AreEqual(17, assassin.Agility);
            Assert.AreEqual(6, assassin.Defense);
            Assert.AreEqual(30, assassin.CriticalChance);
        }

        [TestMethod]
        public void TestAssassinAttack()
        {
            Assassin assassin = new("Test Assassin");

            Assert.AreEqual(51, assassin.Attack());
        }

        [TestMethod]

        public void TestAssassinSpecialAbility()
        {
            Assassin assassin = new("Test Assassin");

            Assert.AreEqual("Test Assassin wykonuje Cichy Cios!", assassin.UseSpecialAbility());
        }
    }
}
