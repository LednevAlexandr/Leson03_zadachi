using System.Linq;
String text = "(1,2) (2,3) (4,5) (6,7)";

Point p1=new Point();
p1.x=0;
p1.y=2;

System.Console.Write(text);

var data = text.Split(" ");
Point[] points = new Point[data.Length];
for (int i = 0; i < data.Length; i++)
     System.Console.WriteLine(data[i]);

char[] separators = new char[]{'(',')',','};
for (int i = 0; i < data.Length; i++)
{
    string[] ss =data[i].Split(separators,StringSplitOptions.RemoveEmptyEntries);
    System.Console.WriteLine(ss[0]+" "+ss[1]);
    Point point=new Point();
    point.x=int.Parse(ss[0]);
    point.y=int.Parse(ss[1]);
    point[i]=point;
}



class Point
{
    public double x,y;
}