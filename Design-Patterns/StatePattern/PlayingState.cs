using System;

namespace StatePattern
{
    internal class PlayingState : State
    {
        public PlayingState(Player player) : base(player)
        {
        }


        public override void ClickExit()
        {
            Player.State = new ExitState(Player);
            Console.WriteLine("running exit from Play");
        }
        public override void ClickPlay()
        {
            Player.State = new PlayingState(Player);
            Console.WriteLine("running Play from Play");
        }
        public override void ClickPause()
        {
            Player.State = new PauseState(Player);
            Console.WriteLine("running Pause from Play");
        }
    }
}