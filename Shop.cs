using System.Runtime.InteropServices;

namespace PPmKristoffer;

public class Shop
{
    public List<Item> Items;

    public Shop()
    {
        Items = new List<Item>();
    }

    public void ShopMenu(Character myChar)
    {
        Console.Clear();
        Console.WriteLine("Welcome to The Magic Neep");
        Console.WriteLine("Would you like to browse our wares?");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("[x] - Exit shop");
        ListItems();

        var input = Console.ReadLine();
        if (input.ToLower() == "x")
        {
            return;
        }

        var inputNum = Convert.ToInt32(input);
        if (inputNum >= 0 && inputNum <= Items.Count)
        {
            //Valgt en item
            SelectItem(myChar, Items[inputNum]);
        }
    }

    void ListItems()
    {
        int i = 0;
        foreach (Item item in Items)
        {
            Console.WriteLine($"[{i}] - {item._name} (${item._price})");
            i++;
        }
    }

    void SelectItem(Character myChar, Item item)
    {
        Console.Clear();
        Console.WriteLine($"[{item._name} - Price: ${item._price}");
        Console.WriteLine($"Your money: ${myChar.Money()}");
        if (myChar.Money() > item._price)
        {
            Console.WriteLine("Would you like to buy this item? y/n");
            var input = Console.ReadLine();
            if (input == "y")
            {
                myChar.Buy(item._price);
                myChar.Add(item);
            }
            ShopMenu(myChar);
            return;
        }
        else
        {
            Console.WriteLine("Press any button to return to shoplist...");
            Console.ReadKey();
            ShopMenu(myChar);
            return;
        }
    }
}