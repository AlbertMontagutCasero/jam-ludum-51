using UnityEngine;

namespace LudumDare51.Domain
{
    public class CommandInteract : Command
    {
        private readonly CommandId commandId;

        public CommandInteract(CommandId commandId)
        {
            this.commandId = commandId;
        }


        public void Execute()
        {
            Debug.Log("Execute Interact Command");
        }

        public CommandId GetCommandId()
        {
            return this.commandId;
        }
    }
}