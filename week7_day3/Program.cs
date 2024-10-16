namespace week7_day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MAX_ATTEMPTS = 5;
            INumberGenerator ng = new RandomNumGenerator();
            IGameIO gio = new ConsoleInputOutput();

            GameSetup setup = new GameSetup(ng, gio, MAX_ATTEMPTS);

            Game game = new Game(setup);
            game.Run();
        }
    }
}


//INumberGenerator ng = new StaticGenerator();
//IGameIO gio = new DummyInputOutput();