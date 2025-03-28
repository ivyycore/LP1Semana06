using System;
using Humanizer;

namespace MyRPG
{
    public class GameLevel
    {
        private Hardness dif;
        public Hardness GetHardness();
        private int rooms;
        public int GetNumRooms();
        private string enemy;
        public int GetEnemy();

        public GameLevel(int rooms, Hardness dif)
        {
            this.dif = dif;
            this.rooms = rooms;
            this.enemy = enemy;
        }
        
        public void SetEnemyInRoom(int rooms, string enemy)
    }
}