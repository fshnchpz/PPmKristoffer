namespace PPmKristoffer
{
    public class Program
    {
        static List<Spell> spells = new List<Spell>
        {
            new Spell("vingardium leviosa", "You lift the boulder infront of you with magic", "vingardium leviosa"),
        };
        static Shop magicNeep = new();
        public static void Main()
        {
            magicNeep.Items = fillShop();

            Character harry = new("Harry", "slytherin", 100);
            harry.Introduction();



            bool playing = true;
            while (playing)
            {
                Console.Clear();
                Console.WriteLine("I would like to:\n" +
                                   "[1] - go shopping\n" +
                                   "[2] - practise casting spells\n" +
                                   "[3] - look at my stuff\n" +
                                   "[4] - go to sleep");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        magicNeep.ShopMenu(harry);
                        break;
                    case "2":
                        PracticeCasting();
                        break;
                    case "3":
                        harry.CheckInventory();

                        break;
                        case "4":
                        playing = false;
                        break;
                    default:
                        Console.WriteLine(@"¯\_(ツ)_/¯");
                        break;
                }
            }
        }

        static List<Item> fillShop()
        {
            List<Item> list = new List<Item>
            {
                new Item("bad wand", 10),
                new Item("Ok Wand", 20),
                new Item("good wand", 30),
                new Item("very good wand", 50),
                new Item("Owl",60),
                new Item("Rat",20),
                new Item("white cat",35),
                new Item("black cat",40),
                new Item("something special", 70),
            };
            return list;
        }

        static void PracticeCasting()
        {
            Console.Clear();
            Console.WriteLine("Type in your invocation for your spells");
            Console.WriteLine("or 'x' to exit");
            var input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                if (input == "x")
                {
                    return;
                }
                CastSpell(input);
            }
            else
            {
                PracticeCasting();
            }
        }

        static void CastSpell(string input)
        {
            if (spells.Exists(objectIterasjon => objectIterasjon.Invocation == input))
            {
                Spell spell = spells.Find(spell => spell.Invocation == input);
                spell.CastSpell();
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"you tried to cast {input}.\n");
                Thread.Sleep(300);
                Console.WriteLine("Nothing happened");
                Thread.Sleep(1000);

            }
        }
    }
}



//Harry Potter
//Du skal starte med å lage en character klasse med egenskaper som navn, house, inventory (ex wand eller pet)

//Få applikasjonen til å printe ut en introduksjon for karakteren, som sier noe om hva de heter, hvilket hus de er medlem av og hvilke items de har

//Karakteren skal ha mulighet til å gå inn i en Magibutikk, der kan de kjøpe et dyr:  ugle, rotte eller en katt. De har også mulighet til å kjøpe en tryllestav.
//For å få til dette må du lage en egen klasse som er butikken, og presentere brukeren med en meny for hva personen skal kjøpe.

//Karakteren skal ha mulighet til å trylle - ta inn input fra brukeren, og dersom en skriver en riktig trylleformel skal det printes til skjermen at de har utført tryllingen
//trylleformler: 
//vingardium leviosa(får en fjær til å fly)
//hokus pokus(fyrer av fyrverkerier)
/* (item => item.name == "Rotte")
 * Klasser: Character, Shop, Spell, Item
 * 
 * 
 * Character: navn, house, inventory, Money
 * 
 * Shop: inventory
 *
 * Item: Name, Price
 *
 * Spell: Name, Invocation, Description
 * 
 * 
 **/