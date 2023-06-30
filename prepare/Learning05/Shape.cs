class Shape
{
    protected string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public void getColor()
    {
        Console.WriteLine(_color);
    }

    public virtual double getArea()
    {
        return 0;
    }
}