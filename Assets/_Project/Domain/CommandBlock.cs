using UnityEngine;

namespace LudumDare51.Domain
{
    public class CommandBlock : Command
    {
        private readonly CommandId commandId;

        public CommandBlock(CommandId commandId)
        {
            this.commandId = commandId;
        }


        public void Execute()
        {
            Debug.Log("Execute Block Command");
        }

        public CommandId GetCommandId()
        {
            return this.commandId;
        }
    }
}