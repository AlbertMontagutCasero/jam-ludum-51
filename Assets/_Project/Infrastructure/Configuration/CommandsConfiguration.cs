using System;
using System.Collections.Generic;
using LudumDare51.Domain;
using UnityEngine;

namespace _Project.Infrastructure.UnityConfiguration
{
    [CreateAssetMenu(fileName = "CommandConfigurations", menuName = "Configuration/Command Configurations")]
    public class CommandsConfiguration: ScriptableObject
    {
        [SerializeField] private List<CommandConfiguration> commandConfigurations = new();

        public List<CommandConfiguration> GetCommandsConfiguration()
        {
            return this.commandConfigurations;
        }
        
        public CommandConfiguration GetCommandConfiguration(CommandId commandId)
        {
            CommandConfiguration commandFound = null;
            var i = 0;
            
            while (commandFound == null && i < this.commandConfigurations.Count)
            {
                var commandToEvaluate = this.commandConfigurations[i];
                if (commandToEvaluate.IsCommand(commandId))
                {
                    commandFound = commandToEvaluate;
                }

                i++;
            }
            
            return commandFound;
        }
    }

    [Serializable]
    public class CommandConfiguration
    {
        [SerializeField] private CommandId commandId;
        [SerializeField] private Sprite texture;

        public CommandId GetCommandId()
        {
            return this.commandId;
        }
        
        public Sprite GetTexture()
        {
            return this.texture;
        }


        public bool IsCommand(CommandId toCheck)
        {
            return toCheck == this.commandId;
        }
    }
}