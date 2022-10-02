namespace LudumDare51.Domain
{
    public class Map
    {
        private FloorLayer floorLayer;
        private CosmeticLayer cosmeticLayer;
        private InteractionLayer interactionsLayer;
        private Tile[][] tiles;

        public Map(FloorLayer floorLayer, CosmeticLayer cosmeticLayer, InteractionLayer interactionsLayer)
        {
            this.floorLayer = floorLayer;
            this.cosmeticLayer = cosmeticLayer;
            this.interactionsLayer = interactionsLayer;

            this.CreateTiles();
        }

        private void CreateTiles()
        {
            this.tiles = new Tile[MapSize.Size][]
            {
                new Tile[MapSize.Size],
                new Tile[MapSize.Size],
                new Tile[MapSize.Size],
                new Tile[MapSize.Size],
                new Tile[MapSize.Size],
                new Tile[MapSize.Size],
                new Tile[MapSize.Size],
                new Tile[MapSize.Size],
                new Tile[MapSize.Size],
                new Tile[MapSize.Size],
            };
            
            for (int row = 0; row < MapSize.Size; row++)
            {
                for (int col = 0; col < MapSize.Size; col++)
                {
                    var currentFloorId = this.floorLayer.GetFloorId(row, col);
                    var currentCosmeticId = this.cosmeticLayer.GetCosmeticId(row, col);
                    var currentInteractionsId = this.interactionsLayer.GetInteractionId(row, col);
                    var tile = new Tile(currentFloorId, currentCosmeticId, currentInteractionsId);
                    this.tiles[row][col] = tile;
                }
            }
        }

        public Tile[][] GetTiles()
        {
            return this.tiles;
        }
    }
}