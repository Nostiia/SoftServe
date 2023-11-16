class Drinks
{
    enum drinks { coffee = 25, tea = 15, juice = 21, water = 8 }
    public static void Main()
    {
        drinks want;
        int price = 0;
        want = drinks.coffee;
        price = (int)want;
        string str = Console.ReadLine();

       
        switch (str)
        {
            case "coffee":
                want = drinks.coffee;
                price = (int)want;
                break;
            case "tea":
                want = drinks.tea;
                price = (int)want;
                break;
            case "juice":
                want = drinks.juice;
                price = (int)want;
                break;
            case "water":
                want = drinks.water;
                price = (int)want;
                break;
        }
        Console.WriteLine(price);
    }
}