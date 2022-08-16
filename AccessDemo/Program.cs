

Car first = new Car("Chevy", "Trax", Color.Blue);
Console.WriteLine(first.getMake());
Console.WriteLine(first.getModel());
Console.WriteLine(first.getColor());

first.setColor(Color.Red);

Console.WriteLine(first.getColor());

//first.setColor("White"); Can't cause ENUM

Console.WriteLine(first.getColor());


enum Color
{
    Red,
    Blue,
    Black,
    Silver
}


class Car
{
    // Attributes that cannot be changed
    private string make, model;


    // Attributes that can be changed
    //private string color;

    private Color carColor;


    public Car(string _make, string _model, Color _color)
    {
        make = _make;
        model = _model;
        carColor = _color;
    }

    public string getMake()
    {
        return make;
    }
    public string getModel()
    {
        return model;
    }
    public Color getColor()
    {
        return carColor;
    }

    public void setColor(Color newColor)
    {
        //if (newColor == "Red" || newColor == "Blue" || newColor == "Black" || newColor == "Silver")
        //{
        //    carColor = newColor;
        //}
        carColor = newColor;
    }
}