namespace LudumDare51.Domain
{
    public class InteractionLayer
    {
        private readonly InteractionId[][] interactionIds;

        public InteractionLayer(InteractionId[][] interactionIds)
        {
            this.interactionIds = interactionIds;
        }

        public InteractionId GetInteractionId(int row, int col)
        {
            return this.interactionIds[row][col];
        }
    }
}