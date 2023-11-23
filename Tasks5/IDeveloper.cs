using System.Collections;

public interface IDeveloper
{
    string Tool { get; set; }
    void Create();
    void Destroy();

}
class Programmer : IDeveloper, IComparable
{
    private string language;
    public string Tool { get { return language; } set {language = value; } }
    public Programmer( string tool)
    {
        Tool = tool;
    }
    public int CompareTo (object o)
    {
        Programmer p = o as Programmer;
        Builder b = o as Builder;
        if (p != null)
            return this.Tool.CompareTo(p.Tool);
        else if (b != null)
            return this.Tool.CompareTo(b.Tool);
        else
            throw new ArgumentException("Object is not a developer");
    }

    public void Create()
    {
        Console.WriteLine("Programmer created");
    }
    public void Destroy() 
    {
        Console.WriteLine("Programmer destroyed");
    }

}

class Builder : IDeveloper, IComparable
{
    private string tool;
    public string Tool { get { return tool; } set {tool = value; } }
    public Builder(string tool)
    {
        this.tool = tool;
    }
    public int CompareTo(object o)
    {
        Programmer p = o as Programmer;
        Builder b = o as Builder;
        if (p != null)
            return this.Tool.CompareTo(p.Tool);
        else if (b != null)
            return this.Tool.CompareTo(b.Tool);
        else
            throw new ArgumentException("Object is not a developer");
    }

    public void Create()
    {
        Console.WriteLine("Builder created");
        }
    public void Destroy()
    {
        Console.WriteLine("Builder destroyed");
    }

}
public static class TeamWork
{
    public static void SortTeamMembers(ArrayList teamMembers)
    {
        IComparer comparer = Comparer.DefaultInvariant;
        teamMembers.Sort(comparer);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Builder builder = new Builder("Hammer");
        ArrayList developers = new ArrayList
        {
            builder,
            new Builder("Hammer"),
            new Programmer("Visual Studio"),
            new Builder("Screwdriver"),
            new Programmer("Eclipse"),
            new Builder("Hammer"),
            new Programmer("Visual Studio")
        };
        TeamWork.SortTeamMembers(developers);
        foreach (IDeveloper employee in developers)
        {
            employee.Create();
            employee.Destroy();
            Console.WriteLine();
        }
    }
}