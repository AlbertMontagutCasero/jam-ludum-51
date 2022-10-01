using System.Collections.Generic;

namespace LudumDare51.Domain
{
    public class CommandsSelectedSupervisor
    {
        private readonly List<Command> commands = new List<Command>();

        public void DeleteCommands()
        {
            this.commands.Clear();
        }
        
        public void AddCommand(Command command)
        {
            this.commands.Add(command);
        }
    }

    public interface Command
    {
        void Execute();
    }
}