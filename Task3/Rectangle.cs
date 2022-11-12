public class Rectangle : Shape
{
    public double width=1.0;
    public double length=1.0;
    public Rectangle(){}
    public Rectangle(double width, double length)
    {
        this.width=width;
        this.length=length;
    }
    public Rectangle(double width, double length, Color color, bool filled) : base( color, filled )
    {
        this.width=width;
        this.length=length;
    }
    public double GetWidth()
    {
        return width;
    }
    public void SetWidth(double width)
    {
        this.width=width;
    }
    public double GetLength()
    {
        return length;
    }
    public void SetLength(double length)
    {
        this.length=length;
    }
    public override double GetArea()
    {
        return width * length;
    }
    public override double GetPerimeter()
    {
        return 2 * (length + width);
    }
    public override string ToString()
    {
        return $"Color: {color} Filled: {filled} Width: {width} Length: {length}";
    }
}