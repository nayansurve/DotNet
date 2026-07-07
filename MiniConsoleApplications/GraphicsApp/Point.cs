namespace GraphicsApp;

public class Point
{
    private int x;
    private int y;
    private int v;

    public Point()
    {
        x=0;
        y=0;
    }

    public Point(int v)
    {
        this.v = v;
    }

    public Point(int x, int y)
    {
        this.x=x;
        this.y=y;
    }
    public int Getx()
    {
        return x;
    }
    public int Gety()
    {
        return y;
    }

    public void Setx(int x)
    {
        this.x=x;
    }
    public void Sety(int y)
    {
        this.y=y;
    }
}
