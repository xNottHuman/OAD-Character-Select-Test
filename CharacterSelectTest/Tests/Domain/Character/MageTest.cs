using CharacterSelectTest.Application.Factory;
using CharacterSelectTest.Domain.Character;
using CharacterSelectTest.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CharacterSelectTest.Tests.Domain.Character
{
    [TestClass]
    public class MageTest
    {
        [TestMethod]
        public void TestMageStats()
        {
            Mage mage = new("Test Mage");

            Assert.AreEqual(80, mage.Health);
            Assert.AreEqual(4, mage.Strength);
            Assert.AreEqual(16, mage.Intelligence);
            Assert.AreEqual(10, mage.Agility);
            Assert.AreEqual(5, mage.Defense);
            Assert.AreEqual(15, mage.CriticalChance);
        }

        [TestMethod]
        public void TestMageAttack()
        {
            Mage mage = new("Test Mage");

            Assert.AreEqual(48, mage.Attack());
        }

        [TestMethod]

        public void TestMageSpecialAbility()
        {
            Mage mage = new("Test Mage");

            Assert.AreEqual("Test Mage rzuca Kule Ognia!", mage.UseSpecialAbility());
        }
    }
}
