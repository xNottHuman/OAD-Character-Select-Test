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
    public class AssassinTest
    {
        [TestMethod]
        public void TestAssassinAttack()
        {
            var character = CharacterFactory.Create(
                CharacterClass.Assassin,
                "Test Assassin");

            Assert.AreEqual(51, character.Attack());
        }

        [TestMethod]

        public void TestAssassinSpecialAbility()
        {
            var character = CharacterFactory.Create(
                CharacterClass.Assassin,
                "Test Assassin");
            Assert.AreEqual("Test Assassin wykonuje Cichy Cios!", character.UseSpecialAbility());
        }
    }
}
