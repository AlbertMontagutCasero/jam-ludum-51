using System.Collections.Generic;
using _Project.Infrastructure.UnityConfiguration;
using LudumDare51.Domain;

namespace LudumDare51.Interactor
{
    public struct LevelLoadedResponse
    {
        public Map map;
        public List<FloorTexture> floorTextures;
        public List<CosmeticTexture> cosmeticTextures;
    }
}