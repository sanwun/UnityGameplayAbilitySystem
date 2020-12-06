using System;
using GameplayAbilitySystem.AttributeSystem;
using Unity.Entities;

namespace MyGameplayAbilitySystem
{
    [Serializable]
    public struct MyInstantAttributeModifierValues : IAttributeModifier, IComponentData
    {
        public MyPlayerAttributes AddValue;
        public MyPlayerAttributes MultiplyValue;
        public MyPlayerAttributes DivideValue;
        public MyPlayerAttributes OverrideValue;
    }

}
