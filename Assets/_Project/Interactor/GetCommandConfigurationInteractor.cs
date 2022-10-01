using System.Collections.Generic;
using _Project.Infrastructure.UnityConfiguration;
using LudumDare51.Dao;

namespace LudumDare51.Interactor
{
    public class GetCommandConfigurationInteractor: Interactor
    {
        public List<CommandConfiguration> GetCommandsConfiguration()
        {
            var daoCommandSelectedSupervisor = DaoServiceLocator.GetInstance().GetService<DaoCommandSelectedSupervisor>();
            var commandConfiguration = daoCommandSelectedSupervisor.GetCommandConfiguration();

            return commandConfiguration.GetCommandsConfiguration();
        }
    }
}