using System;
using UnityEngine;

namespace LudumDare51.Domain
{
    public class CommandAttack : Command
    {
        private readonly CommandId commandId;

        public CommandAttack(CommandId commandId)
        {
            this.commandId = commandId;
        }


        public void Execute()
        {
            Debug.Log("Execute Attack Command");
        }

        public CommandId GetCommandId()
        {
            return this.commandId;
        }
    }
}