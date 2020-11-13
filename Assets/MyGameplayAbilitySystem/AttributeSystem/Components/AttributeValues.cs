using System;
using GameplayAbilitySystem.AttributeSystem.Components;
using Unity.Entities;

namespace MyGameplayAbilitySystem
{
    [Serializable]
    public struct AttributeValues : IAttributeData, IComponentData
    {
        public MyPlayerAttributes<float> BaseValue;
        public MyPlayerAttributes<float> CurrentValue;
    }
}
