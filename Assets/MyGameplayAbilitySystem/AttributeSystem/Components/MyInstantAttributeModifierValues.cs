using System;
using GameplayAbilitySystem.AttributeSystem.Components;
using Unity.Entities;

namespace MyGameplayAbilitySystem
{
    [Serializable]
    public struct MyInstantAttributeModifierValues : IAttributeModifier, IComponentData
    {
        public MyPlayerAttributes<float> AddValue;
        public MyPlayerAttributes<float> MultiplyValue;
        public MyPlayerAttributes<float> DivideValue;
    }
}
