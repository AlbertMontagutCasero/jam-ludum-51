using _Project.Domain;

namespace _Project.Dao
{
    public class DaoEntity1: Dao
    {
        private Entity1 entity1;
        
        public Entity1 GetEntity1()
        {
            return this.entity1;
        }

        public void StoreTheEntity1(Entity1 entity1)
        {
            this.entity1 = entity1;
        }
    }
}