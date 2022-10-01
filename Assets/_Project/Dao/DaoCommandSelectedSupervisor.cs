using LudumDare51.Domain;

namespace LudumDare51.Dao
{
    public class DaoCommandSelectedSupervisor: Dao
    {
        private readonly CommandsSelectedSupervisor commandsSelectedSupervisor;

        public DaoCommandSelectedSupervisor()
        {
            this.commandsSelectedSupervisor = new CommandsSelectedSupervisor();
        }
        
        public CommandsSelectedSupervisor GetCommandSupervisor()
        {
            return this.commandsSelectedSupervisor;
        }
    }
}