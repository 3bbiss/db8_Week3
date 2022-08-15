Pen gelpen = new Pen("green", 5.0, "gel", "medium");
gelpen.Print();

Pen feltpen = new Pen("blue", 4.0, "felt", "small");
feltpen.Print();

gelpen.Draw(5);
gelpen.Print();
gelpen.Draw(7);
gelpen.Print();

Console.WriteLine(gelpen);

class Pen
{
    public string color;
    public double length;
    public string pointType;
    public string pointSize;
    public int inkAmount;

    public Pen(string _color, double _length, string _pointType, string _pointSize)
    {
        color = _color;
        length = _length;
        pointType = pointType;
        pointSize = pointSize;
        inkAmount = 10;
    }

    public void Print()
    {
        Console.WriteLine("This pen:");
        Console.WriteLine($"   Color: {color}  Length: {length}   Type: {pointType}  Size: {pointSize}  Amount: {inkAmount}");
    }

    public void Draw(int lineLength)
    {
        if (lineLength > inkAmount)
        {
            Console.WriteLine("Sorry, not enough ink for that!");
            return;
        }
        inkAmount -= lineLength;
        if (inkAmount < 0)
        {
            inkAmount = 0;
        }
    }

    public void Refill()
    {
        inkAmount = 10;
    }

    public override string ToString()
    {
        return $"Color: {color}   Length: {length}   Type: {pointType}   Size: {pointSize}  Amount: {inkAmount}";
    }
}