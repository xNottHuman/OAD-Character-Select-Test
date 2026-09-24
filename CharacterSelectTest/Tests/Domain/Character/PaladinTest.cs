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
    public class PaladinTest
    {
        [TestMethod]
        public void TestPaladinAttack()
        {
            var character = CharacterFactory.Create(
                CharacterClass.Paladin,
                "Test Paladin");

            Assert.AreEqual(36, character.Attack());
        }

        [TestMethod]

        public void TestPaladinSpecialAbility()
        {
            var character = CharacterFactory.Create(
                CharacterClass.Paladin,
                "Test Paladin");
            Assert.AreEqual("Test Paladin używa Świętej Tarczy!", character.UseSpecialAbility());
        }
    }
}
