using System.Net.NetworkInformation;

public class Point
{
    int x;
    int y;

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public int X
    {
        get { return x; }
        set { x = value; }
    }

    public int Y
    {
        get { return y; }
        set { y = value; }
    }

    public void print(string pointName)
    {
        Console.WriteLine("For Point " + pointName + ": X = " + this.x + ", Y = " + this.y);
    }

    public void dist(Point p2)
    {
        Console.WriteLine("Distance between p1 and p2: " + Math.Sqrt(Math.Pow(p2.x - this.x, 2) + Math.Pow(p2.y - this.y, 2)));
    }
}

public class My
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input x1 and y1:");
        int x1 = Convert.ToInt32(Console.ReadLine());
        int y1 = Convert.ToInt32(Console.ReadLine());
        Point p1 = new Point(x1, y1);
        Console.WriteLine("Input x2 and y2:");
        int x2 = Convert.ToInt32(Console.ReadLine());
        int y2 = Convert.ToInt32(Console.ReadLine());
        Point p2 = new Point(x2, y2);

        p1.print("p1");
        p2.print("p2");
        p1.dist(p2);
    }
}