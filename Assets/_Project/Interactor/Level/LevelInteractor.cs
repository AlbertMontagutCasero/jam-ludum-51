using System.Collections.Generic;
using _Project.Infrastructure.UnityConfiguration;
using LudumDare51.Dao;
using LudumDare51.Domain;
using LudumDare51.Interactor;

namespace LudumDare51.Infrastructure
{
    public class LevelInteractor : Interactor.Interactor
    {
        public void LoadCurrentLevel()
        {
            var dao = DaoServiceLocator.GetInstance().GetService<DaoLevel>();
            var currentLevelId = dao.GetCurrentLevelId();
            var level = new LevelFactory().Create(currentLevelId);
            dao.SetLevel(currentLevelId, level);

            var map = level.GetMap().GetTiles();
            var configSet = 0;
            var configs = this.GetCosmeticConfig(level);
            for (int row = 0; row < MapSize.Size; row++)
            {
                for (int col = 0; col < MapSize.Size; col++)
                {
                    var tile = map[row][col];
                    if (tile.GetCosmeticId() != CosmeticId.None)
                    {
                        tile.SetCosmeticConfig(configs[configSet]);
                        configSet++;
                    }
                }
            }


            var levelLoadedResponse = new LevelLoadedResponse();
            levelLoadedResponse.map = level.GetMap();

            var daoLevelTextureMapperConfiguration =
                DaoServiceLocator.GetInstance().GetService<DaoLevelTextureMapperConfiguration>();
            var levelTextureMapperConfiguration =
                daoLevelTextureMapperConfiguration.GetLevelTextureMapperConfiguration();
            levelLoadedResponse.floorTextures = levelTextureMapperConfiguration.GetFloorTextures();
            levelLoadedResponse.cosmeticTextures = levelTextureMapperConfiguration.GetCosmeticTextures();
            GameSignals.OnLevelLoaded?.Invoke(levelLoadedResponse);
        }

        private List<CosmeticItemPreset> GetCosmeticConfig(Level level)
        {
            var levelId = level.GetLevelId();
            var dao = DaoServiceLocator.GetInstance().GetService<DaoLevel>();
            return dao.GetCosmeticConfiguration(levelId).cosmeticItemPresets;
        }

        private void ExecuteTurnCosmetics(Level level)
        {
            var levelId = level.GetLevelId();
            var secondsElapsed = level.GetSecondsElapsed();
            var dao = DaoServiceLocator.GetInstance().GetService<DaoLevel>();
            var cosmeticItemPresets = dao.GetCosmeticConfiguration(levelId).cosmeticItemPresets;
            var currentSecondCosmetics =
                cosmeticItemPresets.FindAll(preset => preset.secondToActivate == secondsElapsed);

            for (var i = 0; i < currentSecondCosmetics.Count; i++)
            {
                var currentCosmetic = currentSecondCosmetics[i];
                var currentCosmeticCosmeticId = currentCosmetic.cosmeticId;
            }
        }
    }
}
