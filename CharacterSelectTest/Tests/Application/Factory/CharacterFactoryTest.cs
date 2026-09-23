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
        var character = CharacterFactory.Create(
            CharacterClass.Warrior,
            "Test Warrior");

        Assert.IsExactInstanceOfType<Warrior>(character);
        Assert.AreEqual("Test Warrior", character.Name);

        Assert.AreEqual(120, character.Health);
        Assert.AreEqual(14, character.Strength);
        Assert.AreEqual(6, character.Intelligence);
        Assert.AreEqual(8, character.Agility);
        Assert.AreEqual(18, character.Defense);
        Assert.AreEqual(5, character.CriticalChance);
    }

    [TestMethod]
    public void TestCreateMage()
    {
        var character = CharacterFactory.Create(
            CharacterClass.Mage,
            "Test Mage");

        Assert.IsExactInstanceOfType<Mage>(character);
        Assert.AreEqual("Test Mage", character.Name);

        Assert.AreEqual(80, character.Health);
        Assert.AreEqual(4, character.Strength);
        Assert.AreEqual(16, character.Intelligence);
        Assert.AreEqual(10, character.Agility);
        Assert.AreEqual(5, character.Defense);
        Assert.AreEqual(15, character.CriticalChance);
    }

    [TestMethod]
    public void TestCreateRogue()
    {
        var character = CharacterFactory.Create(
            CharacterClass.Rogue,
            "Test Rogue");

        Assert.IsExactInstanceOfType<Rogue>(character);
        Assert.AreEqual("Test Rogue", character.Name);

        Assert.AreEqual(95, character.Health);
        Assert.AreEqual(9, character.Strength);
        Assert.AreEqual(8, character.Intelligence);
        Assert.AreEqual(15, character.Agility);
        Assert.AreEqual(7, character.Defense);
        Assert.AreEqual(25, character.CriticalChance);
    }

    [TestMethod]
    public void TestCreateAssassin()
    {
        var character = CharacterFactory.Create(
            CharacterClass.Assassin,
            "Test Assassin");

        Assert.IsExactInstanceOfType<Assassin>(character);
        Assert.AreEqual("Test Assassin", character.Name);

        Assert.AreEqual(70, character.Health);
        Assert.AreEqual(12, character.Strength);
        Assert.AreEqual(12, character.Intelligence);
        Assert.AreEqual(17, character.Agility);
        Assert.AreEqual(6, character.Defense);
        Assert.AreEqual(30, character.CriticalChance);
    }

    [TestMethod]
    public void TestCreatePaladin()
    {
        var character = CharacterFactory.Create(
            CharacterClass.Paladin,
            "Test Paladin");

        Assert.IsExactInstanceOfType<Paladin>(character);
        Assert.AreEqual("Test Paladin", character.Name);

        Assert.AreEqual(110, character.Health);
        Assert.AreEqual(12, character.Strength);
        Assert.AreEqual(10, character.Intelligence);
        Assert.AreEqual(6, character.Agility);
        Assert.AreEqual(20, character.Defense);
        Assert.AreEqual(5, character.CriticalChance);
    }

    [TestMethod]
    public void TestCreateRanger()
    {
        var character = CharacterFactory.Create(
            CharacterClass.Ranger,
            "Test Ranger");

        Assert.IsExactInstanceOfType<Ranger>(character);
        Assert.AreEqual("Test Ranger", character.Name);

        Assert.AreEqual(100, character.Health);
        Assert.AreEqual(11, character.Strength);
        Assert.AreEqual(9, character.Intelligence);
        Assert.AreEqual(16, character.Agility);
        Assert.AreEqual(10, character.Defense);
        Assert.AreEqual(20, character.CriticalChance);
    }

    [TestMethod]
    public void TestWarriorAttack()
    {
        var character = CharacterFactory.Create(
            CharacterClass.Warrior,
            "Test Warrior");

        Assert.AreEqual(42, character.Attack());
    }

    [TestMethod]
    public void TestMageAttack()
    {
        var character = CharacterFactory.Create(
            CharacterClass.Mage,
            "Test Mage");

        Assert.AreEqual(48, character.Attack());
    }

    [TestMethod]
    public void TestRogueAttack()
    {
        var character = CharacterFactory.Create(
            CharacterClass.Rogue,
            "Test Rogue");

        Assert.AreEqual(45, character.Attack());
    }

    [TestMethod]
    public void TestAssassinAttack()
    {
        var character = CharacterFactory.Create(
            CharacterClass.Assassin,
            "Test Assassin");

        Assert.AreEqual(51, character.Attack());
    }

    [TestMethod]
    public void TestPaladinAttack()
    {
        var character = CharacterFactory.Create(
            CharacterClass.Paladin,
            "Test Paladin");

        Assert.AreEqual(36, character.Attack());
    }

    [TestMethod]
    public void TestRangerAttack()
    {
        var character = CharacterFactory.Create(
            CharacterClass.Ranger,
            "Test Ranger");

        Assert.AreEqual(48, character.Attack());
    }
}