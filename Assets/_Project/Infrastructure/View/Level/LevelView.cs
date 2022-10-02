using LudumDare51.Domain;
using LudumDare51.Interactor;
using UnityEngine;

namespace LudumDare51.Infrastructure
{
    public class LevelView: MonoBehaviour
    {
        private TileViewData[][] tilesViewData = new TileViewData[MapSize.Size][];
        
        private void Awake()
        {
            GameSignals.OnLevelLoaded += this.OnLevelLoaded;
            this.tilesViewData = new TileViewData[MapSize.Size][]
            {
                new TileViewData[MapSize.Size],
                new TileViewData[MapSize.Size],
                new TileViewData[MapSize.Size],
                new TileViewData[MapSize.Size],
                new TileViewData[MapSize.Size],
                new TileViewData[MapSize.Size],
                new TileViewData[MapSize.Size],
                new TileViewData[MapSize.Size],
                new TileViewData[MapSize.Size],
                new TileViewData[MapSize.Size],
            };
        }

        private void OnLevelLoaded(LevelLoadedResponse levelLoadedResponse)
        {
            var tiles = levelLoadedResponse.map.GetTiles();
            var cosmeticTextures = levelLoadedResponse.cosmeticTextures;
            var floorTextures = levelLoadedResponse.floorTextures;
            for (var rowIndex = 0; rowIndex < tiles.Length; rowIndex++)
            {
                var row = tiles[rowIndex];
                for (int columnIndex = 0; columnIndex < row.Length; columnIndex++)
                {
                    var tile = row[columnIndex];
                    var tileGameObject = new GameObject($"Tile{rowIndex}:{columnIndex}");
                    var floorSpriteRenderer = new GameObject("floorSpriteRenderer").AddComponent<SpriteRenderer>();
                    floorSpriteRenderer.transform.SetParent(tileGameObject.transform);
                    var cosmeticSpriteRenderer = new GameObject("cosmeticSpriteRenderer").AddComponent<SpriteRenderer>();
                    cosmeticSpriteRenderer.transform.SetParent(tileGameObject.transform);
                    
                    var tileViewData = new TileViewData(tile, tileGameObject, floorSpriteRenderer, cosmeticSpriteRenderer);
                    tileViewData.SetCosmeticSprite(cosmeticTextures.Find(texture => texture.cosmeticId == tile.GetCosmeticId()).sprite);
                    tileViewData.SetFloorSprite(floorTextures.Find(texture => texture.floorId == tile.GetFloorId()).sprite);

                    tileGameObject.transform.localPosition = new Vector3(
                        x: -MapSize.Size * 0.5f + columnIndex,
                        y: MapSize.Size * 0.5f - rowIndex
                    );
                    
                    this.tilesViewData[rowIndex][columnIndex] = tileViewData;
                } 
            }
        }
        
        private void Start()
        {
            var levelInteractor = InteractorServiceLocator.GetInstance().GetService<LevelInteractor>();
            levelInteractor.LoadCurrentLevel();
        }
    }

    public class TileViewData
    {
        public Tile tile;
        public GameObject tileGameObject;
        public SpriteRenderer floorSpriteRenderer;
        public SpriteRenderer cosmeticSpriteRenderer;

        public TileViewData(Tile tile, GameObject tileGameObject, SpriteRenderer floorSpriteRenderer, SpriteRenderer cosmeticSpriteRenderer)
        {
            this.tile = tile;
            this.tileGameObject = tileGameObject;
            this.floorSpriteRenderer = floorSpriteRenderer;
            this.cosmeticSpriteRenderer = cosmeticSpriteRenderer;
        }

        public void SetFloorSprite(Sprite sprite)
        {
            this.floorSpriteRenderer.sprite = sprite;
        }
        
        public void SetCosmeticSprite(Sprite sprite)
        {
            this.cosmeticSpriteRenderer.sprite = sprite;
        }
    }
}