using UnityEngine;

namespace LudumDare51.Domain
{
    public class CommandMovement: Command
    {
        private readonly CommandId commandId;

        public CommandMovement(CommandId commandId)
        {
            this.commandId = commandId;
        }

        public void Execute()
        {
            Debug.Log("COMMAND MOVEMENT EXECUTED");
        }

        public CommandId GetCommandId()
        {
            return this.commandId;
        }
    }
}