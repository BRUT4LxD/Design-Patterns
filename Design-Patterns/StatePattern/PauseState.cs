using System;

namespace StatePattern
{
    internal class PauseState : State
    {
        public PauseState(Player player) : base(player)
        {
        }


        public override void ClickExit()
        {
            Player.State = new ExitState(Player);
            Console.WriteLine("running exit from Pause");
        }
        public override void ClickPlay()
        {
            Player.State = new PlayingState(Player);
            Console.WriteLine("running Play from Pause");
        }
        public override void ClickPause()
        {
            Player.State = new PauseState(Player);
            Console.WriteLine("running Pause from Pause");
        }
    }
}