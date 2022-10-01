using System.Collections.Generic;

namespace LudumDare51.Domain
{
    public class CommandsSelectedSupervisor
    {
        private readonly List<Command> commands = new();
        private int currentCommand = 0;

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

        public void ExecuteNextCommand()
        {
            var currentCommand = this.commands[this.currentCommand];
            currentCommand.Execute();
        }

        public void GoToNextCommand()
        {
            this.currentCommand++;
        }
    }
}