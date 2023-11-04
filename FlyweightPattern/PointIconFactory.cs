namespace FlyweightPattern;

public class PointIconFactory
{
    private readonly Dictionary<PointType, PointIcon> _icons = new ();
    public PointIcon GetPointIcon(PointType type)
    {
        if (!_icons.ContainsKey(type))
        {
            var icon = new PointIcon(type,new IconImage());
            _icons.Add(type,icon);
        }

        return _icons[type];
    }
}