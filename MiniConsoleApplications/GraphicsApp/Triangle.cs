namespace GraphicsApp;

public class Triangle
{
    private Point vertex1;
    private Point vertex2;
    private Point vertex3;


    public Triangle(Point vertex1,Point vertex2,Point vertex3)
    {
        this.vertex1=vertex1;
        this.vertex2=vertex2;
        this.vertex3=vertex3;
    }

    public Point GetVertex1()
    {
        return vertex1;
    }
     public Point GetVertex2()
    {
        return vertex2;
    }
     public Point GetVertex3()
    {
        return vertex3;
    }
    public void Display()
    {
        Console.WriteLine($"Triangle Vertices ({vertex1.Getx()}),({vertex2.Gety()}),({vertex2.Getx()}),({vertex2.Gety()}),({vertex3.Getx()}),({vertex3.Gety()})");
    }

}