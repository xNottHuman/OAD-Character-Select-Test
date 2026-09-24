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
    public class RangerTest
    {
        [TestMethod]
        public void TestRangerAttack()
        {
            var character = CharacterFactory.Create(
                CharacterClass.Ranger,
                "Test Ranger");

            Assert.AreEqual(48, character.Attack());
        }

        [TestMethod]

        public void TestRangerSpecialAbility()
        {
            var character = CharacterFactory.Create(
                CharacterClass.Ranger,
                "Test Ranger");
            Assert.AreEqual("Test Ranger wykonuje Precyzyjny Strzał!", character.UseSpecialAbility());
        }
    }
}
