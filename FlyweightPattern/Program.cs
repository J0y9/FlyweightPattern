// See https://aka.ms/new-console-template for more information

using FlyweightPattern;

var points = new List<Point>();
var pointIconFactory = new PointIconFactory();

var point1 = new Point(1,2,pointIconFactory.GetPointIcon(PointType.Hospital));
var point2 = new Point(12,23,pointIconFactory.GetPointIcon(PointType.Hospital));

points.Add(point1);
points.Add(point2);
