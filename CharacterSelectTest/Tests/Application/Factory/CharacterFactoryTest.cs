using CharacterSelectTest.Application.Factory;
using CharacterSelectTest.Domain.Character;
using CharacterSelectTest.Domain.Enum;
using System.Threading;

namespace CharacterSelectTest.Tests.Application.Factory;

[TestClass]
public class CharacterFactoryTest
{
    [TestMethod]
    public void TestCreateWarrior()
    {
        Warrior warrior = new("Test Warrior");

        Assert.AreEqual("Test Warrior", warrior.Name);
        Assert.AreEqual(CharacterClass.Warrior, warrior.Class);
    }

    [TestMethod]
    public void TestCreateMage()
    {
        Mage mage = new("Test Mage");

        Assert.AreEqual("Test Mage", mage.Name);
        Assert.AreEqual(CharacterClass.Mage, mage.Class);
    }

    [TestMethod]
    public void TestCreateRogue()
    {
        Rogue rogue = new("Test Rogue");

        Assert.AreEqual("Test Rogue", rogue.Name);
        Assert.AreEqual(CharacterClass.Rogue, rogue.Class);

    }

    [TestMethod]
    public void TestCreateAssassin()
    {
        Assassin assassin = new("Test Assassin");

        Assert.AreEqual("Test Assassin", assassin.Name);
        Assert.AreEqual(CharacterClass.Assassin, assassin.Class);
    }

    [TestMethod]
    public void TestCreatePaladin()
    {
        Paladin paladin = new("Test Paladin");

        Assert.AreEqual("Test Paladin", paladin.Name);
        Assert.AreEqual(CharacterClass.Paladin, paladin.Class);
    }

    [TestMethod]
    public void TestCreateRanger()
    {
        Ranger ranger = new("Test Ranger");

        Assert.AreEqual("Test Ranger", ranger.Name);
        Assert.AreEqual(CharacterClass.Ranger, ranger.Class);
    }

}