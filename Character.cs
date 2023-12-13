namespace PPmKristoffer;

public class Character
{
    private string _navn { get; }
    private string _house { get; }
    private List<Item> _inventory { get; set; }
    private int _Money { get; set; }

    public Character(string navn, string house, int money)
    {
        _navn = navn;
        _house = house;
        _inventory = new();
        _Money = money;
    }

    internal string Navn() { return _navn; }
    internal string House() { return _house; }
    internal int Money() { return _Money; }

    internal void Buy(int cost) { _Money -= cost; }

    internal void Add(Item item) { _inventory.Add(item); }
    internal void remove(Item item) { _inventory.Remove(item); }

    internal void Introduction()
    {
        Console.Clear();
        Console.WriteLine($"My name is {_navn}. \n" +
                          $"I'm a magician enrolled at Hogwarts in the house of {_house}");
        CheckInventory();
    }

    internal void CheckInventory()
    {
        Console.WriteLine("My inventory:");
        foreach (Item item in _inventory) Console.WriteLine(item._name);

        Console.WriteLine("\n\ncontinue?");
        Console.ReadKey();
    }
    
}