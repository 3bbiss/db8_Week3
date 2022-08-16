

List<Song> playlist = new List<Song>();

Song song1 = new Song("The Beatles", "I Want to Hold Your Hand", "Rock", 1964);
playlist.Add(song1);

song1 = new Song("Pink Floyd", "Comfortably Numb", "Rock", 1979);
playlist.Add(song1);

song1 = new Song("Brittany Spears", "Toxic", "LamePop", 2003);
playlist.Add(song1);

playlist.Add(new Song("Dave Brubeck", "Take 5", "Jazz", 1959) );


Console.WriteLine("Here is your playlist: ");

foreach (Song next in playlist)
{
    Console.WriteLine(next.title);
}


Console.Write("Which song title do you want more info on?: ");
string mySong = Console.ReadLine();

Song found = FindSong(playlist, mySong);
if (found == null)
{
    Console.WriteLine("Sorry, we don't have that song.");
}
else
{
    Console.WriteLine(found);
}


static Song FindSong(List<Song>theList, string theTitle)
{
    foreach (Song next in theList)
    {
        if (next.title.ToLower() == theTitle.ToLower())
        {
            return next;
        }
    }
    return null;
}



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