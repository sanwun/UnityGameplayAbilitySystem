using System;

namespace GameplayAbilitySystem.AbilitySystem.GameplayEffects.ScriptableObjects
{
    [Serializable]
    public struct DurationPolicy
    {
        public EDurationPolicy DurationType;
        public float Duration;
    }

}
