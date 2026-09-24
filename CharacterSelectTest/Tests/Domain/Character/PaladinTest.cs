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
    public class PaladinTest
    {
        [TestMethod]
        public void TestPaladinStats()
        {
            Paladin paladin = new("Test Paladin");

            Assert.AreEqual(110, paladin.Health);
            Assert.AreEqual(12, paladin.Strength);
            Assert.AreEqual(10, paladin.Intelligence);
            Assert.AreEqual(6, paladin.Agility);
            Assert.AreEqual(20, paladin.Defense);
            Assert.AreEqual(5, paladin.CriticalChance);
        }

        [TestMethod]
        public void TestPaladinAttack()
        {
            Paladin paladin = new("Test Paladin");

            Assert.AreEqual(36, paladin.Attack());
        }

        [TestMethod]

        public void TestPaladinSpecialAbility()
        {
            Paladin paladin = new("Test Paladin");

            Assert.AreEqual("Test Paladin używa Świętej Tarczy!", paladin.UseSpecialAbility());
        }
    }
}
