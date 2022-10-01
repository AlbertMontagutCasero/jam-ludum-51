using _Project.Infrastructure.UnityConfiguration;
using LudumDare51.Dao;
using LudumDare51.Interactor;
using UnityEngine;

namespace LudumDare51.Infrastructure.Installer
{
    public class Installer: MonoBehaviour
    {
        [SerializeField] private CommandsConfiguration commandsConfiguration;
        
        private void Awake()
        {
            // DOMAIN
            
            // DAO
            DaoServiceLocator.GetInstance().RegisterService(new DaoCommandSelectedSupervisor(this.commandsConfiguration));
            
            // INTERACTOR
            InteractorServiceLocator.GetInstance().RegisterService(new AddCommandInteractor());
            InteractorServiceLocator.GetInstance().RegisterService(new GetCommandConfigurationInteractor());
            InteractorServiceLocator.GetInstance().RegisterService(new RemoveSelectedCommandsInteractor());
            InteractorServiceLocator.GetInstance().RegisterService(new PlayInteractor());

        }
    }
}