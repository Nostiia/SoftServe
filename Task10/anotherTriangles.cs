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
    public double DistanceTo(Point otherPoint)
    {
        int deltaX = x - otherPoint.x;
        int deltaY = y - otherPoint.y;
        return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
    }
    public double DistanceToOrigin()
    {
        double dist = Math.Sqrt(x * x + y * y);
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
    public double Perimeter()
    {
        double dist1 = vertex1.DistanceTo(vertex2);
        double dist2 = vertex2.DistanceTo(vertex3);
        double dist3 = vertex3.DistanceTo(vertex1);
        return dist1 + dist2 + dist3;
    }
    public double Area()
    {
        double p = Perimeter() / 2;
        double area = Math.Sqrt(p * (p - vertex1.DistanceTo(vertex2)) * (p - vertex2.DistanceTo(vertex3)) * (p - vertex3.DistanceTo(vertex1)));
        return area;
    }
    public void Print()
    {
        Console.WriteLine("Triangle vertices: {0}, {1}, {2}\r\nPerimeter: {3}\r\nArea: {4}",
            vertex1.ToString(), vertex2.ToString(), vertex3.ToString(),
            Perimeter(), Area());
    }
    public Point ClosestVertexToOrigin()
    {
        Point closest = vertex1;
        if (vertex2.DistanceToOrigin() < closest.DistanceToOrigin())
        {
            closest = vertex2;
        }
        else if (vertex3.DistanceToOrigin() < closest.DistanceToOrigin())
        {
            closest = vertex3;
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
        foreach (Triangle tr in triangles)
        {
            tr.Print();
        }
        double minDistance = double.MaxValue;
        Triangle closestTriangle = null;
        foreach (var triangle in triangles)
        {
            Point closestVertex = triangle.ClosestVertexToOrigin();
            double distance = closestVertex.DistanceToOrigin();

            if (distance < minDistance)
            {
                minDistance = distance;
                closestTriangle = triangle;
            }
        }
        Console.WriteLine("\nTriangle with a vertex closest to the origin:");
        closestTriangle.Print();
    }
}