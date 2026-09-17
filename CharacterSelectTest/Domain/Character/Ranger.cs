using CharacterSelectTest.Application;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

public sealed class Ranger : Entity.Character
{
    public Ranger(string name) : base(name, CharacterClass.Ranger)
    {
        Health = 100;
        Strength = 11;
        Intelligence = 9;
        Agility = 16;
        Defense = 10;
        CriticalChance = 20;
    }
}