using GameplayAbilitySystem.AttributeSystem.Systems;
using Unity.Entities;

namespace MyGameplayAbilitySystem
{
    public struct MyAttributeModifierValues : IAttributeModifier, IComponentData
    {
        public MyPlayerAttributes<float> AddValue;
        public MyPlayerAttributes<float> MultiplyValue;
        public MyPlayerAttributes<float> DivideValue;
    }
}
