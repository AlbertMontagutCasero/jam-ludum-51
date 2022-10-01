using System.Collections.Generic;

namespace LudumDare51.Domain
{
    public class CommandsSelectedSupervisor
    {
        private readonly List<Command> commands = new List<Command>();

        public void RemoveCommands()
        {
            this.commands.Clear();
        }
        
        public void AddCommand(Command command)
        {
            this.commands.Add(command);
        }
        
        public List<Command> GetCommands()
        {
            return this.commands;
        }
        
        public void Execute()
        {
            for (var i = 0; i < this.commands.Count; i++)
            {
                var currentCommand = this.commands[i];
                currentCommand.Execute();
            }
        }
    }
}