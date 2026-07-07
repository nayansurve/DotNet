namespace GraphicsApp;

public class Line
{
    private Point start;
    private Point end;


    public Line(Point start,Point end)
    {
        this.start=start;
        this.end=end;
    }

    public Point GetStart()
    {
        return start;
    }
    public Point GetEnd()
    {
        return end;
    }
    public void Display()
    {
        Console.WriteLine($"Line Start At({start.Getx()},{start.Gety()}) and Line Ends At ({end.Getx()},{end.Gety()})");

    }
}