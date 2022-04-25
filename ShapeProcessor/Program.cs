using Application.Factory;
using Application.Validation;
using Domain;
using Infrastructure.Factory;

List<Shape> listOfShapes = new List<Shape>();

//User inputs dimensions as part of creating shapes 

var c1Radius = 14;
var c1 = ShapeFactory.CreateCircle(c1Radius);
listOfShapes.Add(c1);

//equilateral
var t1Side = 5;
var t1 = ShapeFactory.CreateTriangle(t1Side, t1Side, t1Side);
listOfShapes.Add(t1);

//isoceles
var t2Side1 = 5;
var t2Side2 = 5;
var t2Side3 = 9;

var isValidIsoceles = TriangleValidator.IsValidTriangle(t2Side1, t2Side2, t2Side3);
if (!isValidIsoceles) 
{
    throw new ArgumentException();
}

var t2 = ShapeFactory.CreateTriangle(t2Side1, t2Side2, t2Side3);
listOfShapes.Add(t2);

//scalene
var t3Side1 = 5;
var t3Side2 = 8;
var t3Side3 = 11;

var isValidScalene = TriangleValidator.IsValidTriangle(t3Side1, t3Side2, t3Side3);
if (!isValidScalene)
{
    throw new ArgumentException();
}


var t3 = ShapeFactory.CreateTriangle(t3Side1, t3Side2, t3Side3);
listOfShapes.Add(t3);

//rectangle
var q1Length = 1;
var q1Width = 100;
var q1 = ShapeFactory.CreateQuadrilateral(q1Length, q1Width);
listOfShapes.Add(q1);

//square
var q2Length = 5;
var q2Width = 5;
var q2 = ShapeFactory.CreateQuadrilateral(q2Length, q2Width);
listOfShapes.Add(q2);

Console.WriteLine($"DISPLAYING ALL SHAPES CREATED...");
foreach (var shape in listOfShapes)
{
    Console.WriteLine("");
    Console.WriteLine($"Name: {shape.Name}");
    Console.WriteLine($"Perimeter: {shape.Perimeter}");
    Console.WriteLine($"Area: {shape.Area}");
}

Console.WriteLine("\n");
Console.WriteLine($"DISPLAYING ALL SHAPES SORTED BY AREA ASC...");
listOfShapes.Sort();
foreach (var shape in listOfShapes)
{
    Console.WriteLine("");
    Console.WriteLine($"Name: {shape.Name}");
    Console.WriteLine($"Area: {shape.Area}");
}

Console.WriteLine("\n");
Console.WriteLine($"DISPLAYING ALL SHAPES SORTED BY PERIMETER ASC...");
listOfShapes.Sort(new Shape.PerimeterComparer());
foreach (var shape in listOfShapes)
{
    Console.WriteLine("");
    Console.WriteLine($"Name: {shape.Name}");
    Console.WriteLine($"Perimeter: {shape.Perimeter}");
}

//User can select from 3 options: "json" / "xml" / "binary"
var userFileFormatSelection = "json";
var fileExporter = FileExporterFactory.GetFileExporter(userFileFormatSelection);

Console.WriteLine("\n");
Console.WriteLine($"Saving created shapes to disk in {userFileFormatSelection.ToUpper()} format");
foreach (var shape in listOfShapes)
{
    fileExporter.Save(shape);
}

Console.WriteLine("\n");
Console.WriteLine("Instance Count:");
Console.WriteLine("");
Console.WriteLine($"Number of Circles created: {Circle.InstanceCounter}");
Console.WriteLine($"Number of Triangles created: {Triangle.InstanceCounter}");
Console.WriteLine($"Number of Quadrilaterals created: {Quadrilateral.InstanceCounter}");


Console.ReadLine();
