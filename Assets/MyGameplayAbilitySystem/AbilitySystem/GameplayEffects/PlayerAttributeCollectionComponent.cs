using Unity.Entities;
using MyGameplayAbilitySystem;

public struct PlayerAttributeCollectionComponent : IComponentData
{
    public AttributeValues Source;
    public AttributeValues Target;
}