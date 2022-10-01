using System.Collections.Generic;
using LudumDare51.Dao;
using LudumDare51.Domain;

namespace LudumDare51.Interactor
{
    public class AddCommandInteractor: Interactor
    {
        public void AddCommand(CommandId commandId)
        {
            var daoCommandSelectedSupervisor = DaoServiceLocator.GetInstance().GetService<DaoCommandSelectedSupervisor>();
            var commandsSelectedSupervisor = daoCommandSelectedSupervisor.GetCommandSupervisor();

            var maxCommands = 10;
            var numberOfCurrentCommands = commandsSelectedSupervisor.GetCommands().Count; 
            if (numberOfCurrentCommands >= maxCommands)
            {
                return;
            }

            var command = new CommandFactory().Create(commandId);
            commandsSelectedSupervisor.AddCommand(command);
            this.SendCommandsUpdatedSignal();
        }
        
        private void SendCommandsUpdatedSignal()
        {
            var selectedCommandsSupervisor = DaoServiceLocator.GetInstance().GetService<DaoCommandSelectedSupervisor>();
            var commandsSelectedSupervisor = selectedCommandsSupervisor.GetCommandSupervisor();
            var commandConfiguration = selectedCommandsSupervisor.GetCommandConfiguration();
            
            var commands = commandsSelectedSupervisor.GetCommands();
            var commandsDto = new List<CommandDto>();
            for (var i = 0; i < commands.Count; i++)
            {
                var command = commands[i];
                var configuration = commandConfiguration.GetCommandConfiguration(command.GetCommandId());
                var commandDto = new CommandDto
                {
                    commandConfiguration = configuration
                };
                commandsDto.Add(commandDto);
            }
            
            GameSignals.OnCommandSelected?.Invoke(new CommandSelectedResponse
            {
                commandDto = commandsDto
            });
        }
    }
}