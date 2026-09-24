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
    public class RangerTest
    {
        [TestMethod]
        public void TestRangerStats()
        {
            Ranger ranger = new("Test Ranger");

            Assert.AreEqual(100, ranger.Health);
            Assert.AreEqual(11, ranger.Strength);
            Assert.AreEqual(9, ranger.Intelligence);
            Assert.AreEqual(16, ranger.Agility);
            Assert.AreEqual(10, ranger.Defense);
            Assert.AreEqual(20, ranger.CriticalChance);
        }

        [TestMethod]
        public void TestRangerAttack()
        {
            Ranger ranger = new("Test Ranger");

            Assert.AreEqual(48, ranger.Attack());
        }

        [TestMethod]

        public void TestRangerSpecialAbility()
        {
            Ranger ranger = new("Test Ranger");
            Assert.AreEqual("Test Ranger wykonuje Precyzyjny Strzał!", ranger.UseSpecialAbility());
        }
    }
}
