using UnityEngine;

namespace LudumDare51.Dao
{
    public class MapDao: Dao
    {
        private readonly GameObject map;

        public MapDao(GameObject map)
        {
            this.map = map;
        }

        public GameObject GetMap()
        {
            return this.map;
        }
    }
}