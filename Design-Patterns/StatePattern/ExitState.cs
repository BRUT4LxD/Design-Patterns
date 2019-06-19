using System;

namespace StatePattern
{
    internal class ExitState : State
    {
        public ExitState(Player player) : base(player)
        {
        }

        public override void ClickExit()
        {
            Player.State = new ExitState(Player);
            Console.WriteLine("running exit from exit");
        }
        public override void ClickPlay()
        {
            Player.State = new PlayingState(Player);
            Console.WriteLine("running Play from exit");
        }
        public override void ClickPause()
        {
            Player.State = new PauseState(Player);
            Console.WriteLine("running Pause from exit");
        }
    }
}