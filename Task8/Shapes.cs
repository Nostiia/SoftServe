using System.Collections.Generic;
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
class Circle: Shape
{
    public double radius { get; set; }
    public Circle(string name, double radius) : base (name)
    {
        this .radius = radius;
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
        int index =0;
        for (int i = 1; i<f.Count;i++)
        {
            if (f[i].Perimeter() > f[i-1].Perimeter())
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