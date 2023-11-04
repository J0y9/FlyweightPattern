namespace FlyweightPattern;

public class Point
{
    private int Longitude { get; set; }
    private int Latitude { get; set; }
    // private PointType Type { get; set; }
    // private Icon Icon { get; set; }
    private PointIcon Icon { get; set; }
    
    public Point(int longitude, int latitude, PointIcon icon)
    {
        Longitude = longitude;
        Latitude = latitude;
        Icon = icon;
    }

    public void Draw()
    {
        Console.WriteLine($"{Icon.Type} at ({Longitude}, {Latitude})");
    }
}