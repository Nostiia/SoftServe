class Cat
{
    enum Food { fish = 1, mouse, person, sausage, feed }
    public static void Main()
    {
        int fullness=0;
        Food fd = new Food();
        Console.WriteLine($"Cat`s stomach full on {fullness*10}% Do you want to feed your Cat? Y -yes, N - no");
        char answer = char.Parse(Console.ReadLine());
        if ( answer =='Y'||  answer == 'y')
        {
            eatSomething(ref fullness,ref fd);
        }
        else
        {
            Console.WriteLine("Have a nice day");
        }
    }
    static int extra(ref int fullness, ref Food fd)
    {
        Console.WriteLine($"More? Stomach full on {fullness*10}%");
        char answer = char.Parse(Console.ReadLine());
        if( answer == 'y'|| answer == 'Y')
        {
            
            eatSomething(ref fullness, ref fd);
            
        }
        else
        {
            return fullness;
        }

        return fullness;
    }
  
    static int eatSomething(ref int fullness, ref Food fd)
    {
        if (fullness >= 17)
        {
            Console.WriteLine("Too much");
            return 0;
        }
        else
        {
            Console.WriteLine("What?");
            int kind = int.Parse(Console.ReadLine());
            fd = (Food)kind;
            switch (fd)
                {
                    case Food.fish:
                        fullness += 3;
                        break;
                    case Food.mouse:
                        fullness += 7;
                        break;
                    case Food.person:
                        fullness += 10;
                        break;
                    case Food.sausage:
                        fullness += 5;
                        break;
                    case Food.feed:
                        fullness += 4;
                        break;
                }
            extra(ref fullness, ref fd);

        }
        return fullness;
    }
}