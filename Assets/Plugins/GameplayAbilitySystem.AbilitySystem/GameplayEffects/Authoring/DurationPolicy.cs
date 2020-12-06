using System;

namespace GameplayAbilitySystem.AbilitySystem
{
    [Serializable]
    public struct DurationPolicy
    {
        public EDurationPolicy DurationType;
        public float Duration;
    }

}
