using _Project.Infrastructure.UnityConfiguration;
using LudumDare51.Domain;

namespace LudumDare51.Dao
{
    public class DaoCommandSelectedSupervisor: Dao
    {
        private readonly CommandsSelectedSupervisor commandsSelectedSupervisor;
        private CommandsConfiguration commandsConfiguration;

        public DaoCommandSelectedSupervisor(CommandsConfiguration commandsConfiguration)
        {
            this.commandsSelectedSupervisor = new CommandsSelectedSupervisor();
            this.commandsConfiguration = commandsConfiguration;
        }
        
        public CommandsSelectedSupervisor GetCommandSupervisor()
        {
            return this.commandsSelectedSupervisor;
        }

        public CommandsConfiguration GetCommandConfiguration()
        {
            return this.commandsConfiguration;
        }
    }
}