using System;

namespace StatePattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Player player = new Player();

            player.State = new PlayingState(player);

            player.State.ClickPlay();
            player.State.ClickPause();
            player.State.ClickPlay();
            player.State.ClickExit();

            Console.ReadKey();
        }
    }
}
