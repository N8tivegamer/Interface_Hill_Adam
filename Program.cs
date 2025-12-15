namespace Interface_Hill_Adam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game("T", "FPS","THE Finals");
            Console.WriteLine(myGame.Describe();
            myGame.PLaygame();

            Movie myMovie = new Movie("PG-13", "Sport/Action", "F1");
            Console.WriteLine(myMovie.Describe());
            myMovie.PlayMovie();
        }
    }
}
