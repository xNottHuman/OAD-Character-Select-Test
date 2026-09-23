using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Entity;

public abstract class Character
{
    public string Name { get; set; }
    public CharacterClass Class { get; }
    public int Health { get; protected set; }
    public int Strength { get; protected set; }
    public int Intelligence { get; protected set; }
    public int Agility { get; protected set; }
    public int Defense { get; protected set; }
    public int CriticalChance { get; protected set; }

    protected Character(string name, CharacterClass @class)
    {
        Name = string.IsNullOrWhiteSpace(name) ? @class.ToString() : name.Trim();
        Class = @class;
    }

    public abstract int MainStat { get; }

    public virtual int Attack()
    {
        return MainStat * 3;
    }

    public abstract string UseSpecialAbility();

    public virtual void Describe()
    {
        Console.WriteLine($"[{Class}] {Name}");
        Console.WriteLine($"  HP: {Health}");
        Console.WriteLine($"  STR: {Strength}  INT: {Intelligence}  AGI: {Agility}");
        Console.WriteLine($"  DEF: {Defense}   CRIT: {CriticalChance}");
    }
}