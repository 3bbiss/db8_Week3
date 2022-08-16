

List<Song> playlist = new List<Song>();

Song song1 = new Song("The Beatles", "I Want to Hold Your Hand", "Rock", 1964);
playlist.Add(song1);

Song song2 = new Song("Pink Floyd", "Comfortably Numb", "Rock", 1979);
playlist.Add(song2);

Song song3 = new Song("Brittany Spears", "Toxic", "LamePop", 2003);
playlist.Add(song3);


Console.WriteLine("Here are your songs:");
foreach (Song next in playlist)
{
    Console.WriteLine(next.title);
}

Console.WriteLine();
Console.Write("Which song do you want more details on:");
string mysong = Console.ReadLine();



class Song
{
    public string artist;
    public string title;
    public string genre;
    public int year;

    public Song(string _artist, string _title, string _genre, int _year)
    {
        artist = _artist;
        title = _title;
        genre = _genre;
        year = _year;
    }

    public override string ToString()
    {
        return $"\"{title}\" by {artist} from {year} ({genre})";
    }
}