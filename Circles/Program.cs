
double radius;
string entry;
bool res;

Console.Write("Enter a radius 1.0 to 1000.0: ");
entry = Console.ReadLine();
res = double.TryParse(entry, out radius);

while (!res || radius < 1 || radius > 1000)
{
    Console.Write("Please enter a valid number for radius 1 to 1000: ");
    entry = Console.ReadLine();
    res = double.TryParse(entry, out radius);
}


// just run it normal. without the class. then integrate the math into
// the functions below..


// so CW the radius, circ, and area of the circule based on the inputted
// radius.

class Circle
{

    public double radius;

    public double getRadius()
    {
        return radius;
    }

    public double CalculateCircumference()
    {

    }


    public double CalculateArea()
    {

    }


    public Circle(double _radius)
    {
        radius = _radius;
    }
}