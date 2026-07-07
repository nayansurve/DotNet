using GraphicsApp;
public class Prograam
{
    public static void Main(string [] args)
    {
        Point p1=new Point(0,2);
        Point p2=new Point(1,5);
        Point p3=new Point(6,5);

        Triangle t1=new Triangle(p1,p2,p3);
        t1.Display();
        
        Point center=new Point(5,4);
        Circle c1=new Circle(center,10);
        c1.Display();


      Point x=new Point(5,3);
      Point y=new Point(9,7);
      Line l1=new Line(x,y);
      l1.Display();
       

    }
}