


double len, hgt;
string entry, goAgain;
bool res;

//do
//{
//    Console.Write("Enter a length 1.0 to 1000.0: ");
//    entry = Console.ReadLine();
//    res = double.TryParse(entry, out len);

//    while (!res || len < 1 || len > 1000)
//    {
//        Console.Write("Please enter a valid number for length 1 to 1000: ");
//        entry = Console.ReadLine();
//        res = double.TryParse(entry, out len);
//    }

//    Console.Write("Enter a height 1.0 to 1000.0: ");
//    entry = Console.ReadLine();
//    res = double.TryParse(entry, out hgt);

//    while (!res || hgt < 1 || hgt > 1000)
//    {
//        Console.Write("Please enter a valid number for height 1 to 1000: ");
//        entry = Console.ReadLine();
//        res = double.TryParse(entry, out hgt);
//    }




//    Console.WriteLine("Do you want to create another circle? Enter y/Y or another key to exit.");
//    goAgain = Console.ReadLine().ToLower();
//} while (goAgain[0] == 'y');




Triangle first = new Triangle(4, 3);


double ar = first.getArea();
double hyp = first.getHypotenuse();
double per = first.getPerimeter();

Console.WriteLine(ar);
Console.WriteLine(per);
Console.WriteLine(hyp);

//first.height = 12;  Can't do this now, because height is private.

class Triangle
{
    private double length;
    private double height;
    private double area;

    // Initializing the data - using a constructor
    public Triangle(double _length, double _height)
    {
        length = _length;
        height = _height;
        area = length * height / 2;
    }

    public double getArea()
    {
        //return length * height / 2;
        return area;
    }

    public double getPerimeter()
    {
        return length + height + getHypotenuse();
    }

    public double getHypotenuse()
    {
        return Math.Sqrt((length * length) + (height * height));
    }
}