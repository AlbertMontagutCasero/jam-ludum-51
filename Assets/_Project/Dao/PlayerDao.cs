using LudumDare51.Infrastructure;

namespace LudumDare51.Dao
{
    public class PlayerDao: Dao
    {
        private readonly Player player;

        public PlayerDao(Player player)
        {
            this.player = player;
        }

        public Player GetPlayer()
        {
            return this.player;
        }
    }
}