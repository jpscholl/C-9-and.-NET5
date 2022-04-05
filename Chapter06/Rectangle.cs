public class Rectangle : Shape
{
    public Rectangle() { }

    public Rectangle(double width, double height) 
    { 
        this.height = height;
        this.width = width;
    }

    public override double Area
    {
        get 
        {
            return height * width;
        }
    }
}