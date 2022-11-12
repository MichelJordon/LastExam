public class Circle 
{
    private double radius;
    private double PI = 3.14;
    public Circle(){}
    public Circle(double radius)
    {
      this.radius = radius;
    }
    public double GetRadius()
    {
        return radius;
    }
    public void SetRadius(double radius)
    {
        this.radius = radius;
    }
    public double GetArea()
    {
        return PI * radius * radius;
    }
    public double GetCircumference()
    {
        return 2 * PI * radius;
    }
    public string ToString()
    {
        return $"Circle [ radius [{radius} ]";
    }
    
}