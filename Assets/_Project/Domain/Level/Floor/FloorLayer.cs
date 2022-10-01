namespace LudumDare51.Domain
{
    public class FloorLayer
    {
        private readonly FloorId[][] floorIds;

        public FloorLayer(FloorId[][] floorIds)
        {
            this.floorIds = floorIds;
        }

        public FloorId GetFloorId(int row, int col)
        {
            return this.floorIds[row][col];
        }
    }
}