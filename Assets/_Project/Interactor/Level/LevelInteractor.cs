using LudumDare51.Dao;
using LudumDare51.Domain;
using LudumDare51.Interactor;

namespace LudumDare51.Infrastructure
{
    public class LevelInteractor: Interactor.Interactor
    {
        public void LoadNextLevel()
        {
            var daoLevelTextureMapperConfiguration = DaoServiceLocator.GetInstance().GetService<DaoLevelTextureMapperConfiguration>();
            var levelTextureMapperConfiguration = daoLevelTextureMapperConfiguration.GetLevelTextureMapperConfiguration();
            var level = new LevelFactory().Create(LevelId.Level02);

            var levelLoadedResponse = new LevelLoadedResponse();
            levelLoadedResponse.map = level.GetMap(); 
            levelLoadedResponse.floorTextures = levelTextureMapperConfiguration.GetFloorTextures(); 
            levelLoadedResponse.cosmeticTextures = levelTextureMapperConfiguration.GetCosmeticTextures(); 
            GameSignals.OnLevelLoaded?.Invoke(levelLoadedResponse);
        }
    }
}