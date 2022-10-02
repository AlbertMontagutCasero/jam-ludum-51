using _Project.Infrastructure.UnityConfiguration;
using LudumDare51.Dao;
using LudumDare51.Interactor;
using UnityEngine;

namespace LudumDare51.Infrastructure.Installer
{
    public class Installer: MonoBehaviour
    {

        
        private void Awake()
        {
            // DOMAIN
            
            // DAO
            // DaoServiceLocator.GetInstance().RegisterService(new DaoCommandSelectedSupervisor(this.commandsConfiguration));

            // INTERACTOR
            // InteractorServiceLocator.GetInstance().RegisterService(new AddCommandInteractor());

            // View

        }
    }


}