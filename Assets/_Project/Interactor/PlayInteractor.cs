using LudumDare51.Dao;

namespace LudumDare51.Interactor
{
    public class PlayInteractor: Interactor
    {
        public void Execute()
        {
            var daoCommandSelectedSupervisor = DaoServiceLocator.GetInstance().GetService<DaoCommandSelectedSupervisor>();
            var commandsSelectedSupervisor = daoCommandSelectedSupervisor.GetCommandSupervisor();

            commandsSelectedSupervisor.ExecuteNextCommand();
            commandsSelectedSupervisor.GoToNextCommand();
        }
    }
}