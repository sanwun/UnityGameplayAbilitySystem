using GameplayAbilitySystem.AttributeSystem.Components;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace MyGameplayAbilitySystem
{
    public struct MyDurationalGameplayAttributeModifier : IComponentData, IGameplayAttributeModifier<MyDurationalAttributeModifierValues>
    {
        public float Value;
        public EMyPlayerAttribute Attribute;
        public EMyAttributeModifierOperator Operator;
        ref MyPlayerAttributes GetAttributeCollection(ref MyDurationalAttributeModifierValues attributeModifier)
        {
            switch (Operator)
            {
                case EMyAttributeModifierOperator.Add:
                    return ref attributeModifier.AddValue;
                case EMyAttributeModifierOperator.Multiply:
                    return ref attributeModifier.MultiplyValue;
                case EMyAttributeModifierOperator.Divide:
                    return ref attributeModifier.DivideValue;
                default:
                    // Should never get here
                    return ref attributeModifier.AddValue;
            }
        }

        public void UpdateAttribute(ref MyDurationalAttributeModifierValues attributeModifier)
        {

            if (Operator == EMyAttributeModifierOperator.None) return;

            ref var attributeGroup = ref GetAttributeCollection(ref attributeModifier);
            attributeGroup[Attribute] += Value;
        }

    }
}
