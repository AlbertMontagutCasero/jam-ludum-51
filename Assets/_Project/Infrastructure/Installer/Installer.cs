using _Project.Infrastructure.UnityConfiguration;
using LudumDare51.Dao;
using LudumDare51.Interactor;
using UnityEngine;

namespace LudumDare51.Infrastructure.Installer
{
    public class Installer: MonoBehaviour
    {
        [SerializeField] private CommandsConfiguration commandsConfiguration;
        [SerializeField] private LevelTextureMapperConfiguration levelTextureMapperConfiguration;
        [SerializeField] private CosmeticConfigurationList cosmeticConfigurationList;
        
        
        private void Awake()
        {
            // DOMAIN
            
            // DAO
            DaoServiceLocator.GetInstance().RegisterService(new DaoCommandSelectedSupervisor(this.commandsConfiguration));
            DaoServiceLocator.GetInstance().RegisterService(new DaoLevelTextureMapperConfiguration(this.levelTextureMapperConfiguration));
            DaoServiceLocator.GetInstance().RegisterService(new DaoLevel(this.cosmeticConfigurationList));
            
            // INTERACTOR
            InteractorServiceLocator.GetInstance().RegisterService(new AddCommandInteractor());
            InteractorServiceLocator.GetInstance().RegisterService(new GetCommandConfigurationInteractor());
            InteractorServiceLocator.GetInstance().RegisterService(new RemoveSelectedCommandsInteractor());
            InteractorServiceLocator.GetInstance().RegisterService(new PlayInteractor());
            InteractorServiceLocator.GetInstance().RegisterService(new LevelInteractor());

            // View
            new GameObject("LevelView").AddComponent<LevelView>();

        }
    }


}