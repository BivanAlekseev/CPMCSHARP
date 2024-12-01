using System;
using System.Collections.Generic;

class Figure
{
    public int Layer { get; set; }
    public string EdgeColor { get; set; }
    public double EdgeThickness { get; set; }
    public string FillColor { get; set; }

    public Figure(int layer = 0, string edgeColor = "black", double edgeThickness = 1.0, string fillColor = "white")
    {
        Layer = layer;
        EdgeColor = edgeColor;
        EdgeThickness = edgeThickness;
        FillColor = fillColor;
    }

    public override string ToString()
    {
        return $"Figure(Layer={Layer}, EdgeColor={EdgeColor}, EdgeThickness={EdgeThickness}, FillColor={FillColor})";
    }
}

class Point
{
    public double XPosition { get; set; }
    public double YPosition { get; set; }

    public Point(double xPosition = 0.0, double yPosition = 0.0)
    {
        XPosition = xPosition;
        YPosition = yPosition;
    }

    public override string ToString()
    {
        return $"Point(XPosition={XPosition}, YPosition={YPosition})";
    }
}

sealed class Circle : Figure
{
    public double Radius { get; set; }
    public Point Center { get; set; }

    public Circle(int layer = 0, string edgeColor = "black", double edgeThickness = 1.0, string fillColor = "white", double radius = 1.0, Point center = null)
        : base(layer, edgeColor, edgeThickness, fillColor)
    {
        Radius = radius;
        Center = center ?? new Point();
    }

    public override string ToString()
    {
        return $"Circle(Layer={Layer}, EdgeColor={EdgeColor}, EdgeThickness={EdgeThickness}, FillColor={FillColor}, Radius={Radius}, Center={Center})";
    }
}

sealed class Edge : Figure
{
    public Point FirstPoint { get; set; }
    public Point SecondPoint { get; set; }

    private string _fillColor = "black";
    public string FillColor => _fillColor;

    public Edge(int layer = 0, string edgeColor = "black", double edgeThickness = 1.0, Point firstPoint = null, Point secondPoint = null)
        : base(layer, edgeColor, edgeThickness)
    {
        FirstPoint = firstPoint ?? new Point();
        SecondPoint = secondPoint ?? new Point();
    }

    public override string ToString()
    {
        return $"Edge(Layer={Layer}, EdgeColor={EdgeColor}, EdgeThickness={EdgeThickness}, FillColor={FillColor}, FirstPoint={FirstPoint}, SecondPoint={SecondPoint})";
    }

    public static void ShowVerticalEdges(List<Edge> edges)
    {
        foreach (var edge in edges)
        {
            if (edge.FirstPoint.XPosition == edge.SecondPoint.XPosition)
            {
                Console.WriteLine($"{edge.FirstPoint.XPosition} {edge.FirstPoint.YPosition} {edge.SecondPoint.XPosition} {edge.SecondPoint.YPosition}");
            }
        }
    }
}

class Polygon : Figure
{
    public List<Point> Points { get; set; }

    public Polygon(int layer = 0, string edgeColor = "black", double edgeThickness = 1.0, string fillColor = "white", List<Point> points = null)
        : base(layer, edgeColor, edgeThickness, fillColor)
    {
        Points = points ?? new List<Point>();
    }

    public override string ToString()
    {
        return $"Polygon(Layer={Layer}, EdgeColor={EdgeColor}, EdgeThickness={EdgeThickness}, FillColor={FillColor}, Points=[{string.Join(", ", Points)}])";
    }
}

class Program
{
    static void Main(string[] args)
    {
        var figure = new Figure(layer: 2, edgeColor: "blue", edgeThickness: 2.5, fillColor: "red");
        Console.WriteLine(figure);

        var point1 = new Point(1.0, 2.0);
        var point2 = new Point(3.0, 4.0);
        var point3 = new Point(1.0, 5.0);

        var circle = new Circle(layer: 1, edgeColor: "green", edgeThickness: 1.5, radius: 5.0, center: point1);
        Console.WriteLine(circle);

        var edge1 = new Edge(layer: 3, edgeColor: "yellow", edgeThickness: 0.5, firstPoint: point1, secondPoint: point3);
        var edge2 = new Edge(layer: 4, edgeColor: "blue", edgeThickness: 0.7, firstPoint: point2, secondPoint: point3);

        var edges = new List<Edge> { edge1, edge2 };
        Edge.ShowVerticalEdges(edges);

        var polygon = new Polygon(layer: 2, edgeColor: "purple", edgeThickness: 1.0, points: new List<Point> { point1, point2, point3 });
        Console.WriteLine(polygon);
    }
}
