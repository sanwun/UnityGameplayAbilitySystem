using GameplayAbilitySystem.AttributeSystem.Components;
using Unity.Entities;
using Unity.Mathematics;

namespace MyGameplayAbilitySystem
{
    public struct MyInstantGameplayAttributeModifier : IComponentData, IGameplayAttributeModifier<MyInstantAttributeModifierValues>
    {
        public half Value;
        public EMyPlayerAttribute Attribute;
        public EMyAttributeModifierOperator Operator;
        ref MyPlayerAttributes GetAttributeCollection(ref MyInstantAttributeModifierValues attributeModifier)
        {
            switch (Operator)
            {
                case EMyAttributeModifierOperator.Add:
                    return ref attributeModifier.AddValue;
                case EMyAttributeModifierOperator.Multiply:
                    return ref attributeModifier.MultiplyValue;
                case EMyAttributeModifierOperator.Divide:
                    return ref attributeModifier.DivideValue;
                case EMyAttributeModifierOperator.Override:
                    return ref attributeModifier.OverrideValue;
                default:
                    // Should never get here
                    return ref attributeModifier.AddValue;
            }
        }

        public void UpdateAttribute(ref MyInstantAttributeModifierValues attributeModifier)
        {

            if (Operator == EMyAttributeModifierOperator.None) return;

            ref var attributeGroup = ref GetAttributeCollection(ref attributeModifier);

            attributeGroup[Attribute] += Value;
        }
    }
}
