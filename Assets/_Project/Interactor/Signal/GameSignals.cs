using System;

namespace LudumDare51.Interactor
{
    public class GameSignals
    {
        // EXAMPLE
        public static Action<string> OnClick;
        public static Action OnCreated;
        
        // GAME
        public static Action<CommandSelectedResponse> OnCommandSelected;
    }
}