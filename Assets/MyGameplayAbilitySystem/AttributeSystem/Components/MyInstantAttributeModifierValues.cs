using System;
using System.ComponentModel;
using GameplayAbilitySystem.AttributeSystem.Components;
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
