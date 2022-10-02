using _Project.Infrastructure.UnityConfiguration;

namespace LudumDare51.Domain
{
    public class Tile
    {
        private FloorId floorId;
        private CosmeticId cosmeticId;
        private InteractionId interactionsId;
        private CosmeticItemPreset cosmeticItemPreset;

        public Tile(FloorId floorId, CosmeticId cosmeticId, InteractionId interactionsId)
        {
            this.floorId = floorId;
            this.cosmeticId = cosmeticId;
            this.interactionsId = interactionsId;
        }

        public CosmeticId GetCosmeticId()
        {
            return this.cosmeticId;
        }

        public FloorId GetFloorId()
        {
            return this.floorId;
        }

        public InteractionId GetInteractionsId()
        {
            return this.interactionsId;
        }

        public void SetCosmeticConfig(CosmeticItemPreset config)
        {
            this.cosmeticItemPreset = config;
        }
    }
}