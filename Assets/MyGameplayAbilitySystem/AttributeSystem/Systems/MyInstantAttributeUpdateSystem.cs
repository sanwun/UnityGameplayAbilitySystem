using GameplayAbilitySystem.AttributeSystem.Components;
using GameplayAbilitySystem.AttributeSystem.Systems;
using Unity.Entities;

namespace MyGameplayAbilitySystem
{
    [UpdateBefore(typeof(MyDurationalAttributeUpdateSystem))]
    [UpdateInGroup(typeof(AttributeUpdateSystemGroup))]
    public class MyInstantAttributeUpdateSystem
        : AttributeModifierCollectionSystem<MyInstantAttributeModifierValues, MyInstantGameplayAttributeModifier, InstantAttributeModifierComponentTag>
    {
    }
}
