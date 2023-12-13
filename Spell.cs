namespace PPmKristoffer;

public class Spell
{
    string Name { get; set; }
    string Description { get; set; }
    public string Invocation { get; set; }

    public Spell(string name, string description, string invocation)
    {
        Name = name;
        Description = description;
        Invocation = invocation;
    }

    public void CastSpell()
    {
        Console.WriteLine($"You cast: '{Name}'");
        Console.WriteLine($"Effect: '{Description}'");
        Thread.Sleep(1500);
    }
}