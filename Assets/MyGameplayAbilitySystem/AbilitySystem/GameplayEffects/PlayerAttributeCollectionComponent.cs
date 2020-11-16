using Unity.Entities;
using MyGameplayAbilitySystem;

public struct PlayerAttributeCollectionComponent : IComponentData
{
    public MyPlayerAttributes SourceBaseAttributes;
    public MyPlayerAttributes SourceCurrentAttributes;
    public MyPlayerAttributes TargetBaseAttributes;
    public MyPlayerAttributes TargetCurrentAttributes;
}