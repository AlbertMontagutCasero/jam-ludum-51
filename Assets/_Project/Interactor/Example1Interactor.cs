using _Project.Dao;
using _Project.Domain;
using DefaultNamespace;

namespace _Project.Interactor
{
    public class Example1Interactor: Interactor
    {
        public void InteractWithSystemToDoSomething()
        {
            var daoEntity1 = DaoServiceLocator.GetInstance().GetService<DaoEntity1>();
            var entity1 = daoEntity1.GetEntity1();
            var businessThingyDone = entity1.DoBusinessThingy();
         
            GameSignals.OnClick?.Invoke(businessThingyDone);
        }
        
        public void InteractWithSystemToCreate()
        {
            var entity1 = new Entity1();

            var daoEntity1 = DaoServiceLocator.GetInstance().GetService<DaoEntity1>();
            daoEntity1.StoreTheEntity1(entity1);
            
            GameSignals.OnCreated?.Invoke();
        }
    }
}