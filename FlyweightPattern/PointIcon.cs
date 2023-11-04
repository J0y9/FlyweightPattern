namespace FlyweightPattern;

public class PointIcon
{
    public PointType Type { get;}
    public IconImage IconImage { get; }
    
    public PointIcon(PointType type, IconImage iconImage)
    {
        Type = type;
        IconImage = iconImage;
    }

}