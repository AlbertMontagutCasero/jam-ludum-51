namespace LudumDare51.Domain
{
    public interface Command
    {
        void Execute();
        CommandId GetCommandId();
    }
}