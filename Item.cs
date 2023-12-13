namespace PPmKristoffer;

public class Item
{
    public string _name { get; set; }
    public int _price { get; set; }

    public Item(string name, int price)
    {
        _name = name;
        _price = price;
    }
}