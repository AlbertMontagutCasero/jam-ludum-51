using System;
using System.Collections.Generic;
using LudumDare51.Domain;
using UnityEngine;

namespace _Project.Infrastructure.UnityConfiguration
{
    [CreateAssetMenu(fileName = "LevelTextureMapper", menuName = "Configuration/Level texture Mapper Configuration")]
    public class LevelTextureMapperConfiguration: ScriptableObject
    {
        [SerializeField]
        private List<FloorTexture> floorTextures = new List<FloorTexture>();
        
        [SerializeField]
        private List<CosmeticTexture> cosmeticTextures = new List<CosmeticTexture>();

        public List<FloorTexture> GetFloorTextures()
        {
            return this.floorTextures;
        }
        
        public List<CosmeticTexture> GetCosmeticTextures()
        {
            return this.cosmeticTextures;
        }
    }

    [Serializable]
    public class FloorTexture
    {
        public FloorId floorId;
        public Sprite sprite;
    }
    
    [Serializable]
    public class CosmeticTexture
    {
        public CosmeticId cosmeticId;
        public Sprite sprite;
    }
}