using System.Linq;
class Item
{
    public String? name;
    public List<Item>? itemsInside;
}

internal class Program
{
    private static void Main(string[] args)
    {
        var inventory = new List<Item>() {
            new Item() {
                name = "Backbag",
                itemsInside = new List<Item>() 
                {
                    new Item()
                    {
                        name = "Wallet",
                        itemsInside = new List<Item>() {
                            new Item() { name = "Money" },
                            new Item() { name = "Credit card" },
                            new Item() { name = "Driving license" }
                        }
                    },
                    new Item() 
                    {
                        name = "Pouch",
                        itemsInside = new List<Item>() {
                            new Item() { name = "Watch" },
                            new Item() { name = "Candy" }
                        }
                    },
                    new Item() { name = "T-shirt" },
                    new Item() { name = "Jeans" },
                    new Item() { name = "Jacket" }
                }
            },

            new Item() {
                name = "Pockets",
                itemsInside = new List<Item>() 
                {
                    new Item() { name = "Coins" },
                    new Item() { name = "Keys" },
                }
            },

        };

        myRecurision(inventory);

        void myRecurision(List<Item> thisInventory, String myString = "")
        {
            foreach (var item in thisInventory)
            {
                Console.WriteLine($"{myString}{item.name}");
                if (item.itemsInside != null)
                {
                    myRecurision(item.itemsInside, $"{myString}{item.name}->");
                };
            }
            
        }



        /*
        Write a function that outputs all the contents of the "inventory" in the following format:
        Backbag
        Backbag->Wallet
        Backbag->Wallet->Money
        Backbag->Wallet->Credit card
        Backbag->Wallet->Driving license
        Backbag->Pouch
        Backbag->Pouch->Watch
        Backbag->Pouch->Candy
        Backbag->T-shirt
        Backbag->Jeans
        Backbag->Jacket
        Pockets
        Pockets->Coins
        Pockets->Keys
        */
    }
}
