namespace Interface_Hill_Adam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new Game object (e.g., a general game)
            Game myGame = new Game("T", "FPS","THE Finals");

            // Display a description of the game
            Console.WriteLine(myGame.Describe());

            // Call PlayGame() to indicate the game is starting
            myGame.PLaygame();


            // Create a new Movie object
            Movie myMovie = new Movie("PG-13", "Sport/Action", "F1");
            // Display a description of the movie
            Console.WriteLine(myMovie.Describe());
            // Call PlayMovie() to indicate the movie is starting
            myMovie.PlayMovie();
        }
    }
}
