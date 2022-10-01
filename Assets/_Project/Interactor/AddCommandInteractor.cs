using LudumDare51.Dao;
using LudumDare51.Domain;

namespace LudumDare51.Interactor
{
    public class AddCommandInteractor: Interactor
    {
        public void AddCommand()
        {
            var daoCommandSelectedSupervisor = DaoServiceLocator.GetInstance().GetService<DaoCommandSelectedSupervisor>();
            var commandsSelectedSupervisor = daoCommandSelectedSupervisor.GetCommandSupervisor();
            
            var command = new CommandMovement();
            commandsSelectedSupervisor.AddCommand(command);
            
            GameSignals.OnCommandSelected?.Invoke();
        }
    }
}