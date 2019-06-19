namespace StatePattern
{
    internal abstract class State
    {
        protected Player Player;

        protected State(Player player)
        {
            Player = player;
        }

        public virtual void ClickPlay()
        {

        }
        public virtual void ClickPause()
        {

        }
        public virtual void ClickExit()
        {

        }

    }
}