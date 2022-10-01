using System;
using System.Collections.Generic;

namespace LudumDare51.Domain
{
    public class CommandFactory
    {
        private Dictionary<CommandId, Func<CommandId, Command>> factoryMapper = new();

        public CommandFactory()
        {
            this.factoryMapper.Add(CommandId.MovementUp, this.CreateMovement);
            this.factoryMapper.Add(CommandId.MovementDown, this.CreateMovement);
            this.factoryMapper.Add(CommandId.MovementRight, this.CreateMovement);
            this.factoryMapper.Add(CommandId.MovementLeft, this.CreateMovement);
            this.factoryMapper.Add(CommandId.Attack, this.CreateAttack);
            this.factoryMapper.Add(CommandId.Block, this.CreateBlock);
            this.factoryMapper.Add(CommandId.Interact, this.CreateInteract);
        }

        public Command Create(CommandId commandId)
        {
            return this.factoryMapper[commandId].Invoke(commandId);
        }
        
        private Command CreateInteract(CommandId commandId)
        {
            return new CommandInteract(commandId);
        }

        private Command CreateBlock(CommandId commandId)
        {
            return new CommandBlock(commandId);
        }

        private Command CreateAttack(CommandId commandId)
        {
            return new CommandAttack(commandId);
        }

        private Command CreateMovement(CommandId commandId)
        {
            return new CommandMovement(commandId);
        }
    }
}