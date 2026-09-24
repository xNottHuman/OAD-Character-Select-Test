using CharacterSelectTest.Application;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

public sealed class Paladin : Entity.Character
{
    public Paladin(string name) : base(name, CharacterClass.Paladin)
    {
        Health = 110;
        Strength = 12;
        Intelligence = 10;
        Agility = 6;
        Defense = 20;
        CriticalChance = 5;
    }
    public override int MainStat => Strength;

    public override string UseSpecialAbility()
    {
        return $"{Name} używa Świętej Tarczy!";
    }
}