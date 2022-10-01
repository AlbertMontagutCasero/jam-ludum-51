using System.Collections.Generic;
using LudumDare51.Dao;
using LudumDare51.Domain;

namespace LudumDare51.Interactor
{
    public class RemoveSelectedCommandsInteractor: Interactor
    {
        public void RemoveAllSelectedCommands()
        {
            var selectedCommandsSupervisor = DaoServiceLocator.GetInstance().GetService<DaoCommandSelectedSupervisor>();
            var commandsSelectedSupervisor = selectedCommandsSupervisor.GetCommandSupervisor();
            
            commandsSelectedSupervisor.RemoveCommands();
            
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