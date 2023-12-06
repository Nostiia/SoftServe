using System.Collections.Generic;
using System.Text.RegularExpressions;

abstract class Shape : IComparable<Shape>
{
    private string name;

    public string Name
    {
        get { return name; }
    }
    public abstract double Area();
    public abstract double Perimeter();
    public Shape(string name)
    {
        this.name = name;
    }
    public int CompareTo(Shape other)
    {
        return Area().CompareTo(other.Area());
    }
}
class Circle : Shape
{
    public double radius { get; set; }
    public Circle(string name, double radius) : base(name)
    {
        this.radius = radius;
    }

    public override double Area()
    {
        double area = 3.14 * radius * radius;
        return area;
    }
    public override double Perimeter()
    {
        double perimetr = 2 * 3.14 * radius;
        return perimetr;
    }
}
class Square : Shape
{
    public double side { get; set; }
    public Square(string name, double side) : base(name)
    {
        this.side = side;
    }

    public override double Area()
    {
        double area = side * side;
        return area;
    }
    public override double Perimeter()
    {
        double perimetr = 4 * side;
        return perimetr;
    }
}
class Operator
{
    public static void GetInfo(List<Shape> f)
    {
        foreach (Shape shape in f)
        {
            Console.WriteLine($"{shape.Name}, {shape.Area()}, {shape.Perimeter()}");
        }
    }
    public static void GetLargestPerimeter(List<Shape> f)
    {
        int index = 0;
        for (int i = 1; i < f.Count; i++)
        {
            if (f[i].Perimeter() > f[i - 1].Perimeter())
            {
                index = i;
            }
        }
        Console.WriteLine(f[index].Name);

    }
    public static void Sort(List<Shape> f)
    {
        f.Sort();
        foreach (var shape in f)
        {
            Console.WriteLine(shape.Name);
        }
    }
}
class Program
{
    public static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>
        {
           new Circle("c1", 5.1),
           new Circle("ca2", 0.2),
           new Square("sa1", 1.7),
           new Square("s2", 8.4),
           new Square("s4", 4.3),
           new Square("sa3", 1.1)
        };
        IEnumerable<Shape> area10 = from i in shapes
                                    where i.Area() >= 10 && i.Area() <= 100
                                    select i;
        foreach (var shape in area10)
        {
            Console.WriteLine($"{shape.Name}, {shape.Area()}");
        }
        Regex regex = new Regex("a");

        List<string> matches = new List<string>();
        foreach (var shape in shapes)
        {
            if (regex.IsMatch(shape.Name))
            {
                matches.Add(shape.Name);
            }
        }
        foreach (var i in matches)
        {
            Console.WriteLine(i);
        }
        var result = from per in shapes
                     where per.Perimeter() < 5
                     select new { per.Name };
        foreach (var i in result)
        {
            Console.WriteLine(i.Name);
        }
    }
}