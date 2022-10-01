using _Project.Infrastructure.UnityConfiguration;

namespace LudumDare51.Dao
{
    public class DaoLevelTextureMapperConfiguration: Dao
    {
        private readonly LevelTextureMapperConfiguration levelTextureMapperConfiguration;

        public DaoLevelTextureMapperConfiguration(LevelTextureMapperConfiguration levelTextureMapperConfiguration)
        {
            this.levelTextureMapperConfiguration = levelTextureMapperConfiguration;
        }

        public LevelTextureMapperConfiguration GetLevelTextureMapperConfiguration()
        {
            return this.levelTextureMapperConfiguration;
        }
    }
}