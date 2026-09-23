using CharacterSelectTest.Application;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

public sealed class Rogue : Entity.Character
{
    public Rogue(string name) : base(name, CharacterClass.Rogue)
    {
        Health = 95;
        Strength = 9;
        Intelligence = 8;
        Agility = 15;
        Defense = 7;
        CriticalChance = 25;
    }
    public override int MainStat => Agility;

    public override string UseSpecialAbility()
    {
        return $"{Name} wykonuje Zasadzkę!";
    }
}