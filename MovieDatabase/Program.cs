
string goAgain;
List<Movie> movies = new List<Movie>();

movies.Add(new Movie("The Iron Giant", "Animated"));
movies.Add(new Movie("The Dark Knight", "Scifi"));
movies.Add(new Movie("The Avengers", "Scifi"));
movies.Add(new Movie("Halloween", "Horror"));
movies.Add(new Movie("Friday The 13th", "Horror"));
movies.Add(new Movie("Attack on Titan", "Animated"));
movies.Add(new Movie("Titanic", "Drama"));
movies.Add(new Movie("Never Back Down", "Drama"));
movies.Add(new Movie("The Notebook", "Drama"));
movies.Add(new Movie("The Forbidden Kingdom", "Scifi"));

do
{
    Console.Write("\nWhich category do you want to see movies from?: ");
    //foreach (Movie movie in movies)
    //{
    //    Console.WriteLine(movie.title);
    //}

    string entry = Console.ReadLine().ToLower();

    while (entry != "animated" && entry != "scifi" & entry != "horror" & entry != "drama")
    {
        Console.Write("\nPlease enter a valid category: ");
        entry = Console.ReadLine();
    }

    Console.WriteLine($"\nThe movies in {entry} are: ");

    foreach (Movie movie in movies)
    {
        if (movie.category.ToLower() == entry)
        {
            Console.WriteLine(movie.title);
        }
    }

    Console.Write("\nDo you want to go again? Enter y/Y if so, or another key to quit: ");
    goAgain = Console.ReadLine().ToLower();
} while (goAgain[0] == 'y');


class Movie
{
    public string title;
    public string category;
    
    public Movie(string _title, string _category)
    {
        title = _title;
        category = _category;
    }

    public override string ToString()
    {
        return $"\"{title}\" in {category})";
    }
}