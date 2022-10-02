using UnityEngine;

namespace LudumDare51.Infrastructure
{
    [CreateAssetMenu(fileName = "GameplayConfiguration", menuName = "Configuration/Gameplay Configuration")]
    public class GameplayConfiguration: ScriptableObject
    {
        public int maxRacoonsToCatch;
        public int numberOfTry;
    }
}