
// Lists

List<Rectangle> myList = new List<Rectangle> ();
myList.Add(new Rectangle("First", 10.5, 20.6));
myList.Add(new Rectangle("Second", 25.6, 13.2));
myList.Add(new Rectangle("Third", 12.9, 11.3));

foreach (Rectangle rect in myList)
{
    Console.WriteLine(rect);
}


// Dictionaries

Dictionary<string, int> spelling = new Dictionary<string, int>();
spelling.Add("One", 1);
spelling.Add("Two", 2);
spelling["Three"] = 3;
spelling["Four"] = 4;
spelling["One Hundred"] = 100;
spelling.Add("Five", 5);


foreach (KeyValuePair<string, int> item in spelling)
{
    Console.WriteLine($"{item.Key} maps to {item.Value}");
}

//foreach (var item in spelling)
//{
//    Console.WriteLine(item);
//}



// Enums



Season now = Season.Summer;
Console.WriteLine(now);


enum Season
{
    Winter,
    Spring,
    Summer,
    Autumn
}

class Rectangle
{
    public string name;
    public double length;
    public double height;

    public Rectangle(string _name, double _length, double _height)
    {
        name = _name;
        length = _length;
        height = _height;
    }

    public override string ToString()
    {
        return $"{name}: Length {length}  Height {height}  Area {length * height}  Perimeter {2 * length + 2 * height}";
    }
}