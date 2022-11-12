public class Square : Rectangle
{
    public double side = 1.0;
    public Square(){}
    public Square(double side)
    {
        this.side = side;
    }
    public Square(double side, Color color, bool filled) : base( color, filled )
    {
        this.side = side;
    }
    public double GetSide()
    {
        return side;
    }
    public void SetSide(double side)
    {
        this.side = side;
    }
}