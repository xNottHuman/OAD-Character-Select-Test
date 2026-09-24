using CharacterSelectTest.Application.Factory;
using CharacterSelectTest.Domain.Character;
using CharacterSelectTest.Domain.Enum;

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
        Mage mage = new("Test mage");

        Assert.IsExactInstanceOfType<Mage>(mage);
        Assert.AreEqual("Test Mage", mage.Name);
    }

    [TestMethod]
    public void TestCreateRogue()
    {
        Rogue rogue = new("Test Rogue");

        Assert.IsExactInstanceOfType<Rogue>(rogue);
        Assert.AreEqual("Test Rogue", rogue.Name);

    }

    [TestMethod]
    public void TestCreateAssassin()
    {
        Assassin assassin = new("Test Assassin");

        Assert.IsExactInstanceOfType<Assassin>(assassin);
        Assert.AreEqual("Test Assassin", assassin.Name);
    }

    [TestMethod]
    public void TestCreatePaladin()
    {
        Paladin paladin = new("Test Paladin");

        Assert.IsExactInstanceOfType<Paladin>(paladin);
        Assert.AreEqual("Test Paladin", paladin.Name);
    }

    [TestMethod]
    public void TestCreateRanger()
    {
        Ranger ranger = new("Test Ranger");

        Assert.IsExactInstanceOfType<Ranger>(ranger);
        Assert.AreEqual("Test Ranger", ranger.Name);
    }

}