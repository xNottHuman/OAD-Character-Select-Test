using CharacterSelectTest.Application;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

public sealed class Assassin : Entity.Character
{
    public Assassin(string name) : base(name, CharacterClass.Assassin)
    {
        Health = 70;
        Strength = 12;
        Intelligence = 12;
        Agility = 17;
        Defense = 6;
        CriticalChance = 30;
    }
    public override int MainStat => Agility;

    public override string UseSpecialAbility()
    {
        return $"{Name} wykonuje Cichy Cios!";
    }

}