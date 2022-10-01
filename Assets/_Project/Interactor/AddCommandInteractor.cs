using System.Collections.Generic;
using LudumDare51.Dao;
using LudumDare51.Domain;
using UnityEngine;

namespace LudumDare51.Interactor
{
    public class AddCommandInteractor: Interactor
    {
        public void AddCommand(CommandId commandId)
        {
            Debug.Log(commandId);
            
            var daoCommandSelectedSupervisor = DaoServiceLocator.GetInstance().GetService<DaoCommandSelectedSupervisor>();
            var commandsSelectedSupervisor = daoCommandSelectedSupervisor.GetCommandSupervisor();

            var maxCommands = 10;
            var numberOfCurrentCommands = commandsSelectedSupervisor.GetCommands().Count; 
            if (numberOfCurrentCommands >= maxCommands)
            {
                return;
            }
            
            var commandMovement = new CommandMovement(CommandId.MovementUp);
            commandsSelectedSupervisor.AddCommand(commandMovement);
            this.SendCommandsUpdatedSignal();
        }
        private void SendCommandsUpdatedSignal()
        {
            var selectedCommandsSupervisor = DaoServiceLocator.GetInstance().GetService<DaoCommandSelectedSupervisor>();
            var commandsSelectedSupervisor = selectedCommandsSupervisor.GetCommandSupervisor();
            
            var commands = commandsSelectedSupervisor.GetCommands();
            var commandsDto = new List<CommandDto>();
            for (var i = 0; i < commands.Count; i++)
            {
                var command = commands[i];
                var commandDto = new CommandDto
                {
                    CommandId = command.GetCommandId()
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