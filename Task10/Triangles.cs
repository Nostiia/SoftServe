using System;
using static System.Math;
using System.Collections.Generic;

public struct Point
{
    public int x { get; set; }
    public int y { get; set; }
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public override string ToString()
    {
        return $"({x},{y})";
    }
    public double DistanceTo(Point a, Point b)
    {
        double dist = Math.Sqrt(Math.Pow((a.x - b.x), 2) + Math.Pow((a.y - b.y), 2));
        return dist;
    }
    public double DistanceToOrigin()
    {
        double dist = Math.Sqrt(x*x + y*y);
        return dist;
    }
}
class Triangle
{
    public Point vertex1 { get; set; }
    public Point vertex2 { get; set; }
    public Point vertex3 { get; set; }
    public Triangle(Point vertex1, Point vertex2, Point vertex3)
    {
        this.vertex1 = vertex1;
        this.vertex2 = vertex2;
        this.vertex3 = vertex3;
    }
    public static double Perimeter(Point a, Point b, Point c)
    {
        double dist1 = a.DistanceTo(a,b);
        double dist2 = b.DistanceTo(b,c);
        double dist3 = c.DistanceTo(c,a);
        return dist1 + dist2 + dist3;
    }
    public static double Area(Point a, Point b, Point c)
    {
        double p = Perimeter(a, b, c) / 2;
        double area = Math.Sqrt(p * (p- a.DistanceTo(a, b)) * (p- b.DistanceTo(b, c)) * (p - c.DistanceTo(c, a)));
        return area;
    }
    public void Print()
    {
        Console.WriteLine("Triangle vertices: {0}, {1}, {2}\r\nPerimeter: {3}\r\nArea: {4}",
            vertex1.ToString(), vertex2.ToString(), vertex3.ToString(), 
            Triangle.Perimeter(vertex1, vertex2, vertex3), Triangle.Area(vertex1, vertex2, vertex3));
    }
    public static double ClosestVertexToOrigin(Triangle tr1)
    {
        double closest = tr1.vertex1.DistanceToOrigin();
        if (tr1.vertex2.DistanceToOrigin() < closest)
        {
            closest = tr1.vertex2.DistanceToOrigin();
        }
        else if (tr1.vertex3.DistanceToOrigin() < closest)
        {
            closest = tr1.vertex3.DistanceToOrigin();
        }
        return closest;
    }
}
class ShapeProblem
{
    public static void Main()
    {
        List<Triangle> triangles = new List<Triangle>()
        {
            new Triangle (new Point(0,0), new Point (1,0), new Point (0,1)),
            new Triangle (new Point(0,0), new Point (2,0), new Point (1,2)),
            new Triangle (new Point(1,1), new Point (4,1), new Point (1,3))

        };
        /*for (int i = 0; i < 3; i++)
        {
            List<Point> points = new List<Point>();
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("Give points: ");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Point point = new Point(a, b);
                points.Add(point);
            }
            Triangle triangle = new Triangle(points[0], points[1], points[2]);
            triangles.Add(triangle);
            triangle.Print();
        }*/
        foreach (Triangle tr in triangles)
        {
            tr.Print();
        }
        Triangle withClosest = triangles[0];
        for (int i = 1;i < triangles.Count;i++)
        {
            if (Triangle.ClosestVertexToOrigin(triangles[i]) < Triangle.ClosestVertexToOrigin(withClosest))
            {
                withClosest = triangles[i];
            }
        }
        Console.WriteLine("\nTriangle with a vertex closest to the origin:");
        withClosest.Print();
    }
}