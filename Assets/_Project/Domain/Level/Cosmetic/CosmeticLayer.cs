namespace LudumDare51.Domain
{
    public class CosmeticLayer
    {
        private readonly CosmeticId[][] cosmeticIds;

        public CosmeticLayer(CosmeticId[][] cosmeticIds)
        {
            this.cosmeticIds = cosmeticIds;
        }

        public CosmeticId GetCosmeticId(int row, int col)
        {
            return this.cosmeticIds[row][col];
        }
    }
}