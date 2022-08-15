
int count = 0;
double radius;
string entry, goAgain;
bool res;

do
{
    Console.Write("Enter a radius 1.0 to 1000.0: ");
    entry = Console.ReadLine();
    res = double.TryParse(entry, out radius);

    while (!res || radius < 1 || radius > 1000)
    {
        Console.Write("Please enter a valid number for radius 1 to 1000: ");
        entry = Console.ReadLine();
        res = double.TryParse(entry, out radius);
    }

    Circle c1 = new Circle(radius);

    Console.WriteLine($"Radius: {c1.getRadius()} -- Area: {c1.CalculateArea()} -- Circumference: {c1.CalculateCircumference()}");

    Console.WriteLine("Do you want to create another circle? Enter y/Y or another key to exit.");
    goAgain = Console.ReadLine().ToLower();
    count++;
} while (goAgain[0] == 'y');


Console.WriteLine($"Adios! You made {count} circles!");

class Circle
{
    public double radius;

    public double getRadius()
    {
        return radius;
    }

    public double CalculateCircumference()
    {
        return Math.Round(2 * Math.PI * radius, 2);
        //return (2 * Math.PI * radius);
    }

    public double CalculateArea()
    {
        return Math.Round(Math.PI * radius * radius, 2);
        //return Math.PI * radius * radius;
    }

    public Circle(double _radius)
    {
        radius = _radius;
    }
}