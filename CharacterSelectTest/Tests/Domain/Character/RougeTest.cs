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
    public class RougeTest
    {
        [TestMethod]
        public void TestRogueAttack()
        {
            var character = CharacterFactory.Create(
                CharacterClass.Rogue,
                "Test Rogue");

            Assert.AreEqual(45, character.Attack());
        }

        [TestMethod]
        public void TestRogueSpecialAbility()
        {
            var character = CharacterFactory.Create(
                CharacterClass.Rogue,
                "Test Rogue");
            Assert.AreEqual("Test Rogue wykonuje Zasadzkę!", character.UseSpecialAbility());
        }
    }
}
