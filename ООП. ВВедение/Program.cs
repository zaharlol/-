using System.Reflection.Metadata.Ecma335;
class Pen
{
    public string color;
    public int cost;

    public Pen()
    {
        color = "Чёерный";
        cost = 100;
    }

    public Pen(string pencolor, int pencost)
    {
        color = pencolor;
        cost = pencost;
    }
}

class Rectangle
{
    public int a;
    public int b;

    public static int Square(int a, int b)
    {
        return a * b;
    }

    public Rectangle(int one, int two)
    {
        a = one;
        b = two;
    }

    public Rectangle(int a)
    {
        b = a;
    }

    public Rectangle()
    {
        a = 6;
        b = 4;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle();
        Rectangle.Square(1, 2);
    }
}