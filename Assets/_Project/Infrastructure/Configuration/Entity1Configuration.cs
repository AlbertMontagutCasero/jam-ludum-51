using UnityEngine;

namespace _Project.Infrastructure.UnityConfiguration
{
    [CreateAssetMenu(fileName = "Entity1Configuration", menuName = "Configuration/Entity 1 Configuration")]
    public class Entity1Configuration: ScriptableObject
    {
        [SerializeField] private float timeToProcessMs = 1;
        
        public float GetTimeToProcess()
        {
            Debug.Assert(this.timeToProcessMs > 0);
            
            return this.timeToProcessMs;
        }
    }
}