using GameplayAbilitySystem.AttributeSystem.Components;
using GameplayAbilitySystem.AttributeSystem.Systems;
using Unity.Entities;

namespace MyGameplayAbilitySystem
{
    [UpdateBefore(typeof(MyAttributeUpdateSystem))]
    [UpdateInGroup(typeof(AttributeUpdateSystemGroup))]
    [AlwaysUpdateSystem]
    public class MyDurationalAttributeUpdateSystem
        : AttributeModifierCollectionSystem<MyDurationalAttributeModifierValues, MyDurationalGameplayAttributeModifier, DurationalAttributeModifierComponentTag>
    { }
}
