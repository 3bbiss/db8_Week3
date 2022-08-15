
Pen firstPen = new Pen();

firstPen.color = "Red";
firstPen.length = 4.5;
firstPen.pointType = "Fountain Elite";
firstPen.pointSize = "Medium";
firstPen.inkAmount = 8;

//Console.WriteLine(firstPen.color);
//Console.WriteLine(firstPen.length);
//Console.WriteLine(firstPen.pointType);
//Console.WriteLine(firstPen.pointSize);

//Console.WriteLine();
//Console.WriteLine();

Console.WriteLine("Let's draw with firstPen!");
firstPen.Draw();
Console.WriteLine($"The ink is now {firstPen.inkAmount} amount.");

Console.WriteLine();
Console.WriteLine();


Pen secondPen = new Pen();
secondPen.color = "Naranjada";
secondPen.length = 4.5;
secondPen.pointType = "Magnus Carletist";
secondPen.pointSize = "Extra medium";
secondPen.inkAmount = 2;

//Console.WriteLine(secondPen.color);
//Console.WriteLine(secondPen.length);
//Console.WriteLine(secondPen.pointType);
//Console.WriteLine(secondPen.pointSize);

Console.WriteLine("Let's do two drawings with secondPen!");
secondPen.Draw();
secondPen.Draw();
Console.WriteLine($"secondPen now has ink level {secondPen.inkAmount}");
Console.WriteLine($"firstPen still has ink level {firstPen.inkAmount}");
Console.WriteLine();

secondPen.Draw();
Console.WriteLine($"secondPen now has ink level {secondPen.inkAmount}");

secondPen.Refill();
Console.WriteLine($"secondPen now has ink level {secondPen.inkAmount}");

Console.WriteLine();
Console.WriteLine("Let's refill firstpen with green ink");
firstPen.Refill("green");
Console.WriteLine($"firstPen has ink color: {firstPen.color}");
Console.WriteLine();

Console.WriteLine();
Pen thirdPen = new Pen();
Console.WriteLine(thirdPen.inkAmount);

Console.WriteLine();
Pen fourthPen = new Pen("greem");
Console.WriteLine(fourthPen.color);


class Pen
{
    public string color;
    public double length;
    public string pointType;
    public string pointSize;
    public int inkAmount;

    public Pen()  // Constructor 
    {
        inkAmount = 10;
        color = "black";
    }

    public Pen(string _color)
    {
        color = _color;
        inkAmount = 10;
    }


    public void Draw()
    {
        if (inkAmount > 0)
        {
            inkAmount--;
        }
    }
    public void Refill()
    {
        inkAmount = 10;
    }
    public void Refill(string newColor)
    {
        inkAmount = 10;
        color = newColor;
    }
}






// Let's add another Refill function that lets us specify ink color
//public void Refill(string color)
//{
//    inkAmount = 10;
//    this.color = color;
//}