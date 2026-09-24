using CharacterSelectTest.Application.Factory;
using CharacterSelectTest.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSelectTest.Tests.Domain.Character
{
    [TestClass]
    public class MageTest
    {
        [TestMethod]
        public void TestMageAttack()
        {
            var character = CharacterFactory.Create(
                CharacterClass.Mage,
                "Test Mage");

            Assert.AreEqual(48, character.Attack());
        }

        [TestMethod]

        public void TestMageSpecialAbility()
        {
            var character = CharacterFactory.Create(
                CharacterClass.Mage,
                "Test Mage");
            Assert.AreEqual("Test Mage rzuca Kule Ognia!", character.UseSpecialAbility());
        }
    }
}
