public enum Color
    {
        Red,
        Green,
        Yellow
    }
public abstract class Shape
{
    protected Color color;
    protected bool filled = true;
    public Shape(){}
    public Shape(Color color, bool filled)
    {
        this.color = color;
        this.filled = filled;
    }
    public Color GetColor()
    {
        return color;
    }
    public void SetColor(Color color)
    {
        this.color = color;
    }
    public abstract double GetArea();
    public abstract double GetPerimeter();
    public override string? ToString()
    {
        return base.ToString();
    }
}

