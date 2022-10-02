using System;
using LudumDare51.Dao;

namespace LudumDare51.Interactor
{
    public class GameSignals
    {
        // EXAMPLE
        public static Action<string> OnClick;
        public static Action OnCreated;
        
        // GAME
        public static Action<GameDataDao> OnGameplayDataUpdate;
        public static Action<GameDataDao> OnGameplayStarts;
        public static Action<GameDataDao> OnGameplayFinishes;
        public static Action<float> OnTimePenalization;
        public static Action OnRacoonCaught;
        public static Action<int> OnCheckClue;
    }
}