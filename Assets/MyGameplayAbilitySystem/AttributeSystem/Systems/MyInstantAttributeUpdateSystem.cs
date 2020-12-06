using GameplayAbilitySystem.AttributeSystem;
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
